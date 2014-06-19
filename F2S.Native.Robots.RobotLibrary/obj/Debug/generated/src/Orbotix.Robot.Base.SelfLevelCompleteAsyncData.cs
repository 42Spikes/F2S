using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SelfLevelCompleteAsyncData", DoNotGenerateAcw=true)]
	public partial class SelfLevelCompleteAsyncData : global::Orbotix.Robot.Base.DeviceAsyncData {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_ABORTED']"
		[Register ("RESULT_CODE_ABORTED")]
		public const int ResultCodeAborted = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_CHARGER_NOT_FOUND']"
		[Register ("RESULT_CODE_CHARGER_NOT_FOUND")]
		public const int ResultCodeChargerNotFound = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_SELF_LEVEL_DISABLED']"
		[Register ("RESULT_CODE_SELF_LEVEL_DISABLED")]
		public const int ResultCodeSelfLevelDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_SENSORS_ERROR']"
		[Register ("RESULT_CODE_SENSORS_ERROR")]
		public const int ResultCodeSensorsError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_SUCCESS']"
		[Register ("RESULT_CODE_SUCCESS")]
		public const int ResultCodeSuccess = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_TIMEOUT']"
		[Register ("RESULT_CODE_TIMEOUT")]
		public const int ResultCodeTimeout = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/field[@name='RESULT_CODE_UKNOWN']"
		[Register ("RESULT_CODE_UKNOWN")]
		public const int ResultCodeUknown = (int) 0;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/SelfLevelCompleteAsyncData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SelfLevelCompleteAsyncData); }
		}

		protected SelfLevelCompleteAsyncData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/constructor[@name='SelfLevelCompleteAsyncData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;[B)V", "")]
		public SelfLevelCompleteAsyncData (global::Orbotix.Robot.Base.Robot p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (SelfLevelCompleteAsyncData)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/constructor[@name='SelfLevelCompleteAsyncData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected SelfLevelCompleteAsyncData (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SelfLevelCompleteAsyncData)) {
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

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResultCode);
			return cb_getResultCode;
		}

		static int n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SelfLevelCompleteAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SelfLevelCompleteAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultCode;
		}
#pragma warning restore 0169

		static IntPtr id_getResultCode;
		public virtual int ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SelfLevelCompleteAsyncData']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()I", "GetGetResultCodeHandler")]
			get {
				if (id_getResultCode == IntPtr.Zero)
					id_getResultCode = JNIEnv.GetMethodID (class_ref, "getResultCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getResultCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultCode", "()I"));
			}
		}

	}
}
