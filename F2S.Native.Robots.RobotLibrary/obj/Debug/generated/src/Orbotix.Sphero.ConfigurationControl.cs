using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']"
	[global::Android.Runtime.Register ("orbotix/sphero/ConfigurationControl", DoNotGenerateAcw=true)]
	public partial class ConfigurationControl : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "OBX-CC";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/ConfigurationControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigurationControl); }
		}

		protected ConfigurationControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_sphero_Sphero_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/constructor[@name='ConfigurationControl' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.Sphero']]"
		[Register (".ctor", "(Lorbotix/sphero/Sphero;)V", "")]
		public ConfigurationControl (global::Orbotix.Sphero.Sphero p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConfigurationControl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/sphero/Sphero;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/sphero/Sphero;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_sphero_Sphero_ == IntPtr.Zero)
				id_ctor_Lorbotix_sphero_Sphero_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/sphero/Sphero;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_sphero_Sphero_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_sphero_Sphero_, new JValue (p0));
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReady);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReady", "()Z"));
			}
		}

		static Delegate cb_isShellAvailable;
#pragma warning disable 0169
		static Delegate GetIsShellAvailableHandler ()
		{
			if (cb_isShellAvailable == null)
				cb_isShellAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShellAvailable);
			return cb_isShellAvailable;
		}

		static bool n_IsShellAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShellAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isShellAvailable;
		public virtual bool IsShellAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='isShellAvailable' and count(parameter)=0]"
			[Register ("isShellAvailable", "()Z", "GetIsShellAvailableHandler")]
			get {
				if (id_isShellAvailable == IntPtr.Zero)
					id_isShellAvailable = JNIEnv.GetMethodID (class_ref, "isShellAvailable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShellAvailable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShellAvailable", "()Z"));
			}
		}

		static Delegate cb_disableMotionTimeout;
#pragma warning disable 0169
		static Delegate GetDisableMotionTimeoutHandler ()
		{
			if (cb_disableMotionTimeout == null)
				cb_disableMotionTimeout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableMotionTimeout);
			return cb_disableMotionTimeout;
		}

		static void n_DisableMotionTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableMotionTimeout ();
		}
#pragma warning restore 0169

		static IntPtr id_disableMotionTimeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='disableMotionTimeout' and count(parameter)=0]"
		[Register ("disableMotionTimeout", "()V", "GetDisableMotionTimeoutHandler")]
		public virtual void DisableMotionTimeout ()
		{
			if (id_disableMotionTimeout == IntPtr.Zero)
				id_disableMotionTimeout = JNIEnv.GetMethodID (class_ref, "disableMotionTimeout", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableMotionTimeout);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableMotionTimeout", "()V"));
		}

		static Delegate cb_enableInactivityTimeout_I;
