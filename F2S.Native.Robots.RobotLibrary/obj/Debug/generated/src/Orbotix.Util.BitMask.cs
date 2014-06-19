using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']"
	[global::Android.Runtime.Register ("orbotix/util/BitMask", DoNotGenerateAcw=true)]
	public partial class BitMask : global::Java.Lang.Object, global::Orbotix.Util.IMaskable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/util/BitMask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitMask); }
		}

		protected BitMask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/constructor[@name='BitMask' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public BitMask (long p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BitMask)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", new JValue (p0));
				return;
			}

			if (id_ctor_J == IntPtr.Zero)
				id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, new JValue (p0));
		}

		static IntPtr id_ctor_arrayLorbotix_util_Maskable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/constructor[@name='BitMask' and count(parameter)=1 and parameter[1][@type='orbotix.util.Maskable...']]"
		[Register (".ctor", "([Lorbotix/util/Maskable;)V", "")]
		public BitMask (params global:: Orbotix.Util.IMaskable[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (BitMask)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lorbotix/util/Maskable;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lorbotix/util/Maskable;)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayLorbotix_util_Maskable_ == IntPtr.Zero)
				id_ctor_arrayLorbotix_util_Maskable_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorbotix/util/Maskable;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorbotix_util_Maskable_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLorbotix_util_Maskable_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addFlag_Lorbotix_util_Maskable_;
#pragma warning disable 0169
		static Delegate GetAddFlag_Lorbotix_util_Maskable_Handler ()
		{
			if (cb_addFlag_Lorbotix_util_Maskable_ == null)
				cb_addFlag_Lorbotix_util_Maskable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFlag_Lorbotix_util_Maskable_);
			return cb_addFlag_Lorbotix_util_Maskable_;
		}

		static void n_AddFlag_Lorbotix_util_Maskable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Util.BitMask __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Util.IMaskable p0 = (global::Orbotix.Util.IMaskable)global::Java.Lang.Object.GetObject<global::Orbotix.Util.IMaskable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFlag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFlag_Lorbotix_util_Maskable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/method[@name='addFlag' and count(parameter)=1 and parameter[1][@type='orbotix.util.Maskable']]"
		[Register ("addFlag", "(Lorbotix/util/Maskable;)V", "GetAddFlag_Lorbotix_util_Maskable_Handler")]
		public virtual void AddFlag (global::Orbotix.Util.IMaskable p0)
		{
			if (id_addFlag_Lorbotix_util_Maskable_ == IntPtr.Zero)
				id_addFlag_Lorbotix_util_Maskable_ = JNIEnv.GetMethodID (class_ref, "addFlag", "(Lorbotix/util/Maskable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addFlag_Lorbotix_util_Maskable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFlag", "(Lorbotix/util/Maskable;)V"), new JValue (p0));
		}

		static Delegate cb_getByteArray;
#pragma warning disable 0169
		static Delegate GetGetByteArrayHandler ()
		{
			if (cb_getByteArray == null)
				cb_getByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetByteArray);
			return cb_getByteArray;
		}

		static IntPtr n_GetByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.BitMask __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/method[@name='getByteArray' and count(parameter)=0]"
		[Register ("getByteArray", "()[B", "GetGetByteArrayHandler")]
		public virtual byte[] GetByteArray ()
		{
			if (id_getByteArray == IntPtr.Zero)
				id_getByteArray = JNIEnv.GetMethodID (class_ref, "getByteArray", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_isEnabled_Lorbotix_util_Maskable_;
#pragma warning disable 0169
		static Delegate GetIsEnabled_Lorbotix_util_Maskable_Handler ()
		{
			if (cb_isEnabled_Lorbotix_util_Maskable_ == null)
				cb_isEnabled_Lorbotix_util_Maskable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsEnabled_Lorbotix_util_Maskable_);
			return cb_isEnabled_Lorbotix_util_Maskable_;
		}

		static bool n_IsEnabled_Lorbotix_util_Maskable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Util.BitMask __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Util.IMaskable p0 = (global::Orbotix.Util.IMaskable)global::Java.Lang.Object.GetObject<global::Orbotix.Util.IMaskable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled_Lorbotix_util_Maskable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/method[@name='isEnabled' and count(parameter)=1 and parameter[1][@type='orbotix.util.Maskable']]"
		[Register ("isEnabled", "(Lorbotix/util/Maskable;)Z", "GetIsEnabled_Lorbotix_util_Maskable_Handler")]
		public virtual bool IsEnabled (global::Orbotix.Util.IMaskable p0)
		{
			if (id_isEnabled_Lorbotix_util_Maskable_ == IntPtr.Zero)
				id_isEnabled_Lorbotix_util_Maskable_ = JNIEnv.GetMethodID (class_ref, "isEnabled", "(Lorbotix/util/Maskable;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isEnabled_Lorbotix_util_Maskable_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "(Lorbotix/util/Maskable;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_longValue;
#pragma warning disable 0169
		static Delegate GetLongValueHandler ()
		{
			if (cb_longValue == null)
				cb_longValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_LongValue);
			return cb_longValue;
		}

		static long n_LongValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.BitMask __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue ();
		}
#pragma warning restore 0169

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "GetLongValueHandler")]
		public virtual long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_longValue);
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "longValue", "()J"));
		}

		static Delegate cb_removeFlag_Lorbotix_util_Maskable_;
