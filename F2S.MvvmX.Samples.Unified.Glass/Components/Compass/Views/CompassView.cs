using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using F2S.TinyMvx;
using Java.Text;
using Java.Util;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Utils;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Model;

namespace F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Views
{
    public class CompassView : View, ValueAnimator.IAnimatorUpdateListener, Animator.IAnimatorListener
    {
        private static Color NEEDLE_COLOR = Color.Blue;
        private static double NEEDLE_WIDTH = 6;
        private static double NEEDLE_HEIGHT = 125;
        private static double TICK_WIDTH = 2;
        private static double TICK_HEIGHT = 10;
        private static double DIRECTION_TEXT_HEIGHT = 84.0f;
        private static double PLACE_TEXT_HEIGHT = 22.0f;
        private static double PLACE_PIN_WIDTH = 14.0f;
        private static double PLACE_TEXT_LEADING = 4.0f;
        private static double PLACE_TEXT_MARGIN = 8.0f;

        /**
         * The maximum number of places names to allow to stack vertically underneath the compass
         * direction labels.
         */
        private static int MAX_OVERLAPPING_PLACE_NAMES = 4;

        /**
         * If the difference between two consecutive headings is less than this value, the canvas will
         * be redrawn immediately rather than animated.
         */
        private static double MIN_DISTANCE_TO_ANIMATE = 15.0f;

        /**
         * Represents the heading that is currently being displayed when the view is drawn. This is
         * used during animations, to keep track of the heading that should be drawn on the current
         * frame, which may be different than the desired end point.
         */
        private double _animatedHeading;

        private Paint _paint;
        private Paint _tickPaint;
        private Path _path;
        private TextPaint _placePaint;
        private Bitmap _placeBitmap;
        private Rect _textBounds;
        private List<Rect> _allBounds;
        private NumberFormat _distanceFormat;
        private String[] _directions;
        private ValueAnimator _animator;

        public List<Place> NearbyPlaces { get; set; }

        private double _heading;
        public double Heading
        {
            get { return _heading; }
            set
            {
                _heading = MathUtils.mod(value, 360.0);
                animateTo(_heading);
            }
        }

        public CompassView(Context context)
            : this(context, null, 0)
        {
        }

        public CompassView(Context context, Android.Util.IAttributeSet attrs)
            : this(context, attrs, 0)
        {

        }
        public CompassView(Context context, Android.Util.IAttributeSet attrs, int defStyle)
            : base(context, attrs, defStyle)
        {
            _paint = new Paint();
            _paint.SetStyle(Paint.Style.Fill);
            _paint.AntiAlias = true;
            _paint.TextSize = (float)DIRECTION_TEXT_HEIGHT;
            _paint.SetTypeface(Typeface.Create("sans-serif-thin", TypefaceStyle.Normal));

            _tickPaint = new Paint();
            _tickPaint.SetStyle(Paint.Style.Stroke);
            _tickPaint.StrokeWidth = (float)TICK_WIDTH;
            _tickPaint.AntiAlias = true;
            _tickPaint.Color = Color.White;

            _placePaint = new TextPaint();
            _placePaint.SetStyle(Paint.Style.Fill);
            _placePaint.AntiAlias = true;
            _placePaint.Color = Color.White;
            _placePaint.TextSize = (float)PLACE_TEXT_HEIGHT;
            _placePaint.SetTypeface(Typeface.Create("sans-serif-light", TypefaceStyle.Normal));

            _path = new Path();
            _textBounds = new Rect();
            _allBounds = new List<Rect>();

            _distanceFormat = NumberFormat.GetNumberInstance(Locale.Default);
            _distanceFormat.MinimumFractionDigits = 0;
            _distanceFormat.MaximumFractionDigits = 1;

            _placeBitmap = BitmapFactory.DecodeResource(context.Resources, Resource.Drawable.place_mark);
            _animatedHeading = Double.NaN;

            _directions = context.Resources.GetStringArray(Resource.Array.direction_abbreviations);

            _animator = new ValueAnimator();
            setupAnimator();
        }

        public OrientationManager OrientationManager { get; set; }


        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            // The view displays 90 degrees across its width so that one 90 degree head rotation is
            // equal to one full view cycle.
            var pixelsPerDegree = Width / 90.0;
            var centerX = Width / 2.0;
            var centerY = Height / 2.0;

            canvas.Save();
            canvas.Translate((float)(-_animatedHeading * pixelsPerDegree + centerX), (float)centerY);

