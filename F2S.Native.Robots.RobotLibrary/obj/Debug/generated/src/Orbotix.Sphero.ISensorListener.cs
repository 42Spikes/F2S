using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.sphero']/interface[@name='SensorListener']"
	[Register ("orbotix/sphero/SensorListener", "", "Orbotix.Sphero.ISensorListenerInvoker")]
	public partial interface ISensorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='SensorListener']/method[@name='sensorUpdated' and count(parameter)=1 and parameter[1][@type='orbotix.robot.sensor.DeviceSensorsData']]"
		[Register ("sensorUpdated", "(Lorbotix/robot/sensor/DeviceSensorsData;)V", "GetSensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_Handler:Orbotix.Sphero.ISensorListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void SensorUpdated (global::Orbotix.Robot.Sensor.DeviceSensorsData p0);

	}

	[global::Android.Runtime.Register ("orbotix/sphero/SensorListener", DoNotGenerateAcw=true)]
	internal class ISensorListenerInvoker : global::Java.Lang.Object, ISensorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/sphero/SensorListener");
		IntPtr class_ref;

		public static ISensorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISensorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.sphero.SensorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISensorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISensorListenerInvoker); }
		}

		static Delegate cb_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_;
#pragma warning disable 0169
		static Delegate GetSensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_Handler ()
		{
			if (cb_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_ == null)
				cb_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_);
			return cb_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_;
		}

		static void n_SensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.ISensorListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ISensorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Sensor.DeviceSensorsData p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.DeviceSensorsData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SensorUpdated (p0);
		}
#pragma warning restore 0169

		IntPtr id_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_;
		public void SensorUpdated (global::Orbotix.Robot.Sensor.DeviceSensorsData p0)
		{
			if (id_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_ == IntPtr.Zero)
				id_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_ = JNIEnv.GetMethodID (class_ref, "sensorUpdated", "(Lorbotix/robot/sensor/DeviceSensorsData;)V");
			JNIEnv.CallVoidMethod (Handle, id_sensorUpdated_Lorbotix_robot_sensor_DeviceSensorsData_, new JValue (p0));
		}

	}

	public partial class SensorEventArgs : global::System.EventArgs {

		public SensorEventArgs (global::Orbotix.Robot.Sensor.DeviceSensorsData p0)
		{
			this.p0 = p0;
		}

		global::Orbotix.Robot.Sensor.DeviceSensorsData p0;
		public global::Orbotix.Robot.Sensor.DeviceSensorsData P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/orbotix/sphero/SensorListenerImplementor")]
	internal sealed class ISensorListenerImplementor : global::Java.Lang.Object, ISensorListener {

		object sender;

		public ISensorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/sphero/SensorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<SensorEventArgs> Handler;
#pragma warning restore 0649

		public void SensorUpdated (global::Orbotix.Robot.Sensor.DeviceSensorsData p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SensorEventArgs (p0));
		}

		internal static bool __IsEmpty (ISensorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