#pragma warning disable 0169
		static Delegate GetEnableInactivityTimeout_IHandler ()
		{
			if (cb_enableInactivityTimeout_I == null)
				cb_enableInactivityTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EnableInactivityTimeout_I);
			return cb_enableInactivityTimeout_I;
		}

		static void n_EnableInactivityTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableInactivityTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableInactivityTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='enableInactivityTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableInactivityTimeout", "(I)V", "GetEnableInactivityTimeout_IHandler")]
		public virtual void EnableInactivityTimeout (int p0)
		{
			if (id_enableInactivityTimeout_I == IntPtr.Zero)
				id_enableInactivityTimeout_I = JNIEnv.GetMethodID (class_ref, "enableInactivityTimeout", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableInactivityTimeout_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableInactivityTimeout", "(I)V"), new JValue (p0));
		}

		static Delegate cb_enableMotionTimeout_I;
#pragma warning disable 0169
		static Delegate GetEnableMotionTimeout_IHandler ()
		{
			if (cb_enableMotionTimeout_I == null)
				cb_enableMotionTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EnableMotionTimeout_I);
			return cb_enableMotionTimeout_I;
		}

		static void n_EnableMotionTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableMotionTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableMotionTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='enableMotionTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableMotionTimeout", "(I)V", "GetEnableMotionTimeout_IHandler")]
		public virtual void EnableMotionTimeout (int p0)
		{
			if (id_enableMotionTimeout_I == IntPtr.Zero)
				id_enableMotionTimeout_I = JNIEnv.GetMethodID (class_ref, "enableMotionTimeout", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableMotionTimeout_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableMotionTimeout", "(I)V"), new JValue (p0));
		}

		static Delegate cb_enableShellAccess_Z;
#pragma warning disable 0169
		static Delegate GetEnableShellAccess_ZHandler ()
		{
			if (cb_enableShellAccess_Z == null)
				cb_enableShellAccess_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableShellAccess_Z);
			return cb_enableShellAccess_Z;
		}

		static void n_EnableShellAccess_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableShellAccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableShellAccess_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='enableShellAccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableShellAccess", "(Z)V", "GetEnableShellAccess_ZHandler")]
		public virtual void EnableShellAccess (bool p0)
		{
			if (id_enableShellAccess_Z == IntPtr.Zero)
				id_enableShellAccess_Z = JNIEnv.GetMethodID (class_ref, "enableShellAccess", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableShellAccess_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableShellAccess", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_;
#pragma warning disable 0169
		static Delegate GetIsPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_Handler ()
		{
			if (cb_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_ == null)
				cb_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_);
			return cb_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_;
		}

		static bool n_IsPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.PersistentOptionFlags p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPersistentFlagEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='isPersistentFlagEnabled' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.PersistentOptionFlags']]"
		[Register ("isPersistentFlagEnabled", "(Lorbotix/sphero/PersistentOptionFlags;)Z", "GetIsPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_Handler")]
		public virtual bool IsPersistentFlagEnabled (global::Orbotix.Sphero.PersistentOptionFlags p0)
		{
			if (id_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_ == IntPtr.Zero)
				id_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_ = JNIEnv.GetMethodID (class_ref, "isPersistentFlagEnabled", "(Lorbotix/sphero/PersistentOptionFlags;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isPersistentFlagEnabled_Lorbotix_sphero_PersistentOptionFlags_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPersistentFlagEnabled", "(Lorbotix/sphero/PersistentOptionFlags;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_performSelfLevel;
#pragma warning disable 0169
		static Delegate GetPerformSelfLevelHandler ()
		{
			if (cb_performSelfLevel == null)
				cb_performSelfLevel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PerformSelfLevel);
			return cb_performSelfLevel;
		}

		static void n_PerformSelfLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PerformSelfLevel ();
		}
#pragma warning restore 0169

		static IntPtr id_performSelfLevel;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='performSelfLevel' and count(parameter)=0]"
		[Register ("performSelfLevel", "()V", "GetPerformSelfLevelHandler")]
		public virtual void PerformSelfLevel ()
		{
			if (id_performSelfLevel == IntPtr.Zero)
				id_performSelfLevel = JNIEnv.GetMethodID (class_ref, "performSelfLevel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_performSelfLevel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performSelfLevel", "()V"));
		}

		static Delegate cb_setHeading_F;
