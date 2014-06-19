using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/OrbBasicAppendFragmentCommand", DoNotGenerateAcw=true)]
	public partial class OrbBasicAppendFragmentCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/OrbBasicAppendFragmentCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrbBasicAppendFragmentCommand); }
		}

		protected OrbBasicAppendFragmentCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']/constructor[@name='OrbBasicAppendFragmentCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected OrbBasicAppendFragmentCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicAppendFragmentCommand)) {
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

		static IntPtr id_ctor_ZarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']/constructor[@name='OrbBasicAppendFragmentCommand' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Z[B)V", "")]
		public OrbBasicAppendFragmentCommand (bool p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (OrbBasicAppendFragmentCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_ZarrayB == IntPtr.Zero)
				id_ctor_ZarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Z[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZarrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZarrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Orbotix.Robot.Base.OrbBasicAppendFragmentCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicAppendFragmentCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StorageType;
		}
#pragma warning restore 0169

		static IntPtr id_getStorageType;
		public virtual bool StorageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']/method[@name='getStorageType' and count(parameter)=0]"
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

		static Delegate cb_getFragment;
#pragma warning disable 0169
		static Delegate GetGetFragmentHandler ()
		{
			if (cb_getFragment == null)
				cb_getFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFragment);
			return cb_getFragment;
		}

		static IntPtr n_GetFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicAppendFragmentCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicAppendFragmentCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFragment ());
		}
#pragma warning restore 0169

		static IntPtr id_getFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']/method[@name='getFragment' and count(parameter)=0]"
		[Register ("getFragment", "()[B", "GetGetFragmentHandler")]
		public virtual byte[] GetFragment ()
		{
			if (id_getFragment == IntPtr.Zero)
				id_getFragment = JNIEnv.GetMethodID (class_ref, "getFragment", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getFragment), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFragment", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_ZarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicAppendFragmentCommand']/method[@name='sendCommand' and count(parameter)=3 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='boolean'] and parameter[3][@type='byte[]']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;Z[B)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, bool p1, byte[] p2)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_ZarrayB == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_ZarrayB = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;Z[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_ZarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
