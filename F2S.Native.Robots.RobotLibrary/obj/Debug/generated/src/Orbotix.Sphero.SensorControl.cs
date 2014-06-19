using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']"
	[global::Android.Runtime.Register ("orbotix/sphero/SensorControl", DoNotGenerateAcw=true)]
	public partial class SensorControl : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/SensorControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SensorControl); }
		}

		protected SensorControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_sphero_Sphero_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/constructor[@name='SensorControl' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.Sphero']]"
		[Register (".ctor", "(Lorbotix/sphero/Sphero;)V", "")]
		protected SensorControl (global::Orbotix.Sphero.Sphero p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SensorControl)) {
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

		static Delegate cb_getCurrentMask;
#pragma warning disable 0169
		static Delegate GetGetCurrentMaskHandler ()
		{
			if (cb_getCurrentMask == null)
				cb_getCurrentMask = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentMask);
			return cb_getCurrentMask;
		}

		static IntPtr n_GetCurrentMask (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentMask);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentMask;
		public virtual global::Orbotix.Util.BitMask CurrentMask {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='getCurrentMask' and count(parameter)=0]"
			[Register ("getCurrentMask", "()Lorbotix/util/BitMask;", "GetGetCurrentMaskHandler")]
			get {
				if (id_getCurrentMask == IntPtr.Zero)
					id_getCurrentMask = JNIEnv.GetMethodID (class_ref, "getCurrentMask", "()Lorbotix/util/BitMask;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentMask), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentMask", "()Lorbotix/util/BitMask;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addLocatorListener_Lorbotix_sphero_LocatorListener_;
#pragma warning disable 0169
		static Delegate GetAddLocatorListener_Lorbotix_sphero_LocatorListener_Handler ()
		{
			if (cb_addLocatorListener_Lorbotix_sphero_LocatorListener_ == null)
				cb_addLocatorListener_Lorbotix_sphero_LocatorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLocatorListener_Lorbotix_sphero_LocatorListener_);
			return cb_addLocatorListener_Lorbotix_sphero_LocatorListener_;
		}

		static void n_AddLocatorListener_Lorbotix_sphero_LocatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.ILocatorListener p0 = (global::Orbotix.Sphero.ILocatorListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ILocatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocatorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addLocatorListener_Lorbotix_sphero_LocatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='addLocatorListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.LocatorListener']]"
		[Register ("addLocatorListener", "(Lorbotix/sphero/LocatorListener;)V", "GetAddLocatorListener_Lorbotix_sphero_LocatorListener_Handler")]
		public virtual void AddLocatorListener (global::Orbotix.Sphero.ILocatorListener p0)
		{
			if (id_addLocatorListener_Lorbotix_sphero_LocatorListener_ == IntPtr.Zero)
				id_addLocatorListener_Lorbotix_sphero_LocatorListener_ = JNIEnv.GetMethodID (class_ref, "addLocatorListener", "(Lorbotix/sphero/LocatorListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addLocatorListener_Lorbotix_sphero_LocatorListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLocatorListener", "(Lorbotix/sphero/LocatorListener;)V"), new JValue (p0));
		}

		static Delegate cb_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_;