            // In order to ensure that places on a boundary close to 0 or 360 get drawn correctly, we
            // draw them three times; once to the left, once at the "true" bearing, and once to the
            // right.
            for (var i = -1; i <= 1; i++)
            {
                drawPlaces(canvas, pixelsPerDegree, i * pixelsPerDegree * 360);
            }

            drawCompassDirections(canvas, pixelsPerDegree);

            canvas.Restore();

            _paint.Color = NEEDLE_COLOR;
            drawNeedle(canvas, false);
            drawNeedle(canvas, true);
        }

        private void drawCompassDirections(Canvas canvas, double pixelsPerDegree)
        {
            var degreesPerTick = 360.0f / _directions.Length;

            _paint.Color = Color.White;

            // We draw two extra ticks/labels on each side of the view so that the
            // full range is visible even when the heading is approximately 0.
            for (int i = -2; i <= _directions.Length + 2; i++)
            {
                if (MathUtils.mod(i, 2) == 0)
                {
                    // Draw a text label for the even indices.
                    var direction = _directions[MathUtils.mod(i, _directions.Length)];
                    _paint.GetTextBounds(direction, 0, direction.Length, _textBounds);

                    canvas.DrawText(direction,
                            (float)(i * degreesPerTick * pixelsPerDegree - _textBounds.Width() / 2),
                            _textBounds.Height() / 2, _paint);
                }
                else
                {
                    // Draw a tick mark for the odd indices.
                    canvas.DrawLine(
                        (float)(i * degreesPerTick * pixelsPerDegree), 
                        (float)(-TICK_HEIGHT / 2), 
                        (float)(i * degreesPerTick * pixelsPerDegree),
                        (float)(TICK_HEIGHT / 2), 
                    _tickPaint);
                }
            }
        }

