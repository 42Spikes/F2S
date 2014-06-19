using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']"
	[global::Android.Runtime.Register ("orbotix/sphero/RobotVersion", DoNotGenerateAcw=true)]
	public partial class RobotVersion : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/RobotVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RobotVersion); }
		}

		protected RobotVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/constructor[@name='RobotVersion' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public RobotVersion (int p0, string p1, string p2, string p3, string p4, string p5, string p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			IntPtr native_p4 = JNIEnv.NewString (p4);;
			IntPtr native_p5 = JNIEnv.NewString (p5);;
			IntPtr native_p6 = JNIEnv.NewString (p6);;
			if (GetType () != typeof (RobotVersion)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (native_p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (native_p6));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (native_p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (native_p6));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/constructor[@name='RobotVersion' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RobotVersion () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RobotVersion)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getBootloaderVersion;
#pragma warning disable 0169
		static Delegate GetGetBootloaderVersionHandler ()
		{
			if (cb_getBootloaderVersion == null)
				cb_getBootloaderVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBootloaderVersion);
			return cb_getBootloaderVersion;
		}

		static IntPtr n_GetBootloaderVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BootloaderVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getBootloaderVersion;
		public virtual string BootloaderVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getBootloaderVersion' and count(parameter)=0]"
			[Register ("getBootloaderVersion", "()Ljava/lang/String;", "GetGetBootloaderVersionHandler")]
			get {
				if (id_getBootloaderVersion == IntPtr.Zero)
					id_getBootloaderVersion = JNIEnv.GetMethodID (class_ref, "getBootloaderVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBootloaderVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBootloaderVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHardwareVersion;
#pragma warning disable 0169
		static Delegate GetGetHardwareVersionHandler ()
		{
			if (cb_getHardwareVersion == null)
				cb_getHardwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHardwareVersion);
			return cb_getHardwareVersion;
		}

		static IntPtr n_GetHardwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HardwareVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getHardwareVersion;
		public virtual string HardwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getHardwareVersion' and count(parameter)=0]"
			[Register ("getHardwareVersion", "()Ljava/lang/String;", "GetGetHardwareVersionHandler")]
			get {
				if (id_getHardwareVersion == IntPtr.Zero)
					id_getHardwareVersion = JNIEnv.GetMethodID (class_ref, "getHardwareVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHardwareVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHardwareVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMainApplicationVersion;
#pragma warning disable 0169
		static Delegate GetGetMainApplicationVersionHandler ()
		{
			if (cb_getMainApplicationVersion == null)
				cb_getMainApplicationVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainApplicationVersion);
			return cb_getMainApplicationVersion;
		}

		static IntPtr n_GetMainApplicationVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MainApplicationVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getMainApplicationVersion;
		public virtual string MainApplicationVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getMainApplicationVersion' and count(parameter)=0]"
			[Register ("getMainApplicationVersion", "()Ljava/lang/String;", "GetGetMainApplicationVersionHandler")]
			get {
				if (id_getMainApplicationVersion == IntPtr.Zero)
					id_getMainApplicationVersion = JNIEnv.GetMethodID (class_ref, "getMainApplicationVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMainApplicationVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMainApplicationVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getModelNumber;
#pragma warning disable 0169
		static Delegate GetGetModelNumberHandler ()
		{
			if (cb_getModelNumber == null)
				cb_getModelNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetModelNumber);
			return cb_getModelNumber;
		}

		static int n_GetModelNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ModelNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getModelNumber;
		public virtual int ModelNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getModelNumber' and count(parameter)=0]"
			[Register ("getModelNumber", "()I", "GetGetModelNumberHandler")]
			get {
				if (id_getModelNumber == IntPtr.Zero)
					id_getModelNumber = JNIEnv.GetMethodID (class_ref, "getModelNumber", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getModelNumber);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModelNumber", "()I"));
			}
		}

		static Delegate cb_getOrbBasicVersion;
#pragma warning disable 0169
		static Delegate GetGetOrbBasicVersionHandler ()
		{
			if (cb_getOrbBasicVersion == null)
				cb_getOrbBasicVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrbBasicVersion);
			return cb_getOrbBasicVersion;
		}

		static IntPtr n_GetOrbBasicVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrbBasicVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getOrbBasicVersion;
		public virtual string OrbBasicVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getOrbBasicVersion' and count(parameter)=0]"
			[Register ("getOrbBasicVersion", "()Ljava/lang/String;", "GetGetOrbBasicVersionHandler")]
			get {
				if (id_getOrbBasicVersion == IntPtr.Zero)
					id_getOrbBasicVersion = JNIEnv.GetMethodID (class_ref, "getOrbBasicVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOrbBasicVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrbBasicVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOverlayManagerVersion;
#pragma warning disable 0169
		static Delegate GetGetOverlayManagerVersionHandler ()
		{
			if (cb_getOverlayManagerVersion == null)
				cb_getOverlayManagerVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOverlayManagerVersion);
			return cb_getOverlayManagerVersion;
		}

		static IntPtr n_GetOverlayManagerVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OverlayManagerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getOverlayManagerVersion;
		public virtual string OverlayManagerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getOverlayManagerVersion' and count(parameter)=0]"
			[Register ("getOverlayManagerVersion", "()Ljava/lang/String;", "GetGetOverlayManagerVersionHandler")]
			get {
				if (id_getOverlayManagerVersion == IntPtr.Zero)
					id_getOverlayManagerVersion = JNIEnv.GetMethodID (class_ref, "getOverlayManagerVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOverlayManagerVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOverlayManagerVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRecordVersion;
#pragma warning disable 0169
		static Delegate GetGetRecordVersionHandler ()
		{
			if (cb_getRecordVersion == null)
				cb_getRecordVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecordVersion);
			return cb_getRecordVersion;
		}

		static IntPtr n_GetRecordVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.RobotVersion __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecordVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getRecordVersion;
		public virtual string RecordVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='RobotVersion']/method[@name='getRecordVersion' and count(parameter)=0]"
			[Register ("getRecordVersion", "()Ljava/lang/String;", "GetGetRecordVersionHandler")]
			get {
				if (id_getRecordVersion == IntPtr.Zero)
					id_getRecordVersion = JNIEnv.GetMethodID (class_ref, "getRecordVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRecordVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
