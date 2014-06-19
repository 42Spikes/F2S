using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SelfLevelCommand", DoNotGenerateAcw=true)]
	public partial class SelfLevelCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/field[@name='OPTION_CONTROL_SYSTEM_ON']"
		[Register ("OPTION_CONTROL_SYSTEM_ON")]
		public const int OptionControlSystemOn = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/field[@name='OPTION_KEEP_HEADING']"
		[Register ("OPTION_KEEP_HEADING")]
		public const int OptionKeepHeading = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/field[@name='OPTION_SLEEP_AFTER']"
		[Register ("OPTION_SLEEP_AFTER")]
		public const int OptionSleepAfter = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/field[@name='OPTION_START']"
		[Register ("OPTION_START")]
		public const int OptionStart = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/SelfLevelCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SelfLevelCommand); }
		}

		protected SelfLevelCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/constructor[@name='SelfLevelCommand' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public SelfLevelCommand (int p0, int p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SelfLevelCommand)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/constructor[@name='SelfLevelCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected SelfLevelCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SelfLevelCommand)) {
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

		static Delegate cb_getAccuracy;
#pragma warning disable 0169
		static Delegate GetGetAccuracyHandler ()
		{
			if (cb_getAccuracy == null)
				cb_getAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAccuracy);
			return cb_getAccuracy;
		}

		static int n_GetAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SelfLevelCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SelfLevelCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Accuracy;
		}
#pragma warning restore 0169

		static IntPtr id_getAccuracy;
		public virtual int Accuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='getAccuracy' and count(parameter)=0]"
			[Register ("getAccuracy", "()I", "GetGetAccuracyHandler")]
			get {
				if (id_getAccuracy == IntPtr.Zero)
					id_getAccuracy = JNIEnv.GetMethodID (class_ref, "getAccuracy", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAccuracy);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccuracy", "()I"));
			}
		}

		static Delegate cb_getAngleLimit;
#pragma warning disable 0169
		static Delegate GetGetAngleLimitHandler ()
		{
			if (cb_getAngleLimit == null)
				cb_getAngleLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAngleLimit);
			return cb_getAngleLimit;
		}

		static int n_GetAngleLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SelfLevelCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SelfLevelCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AngleLimit;
		}
#pragma warning restore 0169

		static IntPtr id_getAngleLimit;
		public virtual int AngleLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='getAngleLimit' and count(parameter)=0]"
			[Register ("getAngleLimit", "()I", "GetGetAngleLimitHandler")]
			get {
				if (id_getAngleLimit == IntPtr.Zero)
					id_getAngleLimit = JNIEnv.GetMethodID (class_ref, "getAngleLimit", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAngleLimit);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAngleLimit", "()I"));
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOptions);
			return cb_getOptions;
		}

		static int n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SelfLevelCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SelfLevelCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Options;
		}
#pragma warning restore 0169

		static IntPtr id_getOptions;
		public virtual int Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()I", "GetGetOptionsHandler")]
			get {
				if (id_getOptions == IntPtr.Zero)
					id_getOptions = JNIEnv.GetMethodID (class_ref, "getOptions", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getOptions);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptions", "()I"));
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SelfLevelCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SelfLevelCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		public virtual int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTimeout);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()I"));
			}
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='sendCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='sendCommand' and count(parameter)=5 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;IIII)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, int p3, int p4)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_IIII == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_IIII = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;IIII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_sendCommandAbortSelfLevel_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCommand']/method[@name='sendCommandAbortSelfLevel' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("sendCommandAbortSelfLevel", "(Lorbotix/robot/base/Robot;)V", "")]
		public static void SendCommandAbortSelfLevel (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_sendCommandAbortSelfLevel_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_sendCommandAbortSelfLevel_Lorbotix_robot_base_Robot_ = JNIEnv.GetStaticMethodID (class_ref, "sendCommandAbortSelfLevel", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommandAbortSelfLevel_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

	}
}
