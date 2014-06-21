using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.ApiDemo.Touchpad
{
    public class TouchpadView : RelativeLayout
    {
        private const int FINGER_TRACE_SIZE = 50;

        // The drawable ids used to draw the user's three fingers.
        private static int[] FINGER_RES_IDS =
        {
//            Resource.Drawable.finger_trace_0,
  //          Resource.Drawable.finger_trace_1,
    //        Resource.Drawable.finger_trace_2
        };

        // The duration, in milliseconds, of the animation used to fade out a finger trace when the
        // user's finger is lifted from the touchpad.
        private const int FADE_OUT_DURATION_MILLIS = 100;

        // The views used to display the location of a finger on the touchpad.
        private static TextView[] _fingerTraceViews = new TextView[3];

        // The horizontal and vertical hardware resolutions of the touchpad. These are used to
        // calculate the aspect ratio of the view when it is measured.
        private float _touchpadHardwareWidth;
        private float _touchpadHardwareHeight;

        public TouchpadView(Context context) : base(context, null, 0)
        {
        }

        public TouchpadView(Context context, IAttributeSet attrs) : base(context, attrs, 0)
        {
        }

        public TouchpadView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Focusable = true;
            FocusableInTouchMode = true;
            SetClipChildren(true);

            lookupTouchpadHardwareResolution();

            for (var i = 0; i < _fingerTraceViews.Length; i++)
            {
//                _fingerTraceViews[i] = createFingerTraceView(i);
  //              AddView(_fingerTraceViews[i]);
            }
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            // Constrains the view's dimensions to have the same aspect ratio as the actual hardware
            // touchpad.
            var newHeight = (int)(MeasureSpec.GetSize(widthMeasureSpec) / _touchpadHardwareWidth *
                    _touchpadHardwareHeight);
            int newHeightMeasureSpec = MeasureSpec.MakeMeasureSpec(newHeight, MeasureSpecMode.Exactly);
            base.OnMeasure(widthMeasureSpec, newHeightMeasureSpec);
        }

        public override bool OnGenericMotionEvent(MotionEvent e)
        {
            for (var i = 0; i < e.PointerCount; i++)
            {
                var pointerId = e.GetPointerId(i);
                var x = e.GetX(i);
                var y = e.GetY(i);
                switch (e.ActionMasked)
                {
                    case MotionEventActions.Down:
                    case MotionEventActions.PointerDown:
                    case MotionEventActions.Move:
                        moveFingerTrace(pointerId, x, y);
                        break;

                    case MotionEventActions.Up:
                    case MotionEventActions.PointerUp:
                    case MotionEventActions.Cancel:
                        hideFingerTrace(pointerId);
                        break;
                }
            }
            return false;
        }

        /** Looks up the hardware resolution of the Glass touchpad. */
        private void lookupTouchpadHardwareResolution() 
        {
            int[] deviceIds = InputDevice.GetDeviceIds();
            foreach (var deviceId in deviceIds) 
            {
                var device = InputDevice.GetDevice(deviceId);
                if ((device.Sources & InputSourceType.Touchpad) != 0)
                {
                    _touchpadHardwareWidth = device.GetMotionRange(Axis.X).Range;
                    _touchpadHardwareHeight = device.GetMotionRange(Axis.Y).Range;
                    // Stop after we've seen the first touchpad device, because there might be multiple
                    // devices in this list if the user is currently screencasting with MyGlass. The
                    // first one will always be the hardware touchpad.
                    break;
                }
            }
        }

        /**
         * Creates a new view that will be used to display the specified pointer id on the touchpad
         * view.
         *
         * @param pointerId the id of the pointer that this finger trace view will represent; used to
         *     determine its color and text
         * @return the {@code TextView} that was created
         */
        private TextView createFingerTraceView(int pointerId)
        {
            var fingerTraceView = new TextView(Context); 
            fingerTraceView.SetBackgroundResource(FINGER_RES_IDS[pointerId]);
            fingerTraceView.Text = pointerId.ToString();
            fingerTraceView.Gravity = GravityFlags.Center;
            fingerTraceView.SetTextAppearance(Context, Android.Resource.Style.TextAppearanceDeviceDefaultSmall);
            fingerTraceView.Alpha = 0;

            var lp = new RelativeLayout.LayoutParams(FINGER_TRACE_SIZE, FINGER_TRACE_SIZE);
            lp.AddRule(LayoutRules.AlignParentTop);
            lp.AddRule(LayoutRules.AlignParentLeft);

            // The right and bottom margin here are required so that the view doesn't get "squished"
            // as it touches the right or bottom side of the touchpad view.
            lp.RightMargin = -2 * FINGER_TRACE_SIZE;
            lp.BottomMargin = -2 * FINGER_TRACE_SIZE;
            fingerTraceView.LayoutParameters = lp;

            return fingerTraceView;
        }

        /**
         * Moves the finger trace associated with the specified pointer id to a new location in the
         * view.
         *
         * @param pointerId the pointer id of the finger trace to move
         * @param point the new location of the finger trace
         */
        private void moveFingerTrace(int pointerId, float x, float y)
        {
            var fingerTraceView = _fingerTraceViews[pointerId];

            // Cancel any current animations on the view and bring it back to full opacity.
            fingerTraceView.Animate().Cancel();
            fingerTraceView.Alpha = 1;

            // Reposition the finger trace by updating the layout margins of its view.
            var lp = (RelativeLayout.LayoutParams)fingerTraceView.LayoutParameters;
            var viewX = (int) (x/_touchpadHardwareWidth*Width);
            var viewY = (int) (y/_touchpadHardwareHeight*Height);
            lp.LeftMargin = viewX - FINGER_TRACE_SIZE / 2;
            lp.TopMargin = viewY - FINGER_TRACE_SIZE / 2;
            fingerTraceView.LayoutParameters = lp;
        }

        /**
         * Hides the finger trace associated with the specified pointer id. Traces are faded away
         * instead of immediately hidden in order to reduce flickering due to intermittence in the
         * touchpad.
         *
         * @param pointerId the pointer id whose finger trace should be hidden
         */
        private void hideFingerTrace(int pointerId)
        {
            var fingerTraceView = _fingerTraceViews[pointerId];
            fingerTraceView.Animate().SetDuration(FADE_OUT_DURATION_MILLIS).Alpha(0);
        }
    }
}