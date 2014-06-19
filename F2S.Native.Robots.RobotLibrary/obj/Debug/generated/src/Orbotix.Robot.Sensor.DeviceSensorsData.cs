using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/DeviceSensorsData", DoNotGenerateAcw=true)]
	public partial class DeviceSensorsData : global::Orbotix.Robot.Sensor.SensorData, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/DeviceSensorsData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceSensorsData); }
		}

		protected DeviceSensorsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_util_BitMask_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/constructor[@name='DeviceSensorsData' and count(parameter)=2 and parameter[1][@type='orbotix.util.BitMask'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/util/BitMask;[B)V", "")]
		public DeviceSensorsData (global::Orbotix.Util.BitMask p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (DeviceSensorsData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/util/BitMask;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/util/BitMask;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_util_BitMask_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_util_BitMask_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/util/BitMask;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_util_BitMask_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_util_BitMask_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAccelerometerData;
#pragma warning disable 0169
		static Delegate GetGetAccelerometerDataHandler ()
		{
			if (cb_getAccelerometerData == null)
				cb_getAccelerometerData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccelerometerData);
			return cb_getAccelerometerData;
		}

		static IntPtr n_GetAccelerometerData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccelerometerData);
		}
#pragma warning restore 0169

		static IntPtr id_getAccelerometerData;
		public virtual global::Orbotix.Robot.Sensor.AccelerometerData AccelerometerData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getAccelerometerData' and count(parameter)=0]"
			[Register ("getAccelerometerData", "()Lorbotix/robot/sensor/AccelerometerData;", "GetGetAccelerometerDataHandler")]
			get {
				if (id_getAccelerometerData == IntPtr.Zero)
					id_getAccelerometerData = JNIEnv.GetMethodID (class_ref, "getAccelerometerData", "()Lorbotix/robot/sensor/AccelerometerData;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AccelerometerData> (JNIEnv.CallObjectMethod  (Handle, id_getAccelerometerData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AccelerometerData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccelerometerData", "()Lorbotix/robot/sensor/AccelerometerData;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAttitudeData;
#pragma warning disable 0169
		static Delegate GetGetAttitudeDataHandler ()
		{
			if (cb_getAttitudeData == null)
				cb_getAttitudeData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttitudeData);
			return cb_getAttitudeData;
		}

		static IntPtr n_GetAttitudeData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AttitudeData);
		}
#pragma warning restore 0169

		static IntPtr id_getAttitudeData;
		public virtual global::Orbotix.Robot.Sensor.AttitudeSensor AttitudeData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getAttitudeData' and count(parameter)=0]"
			[Register ("getAttitudeData", "()Lorbotix/robot/sensor/AttitudeSensor;", "GetGetAttitudeDataHandler")]
			get {
				if (id_getAttitudeData == IntPtr.Zero)
					id_getAttitudeData = JNIEnv.GetMethodID (class_ref, "getAttitudeData", "()Lorbotix/robot/sensor/AttitudeSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (JNIEnv.CallObjectMethod  (Handle, id_getAttitudeData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttitudeData", "()Lorbotix/robot/sensor/AttitudeSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBackEMFData;
#pragma warning disable 0169
		static Delegate GetGetBackEMFDataHandler ()
		{
			if (cb_getBackEMFData == null)
				cb_getBackEMFData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackEMFData);
			return cb_getBackEMFData;
		}

		static IntPtr n_GetBackEMFData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BackEMFData);
		}
#pragma warning restore 0169

		static IntPtr id_getBackEMFData;
		public virtual global::Orbotix.Robot.Sensor.BackEMFData BackEMFData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getBackEMFData' and count(parameter)=0]"
			[Register ("getBackEMFData", "()Lorbotix/robot/sensor/BackEMFData;", "GetGetBackEMFDataHandler")]
			get {
				if (id_getBackEMFData == IntPtr.Zero)
					id_getBackEMFData = JNIEnv.GetMethodID (class_ref, "getBackEMFData", "()Lorbotix/robot/sensor/BackEMFData;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFData> (JNIEnv.CallObjectMethod  (Handle, id_getBackEMFData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackEMFData", "()Lorbotix/robot/sensor/BackEMFData;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGyroData;
#pragma warning disable 0169
		static Delegate GetGetGyroDataHandler ()
		{
			if (cb_getGyroData == null)
				cb_getGyroData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGyroData);
			return cb_getGyroData;
		}

		static IntPtr n_GetGyroData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GyroData);
		}
