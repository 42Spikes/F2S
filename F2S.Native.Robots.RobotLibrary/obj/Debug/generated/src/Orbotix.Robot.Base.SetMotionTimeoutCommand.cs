using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SetMotionTimeoutCommand", DoNotGenerateAcw=true)]
	public partial class SetMotionTimeoutCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/SetMotionTimeoutCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SetMotionTimeoutCommand); }
		}

		protected SetMotionTimeoutCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']/constructor[@name='SetMotionTimeoutCommand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public SetMotionTimeoutCommand (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SetMotionTimeoutCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
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
			global::Orbotix.Robot.Base.SetMotionTimeoutCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetMotionTimeoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']/method[@name='getJSON' and count(parameter)=0]"
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

		static Delegate cb_getTimeBeforeTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeBeforeTimeoutHandler ()
		{
			if (cb_getTimeBeforeTimeout == null)
				cb_getTimeBeforeTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTimeBeforeTimeout);
			return cb_getTimeBeforeTimeout;
		}

		static float n_GetTimeBeforeTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SetMotionTimeoutCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetMotionTimeoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeBeforeTimeout;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeBeforeTimeout;
		public virtual float TimeBeforeTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']/method[@name='getTimeBeforeTimeout' and count(parameter)=0]"
			[Register ("getTimeBeforeTimeout", "()F", "GetGetTimeBeforeTimeoutHandler")]
			get {
				if (id_getTimeBeforeTimeout == IntPtr.Zero)
					id_getTimeBeforeTimeout = JNIEnv.GetMethodID (class_ref, "getTimeBeforeTimeout", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getTimeBeforeTimeout);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeBeforeTimeout", "()F"));
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/SetMotionTimeoutCommand;", "")]
		public static global::Orbotix.Robot.Base.SetMotionTimeoutCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/SetMotionTimeoutCommand;");
			global::Orbotix.Robot.Base.SetMotionTimeoutCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetMotionTimeoutCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetMotionTimeoutCommand']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;I)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_I == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_I = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_I, new JValue (p0), new JValue (p1));
		}

	}
}
