using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector3D']"
	[global::Android.Runtime.Register ("orbotix/robot/util/Vector3D", DoNotGenerateAcw=true)]
	public partial class Vector3D : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/util/Vector3D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Vector3D); }
		}

		protected Vector3D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector3D']/constructor[@name='Vector3D' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Vector3D () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Vector3D)) {
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

		static IntPtr id_magnitude_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector3D']/method[@name='magnitude' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("magnitude", "(DDD)D", "")]
		public static double Magnitude (double p0, double p1, double p2)
		{
			if (id_magnitude_DDD == IntPtr.Zero)
				id_magnitude_DDD = JNIEnv.GetStaticMethodID (class_ref, "magnitude", "(DDD)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_magnitude_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
