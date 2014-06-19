using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/RGBLEDOutputCommand", DoNotGenerateAcw=true)]
	public sealed partial class RGBLEDOutputCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/RGBLEDOutputCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RGBLEDOutputCommand); }
		}

		internal RGBLEDOutputCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/constructor[@name='RGBLEDOutputCommand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public RGBLEDOutputCommand (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (RGBLEDOutputCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_IIIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/constructor[@name='RGBLEDOutputCommand' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(IIIZ)V", "")]
		public RGBLEDOutputCommand (int p0, int p1, int p2, bool p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RGBLEDOutputCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIZ)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIZ)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_IIIZ == IntPtr.Zero)
				id_ctor_IIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/constructor[@name='RGBLEDOutputCommand' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public RGBLEDOutputCommand (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RGBLEDOutputCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_III == IntPtr.Zero)
				id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_III, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getBlue;
		public int Blue {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getBlue' and count(parameter)=0]"
			[Register ("getBlue", "()I", "GetGetBlueHandler")]
			get {
				if (id_getBlue == IntPtr.Zero)
					id_getBlue = JNIEnv.GetMethodID (class_ref, "getBlue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getBlue);
			}
		}

		static IntPtr id_getCurrentBlue;
		public static int CurrentBlue {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getCurrentBlue' and count(parameter)=0]"
			[Register ("getCurrentBlue", "()I", "GetGetCurrentBlueHandler")]
			get {
				if (id_getCurrentBlue == IntPtr.Zero)
					id_getCurrentBlue = JNIEnv.GetStaticMethodID (class_ref, "getCurrentBlue", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getCurrentBlue);
			}
		}

		static IntPtr id_getCurrentGreen;
		public static int CurrentGreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getCurrentGreen' and count(parameter)=0]"
			[Register ("getCurrentGreen", "()I", "GetGetCurrentGreenHandler")]
			get {
				if (id_getCurrentGreen == IntPtr.Zero)
					id_getCurrentGreen = JNIEnv.GetStaticMethodID (class_ref, "getCurrentGreen", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getCurrentGreen);
			}
		}

		static IntPtr id_getCurrentRed;
		public static int CurrentRed {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getCurrentRed' and count(parameter)=0]"
			[Register ("getCurrentRed", "()I", "GetGetCurrentRedHandler")]
			get {
				if (id_getCurrentRed == IntPtr.Zero)
					id_getCurrentRed = JNIEnv.GetStaticMethodID (class_ref, "getCurrentRed", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getCurrentRed);
			}
		}

		static IntPtr id_getGreen;
		public int Green {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getGreen' and count(parameter)=0]"
			[Register ("getGreen", "()I", "GetGetGreenHandler")]
			get {
				if (id_getGreen == IntPtr.Zero)
					id_getGreen = JNIEnv.GetMethodID (class_ref, "getGreen", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getGreen);
			}
		}

		static IntPtr id_isCurrentColorUserDefault;
		public static bool IsCurrentColorUserDefault {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='isCurrentColorUserDefault' and count(parameter)=0]"
			[Register ("isCurrentColorUserDefault", "()Z", "GetIsCurrentColorUserDefaultHandler")]
			get {
				if (id_isCurrentColorUserDefault == IntPtr.Zero)
					id_isCurrentColorUserDefault = JNIEnv.GetStaticMethodID (class_ref, "isCurrentColorUserDefault", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCurrentColorUserDefault);
			}
		}

		static IntPtr id_isUserDefault;
		public bool IsUserDefault {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='isUserDefault' and count(parameter)=0]"
			[Register ("isUserDefault", "()Z", "GetIsUserDefaultHandler")]
			get {
				if (id_isUserDefault == IntPtr.Zero)
					id_isUserDefault = JNIEnv.GetMethodID (class_ref, "isUserDefault", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isUserDefault);
			}
		}

		static IntPtr id_getJSON;
		public global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler")]
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRed;
		public int Red {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='getRed' and count(parameter)=0]"
			[Register ("getRed", "()I", "GetGetRedHandler")]
			get {
				if (id_getRed == IntPtr.Zero)
					id_getRed = JNIEnv.GetMethodID (class_ref, "getRed", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getRed);
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RGBLEDOutputCommand;", "")]
		public static global::Orbotix.Robot.Base.RGBLEDOutputCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RGBLEDOutputCommand;");
			global::Orbotix.Robot.Base.RGBLEDOutputCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RGBLEDOutputCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='sendCommand' and count(parameter)=4 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;III)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, int p3)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_III == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_III = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;III)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_IIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='sendCommand' and count(parameter)=5 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;IIIZ)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, int p3, bool p4)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_IIIZ == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_IIIZ = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;IIIZ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_IIIZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_setCurrentBlue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='setCurrentBlue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentBlue", "(I)V", "")]
		protected static void SetCurrentBlue (int p0)
		{
			if (id_setCurrentBlue_I == IntPtr.Zero)
				id_setCurrentBlue_I = JNIEnv.GetStaticMethodID (class_ref, "setCurrentBlue", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentBlue_I, new JValue (p0));
		}

		static IntPtr id_setCurrentGreen_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='setCurrentGreen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentGreen", "(I)V", "")]
		protected static void SetCurrentGreen (int p0)
		{
			if (id_setCurrentGreen_I == IntPtr.Zero)
				id_setCurrentGreen_I = JNIEnv.GetStaticMethodID (class_ref, "setCurrentGreen", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentGreen_I, new JValue (p0));
		}

		static IntPtr id_setCurrentRed_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='setCurrentRed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentRed", "(I)V", "")]
		protected static void SetCurrentRed (int p0)
		{
			if (id_setCurrentRed_I == IntPtr.Zero)
				id_setCurrentRed_I = JNIEnv.GetStaticMethodID (class_ref, "setCurrentRed", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentRed_I, new JValue (p0));
		}

		static IntPtr id_setIsCurrentColorUserDefault_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RGBLEDOutputCommand']/method[@name='setIsCurrentColorUserDefault' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsCurrentColorUserDefault", "(Z)V", "")]
		protected static void SetIsCurrentColorUserDefault (bool p0)
		{
			if (id_setIsCurrentColorUserDefault_Z == IntPtr.Zero)
				id_setIsCurrentColorUserDefault_Z = JNIEnv.GetStaticMethodID (class_ref, "setIsCurrentColorUserDefault", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setIsCurrentColorUserDefault_Z, new JValue (p0));
		}

	}
}
