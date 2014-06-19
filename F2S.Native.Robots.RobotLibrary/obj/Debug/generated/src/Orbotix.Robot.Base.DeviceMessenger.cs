using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DeviceMessenger", DoNotGenerateAcw=true)]
	public partial class DeviceMessenger : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DeviceMessenger.AsyncDataListener']"
		[Register ("orbotix/robot/base/DeviceMessenger$AsyncDataListener", "", "Orbotix.Robot.Base.DeviceMessenger/IAsyncDataListenerInvoker")]
		public partial interface IAsyncDataListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DeviceMessenger.AsyncDataListener']/method[@name='onDataReceived' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.DeviceAsyncData']]"
			[Register ("onDataReceived", "(Lorbotix/robot/base/DeviceAsyncData;)V", "GetOnDataReceived_Lorbotix_robot_base_DeviceAsyncData_Handler:Orbotix.Robot.Base.DeviceMessenger/IAsyncDataListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnDataReceived (global::Orbotix.Robot.Base.DeviceAsyncData p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/DeviceMessenger$AsyncDataListener", DoNotGenerateAcw=true)]
		internal class IAsyncDataListenerInvoker : global::Java.Lang.Object, IAsyncDataListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/DeviceMessenger$AsyncDataListener");
			IntPtr class_ref;

			public static IAsyncDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAsyncDataListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.DeviceMessenger.AsyncDataListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAsyncDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IAsyncDataListenerInvoker); }
			}

			static Delegate cb_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_;
#pragma warning disable 0169
			static Delegate GetOnDataReceived_Lorbotix_robot_base_DeviceAsyncData_Handler ()
			{
				if (cb_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_ == null)
					cb_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDataReceived_Lorbotix_robot_base_DeviceAsyncData_);
				return cb_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_;
			}

			static void n_OnDataReceived_Lorbotix_robot_base_DeviceAsyncData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.DeviceAsyncData p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDataReceived (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_;
			public void OnDataReceived (global::Orbotix.Robot.Base.DeviceAsyncData p0)
			{
				if (id_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_ == IntPtr.Zero)
					id_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_ = JNIEnv.GetMethodID (class_ref, "onDataReceived", "(Lorbotix/robot/base/DeviceAsyncData;)V");
				JNIEnv.CallVoidMethod (Handle, id_onDataReceived_Lorbotix_robot_base_DeviceAsyncData_, new JValue (p0));
			}

		}

		public partial class AsyncDataEventArgs : global::System.EventArgs {

			public AsyncDataEventArgs (global::Orbotix.Robot.Base.DeviceAsyncData p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.DeviceAsyncData p0;
			public global::Orbotix.Robot.Base.DeviceAsyncData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/DeviceMessenger_AsyncDataListenerImplementor")]
		internal sealed class IAsyncDataListenerImplementor : global::Java.Lang.Object, IAsyncDataListener {

			object sender;

			public IAsyncDataListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/DeviceMessenger_AsyncDataListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AsyncDataEventArgs> Handler;
#pragma warning restore 0649

			public void OnDataReceived (global::Orbotix.Robot.Base.DeviceAsyncData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AsyncDataEventArgs (p0));
			}

			internal static bool __IsEmpty (IAsyncDataListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DeviceMessenger.DeviceResponseListener']"
		[Register ("orbotix/robot/base/DeviceMessenger$DeviceResponseListener", "", "Orbotix.Robot.Base.DeviceMessenger/IDeviceResponseListenerInvoker")]
		public partial interface IDeviceResponseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DeviceMessenger.DeviceResponseListener']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceResponse']]"
			[Register ("onResponse", "(Lorbotix/robot/internal/DeviceResponse;)V", "GetOnResponse_Lorbotix_robot_internal_DeviceResponse_Handler:Orbotix.Robot.Base.DeviceMessenger/IDeviceResponseListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnResponse (global::Orbotix.Robot.Internal.DeviceResponse p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/DeviceMessenger$DeviceResponseListener", DoNotGenerateAcw=true)]
		internal class IDeviceResponseListenerInvoker : global::Java.Lang.Object, IDeviceResponseListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/DeviceMessenger$DeviceResponseListener");
			IntPtr class_ref;

			public static IDeviceResponseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDeviceResponseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.DeviceMessenger.DeviceResponseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDeviceResponseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IDeviceResponseListenerInvoker); }
			}

			static Delegate cb_onResponse_Lorbotix_robot_internal_DeviceResponse_;
