using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/base/GetUserRGBColorResponse", DoNotGenerateAcw=true)]
	public partial class GetUserRGBColorResponse : global::Orbotix.Robot.Internal.DeviceResponse {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/GetUserRGBColorResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetUserRGBColorResponse); }
		}

		protected GetUserRGBColorResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']/constructor[@name='GetUserRGBColorResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected GetUserRGBColorResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetUserRGBColorResponse)) {
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

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']/constructor[@name='GetUserRGBColorResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public GetUserRGBColorResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (GetUserRGBColorResponse)) {
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

		static Delegate cb_getBlueIntensity;
#pragma warning disable 0169
		static Delegate GetGetBlueIntensityHandler ()
		{
			if (cb_getBlueIntensity == null)
				cb_getBlueIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetBlueIntensity);
			return cb_getBlueIntensity;
		}

		static short n_GetBlueIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetUserRGBColorResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetUserRGBColorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlueIntensity;
		}
#pragma warning restore 0169

		static IntPtr id_getBlueIntensity;
		public virtual short BlueIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']/method[@name='getBlueIntensity' and count(parameter)=0]"
			[Register ("getBlueIntensity", "()S", "GetGetBlueIntensityHandler")]
			get {
				if (id_getBlueIntensity == IntPtr.Zero)
					id_getBlueIntensity = JNIEnv.GetMethodID (class_ref, "getBlueIntensity", "()S");

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_getBlueIntensity);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlueIntensity", "()S"));
			}
		}

		static Delegate cb_getGreenIntensity;
#pragma warning disable 0169
		static Delegate GetGetGreenIntensityHandler ()
		{
			if (cb_getGreenIntensity == null)
				cb_getGreenIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetGreenIntensity);
			return cb_getGreenIntensity;
		}

		static short n_GetGreenIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetUserRGBColorResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetUserRGBColorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GreenIntensity;
		}
#pragma warning restore 0169

		static IntPtr id_getGreenIntensity;
		public virtual short GreenIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']/method[@name='getGreenIntensity' and count(parameter)=0]"
			[Register ("getGreenIntensity", "()S", "GetGetGreenIntensityHandler")]
			get {
				if (id_getGreenIntensity == IntPtr.Zero)
					id_getGreenIntensity = JNIEnv.GetMethodID (class_ref, "getGreenIntensity", "()S");

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_getGreenIntensity);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGreenIntensity", "()S"));
			}
		}

		static Delegate cb_getRedIntensity;
#pragma warning disable 0169
		static Delegate GetGetRedIntensityHandler ()
		{
			if (cb_getRedIntensity == null)
				cb_getRedIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetRedIntensity);
			return cb_getRedIntensity;
		}

		static short n_GetRedIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetUserRGBColorResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetUserRGBColorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RedIntensity;
		}
#pragma warning restore 0169

		static IntPtr id_getRedIntensity;
		public virtual short RedIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetUserRGBColorResponse']/method[@name='getRedIntensity' and count(parameter)=0]"
			[Register ("getRedIntensity", "()S", "GetGetRedIntensityHandler")]
			get {
				if (id_getRedIntensity == IntPtr.Zero)
					id_getRedIntensity = JNIEnv.GetMethodID (class_ref, "getRedIntensity", "()S");

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_getRedIntensity);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedIntensity", "()S"));
			}
		}

	}
}
