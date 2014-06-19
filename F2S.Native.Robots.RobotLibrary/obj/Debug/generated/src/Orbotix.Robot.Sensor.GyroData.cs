using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='GyroData']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/GyroData", DoNotGenerateAcw=true)]
	public partial class GyroData : global::Orbotix.Robot.Sensor.SensorData {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/GyroData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GyroData); }
		}

		protected GyroData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='GyroData']/constructor[@name='GyroData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.sensor.ThreeAxisSensor'] and parameter[2][@type='orbotix.robot.sensor.ThreeAxisSensor']]"
		[Register (".ctor", "(Lorbotix/robot/sensor/ThreeAxisSensor;Lorbotix/robot/sensor/ThreeAxisSensor;)V", "")]
		public GyroData (global::Orbotix.Robot.Sensor.ThreeAxisSensor p0, global::Orbotix.Robot.Sensor.ThreeAxisSensor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GyroData)) {
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

		static Delegate cb_getRotationRateFiltered;
#pragma warning disable 0169
		static Delegate GetGetRotationRateFilteredHandler ()
		{
			if (cb_getRotationRateFiltered == null)
				cb_getRotationRateFiltered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotationRateFiltered);
			return cb_getRotationRateFiltered;
		}

		static IntPtr n_GetRotationRateFiltered (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.GyroData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.GyroData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationRateFiltered);
		}
#pragma warning restore 0169

		static IntPtr id_getRotationRateFiltered;
		public virtual global::Orbotix.Robot.Sensor.ThreeAxisSensor RotationRateFiltered {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='GyroData']/method[@name='getRotationRateFiltered' and count(parameter)=0]"
			[Register ("getRotationRateFiltered", "()Lorbotix/robot/sensor/ThreeAxisSensor;", "GetGetRotationRateFilteredHandler")]
			get {
				if (id_getRotationRateFiltered == IntPtr.Zero)
					id_getRotationRateFiltered = JNIEnv.GetMethodID (class_ref, "getRotationRateFiltered", "()Lorbotix/robot/sensor/ThreeAxisSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallObjectMethod  (Handle, id_getRotationRateFiltered), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotationRateFiltered", "()Lorbotix/robot/sensor/ThreeAxisSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRotationRateRaw;
#pragma warning disable 0169
		static Delegate GetGetRotationRateRawHandler ()
		{
			if (cb_getRotationRateRaw == null)
				cb_getRotationRateRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotationRateRaw);
			return cb_getRotationRateRaw;
		}

		static IntPtr n_GetRotationRateRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.GyroData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.GyroData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationRateRaw);
		}
#pragma warning restore 0169

		static IntPtr id_getRotationRateRaw;
		public virtual global::Orbotix.Robot.Sensor.ThreeAxisSensor RotationRateRaw {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='GyroData']/method[@name='getRotationRateRaw' and count(parameter)=0]"
			[Register ("getRotationRateRaw", "()Lorbotix/robot/sensor/ThreeAxisSensor;", "GetGetRotationRateRawHandler")]
			get {
				if (id_getRotationRateRaw == IntPtr.Zero)
					id_getRotationRateRaw = JNIEnv.GetMethodID (class_ref, "getRotationRateRaw", "()Lorbotix/robot/sensor/ThreeAxisSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallObjectMethod  (Handle, id_getRotationRateRaw), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotationRateRaw", "()Lorbotix/robot/sensor/ThreeAxisSensor;")), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Robot.Sensor.GyroData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.GyroData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='GyroData']/method[@name='getTimeStamp' and count(parameter)=0]"
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
			global::Orbotix.Robot.Sensor.GyroData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.GyroData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='GyroData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
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
