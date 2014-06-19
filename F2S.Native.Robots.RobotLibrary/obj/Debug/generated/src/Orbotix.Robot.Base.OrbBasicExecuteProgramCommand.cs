using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/OrbBasicExecuteProgramCommand", DoNotGenerateAcw=true)]
	public partial class OrbBasicExecuteProgramCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/OrbBasicExecuteProgramCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrbBasicExecuteProgramCommand); }
		}

		protected OrbBasicExecuteProgramCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']/constructor[@name='OrbBasicExecuteProgramCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected OrbBasicExecuteProgramCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicExecuteProgramCommand)) {
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

		static IntPtr id_ctor_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']/constructor[@name='OrbBasicExecuteProgramCommand' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register (".ctor", "(ZI)V", "")]
		public OrbBasicExecuteProgramCommand (bool p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicExecuteProgramCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZI)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZI)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ZI == IntPtr.Zero)
				id_ctor_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(ZI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZI, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZI, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getStartingLine;
#pragma warning disable 0169
		static Delegate GetGetStartingLineHandler ()
		{
			if (cb_getStartingLine == null)
				cb_getStartingLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStartingLine);
			return cb_getStartingLine;
		}

		static int n_GetStartingLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicExecuteProgramCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicExecuteProgramCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartingLine;
		}
#pragma warning restore 0169

		static IntPtr id_getStartingLine;
		public virtual int StartingLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']/method[@name='getStartingLine' and count(parameter)=0]"
			[Register ("getStartingLine", "()I", "GetGetStartingLineHandler")]
			get {
				if (id_getStartingLine == IntPtr.Zero)
					id_getStartingLine = JNIEnv.GetMethodID (class_ref, "getStartingLine", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getStartingLine);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartingLine", "()I"));
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
			global::Orbotix.Robot.Base.OrbBasicExecuteProgramCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicExecuteProgramCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StorageType;
		}
#pragma warning restore 0169

		static IntPtr id_getStorageType;
		public virtual bool StorageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']/method[@name='getStorageType' and count(parameter)=0]"
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

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicExecuteProgramCommand']/method[@name='sendCommand' and count(parameter)=3 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;ZI)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, bool p1, int p2)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_ZI == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_ZI = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;ZI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_ZI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
