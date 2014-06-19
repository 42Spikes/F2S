using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.sphero']/interface[@name='DiscoveryListener']"
	[Register ("orbotix/sphero/DiscoveryListener", "", "Orbotix.Sphero.IDiscoveryListenerInvoker")]
	public partial interface IDiscoveryListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='DiscoveryListener']/method[@name='discoveryComplete' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("discoveryComplete", "(Ljava/util/List;)V", "GetDiscoveryComplete_Ljava_util_List_Handler:Orbotix.Sphero.IDiscoveryListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void DiscoveryComplete (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='DiscoveryListener']/method[@name='onBluetoothDisabled' and count(parameter)=0]"
		[Register ("onBluetoothDisabled", "()V", "GetOnBluetoothDisabledHandler:Orbotix.Sphero.IDiscoveryListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void OnBluetoothDisabled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='DiscoveryListener']/method[@name='onFound' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("onFound", "(Ljava/util/List;)V", "GetOnFound_Ljava_util_List_Handler:Orbotix.Sphero.IDiscoveryListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void OnFound (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0);

	}

	[global::Android.Runtime.Register ("orbotix/sphero/DiscoveryListener", DoNotGenerateAcw=true)]
	internal class IDiscoveryListenerInvoker : global::Java.Lang.Object, IDiscoveryListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/sphero/DiscoveryListener");
		IntPtr class_ref;

		public static IDiscoveryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiscoveryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.sphero.DiscoveryListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiscoveryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDiscoveryListenerInvoker); }
		}

		static Delegate cb_discoveryComplete_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDiscoveryComplete_Ljava_util_List_Handler ()
		{
			if (cb_discoveryComplete_Ljava_util_List_ == null)
				cb_discoveryComplete_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DiscoveryComplete_Ljava_util_List_);
			return cb_discoveryComplete_Ljava_util_List_;
		}

		static void n_DiscoveryComplete_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.IDiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Orbotix.Sphero.Sphero> p0 = global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DiscoveryComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_discoveryComplete_Ljava_util_List_;
		public void DiscoveryComplete (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0)
		{
			if (id_discoveryComplete_Ljava_util_List_ == IntPtr.Zero)
				id_discoveryComplete_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "discoveryComplete", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_discoveryComplete_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onBluetoothDisabled;
#pragma warning disable 0169
		static Delegate GetOnBluetoothDisabledHandler ()
		{
			if (cb_onBluetoothDisabled == null)
				cb_onBluetoothDisabled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBluetoothDisabled);
			return cb_onBluetoothDisabled;
		}

		static void n_OnBluetoothDisabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.IDiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBluetoothDisabled ();
		}
#pragma warning restore 0169

		IntPtr id_onBluetoothDisabled;
		public void OnBluetoothDisabled ()
		{
			if (id_onBluetoothDisabled == IntPtr.Zero)
				id_onBluetoothDisabled = JNIEnv.GetMethodID (class_ref, "onBluetoothDisabled", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onBluetoothDisabled);
		}

		static Delegate cb_onFound_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnFound_Ljava_util_List_Handler ()
		{
			if (cb_onFound_Ljava_util_List_ == null)
				cb_onFound_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFound_Ljava_util_List_);
			return cb_onFound_Ljava_util_List_;
		}

		static void n_OnFound_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.IDiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Orbotix.Sphero.Sphero> p0 = global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFound (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFound_Ljava_util_List_;
		public void OnFound (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0)
		{
			if (id_onFound_Ljava_util_List_ == IntPtr.Zero)
				id_onFound_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onFound", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_onFound_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class DiscoveryCompleteEventArgs : global::System.EventArgs {

		public DiscoveryCompleteEventArgs (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0;
		public global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> P0 {
			get { return p0; }
		}
	}

	public partial class FoundEventArgs : global::System.EventArgs {

		public FoundEventArgs (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0;
		public global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/orbotix/sphero/DiscoveryListenerImplementor")]
	internal sealed class IDiscoveryListenerImplementor : global::Java.Lang.Object, IDiscoveryListener {

		object sender;

		public IDiscoveryListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/sphero/DiscoveryListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DiscoveryCompleteEventArgs> DiscoveryCompleteHandler;
#pragma warning restore 0649

		public void DiscoveryComplete (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0)
		{
			var __h = DiscoveryCompleteHandler;
			if (__h != null)
				__h (sender, new DiscoveryCompleteEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnBluetoothDisabledHandler;
#pragma warning restore 0649

		public void OnBluetoothDisabled ()
		{
			var __h = OnBluetoothDisabledHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<FoundEventArgs> OnFoundHandler;
#pragma warning restore 0649

		public void OnFound (global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> p0)
		{
			var __h = OnFoundHandler;
			if (__h != null)
				__h (sender, new FoundEventArgs (p0));
		}

		internal static bool __IsEmpty (IDiscoveryListenerImplementor value)
		{
			return value.DiscoveryCompleteHandler == null && value.OnBluetoothDisabledHandler == null && value.OnFoundHandler == null;
		}
	}

}
