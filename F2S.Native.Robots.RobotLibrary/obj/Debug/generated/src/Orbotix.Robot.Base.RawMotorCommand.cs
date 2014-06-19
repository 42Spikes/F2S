using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/RawMotorCommand", DoNotGenerateAcw=true)]
	public partial class RawMotorCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/field[@name='MOTOR_MODE_BRAKE']"
		[Register ("MOTOR_MODE_BRAKE")]
		public const int MotorModeBrake = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/field[@name='MOTOR_MODE_FORWARD']"
		[Register ("MOTOR_MODE_FORWARD")]
		public const int MotorModeForward = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/field[@name='MOTOR_MODE_IGNORE']"
		[Register ("MOTOR_MODE_IGNORE")]
		public const int MotorModeIgnore = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/field[@name='MOTOR_MODE_OFF']"
		[Register ("MOTOR_MODE_OFF")]
		public const int MotorModeOff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/field[@name='MOTOR_MODE_REVERSE']"
		[Register ("MOTOR_MODE_REVERSE")]
		public const int MotorModeReverse = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/RawMotorCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RawMotorCommand); }
		}

		protected RawMotorCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/constructor[@name='RawMotorCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected RawMotorCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RawMotorCommand)) {
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

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/constructor[@name='RawMotorCommand' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public RawMotorCommand (int p0, int p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RawMotorCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIII)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_IIII == IntPtr.Zero)
				id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
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
			global::Orbotix.Robot.Base.RawMotorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RawMotorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='getJSON' and count(parameter)=0]"
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

		static Delegate cb_getLeftMode;
#pragma warning disable 0169
		static Delegate GetGetLeftModeHandler ()
		{
			if (cb_getLeftMode == null)
				cb_getLeftMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeftMode);
			return cb_getLeftMode;
		}

		static int n_GetLeftMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RawMotorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RawMotorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftMode;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftMode;
		public virtual int LeftMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='getLeftMode' and count(parameter)=0]"
			[Register ("getLeftMode", "()I", "GetGetLeftModeHandler")]
			get {
				if (id_getLeftMode == IntPtr.Zero)
					id_getLeftMode = JNIEnv.GetMethodID (class_ref, "getLeftMode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLeftMode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftMode", "()I"));
			}
		}

		static Delegate cb_getLeftSpeed;
#pragma warning disable 0169
		static Delegate GetGetLeftSpeedHandler ()
		{
			if (cb_getLeftSpeed == null)
				cb_getLeftSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeftSpeed);
			return cb_getLeftSpeed;
		}

		static int n_GetLeftSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RawMotorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RawMotorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftSpeed;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftSpeed;
		public virtual int LeftSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='getLeftSpeed' and count(parameter)=0]"
			[Register ("getLeftSpeed", "()I", "GetGetLeftSpeedHandler")]
			get {
				if (id_getLeftSpeed == IntPtr.Zero)
					id_getLeftSpeed = JNIEnv.GetMethodID (class_ref, "getLeftSpeed", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLeftSpeed);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftSpeed", "()I"));
			}
		}

		static Delegate cb_getRightMode;
#pragma warning disable 0169
		static Delegate GetGetRightModeHandler ()
		{
			if (cb_getRightMode == null)
				cb_getRightMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRightMode);
			return cb_getRightMode;
		}

		static int n_GetRightMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RawMotorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RawMotorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightMode;
		}
#pragma warning restore 0169

		static IntPtr id_getRightMode;
		public virtual int RightMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='getRightMode' and count(parameter)=0]"
			[Register ("getRightMode", "()I", "GetGetRightModeHandler")]
			get {
				if (id_getRightMode == IntPtr.Zero)
					id_getRightMode = JNIEnv.GetMethodID (class_ref, "getRightMode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRightMode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightMode", "()I"));
			}
		}

		static Delegate cb_getRightSpeed;
#pragma warning disable 0169
		static Delegate GetGetRightSpeedHandler ()
		{
			if (cb_getRightSpeed == null)
				cb_getRightSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRightSpeed);
			return cb_getRightSpeed;
		}

		static int n_GetRightSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RawMotorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RawMotorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightSpeed;
		}
#pragma warning restore 0169

		static IntPtr id_getRightSpeed;
		public virtual int RightSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='getRightSpeed' and count(parameter)=0]"
			[Register ("getRightSpeed", "()I", "GetGetRightSpeedHandler")]
			get {
				if (id_getRightSpeed == IntPtr.Zero)
					id_getRightSpeed = JNIEnv.GetMethodID (class_ref, "getRightSpeed", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRightSpeed);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightSpeed", "()I"));
			}
		}

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RawMotorCommand;", "")]
		public static global::Orbotix.Robot.Base.RawMotorCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/base/RawMotorCommand;");
			global::Orbotix.Robot.Base.RawMotorCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RawMotorCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RawMotorCommand']/method[@name='sendCommand' and count(parameter)=5 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;IIII)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, int p3, int p4)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_IIII == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_IIII = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;IIII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}
}
