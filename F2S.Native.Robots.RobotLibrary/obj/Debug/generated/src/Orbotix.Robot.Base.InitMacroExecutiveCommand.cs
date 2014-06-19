using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='InitMacroExecutiveCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/InitMacroExecutiveCommand", DoNotGenerateAcw=true)]
	public partial class InitMacroExecutiveCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/InitMacroExecutiveCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitMacroExecutiveCommand); }
		}

		protected InitMacroExecutiveCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='InitMacroExecutiveCommand']/constructor[@name='InitMacroExecutiveCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public InitMacroExecutiveCommand () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InitMacroExecutiveCommand)) {
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

		static Delegate cb_getJSON;
#pragma warning disable 0169
		static Delegate GetGetJSONHandler ()
		{
			if (cb_getJSON == null)
				cb_getJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSON);
			return cb_getJSON;
		}

		static IntPtr n_GetJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.InitMacroExecutiveCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.InitMacroExecutiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='InitMacroExecutiveCommand']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler")]
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSON", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='InitMacroExecutiveCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/InitMacroExecutiveCommand;", "")]
		public static global::Orbotix.Robot.Base.InitMacroExecutiveCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/InitMacroExecutiveCommand;");
			global::Orbotix.Robot.Base.InitMacroExecutiveCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.InitMacroExecutiveCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='InitMacroExecutiveCommand']/method[@name='sendCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

	}
}
