using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SaveMacroCommand", DoNotGenerateAcw=true)]
	public partial class SaveMacroCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MACRO_STREAMING_DESTINATION']"
		[Register ("MACRO_STREAMING_DESTINATION")]
		public const sbyte MacroStreamingDestination = (sbyte) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagEndMarker']"
		[Register ("MacroFlagEndMarker")]
		public const sbyte MacroFlagEndMarker = (sbyte) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagExclusiveDrive']"
		[Register ("MacroFlagExclusiveDrive")]
		public const sbyte MacroFlagExclusiveDrive = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagExtendedFlags']"
		[Register ("MacroFlagExtendedFlags")]
		public const sbyte MacroFlagExtendedFlags = (sbyte) -128;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagInhibitIfConnected']"
		[Register ("MacroFlagInhibitIfConnected")]
		public const sbyte MacroFlagInhibitIfConnected = (sbyte) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagMotorControl']"
		[Register ("MacroFlagMotorControl")]
		public const sbyte MacroFlagMotorControl = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagNone']"
		[Register ("MacroFlagNone")]
		public const sbyte MacroFlagNone = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagStealth']"
		[Register ("MacroFlagStealth")]
		public const sbyte MacroFlagStealth = (sbyte) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagUnkillable']"
		[Register ("MacroFlagUnkillable")]
		public const sbyte MacroFlagUnkillable = (sbyte) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/field[@name='MacroFlagUseVersion3']"
		[Register ("MacroFlagUseVersion3")]
		public const sbyte MacroFlagUseVersion3 = (sbyte) 4;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/SaveMacroCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SaveMacroCommand); }
		}

		protected SaveMacroCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_BarrayBB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/constructor[@name='SaveMacroCommand' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte']]"
		[Register (".ctor", "(B[BB)V", "")]
		public SaveMacroCommand (sbyte p0, byte[] p1, sbyte p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (SaveMacroCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(B[BB)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(B[BB)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_BarrayBB == IntPtr.Zero)
				id_ctor_BarrayBB = JNIEnv.GetMethodID (class_ref, "<init>", "(B[BB)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BarrayBB, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_BarrayBB, new JValue (p0), new JValue (native_p1), new JValue (p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/constructor[@name='SaveMacroCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected SaveMacroCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SaveMacroCommand)) {
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

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetFlags);
			return cb_getFlags;
		}

		static sbyte n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SaveMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SaveMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		static IntPtr id_getFlags;
		public virtual sbyte Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()B", "GetGetFlagsHandler")]
			get {
				if (id_getFlags == IntPtr.Zero)
					id_getFlags = JNIEnv.GetMethodID (class_ref, "getFlags", "()B");

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getFlags);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlags", "()B"));
			}
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
			global::Orbotix.Robot.Base.SaveMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SaveMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/method[@name='getJSON' and count(parameter)=0]"
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

		static Delegate cb_getMacro;
#pragma warning disable 0169
		static Delegate GetGetMacroHandler ()
		{
			if (cb_getMacro == null)
				cb_getMacro = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMacro);
			return cb_getMacro;
		}

		static IntPtr n_GetMacro (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SaveMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SaveMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMacro ());
		}
#pragma warning restore 0169

		static IntPtr id_getMacro;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/method[@name='getMacro' and count(parameter)=0]"
		[Register ("getMacro", "()[B", "GetGetMacroHandler")]
		public virtual byte[] GetMacro ()
		{
			if (id_getMacro == IntPtr.Zero)
				id_getMacro = JNIEnv.GetMethodID (class_ref, "getMacro", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMacro), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMacro", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_BBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveMacroCommand']/method[@name='sendCommand' and count(parameter)=4 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;BB[B)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, sbyte p1, sbyte p2, byte[] p3)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_BBarrayB == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_BBarrayB = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;BB[B)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_BBarrayB, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}