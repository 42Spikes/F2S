using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.view.calibration']/interface[@name='Controller']"
	[Register ("orbotix/view/calibration/Controller", "", "Orbotix.View.Calibration.IControllerInvoker")]
	public partial interface IController : global::Orbotix.View.Calibration.IMotionInterpreter {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/interface[@name='Controller']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Orbotix.View.Calibration.IControllerInvoker, F2S.Native.Robots.RobotLibrary")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/interface[@name='Controller']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler:Orbotix.View.Calibration.IControllerInvoker, F2S.Native.Robots.RobotLibrary")]
		void Enable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/interface[@name='Controller']/method[@name='setRobot' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("setRobot", "(Lorbotix/robot/base/Robot;)V", "GetSetRobot_Lorbotix_robot_base_Robot_Handler:Orbotix.View.Calibration.IControllerInvoker, F2S.Native.Robots.RobotLibrary")]
		void SetRobot (global::Orbotix.Robot.Base.Robot p0);

	}

	[global::Android.Runtime.Register ("orbotix/view/calibration/Controller", DoNotGenerateAcw=true)]
	internal class IControllerInvoker : global::Java.Lang.Object, IController {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/view/calibration/Controller");
		IntPtr class_ref;

		public static IController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.view.calibration.Controller"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IControllerInvoker); }
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.IController __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.IController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		IntPtr id_disable;
		public void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			JNIEnv.CallVoidMethod (Handle, id_disable);
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.IController __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.IController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		IntPtr id_enable;
		public void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");
			JNIEnv.CallVoidMethod (Handle, id_enable);
		}

		static Delegate cb_setRobot_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetSetRobot_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_setRobot_Lorbotix_robot_base_Robot_ == null)
				cb_setRobot_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRobot_Lorbotix_robot_base_Robot_);
			return cb_setRobot_Lorbotix_robot_base_Robot_;
		}

		static void n_SetRobot_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.IController __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.IController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRobot (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRobot_Lorbotix_robot_base_Robot_;
		public void SetRobot (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_setRobot_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_setRobot_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "setRobot", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallVoidMethod (Handle, id_setRobot_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static Delegate cb_interpretMotionEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetInterpretMotionEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_interpretMotionEvent_Landroid_view_MotionEvent_ == null)
				cb_interpretMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InterpretMotionEvent_Landroid_view_MotionEvent_);
			return cb_interpretMotionEvent_Landroid_view_MotionEvent_;
		}

		static void n_InterpretMotionEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.IController __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.IController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InterpretMotionEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_interpretMotionEvent_Landroid_view_MotionEvent_;
		public void InterpretMotionEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_interpretMotionEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_interpretMotionEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "interpretMotionEvent", "(Landroid/view/MotionEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_interpretMotionEvent_Landroid_view_MotionEvent_, new JValue (p0));
		}

	}

}
