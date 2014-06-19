using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/Acceleration", DoNotGenerateAcw=true)]
	public partial class Acceleration : global::Java.Lang.Object {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']/field[@name='x']"
		[Register ("x")]
		public double X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "D");
				return JNIEnv.GetDoubleField (Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "D");
				JNIEnv.SetField (Handle, x_jfieldId, value);
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']/field[@name='y']"
		[Register ("y")]
		public double Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "D");
				return JNIEnv.GetDoubleField (Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "D");
				JNIEnv.SetField (Handle, y_jfieldId, value);
			}
		}

		static IntPtr z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']/field[@name='z']"
		[Register ("z")]
		public double Z {
			get {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "D");
				return JNIEnv.GetDoubleField (Handle, z_jfieldId);
			}
			set {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "D");
				JNIEnv.SetField (Handle, z_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/Acceleration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Acceleration); }
		}

		protected Acceleration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']/constructor[@name='Acceleration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Acceleration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Acceleration)) {
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

		static IntPtr id_ctor_SSS;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']/constructor[@name='Acceleration' and count(parameter)=3 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
		[Register (".ctor", "(SSS)V", "")]
		public Acceleration (short p0, short p1, short p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Acceleration)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(SSS)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(SSS)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_SSS == IntPtr.Zero)
				id_ctor_SSS = JNIEnv.GetMethodID (class_ref, "<init>", "(SSS)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_SSS, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_SSS, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_normalize_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='Acceleration']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("normalize", "(S)D", "")]
		public static double Normalize (short p0)
		{
			if (id_normalize_S == IntPtr.Zero)
				id_normalize_S = JNIEnv.GetStaticMethodID (class_ref, "normalize", "(S)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_normalize_S, new JValue (p0));
		}

	}
}
