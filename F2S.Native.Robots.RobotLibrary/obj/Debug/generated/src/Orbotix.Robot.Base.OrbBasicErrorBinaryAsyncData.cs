using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicErrorBinaryAsyncData']"
	[global::Android.Runtime.Register ("orbotix/robot/base/OrbBasicErrorBinaryAsyncData", DoNotGenerateAcw=true)]
	public partial class OrbBasicErrorBinaryAsyncData : global::Orbotix.Robot.Base.DeviceAsyncData {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicErrorBinaryAsyncData']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/OrbBasicErrorBinaryAsyncData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrbBasicErrorBinaryAsyncData); }
		}

		protected OrbBasicErrorBinaryAsyncData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicErrorBinaryAsyncData']/constructor[@name='OrbBasicErrorBinaryAsyncData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;[B)V", "")]
		public OrbBasicErrorBinaryAsyncData (global::Orbotix.Robot.Base.Robot p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (OrbBasicErrorBinaryAsyncData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicErrorBinaryAsyncData']/constructor[@name='OrbBasicErrorBinaryAsyncData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected OrbBasicErrorBinaryAsyncData (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicErrorBinaryAsyncData)) {
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

		static Delegate cb_getErrorBinary;
#pragma warning disable 0169
		static Delegate GetGetErrorBinaryHandler ()
		{
			if (cb_getErrorBinary == null)
				cb_getErrorBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorBinary);
			return cb_getErrorBinary;
		}

		static IntPtr n_GetErrorBinary (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicErrorBinaryAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicErrorBinaryAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetErrorBinary ());
		}
#pragma warning restore 0169

		static IntPtr id_getErrorBinary;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicErrorBinaryAsyncData']/method[@name='getErrorBinary' and count(parameter)=0]"
		[Register ("getErrorBinary", "()[B", "GetGetErrorBinaryHandler")]
		public virtual byte[] GetErrorBinary ()
		{
			if (id_getErrorBinary == IntPtr.Zero)
				id_getErrorBinary = JNIEnv.GetMethodID (class_ref, "getErrorBinary", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getErrorBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorBinary", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}
}
