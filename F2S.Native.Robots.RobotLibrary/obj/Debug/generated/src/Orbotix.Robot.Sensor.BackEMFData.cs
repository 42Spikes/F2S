using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFData']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/BackEMFData", DoNotGenerateAcw=true)]
	public partial class BackEMFData : global::Orbotix.Robot.Sensor.SensorData, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/BackEMFData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackEMFData); }
		}

		protected BackEMFData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_sensor_BackEMFSensor_Lorbotix_robot_sensor_BackEMFSensor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFData']/constructor[@name='BackEMFData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.sensor.BackEMFSensor'] and parameter[2][@type='orbotix.robot.sensor.BackEMFSensor']]"
		[Register (".ctor", "(Lorbotix/robot/sensor/BackEMFSensor;Lorbotix/robot/sensor/BackEMFSensor;)V", "")]
		public BackEMFData (global::Orbotix.Robot.Sensor.BackEMFSensor p0, global::Orbotix.Robot.Sensor.BackEMFSensor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BackEMFData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/sensor/BackEMFSensor;Lorbotix/robot/sensor/BackEMFSensor;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/sensor/BackEMFSensor;Lorbotix/robot/sensor/BackEMFSensor;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorbotix_robot_sensor_BackEMFSensor_Lorbotix_robot_sensor_BackEMFSensor_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_sensor_BackEMFSensor_Lorbotix_robot_sensor_BackEMFSensor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/sensor/BackEMFSensor;Lorbotix/robot/sensor/BackEMFSensor;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_sensor_BackEMFSensor_Lorbotix_robot_sensor_BackEMFSensor_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_sensor_BackEMFSensor_Lorbotix_robot_sensor_BackEMFSensor_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getEMFFiltered;
#pragma warning disable 0169
		static Delegate GetGetEMFFilteredHandler ()
		{
			if (cb_getEMFFiltered == null)
				cb_getEMFFiltered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEMFFiltered);
			return cb_getEMFFiltered;
		}

		static IntPtr n_GetEMFFiltered (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.BackEMFData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EMFFiltered);
		}
#pragma warning restore 0169

		static IntPtr id_getEMFFiltered;
		public virtual global::Orbotix.Robot.Sensor.BackEMFSensor EMFFiltered {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFData']/method[@name='getEMFFiltered' and count(parameter)=0]"
			[Register ("getEMFFiltered", "()Lorbotix/robot/sensor/BackEMFSensor;", "GetGetEMFFilteredHandler")]
			get {
				if (id_getEMFFiltered == IntPtr.Zero)
					id_getEMFFiltered = JNIEnv.GetMethodID (class_ref, "getEMFFiltered", "()Lorbotix/robot/sensor/BackEMFSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFSensor> (JNIEnv.CallObjectMethod  (Handle, id_getEMFFiltered), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEMFFiltered", "()Lorbotix/robot/sensor/BackEMFSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEMFRaw;
#pragma warning disable 0169
		static Delegate GetGetEMFRawHandler ()
		{
			if (cb_getEMFRaw == null)
				cb_getEMFRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEMFRaw);
			return cb_getEMFRaw;
		}

		static IntPtr n_GetEMFRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.BackEMFData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EMFRaw);
		}
#pragma warning restore 0169

		static IntPtr id_getEMFRaw;
		public virtual global::Orbotix.Robot.Sensor.BackEMFSensor EMFRaw {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFData']/method[@name='getEMFRaw' and count(parameter)=0]"
			[Register ("getEMFRaw", "()Lorbotix/robot/sensor/BackEMFSensor;", "GetGetEMFRawHandler")]
			get {
				if (id_getEMFRaw == IntPtr.Zero)
					id_getEMFRaw = JNIEnv.GetMethodID (class_ref, "getEMFRaw", "()Lorbotix/robot/sensor/BackEMFSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFSensor> (JNIEnv.CallObjectMethod  (Handle, id_getEMFRaw), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEMFRaw", "()Lorbotix/robot/sensor/BackEMFSensor;")), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Robot.Sensor.BackEMFData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFData']/method[@name='getTimeStamp' and count(parameter)=0]"
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
			global::Orbotix.Robot.Sensor.BackEMFData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.BackEMFData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='BackEMFData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
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
