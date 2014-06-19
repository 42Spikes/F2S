using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='ThreeAxisSensor']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/ThreeAxisSensor", DoNotGenerateAcw=true)]
	public partial class ThreeAxisSensor : global::Java.Lang.Object {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='ThreeAxisSensor']/field[@name='x']"
		[Register ("x")]
		public int X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				return JNIEnv.GetIntField (Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				JNIEnv.SetField (Handle, x_jfieldId, value);
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='ThreeAxisSensor']/field[@name='y']"
		[Register ("y")]
		public int Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				return JNIEnv.GetIntField (Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				JNIEnv.SetField (Handle, y_jfieldId, value);
			}
		}

		static IntPtr z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='ThreeAxisSensor']/field[@name='z']"
		[Register ("z")]
		public int Z {
			get {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "I");
				return JNIEnv.GetIntField (Handle, z_jfieldId);
			}
			set {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "I");
				JNIEnv.SetField (Handle, z_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/ThreeAxisSensor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreeAxisSensor); }
		}

		protected ThreeAxisSensor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='ThreeAxisSensor']/constructor[@name='ThreeAxisSensor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ThreeAxisSensor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ThreeAxisSensor)) {
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

	}
}
