using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Value']"
	[global::Android.Runtime.Register ("orbotix/robot/util/Value", DoNotGenerateAcw=true)]
	public partial class Value : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/util/Value", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Value); }
		}

		protected Value (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Value']/constructor[@name='Value' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Value () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Value)) {
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

		static IntPtr id_clamp_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Value']/method[@name='clamp' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("clamp", "(DDD)D", "")]
		public static double Clamp (double p0, double p1, double p2)
		{
			if (id_clamp_DDD == IntPtr.Zero)
				id_clamp_DDD = JNIEnv.GetStaticMethodID (class_ref, "clamp", "(DDD)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_clamp_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_clamp_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Value']/method[@name='clamp' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("clamp", "(III)I", "")]
		public static int Clamp (int p0, int p1, int p2)
		{
			if (id_clamp_III == IntPtr.Zero)
				id_clamp_III = JNIEnv.GetStaticMethodID (class_ref, "clamp", "(III)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_clamp_III, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_window_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Value']/method[@name='window' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("window", "(DDD)D", "")]
		public static double Window (double p0, double p1, double p2)
		{
			if (id_window_DDD == IntPtr.Zero)
				id_window_DDD = JNIEnv.GetStaticMethodID (class_ref, "window", "(DDD)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_window_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