#pragma warning restore 0169

		static IntPtr id_getGyroData;
		public virtual global::Orbotix.Robot.Sensor.GyroData GyroData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getGyroData' and count(parameter)=0]"
			[Register ("getGyroData", "()Lorbotix/robot/sensor/GyroData;", "GetGetGyroDataHandler")]
			get {
				if (id_getGyroData == IntPtr.Zero)
					id_getGyroData = JNIEnv.GetMethodID (class_ref, "getGyroData", "()Lorbotix/robot/sensor/GyroData;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.GyroData> (JNIEnv.CallObjectMethod  (Handle, id_getGyroData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.GyroData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGyroData", "()Lorbotix/robot/sensor/GyroData;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocatorData;
#pragma warning disable 0169
		static Delegate GetGetLocatorDataHandler ()
		{
			if (cb_getLocatorData == null)
				cb_getLocatorData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocatorData);
			return cb_getLocatorData;
		}

		static IntPtr n_GetLocatorData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocatorData);
		}
#pragma warning restore 0169

		static IntPtr id_getLocatorData;
		public virtual global::Orbotix.Robot.Sensor.LocatorData LocatorData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getLocatorData' and count(parameter)=0]"
			[Register ("getLocatorData", "()Lorbotix/robot/sensor/LocatorData;", "GetGetLocatorDataHandler")]
			get {
				if (id_getLocatorData == IntPtr.Zero)
					id_getLocatorData = JNIEnv.GetMethodID (class_ref, "getLocatorData", "()Lorbotix/robot/sensor/LocatorData;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (JNIEnv.CallObjectMethod  (Handle, id_getLocatorData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocatorData", "()Lorbotix/robot/sensor/LocatorData;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMagnetometerData;
#pragma warning disable 0169
		static Delegate GetGetMagnetometerDataHandler ()
		{
			if (cb_getMagnetometerData == null)
				cb_getMagnetometerData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagnetometerData);
			return cb_getMagnetometerData;
		}

		static IntPtr n_GetMagnetometerData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagnetometerData);
		}
#pragma warning restore 0169

		static IntPtr id_getMagnetometerData;
		[Obsolete (@"deprecated")]
		public virtual global::Orbotix.Robot.Sensor.MagnetometerData MagnetometerData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getMagnetometerData' and count(parameter)=0]"
			[Register ("getMagnetometerData", "()Lorbotix/robot/sensor/MagnetometerData;", "GetGetMagnetometerDataHandler")]
			get {
				if (id_getMagnetometerData == IntPtr.Zero)
					id_getMagnetometerData = JNIEnv.GetMethodID (class_ref, "getMagnetometerData", "()Lorbotix/robot/sensor/MagnetometerData;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.MagnetometerData> (JNIEnv.CallObjectMethod  (Handle, id_getMagnetometerData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.MagnetometerData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagnetometerData", "()Lorbotix/robot/sensor/MagnetometerData;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getQuaternion;
#pragma warning disable 0169
		static Delegate GetGetQuaternionHandler ()
		{
			if (cb_getQuaternion == null)
				cb_getQuaternion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuaternion);
			return cb_getQuaternion;
		}

		static IntPtr n_GetQuaternion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Quaternion);
		}
#pragma warning restore 0169

		static IntPtr id_getQuaternion;
		public virtual global::Orbotix.Robot.Sensor.QuaternionSensor Quaternion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getQuaternion' and count(parameter)=0]"
			[Register ("getQuaternion", "()Lorbotix/robot/sensor/QuaternionSensor;", "GetGetQuaternionHandler")]
			get {
				if (id_getQuaternion == IntPtr.Zero)
					id_getQuaternion = JNIEnv.GetMethodID (class_ref, "getQuaternion", "()Lorbotix/robot/sensor/QuaternionSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (JNIEnv.CallObjectMethod  (Handle, id_getQuaternion), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuaternion", "()Lorbotix/robot/sensor/QuaternionSensor;")), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='getTimeStamp' and count(parameter)=0]"
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
			global::Orbotix.Robot.Sensor.DeviceSensorsData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='DeviceSensorsData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
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