#pragma warning disable 0169
		static Delegate GetRemoveFlag_Lorbotix_util_Maskable_Handler ()
		{
			if (cb_removeFlag_Lorbotix_util_Maskable_ == null)
				cb_removeFlag_Lorbotix_util_Maskable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveFlag_Lorbotix_util_Maskable_);
			return cb_removeFlag_Lorbotix_util_Maskable_;
		}

		static void n_RemoveFlag_Lorbotix_util_Maskable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Util.BitMask __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Util.IMaskable p0 = (global::Orbotix.Util.IMaskable)global::Java.Lang.Object.GetObject<global::Orbotix.Util.IMaskable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFlag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeFlag_Lorbotix_util_Maskable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/method[@name='removeFlag' and count(parameter)=1 and parameter[1][@type='orbotix.util.Maskable']]"
		[Register ("removeFlag", "(Lorbotix/util/Maskable;)V", "GetRemoveFlag_Lorbotix_util_Maskable_Handler")]
		public virtual void RemoveFlag (global::Orbotix.Util.IMaskable p0)
		{
			if (id_removeFlag_Lorbotix_util_Maskable_ == IntPtr.Zero)
				id_removeFlag_Lorbotix_util_Maskable_ = JNIEnv.GetMethodID (class_ref, "removeFlag", "(Lorbotix/util/Maskable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeFlag_Lorbotix_util_Maskable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFlag", "(Lorbotix/util/Maskable;)V"), new JValue (p0));
		}

		static Delegate cb_setFlag_Lorbotix_util_Maskable_Z;
#pragma warning disable 0169
		static Delegate GetSetFlag_Lorbotix_util_Maskable_ZHandler ()
		{
			if (cb_setFlag_Lorbotix_util_Maskable_Z == null)
				cb_setFlag_Lorbotix_util_Maskable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetFlag_Lorbotix_util_Maskable_Z);
			return cb_setFlag_Lorbotix_util_Maskable_Z;
		}

		static void n_SetFlag_Lorbotix_util_Maskable_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Orbotix.Util.BitMask __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Util.IMaskable p0 = (global::Orbotix.Util.IMaskable)global::Java.Lang.Object.GetObject<global::Orbotix.Util.IMaskable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFlag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFlag_Lorbotix_util_Maskable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='BitMask']/method[@name='setFlag' and count(parameter)=2 and parameter[1][@type='orbotix.util.Maskable'] and parameter[2][@type='boolean']]"
		[Register ("setFlag", "(Lorbotix/util/Maskable;Z)V", "GetSetFlag_Lorbotix_util_Maskable_ZHandler")]
		public virtual void SetFlag (global::Orbotix.Util.IMaskable p0, bool p1)
		{
			if (id_setFlag_Lorbotix_util_Maskable_Z == IntPtr.Zero)
				id_setFlag_Lorbotix_util_Maskable_Z = JNIEnv.GetMethodID (class_ref, "setFlag", "(Lorbotix/util/Maskable;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFlag_Lorbotix_util_Maskable_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlag", "(Lorbotix/util/Maskable;Z)V"), new JValue (p0), new JValue (p1));
		}

	}
}
