using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/BackLEDOutputCommand", DoNotGenerateAcw=true)]
	public sealed partial class BackLEDOutputCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']/field[@name='CREATOR']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/BackLEDOutputCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackLEDOutputCommand); }
		}

		internal BackLEDOutputCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']/constructor[@name='BackLEDOutputCommand' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public BackLEDOutputCommand (float p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BackLEDOutputCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(F)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(F)V", new JValue (p0));
				return;
			}

			if (id_ctor_F == IntPtr.Zero)
				id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_F, new JValue (p0));
		}

		static IntPtr id_getBrightness;
		public float Brightness {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']/method[@name='getBrightness' and count(parameter)=0]"
			[Register ("getBrightness", "()F", "GetGetBrightnessHandler")]
			get {
				if (id_getBrightness == IntPtr.Zero)
					id_getBrightness = JNIEnv.GetMethodID (class_ref, "getBrightness", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getBrightness);
			}
		}

		static IntPtr id_getJSON;
		public global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler")]
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/BackLEDOutputCommand;", "")]
		public static global::Orbotix.Robot.Base.BackLEDOutputCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/BackLEDOutputCommand;");
			global::Orbotix.Robot.Base.BackLEDOutputCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.BackLEDOutputCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='BackLEDOutputCommand']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='float']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;F)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, float p1)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_F == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_F = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_F, new JValue (p0), new JValue (p1));
		}

	}
}