#pragma warning disable 0169
		static Delegate GetSetHeading_FHandler ()
		{
			if (cb_setHeading_F == null)
				cb_setHeading_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHeading_F);
			return cb_setHeading_F;
		}

		static void n_SetHeading_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHeading (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHeading_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='setHeading' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHeading", "(F)V", "GetSetHeading_FHandler")]
		public virtual void SetHeading (float p0)
		{
			if (id_setHeading_F == IntPtr.Zero)
				id_setHeading_F = JNIEnv.GetMethodID (class_ref, "setHeading", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHeading_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeading", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z;
#pragma warning disable 0169
		static Delegate GetSetNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_ZHandler ()
		{
			if (cb_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z == null)
				cb_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z);
			return cb_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z;
		}

		static void n_SetNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.NonPersistentOptionFlags p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.NonPersistentOptionFlags> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNonPersistentFlag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='setNonPersistentFlag' and count(parameter)=2 and parameter[1][@type='orbotix.sphero.NonPersistentOptionFlags'] and parameter[2][@type='boolean']]"
		[Register ("setNonPersistentFlag", "(Lorbotix/sphero/NonPersistentOptionFlags;Z)V", "GetSetNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_ZHandler")]
		public virtual void SetNonPersistentFlag (global::Orbotix.Sphero.NonPersistentOptionFlags p0, bool p1)
		{
			if (id_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z == IntPtr.Zero)
				id_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z = JNIEnv.GetMethodID (class_ref, "setNonPersistentFlag", "(Lorbotix/sphero/NonPersistentOptionFlags;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNonPersistentFlag_Lorbotix_sphero_NonPersistentOptionFlags_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNonPersistentFlag", "(Lorbotix/sphero/NonPersistentOptionFlags;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z;
#pragma warning disable 0169
		static Delegate GetSetPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_ZHandler ()
		{
			if (cb_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z == null)
				cb_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z);
			return cb_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z;
		}

		static void n_SetPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.PersistentOptionFlags p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPersistentFlag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='setPersistentFlag' and count(parameter)=2 and parameter[1][@type='orbotix.sphero.PersistentOptionFlags'] and parameter[2][@type='boolean']]"
		[Register ("setPersistentFlag", "(Lorbotix/sphero/PersistentOptionFlags;Z)V", "GetSetPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_ZHandler")]
		public virtual void SetPersistentFlag (global::Orbotix.Sphero.PersistentOptionFlags p0, bool p1)
		{
			if (id_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z == IntPtr.Zero)
				id_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z = JNIEnv.GetMethodID (class_ref, "setPersistentFlag", "(Lorbotix/sphero/PersistentOptionFlags;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPersistentFlag_Lorbotix_sphero_PersistentOptionFlags_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPersistentFlag", "(Lorbotix/sphero/PersistentOptionFlags;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setPersistentFlagDefaults;
#pragma warning disable 0169
		static Delegate GetSetPersistentFlagDefaultsHandler ()
		{
			if (cb_setPersistentFlagDefaults == null)
				cb_setPersistentFlagDefaults = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetPersistentFlagDefaults);
			return cb_setPersistentFlagDefaults;
		}

		static void n_SetPersistentFlagDefaults (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPersistentFlagDefaults ();
		}
#pragma warning restore 0169

		static IntPtr id_setPersistentFlagDefaults;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='setPersistentFlagDefaults' and count(parameter)=0]"
		[Register ("setPersistentFlagDefaults", "()V", "GetSetPersistentFlagDefaultsHandler")]
		public virtual void SetPersistentFlagDefaults ()
		{
			if (id_setPersistentFlagDefaults == IntPtr.Zero)
				id_setPersistentFlagDefaults = JNIEnv.GetMethodID (class_ref, "setPersistentFlagDefaults", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPersistentFlagDefaults);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPersistentFlagDefaults", "()V"));
		}

		static Delegate cb_setRotationRate_F;
#pragma warning disable 0169
		static Delegate GetSetRotationRate_FHandler ()
		{
			if (cb_setRotationRate_F == null)
				cb_setRotationRate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotationRate_F);
			return cb_setRotationRate_F;
		}

		static void n_SetRotationRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationRate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='setRotationRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotationRate", "(F)V", "GetSetRotationRate_FHandler")]
		public virtual void SetRotationRate (float p0)
		{
			if (id_setRotationRate_F == IntPtr.Zero)
				id_setRotationRate_F = JNIEnv.GetMethodID (class_ref, "setRotationRate", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRotationRate_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationRate", "(F)V"), new JValue (p0));
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.ConfigurationControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		static IntPtr id_update;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='ConfigurationControl']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual void Update ()
		{
			if (id_update == IntPtr.Zero)
				id_update = JNIEnv.GetMethodID (class_ref, "update", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "()V"));
		}

	}
}
