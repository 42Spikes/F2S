using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ControllerActivity']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/ControllerActivity", DoNotGenerateAcw=true)]
	public partial class ControllerActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/ControllerActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ControllerActivity); }
		}

		protected ControllerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ControllerActivity']/constructor[@name='ControllerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ControllerActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ControllerActivity)) {
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

		static Delegate cb_addController_Lorbotix_view_calibration_Controller_;
#pragma warning disable 0169
		static Delegate GetAddController_Lorbotix_view_calibration_Controller_Handler ()
		{
			if (cb_addController_Lorbotix_view_calibration_Controller_ == null)
				cb_addController_Lorbotix_view_calibration_Controller_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddController_Lorbotix_view_calibration_Controller_);
			return cb_addController_Lorbotix_view_calibration_Controller_;
		}

		static void n_AddController_Lorbotix_view_calibration_Controller_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.ControllerActivity __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.ControllerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.View.Calibration.IController p0 = (global::Orbotix.View.Calibration.IController)global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.IController> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddController (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addController_Lorbotix_view_calibration_Controller_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ControllerActivity']/method[@name='addController' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.Controller']]"
		[Register ("addController", "(Lorbotix/view/calibration/Controller;)V", "GetAddController_Lorbotix_view_calibration_Controller_Handler")]
		public virtual void AddController (global::Orbotix.View.Calibration.IController p0)
		{
			if (id_addController_Lorbotix_view_calibration_Controller_ == IntPtr.Zero)
				id_addController_Lorbotix_view_calibration_Controller_ = JNIEnv.GetMethodID (class_ref, "addController", "(Lorbotix/view/calibration/Controller;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addController_Lorbotix_view_calibration_Controller_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addController", "(Lorbotix/view/calibration/Controller;)V"), new JValue (p0));
		}

		static Delegate cb_disableControllers;
#pragma warning disable 0169
		static Delegate GetDisableControllersHandler ()
		{
			if (cb_disableControllers == null)
				cb_disableControllers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableControllers);
			return cb_disableControllers;
		}

		static void n_DisableControllers (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.ControllerActivity __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.ControllerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableControllers ();
		}
#pragma warning restore 0169

		static IntPtr id_disableControllers;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ControllerActivity']/method[@name='disableControllers' and count(parameter)=0]"
		[Register ("disableControllers", "()V", "GetDisableControllersHandler")]
		public virtual void DisableControllers ()
		{
			if (id_disableControllers == IntPtr.Zero)
				id_disableControllers = JNIEnv.GetMethodID (class_ref, "disableControllers", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableControllers);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableControllers", "()V"));
		}

		static Delegate cb_enableControllers;
#pragma warning disable 0169
		static Delegate GetEnableControllersHandler ()
		{
			if (cb_enableControllers == null)
				cb_enableControllers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableControllers);
			return cb_enableControllers;
		}

		static void n_EnableControllers (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.ControllerActivity __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.ControllerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableControllers ();
		}
#pragma warning restore 0169

		static IntPtr id_enableControllers;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ControllerActivity']/method[@name='enableControllers' and count(parameter)=0]"
		[Register ("enableControllers", "()V", "GetEnableControllersHandler")]
		public virtual void EnableControllers ()
		{
			if (id_enableControllers == IntPtr.Zero)
				id_enableControllers = JNIEnv.GetMethodID (class_ref, "enableControllers", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableControllers);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableControllers", "()V"));
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
			global::Orbotix.View.Calibration.ControllerActivity __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.ControllerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRobot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRobot_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ControllerActivity']/method[@name='setRobot' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("setRobot", "(Lorbotix/robot/base/Robot;)V", "GetSetRobot_Lorbotix_robot_base_Robot_Handler")]
		public virtual void SetRobot (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_setRobot_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_setRobot_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "setRobot", "(Lorbotix/robot/base/Robot;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRobot_Lorbotix_robot_base_Robot_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRobot", "(Lorbotix/robot/base/Robot;)V"), new JValue (p0));
		}

	}
}
