using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.sphero']/interface[@name='LocatorListener']"
	[Register ("orbotix/sphero/LocatorListener", "", "Orbotix.Sphero.ILocatorListenerInvoker")]
	public partial interface ILocatorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='LocatorListener']/method[@name='onLocatorChanged' and count(parameter)=1 and parameter[1][@type='orbotix.robot.sensor.LocatorData']]"
		[Register ("onLocatorChanged", "(Lorbotix/robot/sensor/LocatorData;)V", "GetOnLocatorChanged_Lorbotix_robot_sensor_LocatorData_Handler:Orbotix.Sphero.ILocatorListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void OnLocatorChanged (global::Orbotix.Robot.Sensor.LocatorData p0);

	}

	[global::Android.Runtime.Register ("orbotix/sphero/LocatorListener", DoNotGenerateAcw=true)]
	internal class ILocatorListenerInvoker : global::Java.Lang.Object, ILocatorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/sphero/LocatorListener");
		IntPtr class_ref;

		public static ILocatorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocatorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.sphero.LocatorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocatorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILocatorListenerInvoker); }
		}

		static Delegate cb_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_;
#pragma warning disable 0169
		static Delegate GetOnLocatorChanged_Lorbotix_robot_sensor_LocatorData_Handler ()
		{
			if (cb_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_ == null)
				cb_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocatorChanged_Lorbotix_robot_sensor_LocatorData_);
			return cb_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_;
		}

		static void n_OnLocatorChanged_Lorbotix_robot_sensor_LocatorData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.ILocatorListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ILocatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Sensor.LocatorData p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.LocatorData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocatorChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_;
		public void OnLocatorChanged (global::Orbotix.Robot.Sensor.LocatorData p0)
		{
			if (id_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_ == IntPtr.Zero)
				id_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_ = JNIEnv.GetMethodID (class_ref, "onLocatorChanged", "(Lorbotix/robot/sensor/LocatorData;)V");
			JNIEnv.CallVoidMethod (Handle, id_onLocatorChanged_Lorbotix_robot_sensor_LocatorData_, new JValue (p0));
		}

	}

	public partial class LocatorEventArgs : global::System.EventArgs {

		public LocatorEventArgs (global::Orbotix.Robot.Sensor.LocatorData p0)
		{
			this.p0 = p0;
		}

		global::Orbotix.Robot.Sensor.LocatorData p0;
		public global::Orbotix.Robot.Sensor.LocatorData P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/orbotix/sphero/LocatorListenerImplementor")]
	internal sealed class ILocatorListenerImplementor : global::Java.Lang.Object, ILocatorListener {

		object sender;

		public ILocatorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/sphero/LocatorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocatorEventArgs> Handler;
#pragma warning restore 0649

		public void OnLocatorChanged (global::Orbotix.Robot.Sensor.LocatorData p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LocatorEventArgs (p0));
		}

		internal static bool __IsEmpty (ILocatorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
