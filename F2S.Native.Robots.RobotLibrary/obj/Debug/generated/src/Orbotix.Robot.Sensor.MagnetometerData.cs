using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Sensor {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='MagnetometerData']"
	[ObsoleteAttribute ("This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("orbotix/robot/sensor/MagnetometerData", DoNotGenerateAcw=true)]
	public partial class MagnetometerData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/sensor/MagnetometerData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MagnetometerData); }
		}

		protected MagnetometerData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_sensor_ThreeAxisSensor_Lorbotix_robot_sensor_ThreeAxisSensor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='MagnetometerData']/constructor[@name='MagnetometerData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.sensor.ThreeAxisSensor'] and parameter[2][@type='orbotix.robot.sensor.ThreeAxisSensor']]"
		[Register (".ctor", "(Lorbotix/robot/sensor/ThreeAxisSensor;Lorbotix/robot/sensor/ThreeAxisSensor;)V", "")]
		public MagnetometerData (global::Orbotix.Robot.Sensor.ThreeAxisSensor p0, global::Orbotix.Robot.Sensor.ThreeAxisSensor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MagnetometerData)) {
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

		static Delegate cb_getMagnetometerDataFiltered;
#pragma warning disable 0169
		static Delegate GetGetMagnetometerDataFilteredHandler ()
		{
			if (cb_getMagnetometerDataFiltered == null)
				cb_getMagnetometerDataFiltered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagnetometerDataFiltered);
			return cb_getMagnetometerDataFiltered;
		}

		static IntPtr n_GetMagnetometerDataFiltered (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.MagnetometerData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.MagnetometerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagnetometerDataFiltered);
		}
#pragma warning restore 0169

		static IntPtr id_getMagnetometerDataFiltered;
		public virtual global::Orbotix.Robot.Sensor.ThreeAxisSensor MagnetometerDataFiltered {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='MagnetometerData']/method[@name='getMagnetometerDataFiltered' and count(parameter)=0]"
			[Register ("getMagnetometerDataFiltered", "()Lorbotix/robot/sensor/ThreeAxisSensor;", "GetGetMagnetometerDataFilteredHandler")]
			get {
				if (id_getMagnetometerDataFiltered == IntPtr.Zero)
					id_getMagnetometerDataFiltered = JNIEnv.GetMethodID (class_ref, "getMagnetometerDataFiltered", "()Lorbotix/robot/sensor/ThreeAxisSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallObjectMethod  (Handle, id_getMagnetometerDataFiltered), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagnetometerDataFiltered", "()Lorbotix/robot/sensor/ThreeAxisSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMagnetometerDataRaw;
#pragma warning disable 0169
		static Delegate GetGetMagnetometerDataRawHandler ()
		{
			if (cb_getMagnetometerDataRaw == null)
				cb_getMagnetometerDataRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagnetometerDataRaw);
			return cb_getMagnetometerDataRaw;
		}

		static IntPtr n_GetMagnetometerDataRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Sensor.MagnetometerData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.MagnetometerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagnetometerDataRaw);
		}
#pragma warning restore 0169

		static IntPtr id_getMagnetometerDataRaw;
		public virtual global::Orbotix.Robot.Sensor.ThreeAxisSensor MagnetometerDataRaw {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.sensor']/class[@name='MagnetometerData']/method[@name='getMagnetometerDataRaw' and count(parameter)=0]"
			[Register ("getMagnetometerDataRaw", "()Lorbotix/robot/sensor/ThreeAxisSensor;", "GetGetMagnetometerDataRawHandler")]
			get {
				if (id_getMagnetometerDataRaw == IntPtr.Zero)
					id_getMagnetometerDataRaw = JNIEnv.GetMethodID (class_ref, "getMagnetometerDataRaw", "()Lorbotix/robot/sensor/ThreeAxisSensor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallObjectMethod  (Handle, id_getMagnetometerDataRaw), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.ThreeAxisSensor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagnetometerDataRaw", "()Lorbotix/robot/sensor/ThreeAxisSensor;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
