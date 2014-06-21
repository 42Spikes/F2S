using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.ApiDemo.Touchpad
{
    public class TouchpadView2 : RelativeLayout
    {
        private float _touchpadHardwareWidth;
        private float _touchpadHardwareHeight;
        public TouchpadView2(Context context) : base(context)
        {
            Focusable = true;
            FocusableInTouchMode = true;
            SetClipChildren(true);

            lookupTouchpadHardwareResolution();

        }

        private void lookupTouchpadHardwareResolution()
        {
            var deviceIds = InputDevice.GetDeviceIds();
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

    }
}