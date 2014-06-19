using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.sphero']/interface[@name='ConnectionListener']"
	[Register ("orbotix/sphero/ConnectionListener", "", "Orbotix.Sphero.IConnectionListenerInvoker")]
	public partial interface IConnectionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='ConnectionListener']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("onConnected", "(Lorbotix/robot/base/Robot;)V", "GetOnConnected_Lorbotix_robot_base_Robot_Handler:Orbotix.Sphero.IConnectionListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void OnConnected (global::Orbotix.Robot.Base.Robot p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='ConnectionListener']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("onConnectionFailed", "(Lorbotix/robot/base/Robot;)V", "GetOnConnectionFailed_Lorbotix_robot_base_Robot_Handler:Orbotix.Sphero.IConnectionListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void OnConnectionFailed (global::Orbotix.Robot.Base.Robot p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='ConnectionListener']/method[@name='onDisconnected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("onDisconnected", "(Lorbotix/robot/base/Robot;)V", "GetOnDisconnected_Lorbotix_robot_base_Robot_Handler:Orbotix.Sphero.IConnectionListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void OnDisconnected (global::Orbotix.Robot.Base.Robot p0);

	}

	[global::Android.Runtime.Register ("orbotix/sphero/ConnectionListener", DoNotGenerateAcw=true)]
	internal class IConnectionListenerInvoker : global::Java.Lang.Object, IConnectionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/sphero/ConnectionListener");
		IntPtr class_ref;

		public static IConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.sphero.ConnectionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IConnectionListenerInvoker); }
		}

		static Delegate cb_onConnected_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_onConnected_Lorbotix_robot_base_Robot_ == null)
				cb_onConnected_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Lorbotix_robot_base_Robot_);
			return cb_onConnected_Lorbotix_robot_base_Robot_;
		}

		static void n_OnConnected_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnected_Lorbotix_robot_base_Robot_;
		public void OnConnected (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_onConnected_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_onConnected_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnected_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static Delegate cb_onConnectionFailed_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_onConnectionFailed_Lorbotix_robot_base_Robot_ == null)
				cb_onConnectionFailed_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionFailed_Lorbotix_robot_base_Robot_);
			return cb_onConnectionFailed_Lorbotix_robot_base_Robot_;
		}

		static void n_OnConnectionFailed_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionFailed_Lorbotix_robot_base_Robot_;
		public void OnConnectionFailed (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_onConnectionFailed_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_onConnectionFailed_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnectionFailed_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static Delegate cb_onDisconnected_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_onDisconnected_Lorbotix_robot_base_Robot_ == null)
				cb_onDisconnected_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lorbotix_robot_base_Robot_);
			return cb_onDisconnected_Lorbotix_robot_base_Robot_;
		}

		static void n_OnDisconnected_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected_Lorbotix_robot_base_Robot_;
		public void OnDisconnected (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_onDisconnected_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_onDisconnected_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Lorbotix/robot/base/Robot;)V");
			JNIEnv.CallVoidMethod (Handle, id_onDisconnected_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

	}

	public partial class ConnectedEventArgs : global::System.EventArgs {

		public ConnectedEventArgs (global::Orbotix.Robot.Base.Robot p0)
		{
			this.p0 = p0;
		}

		global::Orbotix.Robot.Base.Robot p0;
		public global::Orbotix.Robot.Base.Robot P0 {
			get { return p0; }
		}
	}

	public partial class ConnectionFailedEventArgs : global::System.EventArgs {

		public ConnectionFailedEventArgs (global::Orbotix.Robot.Base.Robot p0)
		{
			this.p0 = p0;
		}

		global::Orbotix.Robot.Base.Robot p0;
		public global::Orbotix.Robot.Base.Robot P0 {
			get { return p0; }
		}
	}

	public partial class DisconnectedEventArgs : global::System.EventArgs {

		public DisconnectedEventArgs (global::Orbotix.Robot.Base.Robot p0)
		{
			this.p0 = p0;
		}

		global::Orbotix.Robot.Base.Robot p0;
		public global::Orbotix.Robot.Base.Robot P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/orbotix/sphero/ConnectionListenerImplementor")]
	internal sealed class IConnectionListenerImplementor : global::Java.Lang.Object, IConnectionListener {

		object sender;

		public IConnectionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/sphero/ConnectionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectedEventArgs> OnConnectedHandler;
#pragma warning restore 0649

		public void OnConnected (global::Orbotix.Robot.Base.Robot p0)
		{
			var __h = OnConnectedHandler;
			if (__h != null)
				__h (sender, new ConnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ConnectionFailedEventArgs> OnConnectionFailedHandler;
#pragma warning restore 0649

		public void OnConnectionFailed (global::Orbotix.Robot.Base.Robot p0)
		{
			var __h = OnConnectionFailedHandler;
			if (__h != null)
				__h (sender, new ConnectionFailedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<DisconnectedEventArgs> OnDisconnectedHandler;
#pragma warning restore 0649

		public void OnDisconnected (global::Orbotix.Robot.Base.Robot p0)
		{
			var __h = OnDisconnectedHandler;
			if (__h != null)
				__h (sender, new DisconnectedEventArgs (p0));
		}

		internal static bool __IsEmpty (IConnectionListenerImplementor value)
		{
			return value.OnConnectedHandler == null && value.OnConnectionFailedHandler == null && value.OnDisconnectedHandler == null;
		}
	}

}
