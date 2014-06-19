using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl']"
	[global::Android.Runtime.Register ("orbotix/sphero/CollisionControl", DoNotGenerateAcw=true)]
	public partial class CollisionControl : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl.Method']"
		[global::Android.Runtime.Register ("orbotix/sphero/CollisionControl$Method", DoNotGenerateAcw=true)]
		public sealed partial class Method : global::Java.Lang.Enum {


			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl.Method']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Orbotix.Sphero.CollisionControl.Method Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lorbotix/sphero/CollisionControl$Method;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl.Method> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lorbotix/sphero/CollisionControl$Method;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl.Method']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Orbotix.Sphero.CollisionControl.Method Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lorbotix/sphero/CollisionControl$Method;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl.Method> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lorbotix/sphero/CollisionControl$Method;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DISABLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/sphero/CollisionControl$Method", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Method); }
			}

			internal Method (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/CollisionControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CollisionControl); }
		}

		protected CollisionControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_sphero_Sphero_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl']/constructor[@name='CollisionControl' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.Sphero']]"
		[Register (".ctor", "(Lorbotix/sphero/Sphero;)V", "")]
		public CollisionControl (global::Orbotix.Sphero.Sphero p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CollisionControl)) {
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

		static Delegate cb_addCollisionListener_Lorbotix_sphero_CollisionListener_;
#pragma warning disable 0169
		static Delegate GetAddCollisionListener_Lorbotix_sphero_CollisionListener_Handler ()
		{
			if (cb_addCollisionListener_Lorbotix_sphero_CollisionListener_ == null)
				cb_addCollisionListener_Lorbotix_sphero_CollisionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCollisionListener_Lorbotix_sphero_CollisionListener_);
			return cb_addCollisionListener_Lorbotix_sphero_CollisionListener_;
		}

		static void n_AddCollisionListener_Lorbotix_sphero_CollisionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.CollisionControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.ICollisionListener p0 = (global::Orbotix.Sphero.ICollisionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ICollisionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCollisionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCollisionListener_Lorbotix_sphero_CollisionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl']/method[@name='addCollisionListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.CollisionListener']]"
		[Register ("addCollisionListener", "(Lorbotix/sphero/CollisionListener;)V", "GetAddCollisionListener_Lorbotix_sphero_CollisionListener_Handler")]
		public virtual void AddCollisionListener (global::Orbotix.Sphero.ICollisionListener p0)
		{
			if (id_addCollisionListener_Lorbotix_sphero_CollisionListener_ == IntPtr.Zero)
				id_addCollisionListener_Lorbotix_sphero_CollisionListener_ = JNIEnv.GetMethodID (class_ref, "addCollisionListener", "(Lorbotix/sphero/CollisionListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addCollisionListener_Lorbotix_sphero_CollisionListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCollisionListener", "(Lorbotix/sphero/CollisionListener;)V"), new JValue (p0));
		}

		static Delegate cb_removeCollisionListener_Lorbotix_sphero_CollisionListener_;
#pragma warning disable 0169
		static Delegate GetRemoveCollisionListener_Lorbotix_sphero_CollisionListener_Handler ()
		{
			if (cb_removeCollisionListener_Lorbotix_sphero_CollisionListener_ == null)
				cb_removeCollisionListener_Lorbotix_sphero_CollisionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCollisionListener_Lorbotix_sphero_CollisionListener_);
			return cb_removeCollisionListener_Lorbotix_sphero_CollisionListener_;
		}

		static void n_RemoveCollisionListener_Lorbotix_sphero_CollisionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.CollisionControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.ICollisionListener p0 = (global::Orbotix.Sphero.ICollisionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ICollisionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCollisionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCollisionListener_Lorbotix_sphero_CollisionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl']/method[@name='removeCollisionListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.CollisionListener']]"
		[Register ("removeCollisionListener", "(Lorbotix/sphero/CollisionListener;)V", "GetRemoveCollisionListener_Lorbotix_sphero_CollisionListener_Handler")]
		public virtual void RemoveCollisionListener (global::Orbotix.Sphero.ICollisionListener p0)
		{
			if (id_removeCollisionListener_Lorbotix_sphero_CollisionListener_ == IntPtr.Zero)
				id_removeCollisionListener_Lorbotix_sphero_CollisionListener_ = JNIEnv.GetMethodID (class_ref, "removeCollisionListener", "(Lorbotix/sphero/CollisionListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeCollisionListener_Lorbotix_sphero_CollisionListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCollisionListener", "(Lorbotix/sphero/CollisionListener;)V"), new JValue (p0));
		}

		static Delegate cb_startDetection_IIIII;
#pragma warning disable 0169
		static Delegate GetStartDetection_IIIIIHandler ()
		{
			if (cb_startDetection_IIIII == null)
				cb_startDetection_IIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int>) n_StartDetection_IIIII);
			return cb_startDetection_IIIII;
		}

		static void n_StartDetection_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Orbotix.Sphero.CollisionControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDetection (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_startDetection_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl']/method[@name='startDetection' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("startDetection", "(IIIII)V", "GetStartDetection_IIIIIHandler")]
		public virtual void StartDetection (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_startDetection_IIIII == IntPtr.Zero)
				id_startDetection_IIIII = JNIEnv.GetMethodID (class_ref, "startDetection", "(IIIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startDetection_IIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDetection", "(IIIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_stopDetection;
#pragma warning disable 0169
		static Delegate GetStopDetectionHandler ()
		{
			if (cb_stopDetection == null)
				cb_stopDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopDetection);
			return cb_stopDetection;
		}

		static void n_StopDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.CollisionControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_stopDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='CollisionControl']/method[@name='stopDetection' and count(parameter)=0]"
		[Register ("stopDetection", "()V", "GetStopDetectionHandler")]
		public virtual void StopDetection ()
		{
			if (id_stopDetection == IntPtr.Zero)
				id_stopDetection = JNIEnv.GetMethodID (class_ref, "stopDetection", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopDetection);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopDetection", "()V"));
		}

#region "Event implementation for Orbotix.Sphero.ICollisionListener"
		public event EventHandler<global::Orbotix.Sphero.CollisionEventArgs> Collision {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.ICollisionListener, global::Orbotix.Sphero.ICollisionListenerImplementor>(
						ref weak_implementor_AddCollisionListener,
						__CreateICollisionListenerImplementor,
						AddCollisionListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.ICollisionListener, global::Orbotix.Sphero.ICollisionListenerImplementor>(
						ref weak_implementor_AddCollisionListener,
						global::Orbotix.Sphero.ICollisionListenerImplementor.__IsEmpty,
						RemoveCollisionListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddCollisionListener;

		global::Orbotix.Sphero.ICollisionListenerImplementor __CreateICollisionListenerImplementor ()
		{
			return new global::Orbotix.Sphero.ICollisionListenerImplementor (this);
		}
#endregion
	}
}
