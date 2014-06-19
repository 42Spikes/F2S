using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/LocatorData", DoNotGenerateAcw=true)]
	public partial class LocatorData : global::Orbotix.Robot.Sensor.SensorData, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/LocatorData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocatorData); }
		}

		protected LocatorData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_sensor_LocatorSensor_Lorbotix_robot_sensor_LocatorSensor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/constructor[@name='LocatorData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.sensor.LocatorSensor'] and parameter[2][@type='orbotix.robot.sensor.LocatorSensor']]"
		[Register (".ctor", "(Lorbotix/robot/sensor/LocatorSensor;Lorbotix/robot/sensor/LocatorSensor;)V", "")]
		public LocatorData (global::Orbotix.Robot.Sensor.LocatorSensor p0, global::Orbotix.Robot.Sensor.LocatorSensor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocatorData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/sensor/LocatorSensor;Lorbotix/robot/sensor/LocatorSensor;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/sensor/LocatorSensor;Lorbotix/robot/sensor/LocatorSensor;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorbotix_robot_sensor_LocatorSensor_Lorbotix_robot_sensor_LocatorSensor_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_sensor_LocatorSensor_Lorbotix_robot_sensor_LocatorSensor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/sensor/LocatorSensor;Lorbotix/robot/sensor/LocatorSensor;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_sensor_LocatorSensor_Lorbotix_robot_sensor_LocatorSensor_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_sensor_LocatorSensor_Lorbotix_robot_sensor_LocatorSensor_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		public virtual global::Orbotix.Robot.Sensor.LocatorSensor Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lorbotix/robot/sensor/LocatorSensor;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lorbotix/robot/sensor/LocatorSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorSensor> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lorbotix/robot/sensor/LocatorSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPositionX;
#pragma warning disable 0169
		static Delegate GetGetPositionXHandler ()
		{
			if (cb_getPositionX == null)
				cb_getPositionX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPositionX);
			return cb_getPositionX;
		}

		static float n_GetPositionX (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositionX;
		}
#pragma warning restore 0169

		static IntPtr id_getPositionX;
		public virtual float PositionX {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getPositionX' and count(parameter)=0]"
			[Register ("getPositionX", "()F", "GetGetPositionXHandler")]
			get {
				if (id_getPositionX == IntPtr.Zero)
					id_getPositionX = JNIEnv.GetMethodID (class_ref, "getPositionX", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getPositionX);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionX", "()F"));
			}
		}

		static Delegate cb_getPositionY;
#pragma warning disable 0169
		static Delegate GetGetPositionYHandler ()
		{
			if (cb_getPositionY == null)
				cb_getPositionY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPositionY);
			return cb_getPositionY;
		}

		static float n_GetPositionY (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositionY;
		}
#pragma warning restore 0169

		static IntPtr id_getPositionY;
		public virtual float PositionY {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getPositionY' and count(parameter)=0]"
			[Register ("getPositionY", "()F", "GetGetPositionYHandler")]
			get {
				if (id_getPositionY == IntPtr.Zero)
					id_getPositionY = JNIEnv.GetMethodID (class_ref, "getPositionY", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getPositionY);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionY", "()F"));
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
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getTimeStamp' and count(parameter)=0]"
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

		static Delegate cb_getVelocity;
#pragma warning disable 0169
		static Delegate GetGetVelocityHandler ()
		{
			if (cb_getVelocity == null)
				cb_getVelocity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVelocity);
			return cb_getVelocity;
		}

		static IntPtr n_GetVelocity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Velocity);
		}
#pragma warning restore 0169

		static IntPtr id_getVelocity;
		public virtual global::Orbotix.Robot.Sensor.LocatorSensor Velocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getVelocity' and count(parameter)=0]"
			[Register ("getVelocity", "()Lorbotix/robot/sensor/LocatorSensor;", "GetGetVelocityHandler")]
			get {
				if (id_getVelocity == IntPtr.Zero)
					id_getVelocity = JNIEnv.GetMethodID (class_ref, "getVelocity", "()Lorbotix/robot/sensor/LocatorSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorSensor> (JNIEnv.CallObjectMethod  (Handle, id_getVelocity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVelocity", "()Lorbotix/robot/sensor/LocatorSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVelocityX;
#pragma warning disable 0169
		static Delegate GetGetVelocityXHandler ()
		{
			if (cb_getVelocityX == null)
				cb_getVelocityX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetVelocityX);
			return cb_getVelocityX;
		}

		static float n_GetVelocityX (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VelocityX;
		}
#pragma warning restore 0169

		static IntPtr id_getVelocityX;
		public virtual float VelocityX {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getVelocityX' and count(parameter)=0]"
			[Register ("getVelocityX", "()F", "GetGetVelocityXHandler")]
			get {
				if (id_getVelocityX == IntPtr.Zero)
					id_getVelocityX = JNIEnv.GetMethodID (class_ref, "getVelocityX", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getVelocityX);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVelocityX", "()F"));
			}
		}

		static Delegate cb_getVelocityY;
#pragma warning disable 0169
		static Delegate GetGetVelocityYHandler ()
		{
			if (cb_getVelocityY == null)
				cb_getVelocityY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetVelocityY);
			return cb_getVelocityY;
		}

		static float n_GetVelocityY (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VelocityY;
		}
#pragma warning restore 0169

		static IntPtr id_getVelocityY;
		public virtual float VelocityY {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='getVelocityY' and count(parameter)=0]"
			[Register ("getVelocityY", "()F", "GetGetVelocityYHandler")]
			get {
				if (id_getVelocityY == IntPtr.Zero)
					id_getVelocityY = JNIEnv.GetMethodID (class_ref, "getVelocityY", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getVelocityY);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVelocityY", "()F"));
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
			global::Orbotix.Robot.Sensor.LocatorData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='LocatorData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
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