#pragma warning disable 0169
		static Delegate GetAddSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_Handler ()
		{
			if (cb_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_ == null)
				cb_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_);
			return cb_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_;
		}

		static void n_AddSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.ISensorListener p0 = (global::Orbotix.Sphero.ISensorListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ISensorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.SensorFlag[] p1 = (global::Orbotix.Sphero.SensorFlag[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Orbotix.Sphero.SensorFlag));
			__this.AddSensorListener (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='addSensorListener' and count(parameter)=2 and parameter[1][@type='orbotix.sphero.SensorListener'] and parameter[2][@type='orbotix.sphero.SensorFlag...']]"
		[Register ("addSensorListener", "(Lorbotix/sphero/SensorListener;[Lorbotix/sphero/SensorFlag;)V", "GetAddSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_Handler")]
		public virtual void AddSensorListener (global::Orbotix.Sphero.ISensorListener p0, params global:: Orbotix.Sphero.SensorFlag[] p1)
		{
			if (id_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_ == IntPtr.Zero)
				id_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_ = JNIEnv.GetMethodID (class_ref, "addSensorListener", "(Lorbotix/sphero/SensorListener;[Lorbotix/sphero/SensorFlag;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSensorListener_Lorbotix_sphero_SensorListener_arrayLorbotix_sphero_SensorFlag_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSensorListener", "(Lorbotix/sphero/SensorListener;[Lorbotix/sphero/SensorFlag;)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_enableStreaming_Z;
#pragma warning disable 0169
		static Delegate GetEnableStreaming_ZHandler ()
		{
			if (cb_enableStreaming_Z == null)
				cb_enableStreaming_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableStreaming_Z);
			return cb_enableStreaming_Z;
		}

		static void n_EnableStreaming_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableStreaming (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableStreaming_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='enableStreaming' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableStreaming", "(Z)V", "GetEnableStreaming_ZHandler")]
		public virtual void EnableStreaming (bool p0)
		{
			if (id_enableStreaming_Z == IntPtr.Zero)
				id_enableStreaming_Z = JNIEnv.GetMethodID (class_ref, "enableStreaming", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableStreaming_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableStreaming", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_removeLocatorListener_Lorbotix_sphero_LocatorListener_;
#pragma warning disable 0169
		static Delegate GetRemoveLocatorListener_Lorbotix_sphero_LocatorListener_Handler ()
		{
			if (cb_removeLocatorListener_Lorbotix_sphero_LocatorListener_ == null)
				cb_removeLocatorListener_Lorbotix_sphero_LocatorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocatorListener_Lorbotix_sphero_LocatorListener_);
			return cb_removeLocatorListener_Lorbotix_sphero_LocatorListener_;
		}

		static void n_RemoveLocatorListener_Lorbotix_sphero_LocatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.ILocatorListener p0 = (global::Orbotix.Sphero.ILocatorListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ILocatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocatorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeLocatorListener_Lorbotix_sphero_LocatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='removeLocatorListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.LocatorListener']]"
		[Register ("removeLocatorListener", "(Lorbotix/sphero/LocatorListener;)V", "GetRemoveLocatorListener_Lorbotix_sphero_LocatorListener_Handler")]
		public virtual void RemoveLocatorListener (global::Orbotix.Sphero.ILocatorListener p0)
		{
			if (id_removeLocatorListener_Lorbotix_sphero_LocatorListener_ == IntPtr.Zero)
				id_removeLocatorListener_Lorbotix_sphero_LocatorListener_ = JNIEnv.GetMethodID (class_ref, "removeLocatorListener", "(Lorbotix/sphero/LocatorListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeLocatorListener_Lorbotix_sphero_LocatorListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLocatorListener", "(Lorbotix/sphero/LocatorListener;)V"), new JValue (p0));
		}

		static Delegate cb_removeSensorListener_Lorbotix_sphero_SensorListener_;
#pragma warning disable 0169
		static Delegate GetRemoveSensorListener_Lorbotix_sphero_SensorListener_Handler ()
		{
			if (cb_removeSensorListener_Lorbotix_sphero_SensorListener_ == null)
				cb_removeSensorListener_Lorbotix_sphero_SensorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSensorListener_Lorbotix_sphero_SensorListener_);
			return cb_removeSensorListener_Lorbotix_sphero_SensorListener_;
		}

		static void n_RemoveSensorListener_Lorbotix_sphero_SensorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.ISensorListener p0 = (global::Orbotix.Sphero.ISensorListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ISensorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSensorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSensorListener_Lorbotix_sphero_SensorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='removeSensorListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.SensorListener']]"
		[Register ("removeSensorListener", "(Lorbotix/sphero/SensorListener;)V", "GetRemoveSensorListener_Lorbotix_sphero_SensorListener_Handler")]
		public virtual void RemoveSensorListener (global::Orbotix.Sphero.ISensorListener p0)
		{
			if (id_removeSensorListener_Lorbotix_sphero_SensorListener_ == IntPtr.Zero)
				id_removeSensorListener_Lorbotix_sphero_SensorListener_ = JNIEnv.GetMethodID (class_ref, "removeSensorListener", "(Lorbotix/sphero/SensorListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSensorListener_Lorbotix_sphero_SensorListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSensorListener", "(Lorbotix/sphero/SensorListener;)V"), new JValue (p0));
		}

		static Delegate cb_setRate_I;
#pragma warning disable 0169
		static Delegate GetSetRate_IHandler ()
		{
			if (cb_setRate_I == null)
				cb_setRate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRate_I);
			return cb_setRate_I;
		}

		static void n_SetRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='setRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRate", "(I)V", "GetSetRate_IHandler")]
		public virtual void SetRate (int p0)
		{
			if (id_setRate_I == IntPtr.Zero)
				id_setRate_I = JNIEnv.GetMethodID (class_ref, "setRate", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRate_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRate", "(I)V"), new JValue (p0));
		}

		static Delegate cb_stopStreaming;
#pragma warning disable 0169
		static Delegate GetStopStreamingHandler ()
		{
			if (cb_stopStreaming == null)
				cb_stopStreaming = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopStreaming);
			return cb_stopStreaming;
		}

		static void n_StopStreaming (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.SensorControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopStreaming ();
		}
#pragma warning restore 0169

		static IntPtr id_stopStreaming;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorControl']/method[@name='stopStreaming' and count(parameter)=0]"
		[Register ("stopStreaming", "()V", "GetStopStreamingHandler")]
		public virtual void StopStreaming ()
		{
			if (id_stopStreaming == IntPtr.Zero)
				id_stopStreaming = JNIEnv.GetMethodID (class_ref, "stopStreaming", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopStreaming);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopStreaming", "()V"));
		}

#region "Event implementation for Orbotix.Sphero.ILocatorListener"
		public event EventHandler<global::Orbotix.Sphero.LocatorEventArgs> Locator {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.ILocatorListener, global::Orbotix.Sphero.ILocatorListenerImplementor>(
						ref weak_implementor_AddLocatorListener,
						__CreateILocatorListenerImplementor,
						AddLocatorListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.ILocatorListener, global::Orbotix.Sphero.ILocatorListenerImplementor>(
						ref weak_implementor_AddLocatorListener,
						global::Orbotix.Sphero.ILocatorListenerImplementor.__IsEmpty,
						RemoveLocatorListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddLocatorListener;

		global::Orbotix.Sphero.ILocatorListenerImplementor __CreateILocatorListenerImplementor ()
		{
			return new global::Orbotix.Sphero.ILocatorListenerImplementor (this);
		}
#endregion
	}
}
