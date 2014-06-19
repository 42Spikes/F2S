using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeData']"
	[ObsoleteAttribute ("This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("orbotix/robot/sensor/AttitudeData", DoNotGenerateAcw=true)]
	public partial class AttitudeData : global::Java.Lang.Object, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/AttitudeData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttitudeData); }
		}

		protected AttitudeData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_sensor_AttitudeSensor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeData']/constructor[@name='AttitudeData' and count(parameter)=1 and parameter[1][@type='orbotix.robot.sensor.AttitudeSensor']]"
		[Register (".ctor", "(Lorbotix/robot/sensor/AttitudeSensor;)V", "")]
		public AttitudeData (global::Orbotix.Robot.Sensor.AttitudeSensor p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AttitudeData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/sensor/AttitudeSensor;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/sensor/AttitudeSensor;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_sensor_AttitudeSensor_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_sensor_AttitudeSensor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/sensor/AttitudeSensor;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_sensor_AttitudeSensor_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_sensor_AttitudeSensor_, new JValue (p0));
		}

		static Delegate cb_getAttitudeSensor;
#pragma warning disable 0169
		static Delegate GetGetAttitudeSensorHandler ()
		{
			if (cb_getAttitudeSensor == null)
				cb_getAttitudeSensor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttitudeSensor);
			return cb_getAttitudeSensor;
		}

		static IntPtr n_GetAttitudeSensor (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.AttitudeData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AttitudeSensor);
		}
#pragma warning restore 0169

		static IntPtr id_getAttitudeSensor;
		public virtual global::Orbotix.Robot.Sensor.AttitudeSensor AttitudeSensor {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeData']/method[@name='getAttitudeSensor' and count(parameter)=0]"
			[Register ("getAttitudeSensor", "()Lorbotix/robot/sensor/AttitudeSensor;", "GetGetAttitudeSensorHandler")]
			get {
				if (id_getAttitudeSensor == IntPtr.Zero)
					id_getAttitudeSensor = JNIEnv.GetMethodID (class_ref, "getAttitudeSensor", "()Lorbotix/robot/sensor/AttitudeSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (JNIEnv.CallObjectMethod  (Handle, id_getAttitudeSensor), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttitudeSensor", "()Lorbotix/robot/sensor/AttitudeSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
#pragma warning disable 0169
		static Delegate GetEncode_Lorbotix_robot_internal_DeviceMessageEncoder_Handler ()
		{
			if (cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ == null)
				cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lorbotix_robot_internal_DeviceMessageEncoder_);
			return cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		}

		static void n_Encode_Lorbotix_robot_internal_DeviceMessageEncoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Sensor.AttitudeData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
		[Register ("encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V", "GetEncode_Lorbotix_robot_internal_DeviceMessageEncoder_Handler")]
		public virtual void Encode (global::Orbotix.Robot.Internal.DeviceMessageEncoder p0)
		{
			if (id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ == IntPtr.Zero)
				id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V"), new JValue (p0));
		}

	}
}
