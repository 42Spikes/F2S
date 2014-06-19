using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']"
	[global::Android.Runtime.Register ("orbotix/robot/base/MacroEmitMarker", DoNotGenerateAcw=true)]
	public partial class MacroEmitMarker : global::Orbotix.Robot.Base.DeviceAsyncData {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("orbotix/robot/base/MacroEmitMarker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MacroEmitMarker); }
		}

		protected MacroEmitMarker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']/constructor[@name='MacroEmitMarker' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected MacroEmitMarker (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MacroEmitMarker)) {
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

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']/constructor[@name='MacroEmitMarker' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;[B)V", "")]
		public MacroEmitMarker (global::Orbotix.Robot.Base.Robot p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (MacroEmitMarker)) {
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

		static Delegate cb_getMacroId;
#pragma warning disable 0169
		static Delegate GetGetMacroIdHandler ()
		{
			if (cb_getMacroId == null)
				cb_getMacroId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMacroId);
			return cb_getMacroId;
		}

		static int n_GetMacroId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.MacroEmitMarker __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.MacroEmitMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MacroId;
		}
#pragma warning restore 0169

		static IntPtr id_getMacroId;
		public virtual int MacroId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']/method[@name='getMacroId' and count(parameter)=0]"
			[Register ("getMacroId", "()I", "GetGetMacroIdHandler")]
			get {
				if (id_getMacroId == IntPtr.Zero)
					id_getMacroId = JNIEnv.GetMethodID (class_ref, "getMacroId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMacroId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMacroId", "()I"));
			}
		}

		static Delegate cb_getMacroLineNumber;
#pragma warning disable 0169
		static Delegate GetGetMacroLineNumberHandler ()
		{
			if (cb_getMacroLineNumber == null)
				cb_getMacroLineNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMacroLineNumber);
			return cb_getMacroLineNumber;
		}

		static int n_GetMacroLineNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.MacroEmitMarker __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.MacroEmitMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MacroLineNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getMacroLineNumber;
		public virtual int MacroLineNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']/method[@name='getMacroLineNumber' and count(parameter)=0]"
			[Register ("getMacroLineNumber", "()I", "GetGetMacroLineNumberHandler")]
			get {
				if (id_getMacroLineNumber == IntPtr.Zero)
					id_getMacroLineNumber = JNIEnv.GetMethodID (class_ref, "getMacroLineNumber", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMacroLineNumber);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMacroLineNumber", "()I"));
			}
		}

		static Delegate cb_getMarkerId;
#pragma warning disable 0169
		static Delegate GetGetMarkerIdHandler ()
		{
			if (cb_getMarkerId == null)
				cb_getMarkerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMarkerId);
			return cb_getMarkerId;
		}

		static int n_GetMarkerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.MacroEmitMarker __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.MacroEmitMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MarkerId;
		}
#pragma warning restore 0169

		static IntPtr id_getMarkerId;
		public virtual int MarkerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='MacroEmitMarker']/method[@name='getMarkerId' and count(parameter)=0]"
			[Register ("getMarkerId", "()I", "GetGetMarkerIdHandler")]
			get {
				if (id_getMarkerId == IntPtr.Zero)
					id_getMarkerId = JNIEnv.GetMethodID (class_ref, "getMarkerId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMarkerId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarkerId", "()I"));
			}
		}

	}
}