#pragma warning disable 0169
			static Delegate GetOnResponse_Lorbotix_robot_internal_DeviceResponse_Handler ()
			{
				if (cb_onResponse_Lorbotix_robot_internal_DeviceResponse_ == null)
					cb_onResponse_Lorbotix_robot_internal_DeviceResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Lorbotix_robot_internal_DeviceResponse_);
				return cb_onResponse_Lorbotix_robot_internal_DeviceResponse_;
			}

			static void n_OnResponse_Lorbotix_robot_internal_DeviceResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Internal.DeviceResponse p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResponse_Lorbotix_robot_internal_DeviceResponse_;
			public void OnResponse (global::Orbotix.Robot.Internal.DeviceResponse p0)
			{
				if (id_onResponse_Lorbotix_robot_internal_DeviceResponse_ == IntPtr.Zero)
					id_onResponse_Lorbotix_robot_internal_DeviceResponse_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lorbotix/robot/internal/DeviceResponse;)V");
				JNIEnv.CallVoidMethod (Handle, id_onResponse_Lorbotix_robot_internal_DeviceResponse_, new JValue (p0));
			}

		}

		public partial class DeviceResponseEventArgs : global::System.EventArgs {

			public DeviceResponseEventArgs (global::Orbotix.Robot.Internal.DeviceResponse p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Internal.DeviceResponse p0;
			public global::Orbotix.Robot.Internal.DeviceResponse P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/DeviceMessenger_DeviceResponseListenerImplementor")]
		internal sealed class IDeviceResponseListenerImplementor : global::Java.Lang.Object, IDeviceResponseListener {

			object sender;

			public IDeviceResponseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/DeviceMessenger_DeviceResponseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DeviceResponseEventArgs> Handler;
#pragma warning restore 0649

			public void OnResponse (global::Orbotix.Robot.Internal.DeviceResponse p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DeviceResponseEventArgs (p0));
			}

			internal static bool __IsEmpty (IDeviceResponseListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DeviceMessenger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceMessenger); }
		}

		protected DeviceMessenger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/constructor[@name='DeviceMessenger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected DeviceMessenger () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceMessenger)) {
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

		static IntPtr id_getInstance;
		public static global::Orbotix.Robot.Base.DeviceMessenger Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorbotix/robot/base/DeviceMessenger;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorbotix/robot/base/DeviceMessenger;");
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_;
#pragma warning disable 0169
		static Delegate GetAddAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_Handler ()
		{
			if (cb_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ == null)
				cb_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_);
			return cb_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_;
		}

		static void n_AddAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener p1 = (global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAsyncDataListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='addAsyncDataListener' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.base.DeviceMessenger.AsyncDataListener']]"
		[Register ("addAsyncDataListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$AsyncDataListener;)V", "GetAddAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_Handler")]
		public virtual void AddAsyncDataListener (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener p1)
		{
			if (id_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ == IntPtr.Zero)
				id_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ = JNIEnv.GetMethodID (class_ref, "addAsyncDataListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$AsyncDataListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAsyncDataListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$AsyncDataListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_;
#pragma warning disable 0169
		static Delegate GetAddResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_Handler ()
		{
			if (cb_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ == null)
				cb_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_);
			return cb_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_;
		}

		static void n_AddResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener p1 = (global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddResponseListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='addResponseListener' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.base.DeviceMessenger.DeviceResponseListener']]"
		[Register ("addResponseListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$DeviceResponseListener;)V", "GetAddResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_Handler")]
		public virtual void AddResponseListener (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener p1)
		{
			if (id_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ == IntPtr.Zero)
				id_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ = JNIEnv.GetMethodID (class_ref, "addResponseListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$DeviceResponseListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addResponseListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$DeviceResponseListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_;
#pragma warning disable 0169
		static Delegate GetPostAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_Handler ()
		{
			if (cb_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_ == null)
				cb_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_);
			return cb_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_;
		}

		static void n_PostAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DeviceAsyncData p1 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostAsyncData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='postAsyncData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.base.DeviceAsyncData']]"
		[Register ("postAsyncData", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceAsyncData;)V", "GetPostAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_Handler")]
		public virtual void PostAsyncData (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Base.DeviceAsyncData p1)
		{
			if (id_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_ == IntPtr.Zero)
				id_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_ = JNIEnv.GetMethodID (class_ref, "postAsyncData", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceAsyncData;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postAsyncData_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postAsyncData", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceAsyncData;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_;
#pragma warning disable 0169
		static Delegate GetPostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_Handler ()
		{
			if (cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_ == null)
				cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_);
			return cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_;
		}

		static void n_PostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p1 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='postCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.internal.DeviceCommand']]"
		[Register ("postCommand", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceCommand;)V", "GetPostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_Handler")]
		public virtual void PostCommand (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Internal.DeviceCommand p1)
		{
			if (id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_ == IntPtr.Zero)
				id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_ = JNIEnv.GetMethodID (class_ref, "postCommand", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceCommand;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postCommand", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceCommand;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J;
#pragma warning disable 0169
		static Delegate GetPostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_JHandler ()
		{
			if (cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J == null)
				cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_PostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J);
			return cb_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J;
		}

		static void n_PostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p1 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostCommand (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='postCommand' and count(parameter)=3 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.internal.DeviceCommand'] and parameter[3][@type='long']]"
		[Register ("postCommand", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceCommand;J)V", "GetPostCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_JHandler")]
		public virtual void PostCommand (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Internal.DeviceCommand p1, long p2)
		{
			if (id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J == IntPtr.Zero)
				id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J = JNIEnv.GetMethodID (class_ref, "postCommand", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceCommand;J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceCommand_J, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postCommand", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceCommand;J)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_;
#pragma warning disable 0169
		static Delegate GetPostResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_Handler ()
		{
			if (cb_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ == null)
				cb_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_);
			return cb_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_;
		}

		static void n_PostResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceResponse p1 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostResponse (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='postResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.internal.DeviceResponse']]"
		[Register ("postResponse", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceResponse;)V", "GetPostResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_Handler")]
		public virtual void PostResponse (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Internal.DeviceResponse p1)
		{
			if (id_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ == IntPtr.Zero)
				id_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ = JNIEnv.GetMethodID (class_ref, "postResponse", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postResponse_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postResponse", "(Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceResponse;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_;
#pragma warning disable 0169
		static Delegate GetRemoveAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_Handler ()
		{
			if (cb_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ == null)
				cb_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_);
			return cb_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_;
		}

		static void n_RemoveAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener p1 = (global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAsyncDataListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='removeAsyncDataListener' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.base.DeviceMessenger.AsyncDataListener']]"
		[Register ("removeAsyncDataListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$AsyncDataListener;)V", "GetRemoveAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_Handler")]
		public virtual void RemoveAsyncDataListener (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Base.DeviceMessenger.IAsyncDataListener p1)
		{
			if (id_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ == IntPtr.Zero)
				id_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_ = JNIEnv.GetMethodID (class_ref, "removeAsyncDataListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$AsyncDataListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAsyncDataListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_AsyncDataListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAsyncDataListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$AsyncDataListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_;
#pragma warning disable 0169
		static Delegate GetRemoveResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_Handler ()
		{
			if (cb_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ == null)
				cb_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_);
			return cb_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_;
		}

		static void n_RemoveResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener p1 = (global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveResponseListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='removeResponseListener' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.base.DeviceMessenger.DeviceResponseListener']]"
		[Register ("removeResponseListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$DeviceResponseListener;)V", "GetRemoveResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_Handler")]
		public virtual void RemoveResponseListener (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Base.DeviceMessenger.IDeviceResponseListener p1)
		{
			if (id_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ == IntPtr.Zero)
				id_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_ = JNIEnv.GetMethodID (class_ref, "removeResponseListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$DeviceResponseListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeResponseListener_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceMessenger_DeviceResponseListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeResponseListener", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceMessenger$DeviceResponseListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setMessageHandler_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetSetMessageHandler_Landroid_os_Handler_Handler ()
		{
			if (cb_setMessageHandler_Landroid_os_Handler_ == null)
				cb_setMessageHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageHandler_Landroid_os_Handler_);
			return cb_setMessageHandler_Landroid_os_Handler_;
		}

		static void n_SetMessageHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DeviceMessenger __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageHandler_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceMessenger']/method[@name='setMessageHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setMessageHandler", "(Landroid/os/Handler;)V", "GetSetMessageHandler_Landroid_os_Handler_Handler")]
		public virtual void SetMessageHandler (global::Android.OS.Handler p0)
		{
			if (id_setMessageHandler_Landroid_os_Handler_ == IntPtr.Zero)
				id_setMessageHandler_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "setMessageHandler", "(Landroid/os/Handler;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMessageHandler_Landroid_os_Handler_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageHandler", "(Landroid/os/Handler;)V"), new JValue (p0));
		}

	}
}
