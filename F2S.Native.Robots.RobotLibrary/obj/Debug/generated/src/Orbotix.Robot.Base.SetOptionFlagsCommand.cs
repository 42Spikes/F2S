using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SetOptionFlagsCommand", DoNotGenerateAcw=true)]
	public partial class SetOptionFlagsCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/SetOptionFlagsCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SetOptionFlagsCommand); }
		}

		protected SetOptionFlagsCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_util_BitMask_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/constructor[@name='SetOptionFlagsCommand' and count(parameter)=1 and parameter[1][@type='orbotix.util.BitMask']]"
		[Register (".ctor", "(Lorbotix/util/BitMask;)V", "")]
		public SetOptionFlagsCommand (global::Orbotix.Util.BitMask p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SetOptionFlagsCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/util/BitMask;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/util/BitMask;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_util_BitMask_ == IntPtr.Zero)
				id_ctor_Lorbotix_util_BitMask_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/util/BitMask;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_util_BitMask_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_util_BitMask_, new JValue (p0));
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/constructor[@name='SetOptionFlagsCommand' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public SetOptionFlagsCommand (long p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SetOptionFlagsCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", new JValue (p0));
				return;
			}

			if (id_ctor_J == IntPtr.Zero)
				id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, new JValue (p0));
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
			global::Orbotix.Robot.Base.SetOptionFlagsCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetOptionFlagsCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/method[@name='getJSON' and count(parameter)=0]"
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

		static Delegate cb_getOptionFlags;
#pragma warning disable 0169
		static Delegate GetGetOptionFlagsHandler ()
		{
			if (cb_getOptionFlags == null)
				cb_getOptionFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOptionFlags);
			return cb_getOptionFlags;
		}

		static long n_GetOptionFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SetOptionFlagsCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetOptionFlagsCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptionFlags;
		}
#pragma warning restore 0169

		static IntPtr id_getOptionFlags;
		public virtual long OptionFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/method[@name='getOptionFlags' and count(parameter)=0]"
			[Register ("getOptionFlags", "()J", "GetGetOptionFlagsHandler")]
			get {
				if (id_getOptionFlags == IntPtr.Zero)
					id_getOptionFlags = JNIEnv.GetMethodID (class_ref, "getOptionFlags", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getOptionFlags);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptionFlags", "()J"));
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/SetOptionFlagsCommand;", "")]
		public static global::Orbotix.Robot.Base.SetOptionFlagsCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/SetOptionFlagsCommand;");
			global::Orbotix.Robot.Base.SetOptionFlagsCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetOptionFlagsCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='long']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;J)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, long p1)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_J == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_J = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_J, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendDefaultOptionFlagsCommand_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetOptionFlagsCommand']/method[@name='sendDefaultOptionFlagsCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("sendDefaultOptionFlagsCommand", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void SendDefaultOptionFlagsCommand (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_sendDefaultOptionFlagsCommand_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_sendDefaultOptionFlagsCommand_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "sendDefaultOptionFlagsCommand", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendDefaultOptionFlagsCommand_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

	}
}
