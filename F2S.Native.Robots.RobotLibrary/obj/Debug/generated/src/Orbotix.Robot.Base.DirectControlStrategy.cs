using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DirectControlStrategy']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DirectControlStrategy", DoNotGenerateAcw=true)]
	public partial class DirectControlStrategy : global::Java.Lang.Object, global::Orbotix.Robot.Base.IControlStrategy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DirectControlStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectControlStrategy); }
		}

		protected DirectControlStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceConnection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DirectControlStrategy']/constructor[@name='DirectControlStrategy' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceConnection']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceConnection;)V", "")]
		public DirectControlStrategy (global::Orbotix.Robot.Internal.DeviceConnection p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DirectControlStrategy)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/internal/DeviceConnection;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/internal/DeviceConnection;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_internal_DeviceConnection_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_internal_DeviceConnection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/internal/DeviceConnection;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_internal_DeviceConnection_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_internal_DeviceConnection_, new JValue (p0));
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DirectControlStrategy __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DirectControlStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DirectControlStrategy']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
#pragma warning disable 0169
		static Delegate GetDoCommand_Lorbotix_robot_internal_DeviceCommand_JHandler ()
		{
			if (cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J == null)
				cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_DoCommand_Lorbotix_robot_internal_DeviceCommand_J);
			return cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
		}

		static void n_DoCommand_Lorbotix_robot_internal_DeviceCommand_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Orbotix.Robot.Base.DirectControlStrategy __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DirectControlStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DirectControlStrategy']/method[@name='doCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='long']]"
		[Register ("doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V", "GetDoCommand_Lorbotix_robot_internal_DeviceCommand_JHandler")]
		public virtual void DoCommand (global::Orbotix.Robot.Internal.DeviceCommand p0, long p1)
		{
			if (id_doCommand_Lorbotix_robot_internal_DeviceCommand_J == IntPtr.Zero)
				id_doCommand_Lorbotix_robot_internal_DeviceCommand_J = JNIEnv.GetMethodID (class_ref, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doCommand_Lorbotix_robot_internal_DeviceCommand_J, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setControlHandler_Lorbotix_robot_internal_DeviceConnection_;
#pragma warning disable 0169
		static Delegate GetSetControlHandler_Lorbotix_robot_internal_DeviceConnection_Handler ()
		{
			if (cb_setControlHandler_Lorbotix_robot_internal_DeviceConnection_ == null)
				cb_setControlHandler_Lorbotix_robot_internal_DeviceConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControlHandler_Lorbotix_robot_internal_DeviceConnection_);
			return cb_setControlHandler_Lorbotix_robot_internal_DeviceConnection_;
		}

		static void n_SetControlHandler_Lorbotix_robot_internal_DeviceConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DirectControlStrategy __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DirectControlStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceConnection p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetControlHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setControlHandler_Lorbotix_robot_internal_DeviceConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DirectControlStrategy']/method[@name='setControlHandler' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceConnection']]"
		[Register ("setControlHandler", "(Lorbotix/robot/internal/DeviceConnection;)V", "GetSetControlHandler_Lorbotix_robot_internal_DeviceConnection_Handler")]
		public virtual void SetControlHandler (global::Orbotix.Robot.Internal.DeviceConnection p0)
		{
			if (id_setControlHandler_Lorbotix_robot_internal_DeviceConnection_ == IntPtr.Zero)
				id_setControlHandler_Lorbotix_robot_internal_DeviceConnection_ = JNIEnv.GetMethodID (class_ref, "setControlHandler", "(Lorbotix/robot/internal/DeviceConnection;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setControlHandler_Lorbotix_robot_internal_DeviceConnection_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setControlHandler", "(Lorbotix/robot/internal/DeviceConnection;)V"), new JValue (p0));
		}

	}
}
