using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']"
	[global::Android.Runtime.Register ("orbotix/robot/sensor/AttitudeSensor", DoNotGenerateAcw=true)]
	public partial class AttitudeSensor : global::Orbotix.Robot.Sensor.SensorData, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {


		static IntPtr pitch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/field[@name='pitch']"
		[Register ("pitch")]
		public int Pitch {
			get {
				if (pitch_jfieldId == IntPtr.Zero)
					pitch_jfieldId = JNIEnv.GetFieldID (class_ref, "pitch", "I");
				return JNIEnv.GetIntField (Handle, pitch_jfieldId);
			}
			set {
				if (pitch_jfieldId == IntPtr.Zero)
					pitch_jfieldId = JNIEnv.GetFieldID (class_ref, "pitch", "I");
				JNIEnv.SetField (Handle, pitch_jfieldId, value);
			}
		}

		static IntPtr roll_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/field[@name='roll']"
		[Register ("roll")]
		public int Roll {
			get {
				if (roll_jfieldId == IntPtr.Zero)
					roll_jfieldId = JNIEnv.GetFieldID (class_ref, "roll", "I");
				return JNIEnv.GetIntField (Handle, roll_jfieldId);
			}
			set {
				if (roll_jfieldId == IntPtr.Zero)
					roll_jfieldId = JNIEnv.GetFieldID (class_ref, "roll", "I");
				JNIEnv.SetField (Handle, roll_jfieldId, value);
			}
		}

		static IntPtr yaw_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/field[@name='yaw']"
		[Register ("yaw")]
		public int Yaw {
			get {
				if (yaw_jfieldId == IntPtr.Zero)
					yaw_jfieldId = JNIEnv.GetFieldID (class_ref, "yaw", "I");
				return JNIEnv.GetIntField (Handle, yaw_jfieldId);
			}
			set {
				if (yaw_jfieldId == IntPtr.Zero)
					yaw_jfieldId = JNIEnv.GetFieldID (class_ref, "yaw", "I");
				JNIEnv.SetField (Handle, yaw_jfieldId, value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/AttitudeSensor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttitudeSensor); }
		}

		protected AttitudeSensor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/constructor[@name='AttitudeSensor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AttitudeSensor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AttitudeSensor)) {
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
			global::Orbotix.Robot.Sensor.AttitudeSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public override long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/method[@name='getTimeStamp' and count(parameter)=0]"
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
			global::Orbotix.Robot.Sensor.AttitudeSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
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

		static Delegate cb_getAttitudeSensor;
#pragma warning disable 0169
		static Delegate GetGetAttitudeSensorHandler ()
		{
			if (cb_getAttitudeSensor == null)
				cb_getAttitudeSensor = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetAttitudeSensor);
			return cb_getAttitudeSensor;
		}

		static void n_GetAttitudeSensor (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.AttitudeSensor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.AttitudeSensor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetAttitudeSensor ();
		}
#pragma warning restore 0169

		static IntPtr id_getAttitudeSensor;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='AttitudeSensor']/method[@name='getAttitudeSensor' and count(parameter)=0]"
		[Register ("getAttitudeSensor", "()V", "GetGetAttitudeSensorHandler")]
		public virtual void GetAttitudeSensor ()
		{
			if (id_getAttitudeSensor == IntPtr.Zero)
				id_getAttitudeSensor = JNIEnv.GetMethodID (class_ref, "getAttitudeSensor", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getAttitudeSensor);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttitudeSensor", "()V"));
		}

	}
}
