using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFSensor']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/BackEMFSensor", DoNotGenerateAcw=true)]
	public partial class BackEMFSensor : global::Java.Lang.Object {


		static IntPtr leftMotorValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFSensor']/field[@name='leftMotorValue']"
		[Register ("leftMotorValue")]
		public int LeftMotorValue {
			get {
				if (leftMotorValue_jfieldId == IntPtr.Zero)
					leftMotorValue_jfieldId = JNIEnv.GetFieldID (class_ref, "leftMotorValue", "I");
				return JNIEnv.GetIntField (Handle, leftMotorValue_jfieldId);
			}
			set {
				if (leftMotorValue_jfieldId == IntPtr.Zero)
					leftMotorValue_jfieldId = JNIEnv.GetFieldID (class_ref, "leftMotorValue", "I");
				JNIEnv.SetField (Handle, leftMotorValue_jfieldId, value);
			}
		}

		static IntPtr rightMotorValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFSensor']/field[@name='rightMotorValue']"
		[Register ("rightMotorValue")]
		public int RightMotorValue {
			get {
				if (rightMotorValue_jfieldId == IntPtr.Zero)
					rightMotorValue_jfieldId = JNIEnv.GetFieldID (class_ref, "rightMotorValue", "I");
				return JNIEnv.GetIntField (Handle, rightMotorValue_jfieldId);
			}
			set {
				if (rightMotorValue_jfieldId == IntPtr.Zero)
					rightMotorValue_jfieldId = JNIEnv.GetFieldID (class_ref, "rightMotorValue", "I");
				JNIEnv.SetField (Handle, rightMotorValue_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/BackEMFSensor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackEMFSensor); }
		}

		protected BackEMFSensor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFSensor']/constructor[@name='BackEMFSensor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BackEMFSensor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BackEMFSensor)) {
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
