using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AccelerometerData']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/AccelerometerData", DoNotGenerateAcw=true)]
	public partial class AccelerometerData : global::Orbotix.Robot.Sensor.SensorData {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/AccelerometerData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccelerometerData); }
		}

		protected AccelerometerData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AccelerometerData']/constructor[@name='AccelerometerData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.sensor.ThreeAxisSensor'] and parameter[2][@type='orbotix.robot.sensor.ThreeAxisSensor']]"
		[Register (".ctor", "(Lorbotix/robot/sensor/ThreeAxisSensor;Lorbotix/robot/sensor/ThreeAxisSensor;)V", "")]
		public AccelerometerData (global::Orbotix.Robot.Sensor.ThreeAxisSensor p0, global::Orbotix.Robot.Sensor.ThreeAxisSensor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AccelerometerData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/sensor/ThreeAxisSensor;Lorbotix/robot/sensor/ThreeAxisSensor;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/sensor/ThreeAxisSensor;Lorbotix/robot/sensor/ThreeAxisSensor;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/sensor/ThreeAxisSensor;Lorbotix/robot/sensor/ThreeAxisSensor;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getFilteredAcceleration;
#pragma warning disable 0169
		static Delegate GetGetFilteredAccelerationHandler ()
		{
			if (cb_getFilteredAcceleration == null)
				cb_getFilteredAcceleration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilteredAcceleration);
			return cb_getFilteredAcceleration;
		}

		static IntPtr n_GetFilteredAcceleration (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.AccelerometerData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AccelerometerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FilteredAcceleration);
		}
#pragma warning restore 0169

		static IntPtr id_getFilteredAcceleration;
		public virtual global::Orbotix.Robot.Sensor.Acceleration FilteredAcceleration {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AccelerometerData']/method[@name='getFilteredAcceleration' and count(parameter)=0]"
			[Register ("getFilteredAcceleration", "()Lorbotix/robot/sensor/Acceleration;", "GetGetFilteredAccelerationHandler")]
			get {
				if (id_getFilteredAcceleration == IntPtr.Zero)
					id_getFilteredAcceleration = JNIEnv.GetMethodID (class_ref, "getFilteredAcceleration", "()Lorbotix/robot/sensor/Acceleration;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.Acceleration> (JNIEnv.CallObjectMethod  (Handle, id_getFilteredAcceleration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.Acceleration> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilteredAcceleration", "()Lorbotix/robot/sensor/Acceleration;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRawAcceleration;
#pragma warning disable 0169
		static Delegate GetGetRawAccelerationHandler ()
		{
			if (cb_getRawAcceleration == null)
				cb_getRawAcceleration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawAcceleration);
			return cb_getRawAcceleration;
		}

		static IntPtr n_GetRawAcceleration (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.AccelerometerData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AccelerometerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawAcceleration);
		}
#pragma warning restore 0169

		static IntPtr id_getRawAcceleration;
		public virtual global::Orbotix.Robot.Sensor.ThreeAxisSensor RawAcceleration {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AccelerometerData']/method[@name='getRawAcceleration' and count(parameter)=0]"
			[Register ("getRawAcceleration", "()Lorbotix/robot/sensor/ThreeAxisSensor;", "GetGetRawAccelerationHandler")]
			get {
				if (id_getRawAcceleration == IntPtr.Zero)
					id_getRawAcceleration = JNIEnv.GetMethodID (class_ref, "getRawAcceleration", "()Lorbotix/robot/sensor/ThreeAxisSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallObjectMethod  (Handle, id_getRawAcceleration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawAcceleration", "()Lorbotix/robot/sensor/ThreeAxisSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.AccelerometerData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AccelerometerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AccelerometerData']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimeStamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()J"));
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
			global::Orbotix.Robot.Sensor.AccelerometerData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AccelerometerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AccelerometerData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
		[Register ("encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V", "GetEncode_Lorbotix_robot_internal_DeviceMessageEncoder_Handler")]
		public override void Encode (global::Orbotix.Robot.Internal.DeviceMessageEncoder p0)
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
