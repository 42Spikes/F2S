using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Touchpad;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.ApiDemo.Touchpad
{
    [Activity(Label = "DiscreteGesturesActivity")]
    public class DiscreteGesturesActivity : Activity,
        Android.Glass.Touchpad.GestureDetector.IBaseListener,
        Android.Glass.Touchpad.GestureDetector.IFingerListener
    {
        private TextView _lastGesture;
        private TextView _fingerCount;
        private TextView _swipeAgainTip;
        private Android.Glass.Touchpad.GestureDetector _gestureDetector;

        private bool _swipedDownOnce;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            try
            {
                SetContentView(Resource.Layout.activity_discrete_gestures);

                _lastGesture = (TextView)FindViewById(Resource.Id.last_gesture);
                _fingerCount = (TextView)FindViewById(Resource.Id.finger_count);
                _swipeAgainTip = (TextView)FindViewById(Resource.Id.swipe_again_tip);

                // Initialize the gesture detector and set the activity to listen to discrete gestures.
                _gestureDetector = new Android.Glass.Touchpad.GestureDetector(this).SetBaseListener(this).SetFingerListener(this);
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        public override bool OnGenericMotionEvent(MotionEvent e)
        {
            return _gestureDetector.OnMotionEvent(e);
        }

        public bool OnGesture(Android.Glass.Touchpad.Gesture gesture)
        {
            _lastGesture.Text = gesture.Name();

            if (gesture == Gesture.SwipeDown)
            {
                if (!_swipedDownOnce)
                {
                    _swipeAgainTip.Animate().Alpha(1.0f);
                    _swipedDownOnce = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public void OnFingerCountChanged(int previousCount, int currentCount)
        {
            _fingerCount.Text = currentCount.ToString();
        }
    }
}