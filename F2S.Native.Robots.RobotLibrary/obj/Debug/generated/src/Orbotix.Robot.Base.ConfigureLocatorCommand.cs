using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/ConfigureLocatorCommand", DoNotGenerateAcw=true)]
	public partial class ConfigureLocatorCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/field[@name='ROTATE_WITH_CALIBRATE_FLAG_OFF']"
		[Register ("ROTATE_WITH_CALIBRATE_FLAG_OFF")]
		public const int RotateWithCalibrateFlagOff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/field[@name='ROTATE_WITH_CALIBRATE_FLAG_ON']"
		[Register ("ROTATE_WITH_CALIBRATE_FLAG_ON")]
		public const int RotateWithCalibrateFlagOn = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/ConfigureLocatorCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigureLocatorCommand); }
		}

		protected ConfigureLocatorCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/constructor[@name='ConfigureLocatorCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected ConfigureLocatorCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConfigureLocatorCommand)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/constructor[@name='ConfigureLocatorCommand' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public ConfigureLocatorCommand (int p0, int p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConfigureLocatorCommand)) {
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

		static Delegate cb_getFlag;
#pragma warning disable 0169
		static Delegate GetGetFlagHandler ()
		{
			if (cb_getFlag == null)
				cb_getFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFlag);
			return cb_getFlag;
		}

		static int n_GetFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureLocatorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureLocatorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flag;
		}
#pragma warning restore 0169

		static IntPtr id_getFlag;
		public virtual int Flag {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/method[@name='getFlag' and count(parameter)=0]"
			[Register ("getFlag", "()I", "GetGetFlagHandler")]
			get {
				if (id_getFlag == IntPtr.Zero)
					id_getFlag = JNIEnv.GetMethodID (class_ref, "getFlag", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFlag);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlag", "()I"));
			}
		}

		static Delegate cb_getNewPositionX;
#pragma warning disable 0169
		static Delegate GetGetNewPositionXHandler ()
		{
			if (cb_getNewPositionX == null)
				cb_getNewPositionX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNewPositionX);
			return cb_getNewPositionX;
		}

		static int n_GetNewPositionX (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureLocatorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureLocatorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewPositionX;
		}
#pragma warning restore 0169

		static IntPtr id_getNewPositionX;
		public virtual int NewPositionX {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/method[@name='getNewPositionX' and count(parameter)=0]"
			[Register ("getNewPositionX", "()I", "GetGetNewPositionXHandler")]
			get {
				if (id_getNewPositionX == IntPtr.Zero)
					id_getNewPositionX = JNIEnv.GetMethodID (class_ref, "getNewPositionX", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNewPositionX);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewPositionX", "()I"));
			}
		}

		static Delegate cb_getNewPositionY;
#pragma warning disable 0169
		static Delegate GetGetNewPositionYHandler ()
		{
			if (cb_getNewPositionY == null)
				cb_getNewPositionY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNewPositionY);
			return cb_getNewPositionY;
		}

		static int n_GetNewPositionY (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureLocatorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureLocatorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewPositionY;
		}
#pragma warning restore 0169

		static IntPtr id_getNewPositionY;
		public virtual int NewPositionY {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/method[@name='getNewPositionY' and count(parameter)=0]"
			[Register ("getNewPositionY", "()I", "GetGetNewPositionYHandler")]
			get {
				if (id_getNewPositionY == IntPtr.Zero)
					id_getNewPositionY = JNIEnv.GetMethodID (class_ref, "getNewPositionY", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNewPositionY);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewPositionY", "()I"));
			}
		}

		static Delegate cb_getNewYawTare;
#pragma warning disable 0169
		static Delegate GetGetNewYawTareHandler ()
		{
			if (cb_getNewYawTare == null)
				cb_getNewYawTare = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNewYawTare);
			return cb_getNewYawTare;
		}

		static int n_GetNewYawTare (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureLocatorCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureLocatorCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewYawTare;
		}
#pragma warning restore 0169

		static IntPtr id_getNewYawTare;
		public virtual int NewYawTare {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/method[@name='getNewYawTare' and count(parameter)=0]"
			[Register ("getNewYawTare", "()I", "GetGetNewYawTareHandler")]
			get {
				if (id_getNewYawTare == IntPtr.Zero)
					id_getNewYawTare = JNIEnv.GetMethodID (class_ref, "getNewYawTare", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNewYawTare);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewYawTare", "()I"));
			}
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureLocatorCommand']/method[@name='sendCommand' and count(parameter)=5 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;IIII)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, int p3, int p4)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_IIII == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_IIII = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;IIII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}
}
