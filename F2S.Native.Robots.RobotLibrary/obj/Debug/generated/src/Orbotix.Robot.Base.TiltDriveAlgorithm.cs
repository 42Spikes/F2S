using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='TiltDriveAlgorithm']"
	[global::Android.Runtime.Register ("orbotix/robot/base/TiltDriveAlgorithm", DoNotGenerateAcw=true)]
	public partial class TiltDriveAlgorithm : global::Orbotix.Robot.Base.DriveAlgorithm {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='TiltDriveAlgorithm']/field[@name='MAXIMUM_TILT']"
		[Register ("MAXIMUM_TILT")]
		public const double MaximumTilt = (double) 0.436332312998582;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/TiltDriveAlgorithm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TiltDriveAlgorithm); }
		}

		protected TiltDriveAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='TiltDriveAlgorithm']/constructor[@name='TiltDriveAlgorithm' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TiltDriveAlgorithm () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TiltDriveAlgorithm)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
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
			global::Orbotix.Robot.Base.TiltDriveAlgorithm __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.TiltDriveAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Convert (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_convert_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='TiltDriveAlgorithm']/method[@name='convert' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
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
