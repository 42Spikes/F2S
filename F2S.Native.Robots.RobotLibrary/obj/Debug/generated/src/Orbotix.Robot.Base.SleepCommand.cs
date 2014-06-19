using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SleepCommand", DoNotGenerateAcw=true)]
	public partial class SleepCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/SleepCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SleepCommand); }
		}

		protected SleepCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/constructor[@name='SleepCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected SleepCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SleepCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/constructor[@name='SleepCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public SleepCommand (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SleepCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, new JValue (p0), new JValue (p1));
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
			global::Orbotix.Robot.Base.SleepCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SleepCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/method[@name='getJSON' and count(parameter)=0]"
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

		static Delegate cb_getWakeUpMacroId;
#pragma warning disable 0169
		static Delegate GetGetWakeUpMacroIdHandler ()
		{
			if (cb_getWakeUpMacroId == null)
				cb_getWakeUpMacroId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWakeUpMacroId);
			return cb_getWakeUpMacroId;
		}

		static int n_GetWakeUpMacroId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SleepCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SleepCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WakeUpMacroId;
		}
#pragma warning restore 0169

		static IntPtr id_getWakeUpMacroId;
		public virtual int WakeUpMacroId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/method[@name='getWakeUpMacroId' and count(parameter)=0]"
			[Register ("getWakeUpMacroId", "()I", "GetGetWakeUpMacroIdHandler")]
			get {
				if (id_getWakeUpMacroId == IntPtr.Zero)
					id_getWakeUpMacroId = JNIEnv.GetMethodID (class_ref, "getWakeUpMacroId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWakeUpMacroId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWakeUpMacroId", "()I"));
			}
		}

		static Delegate cb_getWakeUpTime;
#pragma warning disable 0169
		static Delegate GetGetWakeUpTimeHandler ()
		{
			if (cb_getWakeUpTime == null)
				cb_getWakeUpTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWakeUpTime);
			return cb_getWakeUpTime;
		}

		static int n_GetWakeUpTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SleepCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SleepCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WakeUpTime;
		}
#pragma warning restore 0169

		static IntPtr id_getWakeUpTime;
		public virtual int WakeUpTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/method[@name='getWakeUpTime' and count(parameter)=0]"
			[Register ("getWakeUpTime", "()I", "GetGetWakeUpTimeHandler")]
			get {
				if (id_getWakeUpTime == IntPtr.Zero)
					id_getWakeUpTime = JNIEnv.GetMethodID (class_ref, "getWakeUpTime", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWakeUpTime);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWakeUpTime", "()I"));
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/SleepCommand;", "")]
		public static global::Orbotix.Robot.Base.SleepCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/SleepCommand;");
			global::Orbotix.Robot.Base.SleepCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SleepCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SleepCommand']/method[@name='sendCommand' and count(parameter)=3 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;II)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_II == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_II = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;II)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
