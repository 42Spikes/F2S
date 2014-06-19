using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/RunMacroCommand", DoNotGenerateAcw=true)]
	public partial class RunMacroCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/field[@name='TEMPORARY_MACRO_ID']"
		[Register ("TEMPORARY_MACRO_ID")]
		public const sbyte TemporaryMacroId = (sbyte) -1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/RunMacroCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RunMacroCommand); }
		}

		protected RunMacroCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_B;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/constructor[@name='RunMacroCommand' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public RunMacroCommand (sbyte p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RunMacroCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(B)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(B)V", new JValue (p0));
				return;
			}

			if (id_ctor_B == IntPtr.Zero)
				id_ctor_B = JNIEnv.GetMethodID (class_ref, "<init>", "(B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_B, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_B, new JValue (p0));
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
			global::Orbotix.Robot.Base.RunMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RunMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/method[@name='getJSON' and count(parameter)=0]"
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

		static Delegate cb_getMacroId;
#pragma warning disable 0169
		static Delegate GetGetMacroIdHandler ()
		{
			if (cb_getMacroId == null)
				cb_getMacroId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetMacroId);
			return cb_getMacroId;
		}

		static sbyte n_GetMacroId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RunMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RunMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MacroId;
		}
#pragma warning restore 0169

		static IntPtr id_getMacroId;
		public virtual sbyte MacroId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/method[@name='getMacroId' and count(parameter)=0]"
			[Register ("getMacroId", "()B", "GetGetMacroIdHandler")]
			get {
				if (id_getMacroId == IntPtr.Zero)
					id_getMacroId = JNIEnv.GetMethodID (class_ref, "getMacroId", "()B");

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getMacroId);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMacroId", "()B"));
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RunMacroCommand;", "")]
		public static global::Orbotix.Robot.Base.RunMacroCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RunMacroCommand;");
			global::Orbotix.Robot.Base.RunMacroCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RunMacroCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RunMacroCommand']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;B)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, sbyte p1)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_B == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_B = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;B)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_B, new JValue (p0), new JValue (p1));
		}

	}
}
