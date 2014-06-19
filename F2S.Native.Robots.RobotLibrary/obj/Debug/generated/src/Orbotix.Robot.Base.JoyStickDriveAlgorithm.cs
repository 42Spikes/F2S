using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='JoyStickDriveAlgorithm']"
	[global::Android.Runtime.Register ("orbotix/robot/base/JoyStickDriveAlgorithm", DoNotGenerateAcw=true)]
	public partial class JoyStickDriveAlgorithm : global::Orbotix.Robot.Base.DriveAlgorithm {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/JoyStickDriveAlgorithm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JoyStickDriveAlgorithm); }
		}

		protected JoyStickDriveAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='JoyStickDriveAlgorithm']/constructor[@name='JoyStickDriveAlgorithm' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public JoyStickDriveAlgorithm (double p0, double p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JoyStickDriveAlgorithm)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_convert_DDD;
#pragma warning disable 0169
		static Delegate GetConvert_DDDHandler ()
		{
			if (cb_convert_DDD == null)
				cb_convert_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double>) n_Convert_DDD);
			return cb_convert_DDD;
		}

		static void n_Convert_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
		{
			global::Orbotix.Robot.Base.JoyStickDriveAlgorithm __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.JoyStickDriveAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Convert (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_convert_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='JoyStickDriveAlgorithm']/method[@name='convert' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("convert", "(DDD)V", "GetConvert_DDDHandler")]
		public override void Convert (double p0, double p1, double p2)
		{
			if (id_convert_DDD == IntPtr.Zero)
				id_convert_DDD = JNIEnv.GetMethodID (class_ref, "convert", "(DDD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_convert_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convert", "(DDD)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
