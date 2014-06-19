using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/RollCommand", DoNotGenerateAcw=true)]
	public sealed partial class RollCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/RollCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RollCommand); }
		}

		internal RollCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/constructor[@name='RollCommand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public RollCommand (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (RollCommand)) {
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

		static IntPtr id_ctor_FFZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/constructor[@name='RollCommand' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(FFZ)V", "")]
		public RollCommand (float p0, float p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RollCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFZ)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFZ)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_FFZ == IntPtr.Zero)
				id_ctor_FFZ = JNIEnv.GetMethodID (class_ref, "<init>", "(FFZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFZ, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getBoostReturnVelocity;
		static IntPtr id_setBoostReturnVelocity_F;
		public static float BoostReturnVelocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getBoostReturnVelocity' and count(parameter)=0]"
			[Register ("getBoostReturnVelocity", "()F", "GetGetBoostReturnVelocityHandler")]
			get {
				if (id_getBoostReturnVelocity == IntPtr.Zero)
					id_getBoostReturnVelocity = JNIEnv.GetStaticMethodID (class_ref, "getBoostReturnVelocity", "()F");
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_getBoostReturnVelocity);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='setBoostReturnVelocity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBoostReturnVelocity", "(F)V", "GetSetBoostReturnVelocity_FHandler")]
			set {
				if (id_setBoostReturnVelocity_F == IntPtr.Zero)
					id_setBoostReturnVelocity_F = JNIEnv.GetStaticMethodID (class_ref, "setBoostReturnVelocity", "(F)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBoostReturnVelocity_F, new JValue (value));
			}
		}

		static IntPtr id_getCurrentHeading;
		static IntPtr id_setCurrentHeading_F;
		public static float CurrentHeading {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getCurrentHeading' and count(parameter)=0]"
			[Register ("getCurrentHeading", "()F", "GetGetCurrentHeadingHandler")]
			get {
				if (id_getCurrentHeading == IntPtr.Zero)
					id_getCurrentHeading = JNIEnv.GetStaticMethodID (class_ref, "getCurrentHeading", "()F");
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_getCurrentHeading);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='setCurrentHeading' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCurrentHeading", "(F)V", "GetSetCurrentHeading_FHandler")]
			set {
				if (id_setCurrentHeading_F == IntPtr.Zero)
					id_setCurrentHeading_F = JNIEnv.GetStaticMethodID (class_ref, "setCurrentHeading", "(F)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentHeading_F, new JValue (value));
			}
		}

		static IntPtr id_getCurrentVelocity;
		static IntPtr id_setCurrentVelocity_F;
		public static float CurrentVelocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getCurrentVelocity' and count(parameter)=0]"
			[Register ("getCurrentVelocity", "()F", "GetGetCurrentVelocityHandler")]
			get {
				if (id_getCurrentVelocity == IntPtr.Zero)
					id_getCurrentVelocity = JNIEnv.GetStaticMethodID (class_ref, "getCurrentVelocity", "()F");
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_getCurrentVelocity);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='setCurrentVelocity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCurrentVelocity", "(F)V", "GetSetCurrentVelocity_FHandler")]
			set {
				if (id_setCurrentVelocity_F == IntPtr.Zero)
					id_setCurrentVelocity_F = JNIEnv.GetStaticMethodID (class_ref, "setCurrentVelocity", "(F)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentVelocity_F, new JValue (value));
			}
		}

		static IntPtr id_getHeading;
		public float Heading {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getHeading' and count(parameter)=0]"
			[Register ("getHeading", "()F", "GetGetHeadingHandler")]
			get {
				if (id_getHeading == IntPtr.Zero)
					id_getHeading = JNIEnv.GetMethodID (class_ref, "getHeading", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getHeading);
			}
		}

		static IntPtr id_isVelocitySticky;
		public static bool IsVelocitySticky {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='isVelocitySticky' and count(parameter)=0]"
			[Register ("isVelocitySticky", "()Z", "GetIsVelocityStickyHandler")]
			get {
				if (id_isVelocitySticky == IntPtr.Zero)
					id_isVelocitySticky = JNIEnv.GetStaticMethodID (class_ref, "isVelocitySticky", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isVelocitySticky);
			}
		}

		static IntPtr id_getJSON;
		public global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler")]
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStickyVelocity;
		public static float StickyVelocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getStickyVelocity' and count(parameter)=0]"
			[Register ("getStickyVelocity", "()F", "GetGetStickyVelocityHandler")]
			get {
				if (id_getStickyVelocity == IntPtr.Zero)
					id_getStickyVelocity = JNIEnv.GetStaticMethodID (class_ref, "getStickyVelocity", "()F");
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_getStickyVelocity);
			}
		}

		static IntPtr id_getVelocity;
		public float Velocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='getVelocity' and count(parameter)=0]"
			[Register ("getVelocity", "()F", "GetGetVelocityHandler")]
			get {
				if (id_getVelocity == IntPtr.Zero)
					id_getVelocity = JNIEnv.GetMethodID (class_ref, "getVelocity", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getVelocity);
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RollCommand;", "")]
		public static global::Orbotix.Robot.Base.RollCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RollCommand;");
			global::Orbotix.Robot.Base.RollCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RollCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_resendCurrent_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='resendCurrent' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("resendCurrent", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void ResendCurrent (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_resendCurrent_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_resendCurrent_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "resendCurrent", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_resendCurrent_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static IntPtr id_sendBoostReturnCommand_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='sendBoostReturnCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("sendBoostReturnCommand", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void SendBoostReturnCommand (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_sendBoostReturnCommand_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_sendBoostReturnCommand_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "sendBoostReturnCommand", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendBoostReturnCommand_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='sendCommand' and count(parameter)=3 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;FF)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, float p1, float p2)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_FF == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_FF = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;FF)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_FF, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_FFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='sendCommand' and count(parameter)=4 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;FFZ)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, float p1, float p2, bool p3)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_FFZ == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_FFZ = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;FFZ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_FFZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_sendStop_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='sendStop' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("sendStop", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void SendStop (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_sendStop_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_sendStop_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "sendStop", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendStop_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static IntPtr id_setStickyVelocity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='setStickyVelocity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setStickyVelocity", "(F)V", "")]
		protected static void SetStickyVelocity (float p0)
		{
			if (id_setStickyVelocity_F == IntPtr.Zero)
				id_setStickyVelocity_F = JNIEnv.GetStaticMethodID (class_ref, "setStickyVelocity", "(F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setStickyVelocity_F, new JValue (p0));
		}

		static IntPtr id_setVelocitySticky_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='setVelocitySticky' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setVelocitySticky", "(Z)V", "")]
		protected static void SetVelocitySticky (bool p0)
		{
			if (id_setVelocitySticky_Z == IntPtr.Zero)
				id_setVelocitySticky_Z = JNIEnv.GetStaticMethodID (class_ref, "setVelocitySticky", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setVelocitySticky_Z, new JValue (p0));
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RollCommand']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()Z", "")]
		public bool Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_stop);
		}

	}
}