        private void drawPlaces(Canvas canvas, double pixelsPerDegree, double offset) 
        {
            try
            {
                if (OrientationManager.HasLocation && NearbyPlaces != null)
                {
                    lock (NearbyPlaces)
                    {
                        var userLocation = OrientationManager.Location;
                        var latitude1 = userLocation.Latitude;
                        var longitude1 = userLocation.Longitude;

                        _allBounds.Clear();


                        // Loop over the list of nearby places (those within 10 km of the user's current
                        // location), and compute the relative bearing from the user's location to the
                        // place's location. This determines the position on the compass view where the
                        // pin will be drawn.
                        foreach (var place in NearbyPlaces)
                        {
                            var latitude2 = place.Latitiude;
                            var longitude2 = place.Longitude;
                            var bearing = MathUtils.getBearing(latitude1, longitude1, latitude2, longitude2);

                            var name = place.Name;
                            var distanceKm = MathUtils.getDistance(latitude1, longitude1, latitude2, longitude2);
                            var text = this.Context.Resources.GetString(
                                Resource.String.place_text_format, name, _distanceFormat.Format(distanceKm));

                            // Measure the text and offset the text bounds to the location where the text
                            // will finally be drawn.
                            var textBounds = new Rect();
                            _placePaint.GetTextBounds(text, 0, text.Length, textBounds);
                            textBounds.OffsetTo((int)(offset + bearing * pixelsPerDegree
                                    + PLACE_PIN_WIDTH / 2 + PLACE_TEXT_MARGIN), canvas.Height / 2
                                    - (int)PLACE_TEXT_HEIGHT);

                            // Extend the bounds rectangle to include the pin icon and a small margin
                            // to the right of the text, for the overlap calculations below.
                            textBounds.Left -= (int)(PLACE_PIN_WIDTH + PLACE_TEXT_MARGIN);
                            textBounds.Right += (int)PLACE_TEXT_MARGIN;

                            // This loop attempts to find the best vertical position for the string by
                            // starting at the bottom of the display and checking to see if it overlaps
                            // with any other labels that were already drawn. If there is an overlap, we
                            // move up and check again, repeating this process until we find a vertical
                            // position where there is no overlap, or when we reach the limit on
                            // overlapping place names.
                            bool intersects;
                            var numberOfTries = 0;
                            do
                            {
                                intersects = false;
                                numberOfTries++;
                                textBounds.Offset(0, (int)-(PLACE_TEXT_HEIGHT + PLACE_TEXT_LEADING));

                                foreach (var existing in _allBounds)
                                {
                                    if (Rect.Intersects(existing, textBounds))
                                    {
                                        intersects = true;
                                        break;
                                    }
                                }
                            } while (intersects && numberOfTries <= MAX_OVERLAPPING_PLACE_NAMES);

                            // Only draw the string if it would not go high enough to overlap the compass
                            // directions. This means some places may not be drawn, even if they're nearby.
                            if (numberOfTries <= MAX_OVERLAPPING_PLACE_NAMES)
                            {
                                _allBounds.Add(textBounds);

                                canvas.DrawBitmap(_placeBitmap, (float)(offset + bearing * pixelsPerDegree - PLACE_PIN_WIDTH / 2), textBounds.Top + 2, _paint);
                                canvas.DrawText(
                                    text,
                                    (float)(offset + bearing * pixelsPerDegree + PLACE_PIN_WIDTH / 2 + PLACE_TEXT_MARGIN),
                                    (float)(textBounds.Top + PLACE_TEXT_HEIGHT),
                                    _placePaint);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Debug("Exception", e.Message);
            }
        }

        private void drawNeedle(Canvas canvas, bool bottom)
        {
            var centerX = Width / 2.0;
            double origin;
            double sign;

            // Flip the vertical coordinates if we're drawing the bottom needle.
            if (bottom)
            {
                origin = Height;
                sign = -1;
            }
            else
            {
                origin = 0;
                sign = 1;
            }

            var needleHalfWidth = NEEDLE_WIDTH / 2;

            _path.Reset();
            _path.MoveTo((float)(centerX - needleHalfWidth), (float)(origin));
            _path.LineTo((float)(centerX - needleHalfWidth), (float)(origin + sign * (NEEDLE_HEIGHT - 4)));
            _path.LineTo((float)(centerX), (float)(origin + sign * NEEDLE_HEIGHT));
            _path.LineTo((float)(centerX + needleHalfWidth), (float)(origin + sign * (NEEDLE_HEIGHT - 4)));
            _path.LineTo((float)(centerX + needleHalfWidth), (float)(origin));
            _path.Close();

            canvas.DrawPath(_path, _paint);
        }

        private void setupAnimator() 
        {
            _animator.SetInterpolator(new LinearInterpolator());
            _animator.SetDuration(250);

        // Notifies us at each frame of the animation so we can redraw the view.
            _animator.AddUpdateListener(this);
            _animator.AddListener(this);
        }

        // Notifies us when the animation is over. During an animation, the user's head may have
        // continued to move to a different orientation than the original destination angle of the
        // animation. Since we can't easily change the animation goal while it is running, we call
        // animateTo() again, which will either redraw at the new orientation (if the difference is
        // small enough), or start another animation to the new heading. This seems to produce
        // fluid results.
        public void onAnimationEnd(Animator animator) 
        {
            animateTo(_heading);
        }
        
        public void OnAnimationUpdate(ValueAnimator animation)
        {
            _animatedHeading = MathUtils.mod((float)_animator.GetAnimatedValue(null), 360.0f);
            Invalidate();
        }
        
        public void OnAnimationCancel(Animator animation)
        {
        }

        public void OnAnimationEnd(Animator animation)
        {
        }

        public void OnAnimationRepeat(Animator animation)
        {
        }

        public void OnAnimationStart(Animator animation)
        {
        }

        private void animateTo(double end)
        {
            // Only act if the animator is not currently running. If the user's orientation changes
            // while the animator is running, we wait until the end of the animation to update the
            // display again, to prevent jerkiness.
            if (!_animator.IsRunning)
            {
                var start = _animatedHeading;
                var distance = Math.Abs(end - start);
                var reverseDistance = 360.0 - distance;
                var shortest = Math.Min(distance, reverseDistance);

                if (double.IsNaN(_animatedHeading) || shortest < MIN_DISTANCE_TO_ANIMATE)
                {
                    // If the distance to the destination angle is small enough (or if this is the
                    // first time the compass is being displayed), it will be more fluid to just redraw
                    // immediately instead of doing an animation.
                    _animatedHeading = end;
                    Invalidate();
                }
                else
                {
                    // For larger distances (i.e., if the compass "jumps" because of sensor calibration
                    // issues), we animate the effect to provide a more fluid user experience. The
                    // calculation below finds the shortest distance between the two angles, which may
                    // involve crossing 0/360 degrees.
                    double goal;

                    if (distance < reverseDistance)
                    {
                        goal = end;
                    }
                    else if (end < start)
                    {
                        goal = end + 360.0f;
                    }
                    else
                    {
                        goal = end - 360.0f;
                    }

                    _animator.SetFloatValues((float)start, (float)goal);
                    _animator.Start();
                }
            }
        }
    }
}