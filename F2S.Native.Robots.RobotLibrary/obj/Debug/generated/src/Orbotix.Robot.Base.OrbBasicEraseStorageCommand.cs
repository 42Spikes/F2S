using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicEraseStorageCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/OrbBasicEraseStorageCommand", DoNotGenerateAcw=true)]
	public partial class OrbBasicEraseStorageCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicEraseStorageCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/OrbBasicEraseStorageCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrbBasicEraseStorageCommand); }
		}

		protected OrbBasicEraseStorageCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicEraseStorageCommand']/constructor[@name='OrbBasicEraseStorageCommand' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public OrbBasicEraseStorageCommand (bool p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicEraseStorageCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", new JValue (p0));
				return;
			}

			if (id_ctor_Z == IntPtr.Zero)
				id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicEraseStorageCommand']/constructor[@name='OrbBasicEraseStorageCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected OrbBasicEraseStorageCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicEraseStorageCommand)) {
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

		static Delegate cb_getStorageType;
#pragma warning disable 0169
		static Delegate GetGetStorageTypeHandler ()
		{
			if (cb_getStorageType == null)
				cb_getStorageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetStorageType);
			return cb_getStorageType;
		}

		static bool n_GetStorageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicEraseStorageCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicEraseStorageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StorageType;
		}
#pragma warning restore 0169

		static IntPtr id_getStorageType;
		public virtual bool StorageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicEraseStorageCommand']/method[@name='getStorageType' and count(parameter)=0]"
			[Register ("getStorageType", "()Z", "GetGetStorageTypeHandler")]
			get {
				if (id_getStorageType == IntPtr.Zero)
					id_getStorageType = JNIEnv.GetMethodID (class_ref, "getStorageType", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getStorageType);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStorageType", "()Z"));
			}
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicEraseStorageCommand']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='boolean']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;Z)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, bool p1)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_Z == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_Z = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_Z, new JValue (p0), new JValue (p1));
		}

	}
}
