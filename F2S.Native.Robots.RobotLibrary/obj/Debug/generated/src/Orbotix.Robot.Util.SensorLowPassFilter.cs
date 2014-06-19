using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorLowPassFilter']"
	[global::Android.Runtime.Register ("orbotix/robot/util/SensorLowPassFilter", DoNotGenerateAcw=true)]
	public partial class SensorLowPassFilter : global::Orbotix.Robot.Util.SensorFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/util/SensorLowPassFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SensorLowPassFilter); }
		}

		protected SensorLowPassFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorLowPassFilter']/constructor[@name='SensorLowPassFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public SensorLowPassFilter (float p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SensorLowPassFilter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FF)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FF)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_FF == IntPtr.Zero)
				id_ctor_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FF, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FF, new JValue (p0), new JValue (p1));
		}

	}
}
