using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/base/GetDeviceModeResponse", DoNotGenerateAcw=true)]
	public partial class GetDeviceModeResponse : global::Orbotix.Robot.Internal.DeviceResponse {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']/field[@name='DeviceModeNormal']"
		[Register ("DeviceModeNormal")]
		public const int DeviceModeNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']/field[@name='DeviceModeUserHack']"
		[Register ("DeviceModeUserHack")]
		public const int DeviceModeUserHack = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/GetDeviceModeResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetDeviceModeResponse); }
		}

		protected GetDeviceModeResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']/constructor[@name='GetDeviceModeResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public GetDeviceModeResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (GetDeviceModeResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/internal/DeviceCommand;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/internal/DeviceCommand;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/internal/DeviceCommand;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']/constructor[@name='GetDeviceModeResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected GetDeviceModeResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetDeviceModeResponse)) {
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

		static Delegate cb_getDeviceMode;
#pragma warning disable 0169
		static Delegate GetGetDeviceModeHandler ()
		{
			if (cb_getDeviceMode == null)
				cb_getDeviceMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDeviceMode);
			return cb_getDeviceMode;
		}

		static int n_GetDeviceMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetDeviceModeResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetDeviceModeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceMode;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceMode;
		public virtual int DeviceMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetDeviceModeResponse']/method[@name='getDeviceMode' and count(parameter)=0]"
			[Register ("getDeviceMode", "()I", "GetGetDeviceModeHandler")]
			get {
				if (id_getDeviceMode == IntPtr.Zero)
					id_getDeviceMode = JNIEnv.GetMethodID (class_ref, "getDeviceMode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDeviceMode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceMode", "()I"));
			}
		}

	}
}
