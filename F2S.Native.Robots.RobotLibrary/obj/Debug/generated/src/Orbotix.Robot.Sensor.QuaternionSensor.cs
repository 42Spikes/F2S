using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/QuaternionSensor", DoNotGenerateAcw=true)]
	public partial class QuaternionSensor : global::Orbotix.Robot.Sensor.SensorData, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/QuaternionSensor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuaternionSensor); }
		}

		protected QuaternionSensor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/constructor[@name='QuaternionSensor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public QuaternionSensor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (QuaternionSensor)) {
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

		static Delegate cb_getQ0;
#pragma warning disable 0169
		static Delegate GetGetQ0Handler ()
		{
			if (cb_getQ0 == null)
				cb_getQ0 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetQ0);
			return cb_getQ0;
		}

		static float n_GetQ0 (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.QuaternionSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Q0;
		}
#pragma warning restore 0169

		static IntPtr id_getQ0;
		public virtual float Q0 {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='getQ0' and count(parameter)=0]"
			[Register ("getQ0", "()F", "GetGetQ0Handler")]
			get {
				if (id_getQ0 == IntPtr.Zero)
					id_getQ0 = JNIEnv.GetMethodID (class_ref, "getQ0", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getQ0);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQ0", "()F"));
			}
		}

		static Delegate cb_getQ1;
#pragma warning disable 0169
		static Delegate GetGetQ1Handler ()
		{
			if (cb_getQ1 == null)
				cb_getQ1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetQ1);
			return cb_getQ1;
		}

		static float n_GetQ1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.QuaternionSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Q1;
		}
#pragma warning restore 0169

		static IntPtr id_getQ1;
		public virtual float Q1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='getQ1' and count(parameter)=0]"
			[Register ("getQ1", "()F", "GetGetQ1Handler")]
			get {
				if (id_getQ1 == IntPtr.Zero)
					id_getQ1 = JNIEnv.GetMethodID (class_ref, "getQ1", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getQ1);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQ1", "()F"));
			}
		}

		static Delegate cb_getQ2;
#pragma warning disable 0169
		static Delegate GetGetQ2Handler ()
		{
			if (cb_getQ2 == null)
				cb_getQ2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetQ2);
			return cb_getQ2;
		}

		static float n_GetQ2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.QuaternionSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Q2;
		}
#pragma warning restore 0169

		static IntPtr id_getQ2;
		public virtual float Q2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='getQ2' and count(parameter)=0]"
			[Register ("getQ2", "()F", "GetGetQ2Handler")]
			get {
				if (id_getQ2 == IntPtr.Zero)
					id_getQ2 = JNIEnv.GetMethodID (class_ref, "getQ2", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getQ2);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQ2", "()F"));
			}
		}

		static Delegate cb_getQ3;
#pragma warning disable 0169
		static Delegate GetGetQ3Handler ()
		{
			if (cb_getQ3 == null)
				cb_getQ3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetQ3);
			return cb_getQ3;
		}

		static float n_GetQ3 (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.QuaternionSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Q3;
		}
#pragma warning restore 0169

		static IntPtr id_getQ3;
		public virtual float Q3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='getQ3' and count(parameter)=0]"
			[Register ("getQ3", "()F", "GetGetQ3Handler")]
			get {
				if (id_getQ3 == IntPtr.Zero)
					id_getQ3 = JNIEnv.GetMethodID (class_ref, "getQ3", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getQ3);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQ3", "()F"));
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
			global::Orbotix.Robot.Sensor.QuaternionSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='getTimeStamp' and count(parameter)=0]"
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
			global::Orbotix.Robot.Sensor.QuaternionSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.QuaternionSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
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

		static IntPtr id_normalize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='QuaternionSensor']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalize", "(I)F", "")]
		public static float Normalize (int p0)
		{
			if (id_normalize_I == IntPtr.Zero)
				id_normalize_I = JNIEnv.GetStaticMethodID (class_ref, "normalize", "(I)F");
			return JNIEnv.CallStaticFloatMethod  (class_ref, id_normalize_I, new JValue (p0));
		}

	}
}
