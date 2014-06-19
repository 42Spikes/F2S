using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='ControlStrategy']"
	[Register ("orbotix/robot/base/ControlStrategy", "", "Orbotix.Robot.Base.IControlStrategyInvoker")]
	public partial interface IControlStrategy : global::Java.IO.ICloseable {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='ControlStrategy']/method[@name='doCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='long']]"
		[Register ("doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V", "GetDoCommand_Lorbotix_robot_internal_DeviceCommand_JHandler:Orbotix.Robot.Base.IControlStrategyInvoker, F2S.Native.Robots.RobotLibrary")]
		void DoCommand (global::Orbotix.Robot.Internal.DeviceCommand p0, long p1);

	}

	[global::Android.Runtime.Register ("orbotix/robot/base/ControlStrategy", DoNotGenerateAcw=true)]
	internal class IControlStrategyInvoker : global::Java.Lang.Object, IControlStrategy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/ControlStrategy");
		IntPtr class_ref;

		public static IControlStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControlStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.ControlStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControlStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IControlStrategyInvoker); }
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
			global::Orbotix.Robot.Base.IControlStrategy __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.IControlStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoCommand (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
		public void DoCommand (global::Orbotix.Robot.Internal.DeviceCommand p0, long p1)
		{
			if (id_doCommand_Lorbotix_robot_internal_DeviceCommand_J == IntPtr.Zero)
				id_doCommand_Lorbotix_robot_internal_DeviceCommand_J = JNIEnv.GetMethodID (class_ref, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V");
			JNIEnv.CallVoidMethod (Handle, id_doCommand_Lorbotix_robot_internal_DeviceCommand_J, new JValue (p0), new JValue (p1));
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
			global::Orbotix.Robot.Base.IControlStrategy __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.IControlStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

	}

}
