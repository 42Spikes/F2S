using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']"
	[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView", DoNotGenerateAcw=true)]
	public partial class SpheroConnectionView : global::Android.Widget.RelativeLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.ConnectionState']"
		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$ConnectionState", DoNotGenerateAcw=true)]
		public sealed partial class ConnectionState : global::Java.Lang.Enum {


			static IntPtr CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.ConnectionState']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState Connected {
				get {
					if (CONNECTED_jfieldId == IntPtr.Zero)
						CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTED", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONNECTED_jfieldId == IntPtr.Zero)
						CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTED", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONNECTED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CONNECTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.ConnectionState']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState Connecting {
				get {
					if (CONNECTING_jfieldId == IntPtr.Zero)
						CONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONNECTING_jfieldId == IntPtr.Zero)
						CONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONNECTING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DISCONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.ConnectionState']/field[@name='DISCONNECTED']"
			[Register ("DISCONNECTED")]
			public static global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState Disconnected {
				get {
					if (DISCONNECTED_jfieldId == IntPtr.Zero)
						DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTED", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DISCONNECTED_jfieldId == IntPtr.Zero)
						DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTED", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DISCONNECTED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.ConnectionState']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lorbotix/view/connection/SpheroConnectionView$ConnectionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FAILED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$ConnectionState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectionState); }
			}

			internal ConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.view.connection']/interface[@name='SpheroConnectionView.OnRobotConnectionEventListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/view/connection/SpheroConnectionView$OnRobotConnectionEventListener", "", "Orbotix.View.Connection.SpheroConnectionView/IOnRobotConnectionEventListenerInvoker")]
		public partial interface IOnRobotConnectionEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/interface[@name='SpheroConnectionView.OnRobotConnectionEventListener']/method[@name='onBluetoothNotEnabled' and count(parameter)=0]"
[Obsolete (@"deprecated")]
			[Register ("onBluetoothNotEnabled", "()V", "GetOnBluetoothNotEnabledHandler:Orbotix.View.Connection.SpheroConnectionView/IOnRobotConnectionEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnBluetoothNotEnabled ();

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/interface[@name='SpheroConnectionView.OnRobotConnectionEventListener']/method[@name='onNonePaired' and count(parameter)=0]"
[Obsolete (@"deprecated")]
			[Register ("onNonePaired", "()V", "GetOnNonePairedHandler:Orbotix.View.Connection.SpheroConnectionView/IOnRobotConnectionEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnNonePaired ();

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/interface[@name='SpheroConnectionView.OnRobotConnectionEventListener']/method[@name='onRobotConnected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
[Obsolete (@"deprecated")]
			[Register ("onRobotConnected", "(Lorbotix/robot/base/Robot;)V", "GetOnRobotConnected_Lorbotix_robot_base_Robot_Handler:Orbotix.View.Connection.SpheroConnectionView/IOnRobotConnectionEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnRobotConnected (global::Orbotix.Robot.Base.Robot p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/interface[@name='SpheroConnectionView.OnRobotConnectionEventListener']/method[@name='onRobotConnectionFailed' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
[Obsolete (@"deprecated")]
			[Register ("onRobotConnectionFailed", "(Lorbotix/robot/base/Robot;)V", "GetOnRobotConnectionFailed_Lorbotix_robot_base_Robot_Handler:Orbotix.View.Connection.SpheroConnectionView/IOnRobotConnectionEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnRobotConnectionFailed (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$OnRobotConnectionEventListener", DoNotGenerateAcw=true)]
		internal class IOnRobotConnectionEventListenerInvoker : global::Java.Lang.Object, IOnRobotConnectionEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$OnRobotConnectionEventListener");
			IntPtr class_ref;

			public static IOnRobotConnectionEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRobotConnectionEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.view.connection.SpheroConnectionView.OnRobotConnectionEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRobotConnectionEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRobotConnectionEventListenerInvoker); }
			}

			static Delegate cb_onBluetoothNotEnabled;
#pragma warning disable 0169
			static Delegate GetOnBluetoothNotEnabledHandler ()
			{
				if (cb_onBluetoothNotEnabled == null)
					cb_onBluetoothNotEnabled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBluetoothNotEnabled);
				return cb_onBluetoothNotEnabled;
			}

			static void n_OnBluetoothNotEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBluetoothNotEnabled ();
			}
#pragma warning restore 0169

			IntPtr id_onBluetoothNotEnabled;
			public void OnBluetoothNotEnabled ()
			{
				if (id_onBluetoothNotEnabled == IntPtr.Zero)
					id_onBluetoothNotEnabled = JNIEnv.GetMethodID (class_ref, "onBluetoothNotEnabled", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onBluetoothNotEnabled);
			}

			static Delegate cb_onNonePaired;
#pragma warning disable 0169
			static Delegate GetOnNonePairedHandler ()
			{
				if (cb_onNonePaired == null)
					cb_onNonePaired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNonePaired);
				return cb_onNonePaired;
			}

			static void n_OnNonePaired (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNonePaired ();
			}
#pragma warning restore 0169

			IntPtr id_onNonePaired;
			public void OnNonePaired ()
			{
				if (id_onNonePaired == IntPtr.Zero)
					id_onNonePaired = JNIEnv.GetMethodID (class_ref, "onNonePaired", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onNonePaired);
			}

			static Delegate cb_onRobotConnected_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
			static Delegate GetOnRobotConnected_Lorbotix_robot_base_Robot_Handler ()
			{
				if (cb_onRobotConnected_Lorbotix_robot_base_Robot_ == null)
					cb_onRobotConnected_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRobotConnected_Lorbotix_robot_base_Robot_);
				return cb_onRobotConnected_Lorbotix_robot_base_Robot_;
			}

			static void n_OnRobotConnected_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRobotConnected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRobotConnected_Lorbotix_robot_base_Robot_;
			public void OnRobotConnected (global::Orbotix.Robot.Base.Robot p0)
			{
				if (id_onRobotConnected_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_onRobotConnected_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onRobotConnected", "(Lorbotix/robot/base/Robot;)V");
				JNIEnv.CallVoidMethod (Handle, id_onRobotConnected_Lorbotix_robot_base_Robot_, new JValue (p0));
			}

			static Delegate cb_onRobotConnectionFailed_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
			static Delegate GetOnRobotConnectionFailed_Lorbotix_robot_base_Robot_Handler ()
			{
				if (cb_onRobotConnectionFailed_Lorbotix_robot_base_Robot_ == null)
					cb_onRobotConnectionFailed_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRobotConnectionFailed_Lorbotix_robot_base_Robot_);
				return cb_onRobotConnectionFailed_Lorbotix_robot_base_Robot_;
			}

			static void n_OnRobotConnectionFailed_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRobotConnectionFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRobotConnectionFailed_Lorbotix_robot_base_Robot_;
			public void OnRobotConnectionFailed (global::Orbotix.Robot.Base.Robot p0)
			{
				if (id_onRobotConnectionFailed_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_onRobotConnectionFailed_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onRobotConnectionFailed", "(Lorbotix/robot/base/Robot;)V");
				JNIEnv.CallVoidMethod (Handle, id_onRobotConnectionFailed_Lorbotix_robot_base_Robot_, new JValue (p0));
			}

		}

		public partial class RobotConnectedEventArgs : global::System.EventArgs {

			public RobotConnectedEventArgs (global::Orbotix.Robot.Base.Robot p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.Robot p0;
			public global::Orbotix.Robot.Base.Robot P0 {
				get { return p0; }
			}
		}

		public partial class RobotConnectionFailedEventArgs : global::System.EventArgs {

			public RobotConnectionFailedEventArgs (global::Orbotix.Robot.Base.Robot p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.Robot p0;
			public global::Orbotix.Robot.Base.Robot P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/view/connection/SpheroConnectionView_OnRobotConnectionEventListenerImplementor")]
		internal sealed class IOnRobotConnectionEventListenerImplementor : global::Java.Lang.Object, IOnRobotConnectionEventListener {

			object sender;

			public IOnRobotConnectionEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/view/connection/SpheroConnectionView_OnRobotConnectionEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnBluetoothNotEnabledHandler;
#pragma warning restore 0649

			public void OnBluetoothNotEnabled ()
			{
				var __h = OnBluetoothNotEnabledHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnNonePairedHandler;
#pragma warning restore 0649

			public void OnNonePaired ()
			{
				var __h = OnNonePairedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<RobotConnectedEventArgs> OnRobotConnectedHandler;
#pragma warning restore 0649

			public void OnRobotConnected (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = OnRobotConnectedHandler;
				if (__h != null)
					__h (sender, new RobotConnectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<RobotConnectionFailedEventArgs> OnRobotConnectionFailedHandler;
#pragma warning restore 0649

			public void OnRobotConnectionFailed (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = OnRobotConnectionFailedHandler;
				if (__h != null)
					__h (sender, new RobotConnectionFailedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRobotConnectionEventListenerImplementor value)
			{
				return value.OnBluetoothNotEnabledHandler == null && value.OnNonePairedHandler == null && value.OnRobotConnectedHandler == null && value.OnRobotConnectionFailedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroItemView']"
		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$SpheroItemView", DoNotGenerateAcw=true)]
		public partial class SpheroItemView : global::Android.Widget.RelativeLayout {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$SpheroItemView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpheroItemView); }
			}

			protected SpheroItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroItemView']/constructor[@name='SpheroConnectionView.SpheroItemView' and count(parameter)=2 and parameter[1][@type='orbotix.view.connection.SpheroConnectionView'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lorbotix/view/connection/SpheroConnectionView;Landroid/content/Context;)V", "")]
			public SpheroItemView (global::Orbotix.View.Connection.SpheroConnectionView __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (SpheroItemView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/connection/SpheroConnectionView;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_, new JValue (__self), new JValue (p1));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']"
		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$SpheroListAdapter", DoNotGenerateAcw=true)]
		public partial class SpheroListAdapter : global::Android.Widget.BaseAdapter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$SpheroListAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpheroListAdapter); }
			}

			protected SpheroListAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getConnectedRobots;
#pragma warning disable 0169
			static Delegate GetGetConnectedRobotsHandler ()
			{
				if (cb_getConnectedRobots == null)
					cb_getConnectedRobots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedRobots);
				return cb_getConnectedRobots;
			}

			static IntPtr n_GetConnectedRobots (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.ToLocalJniHandle (__this.ConnectedRobots);
			}
#pragma warning restore 0169

			static IntPtr id_getConnectedRobots;
			public virtual global::System.Collections.Generic.IList<global::Orbotix.Robot.Base.Robot> ConnectedRobots {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='getConnectedRobots' and count(parameter)=0]"
				[Register ("getConnectedRobots", "()Ljava/util/List;", "GetGetConnectedRobotsHandler")]
				get {
					if (id_getConnectedRobots == IntPtr.Zero)
						id_getConnectedRobots = JNIEnv.GetMethodID (class_ref, "getConnectedRobots", "()Ljava/util/List;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConnectedRobots), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedRobots", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getCount;
#pragma warning disable 0169
			static Delegate GetGetCountHandler ()
			{
				if (cb_getCount == null)
					cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
				return cb_getCount;
			}

			static int n_GetCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count;
			}
#pragma warning restore 0169

			static IntPtr id_getCount;
			public override int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "GetGetCountHandler")]
				get {
					if (id_getCount == IntPtr.Zero)
						id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				}
			}

			static Delegate cb_isConnected;
#pragma warning disable 0169
			static Delegate GetIsConnectedHandler ()
			{
				if (cb_isConnected == null)
					cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
				return cb_isConnected;
			}

			static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsConnected;
			}
#pragma warning restore 0169

			static IntPtr id_isConnected;
			public virtual bool IsConnected {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='isConnected' and count(parameter)=0]"
				[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
				get {
					if (id_isConnected == IntPtr.Zero)
						id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				}
			}

			static Delegate cb_isConnecting;
#pragma warning disable 0169
			static Delegate GetIsConnectingHandler ()
			{
				if (cb_isConnecting == null)
					cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
				return cb_isConnecting;
			}

			static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsConnecting;
			}
#pragma warning restore 0169

			static IntPtr id_isConnecting;
			public virtual bool IsConnecting {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='isConnecting' and count(parameter)=0]"
				[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
				get {
					if (id_isConnecting == IntPtr.Zero)
						id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isConnecting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnecting", "()Z"));
				}
			}

			static Delegate cb_getItem_I;
#pragma warning disable 0169
			static Delegate GetGetItem_IHandler ()
			{
				if (cb_getItem_I == null)
					cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
				return cb_getItem_I;
			}

			static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
			public override global::Java.Lang.Object GetItem (int p0)
			{
				if (id_getItem_I == IntPtr.Zero)
					id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getItemId_I;
#pragma warning disable 0169
			static Delegate GetGetItemId_IHandler ()
			{
				if (cb_getItemId_I == null)
					cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
				return cb_getItemId_I;
			}

			static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetItemId (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getItemId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
			public override long GetItemId (int p0)
			{
				if (id_getItemId_I == IntPtr.Zero)
					id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getItemId_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), new JValue (p0));
			}

			static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
			static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
			{
				if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
					cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
				return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			}

			static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
			[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
			public override global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
			{
				if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
					id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setSpheroWrappers_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetSpheroWrappers_Ljava_util_List_Handler ()
			{
				if (cb_setSpheroWrappers_Ljava_util_List_ == null)
					cb_setSpheroWrappers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpheroWrappers_Ljava_util_List_);
				return cb_setSpheroWrappers_Ljava_util_List_;
			}

			static void n_SetSpheroWrappers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper> p0 = global::Android.Runtime.JavaList<global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetSpheroWrappers (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setSpheroWrappers_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListAdapter']/method[@name='setSpheroWrappers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setSpheroWrappers", "(Ljava/util/List;)V", "GetSetSpheroWrappers_Ljava_util_List_Handler")]
			public virtual void SetSpheroWrappers (global::System.Collections.Generic.IList<global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper> p0)
			{
				if (id_setSpheroWrappers_Ljava_util_List_ == IntPtr.Zero)
					id_setSpheroWrappers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSpheroWrappers", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper>.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSpheroWrappers_Ljava_util_List_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpheroWrappers", "(Ljava/util/List;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListItemClickListener']"
		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$SpheroListItemClickListener", DoNotGenerateAcw=true)]
		public partial class SpheroListItemClickListener : global::Java.Lang.Object, global::Android.Widget.AdapterView.IOnItemClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$SpheroListItemClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpheroListItemClickListener); }
			}

			protected SpheroListItemClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
			static Delegate GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
			{
				if (cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
					cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ);
				return cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
			}

			static void n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroListItemClickListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroListItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnItemClick (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListItemClickListener']/method[@name='onItemClick' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register ("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
			public virtual void OnItemClick (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3)
			{
				if (id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == IntPtr.Zero)
					id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListView']"
		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$SpheroListView", DoNotGenerateAcw=true)]
		public partial class SpheroListView : global::Android.Widget.ListView {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$SpheroListView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpheroListView); }
			}

			protected SpheroListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroListView']/constructor[@name='SpheroConnectionView.SpheroListView' and count(parameter)=2 and parameter[1][@type='orbotix.view.connection.SpheroConnectionView'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lorbotix/view/connection/SpheroConnectionView;Landroid/content/Context;)V", "")]
			public SpheroListView (global::Orbotix.View.Connection.SpheroConnectionView __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (SpheroListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/connection/SpheroConnectionView;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_connection_SpheroConnectionView_Landroid_content_Context_, new JValue (__self), new JValue (p1));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroWrapper']"
		[global::Android.Runtime.Register ("orbotix/view/connection/SpheroConnectionView$SpheroWrapper", DoNotGenerateAcw=true)]
		public partial class SpheroWrapper : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView$SpheroWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpheroWrapper); }
			}

			protected SpheroWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_connection_SpheroConnectionView_Lorbotix_robot_base_Robot_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroWrapper']/constructor[@name='SpheroConnectionView.SpheroWrapper' and count(parameter)=2 and parameter[1][@type='orbotix.view.connection.SpheroConnectionView'] and parameter[2][@type='orbotix.robot.base.Robot']]"
			[Register (".ctor", "(Lorbotix/view/connection/SpheroConnectionView;Lorbotix/robot/base/Robot;)V", "")]
			public SpheroWrapper (global::Orbotix.View.Connection.SpheroConnectionView __self, global::Orbotix.Robot.Base.Robot p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (SpheroWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorbotix/robot/base/Robot;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorbotix/robot/base/Robot;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorbotix_view_connection_SpheroConnectionView_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_connection_SpheroConnectionView_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/connection/SpheroConnectionView;Lorbotix/robot/base/Robot;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_connection_SpheroConnectionView_Lorbotix_robot_base_Robot_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_connection_SpheroConnectionView_Lorbotix_robot_base_Robot_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_getRobot;
#pragma warning disable 0169
			static Delegate GetGetRobotHandler ()
			{
				if (cb_getRobot == null)
					cb_getRobot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobot);
				return cb_getRobot;
			}

			static IntPtr n_GetRobot (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Robot);
			}
#pragma warning restore 0169

			static IntPtr id_getRobot;
			public virtual global::Orbotix.Robot.Base.Robot Robot {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroWrapper']/method[@name='getRobot' and count(parameter)=0]"
				[Register ("getRobot", "()Lorbotix/robot/base/Robot;", "GetGetRobotHandler")]
				get {
					if (id_getRobot == IntPtr.Zero)
						id_getRobot = JNIEnv.GetMethodID (class_ref, "getRobot", "()Lorbotix/robot/base/Robot;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (JNIEnv.CallObjectMethod  (Handle, id_getRobot), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobot", "()Lorbotix/robot/base/Robot;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getConnectionStateView_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetGetConnectionStateView_Landroid_content_Context_Handler ()
			{
				if (cb_getConnectionStateView_Landroid_content_Context_ == null)
					cb_getConnectionStateView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnectionStateView_Landroid_content_Context_);
				return cb_getConnectionStateView_Landroid_content_Context_;
			}

			static IntPtr n_GetConnectionStateView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.SpheroWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionStateView (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getConnectionStateView_Landroid_content_Context_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView.SpheroWrapper']/method[@name='getConnectionStateView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("getConnectionStateView", "(Landroid/content/Context;)Landroid/view/View;", "GetGetConnectionStateView_Landroid_content_Context_Handler")]
			public virtual global::Android.Views.View GetConnectionStateView (global::Android.Content.Context p0)
			{
				if (id_getConnectionStateView_Landroid_content_Context_ == IntPtr.Zero)
					id_getConnectionStateView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getConnectionStateView", "(Landroid/content/Context;)Landroid/view/View;");

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getConnectionStateView_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionStateView", "(Landroid/content/Context;)Landroid/view/View;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/connection/SpheroConnectionView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpheroConnectionView); }
		}

		protected SpheroConnectionView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/constructor[@name='SpheroConnectionView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public SpheroConnectionView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpheroConnectionView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/constructor[@name='SpheroConnectionView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public SpheroConnectionView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpheroConnectionView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getConnectedRobots;
#pragma warning disable 0169
		static Delegate GetGetConnectedRobotsHandler ()
		{
			if (cb_getConnectedRobots == null)
				cb_getConnectedRobots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedRobots);
			return cb_getConnectedRobots;
		}

		static IntPtr n_GetConnectedRobots (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.ToLocalJniHandle (__this.ConnectedRobots);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedRobots;
		public virtual global::System.Collections.Generic.IList<global::Orbotix.Robot.Base.Robot> ConnectedRobots {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='getConnectedRobots' and count(parameter)=0]"
			[Register ("getConnectedRobots", "()Ljava/util/List;", "GetGetConnectedRobotsHandler")]
			get {
				if (id_getConnectedRobots == IntPtr.Zero)
					id_getConnectedRobots = JNIEnv.GetMethodID (class_ref, "getConnectedRobots", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConnectedRobots), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedRobots", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addConnectionListener_Lorbotix_sphero_ConnectionListener_;
#pragma warning disable 0169
		static Delegate GetAddConnectionListener_Lorbotix_sphero_ConnectionListener_Handler ()
		{
			if (cb_addConnectionListener_Lorbotix_sphero_ConnectionListener_ == null)
				cb_addConnectionListener_Lorbotix_sphero_ConnectionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddConnectionListener_Lorbotix_sphero_ConnectionListener_);
			return cb_addConnectionListener_Lorbotix_sphero_ConnectionListener_;
		}

		static void n_AddConnectionListener_Lorbotix_sphero_ConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IConnectionListener p0 = (global::Orbotix.Sphero.IConnectionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddConnectionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addConnectionListener_Lorbotix_sphero_ConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='addConnectionListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.ConnectionListener']]"
		[Register ("addConnectionListener", "(Lorbotix/sphero/ConnectionListener;)V", "GetAddConnectionListener_Lorbotix_sphero_ConnectionListener_Handler")]
		public virtual void AddConnectionListener (global::Orbotix.Sphero.IConnectionListener p0)
		{
			if (id_addConnectionListener_Lorbotix_sphero_ConnectionListener_ == IntPtr.Zero)
				id_addConnectionListener_Lorbotix_sphero_ConnectionListener_ = JNIEnv.GetMethodID (class_ref, "addConnectionListener", "(Lorbotix/sphero/ConnectionListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addConnectionListener_Lorbotix_sphero_ConnectionListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addConnectionListener", "(Lorbotix/sphero/ConnectionListener;)V"), new JValue (p0));
		}

		static Delegate cb_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetAddDiscoveryListener_Lorbotix_sphero_DiscoveryListener_Handler ()
		{
			if (cb_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ == null)
				cb_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddDiscoveryListener_Lorbotix_sphero_DiscoveryListener_);
			return cb_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
		}

		static void n_AddDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IDiscoveryListener p0 = (global::Orbotix.Sphero.IDiscoveryListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddDiscoveryListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='addDiscoveryListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.DiscoveryListener']]"
		[Register ("addDiscoveryListener", "(Lorbotix/sphero/DiscoveryListener;)V", "GetAddDiscoveryListener_Lorbotix_sphero_DiscoveryListener_Handler")]
		public virtual void AddDiscoveryListener (global::Orbotix.Sphero.IDiscoveryListener p0)
		{
			if (id_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ == IntPtr.Zero)
				id_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ = JNIEnv.GetMethodID (class_ref, "addDiscoveryListener", "(Lorbotix/sphero/DiscoveryListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDiscoveryListener", "(Lorbotix/sphero/DiscoveryListener;)V"), new JValue (p0));
		}

		static Delegate cb_clearListeners;
#pragma warning disable 0169
		static Delegate GetClearListenersHandler ()
		{
			if (cb_clearListeners == null)
				cb_clearListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearListeners);
			return cb_clearListeners;
		}

		static void n_ClearListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_clearListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='clearListeners' and count(parameter)=0]"
		[Register ("clearListeners", "()V", "GetClearListenersHandler")]
		public virtual void ClearListeners ()
		{
			if (id_clearListeners == IntPtr.Zero)
				id_clearListeners = JNIEnv.GetMethodID (class_ref, "clearListeners", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearListeners);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearListeners", "()V"));
		}

		static Delegate cb_enableToast_Z;
#pragma warning disable 0169
		static Delegate GetEnableToast_ZHandler ()
		{
			if (cb_enableToast_Z == null)
				cb_enableToast_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableToast_Z);
			return cb_enableToast_Z;
		}

		static void n_EnableToast_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableToast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableToast_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='enableToast' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableToast", "(Z)V", "GetEnableToast_ZHandler")]
		public virtual void EnableToast (bool p0)
		{
			if (id_enableToast_Z == IntPtr.Zero)
				id_enableToast_Z = JNIEnv.GetMethodID (class_ref, "enableToast", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableToast_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableToast", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_removeConnectionListener_Lorbotix_sphero_ConnectionListener_;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionListener_Lorbotix_sphero_ConnectionListener_Handler ()
		{
			if (cb_removeConnectionListener_Lorbotix_sphero_ConnectionListener_ == null)
				cb_removeConnectionListener_Lorbotix_sphero_ConnectionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveConnectionListener_Lorbotix_sphero_ConnectionListener_);
			return cb_removeConnectionListener_Lorbotix_sphero_ConnectionListener_;
		}

		static void n_RemoveConnectionListener_Lorbotix_sphero_ConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IConnectionListener p0 = (global::Orbotix.Sphero.IConnectionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeConnectionListener_Lorbotix_sphero_ConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='removeConnectionListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.ConnectionListener']]"
		[Register ("removeConnectionListener", "(Lorbotix/sphero/ConnectionListener;)V", "GetRemoveConnectionListener_Lorbotix_sphero_ConnectionListener_Handler")]
		public virtual void RemoveConnectionListener (global::Orbotix.Sphero.IConnectionListener p0)
		{
			if (id_removeConnectionListener_Lorbotix_sphero_ConnectionListener_ == IntPtr.Zero)
				id_removeConnectionListener_Lorbotix_sphero_ConnectionListener_ = JNIEnv.GetMethodID (class_ref, "removeConnectionListener", "(Lorbotix/sphero/ConnectionListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeConnectionListener_Lorbotix_sphero_ConnectionListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeConnectionListener", "(Lorbotix/sphero/ConnectionListener;)V"), new JValue (p0));
		}

		static Delegate cb_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetRemoveDiscoveryListener_Lorbotix_sphero_DiscoveryListener_Handler ()
		{
			if (cb_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ == null)
				cb_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveDiscoveryListener_Lorbotix_sphero_DiscoveryListener_);
			return cb_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
		}

		static void n_RemoveDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IDiscoveryListener p0 = (global::Orbotix.Sphero.IDiscoveryListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDiscoveryListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='removeDiscoveryListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.DiscoveryListener']]"
		[Register ("removeDiscoveryListener", "(Lorbotix/sphero/DiscoveryListener;)V", "GetRemoveDiscoveryListener_Lorbotix_sphero_DiscoveryListener_Handler")]
		public virtual void RemoveDiscoveryListener (global::Orbotix.Sphero.IDiscoveryListener p0)
		{
			if (id_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ == IntPtr.Zero)
				id_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_ = JNIEnv.GetMethodID (class_ref, "removeDiscoveryListener", "(Lorbotix/sphero/DiscoveryListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeDiscoveryListener", "(Lorbotix/sphero/DiscoveryListener;)V"), new JValue (p0));
		}

		static Delegate cb_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectedSuccessDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setConnectedSuccessDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setConnectedSuccessDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetConnectedSuccessDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setConnectedSuccessDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConnectedSuccessDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectedSuccessDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionFailedDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setConnectionFailedDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setConnectionFailedDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetConnectionFailedDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setConnectionFailedDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConnectionFailedDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectionFailedDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNotYetConnectedDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setNotYetConnectedDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setNotYetConnectedDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetNotYetConnectedDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setNotYetConnectedDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNotYetConnectedDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotYetConnectedDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_Handler ()
		{
			if (cb_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_ == null)
				cb_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_);
			return cb_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_;
		}

		static void n_SetOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener p0 = (global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener)global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRobotConnectionEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setOnRobotConnectionEventListener' and count(parameter)=1 and parameter[1][@type='orbotix.view.connection.SpheroConnectionView.OnRobotConnectionEventListener']]"
		[Register ("setOnRobotConnectionEventListener", "(Lorbotix/view/connection/SpheroConnectionView$OnRobotConnectionEventListener;)V", "GetSetOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_Handler")]
		public virtual void SetOnRobotConnectionEventListener (global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener p0)
		{
			if (id_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_ == IntPtr.Zero)
				id_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_ = JNIEnv.GetMethodID (class_ref, "setOnRobotConnectionEventListener", "(Lorbotix/view/connection/SpheroConnectionView$OnRobotConnectionEventListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRobotConnectionEventListener_Lorbotix_view_connection_SpheroConnectionView_OnRobotConnectionEventListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRobotConnectionEventListener", "(Lorbotix/view/connection/SpheroConnectionView$OnRobotConnectionEventListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOneAtATimeMode_Z;
#pragma warning disable 0169
		static Delegate GetSetOneAtATimeMode_ZHandler ()
		{
			if (cb_setOneAtATimeMode_Z == null)
				cb_setOneAtATimeMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOneAtATimeMode_Z);
			return cb_setOneAtATimeMode_Z;
		}

		static void n_SetOneAtATimeMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOneAtATimeMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOneAtATimeMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setOneAtATimeMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOneAtATimeMode", "(Z)V", "GetSetOneAtATimeMode_ZHandler")]
		public virtual void SetOneAtATimeMode (bool p0)
		{
			if (id_setOneAtATimeMode_Z == IntPtr.Zero)
				id_setOneAtATimeMode_Z = JNIEnv.GetMethodID (class_ref, "setOneAtATimeMode", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOneAtATimeMode_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOneAtATimeMode", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRowBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setRowBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setRowBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetRowBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setRowBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRowBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRowBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setSingleSpheroMode_Z;
#pragma warning disable 0169
		static Delegate GetSetSingleSpheroMode_ZHandler ()
		{
			if (cb_setSingleSpheroMode_Z == null)
				cb_setSingleSpheroMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSingleSpheroMode_Z);
			return cb_setSingleSpheroMode_Z;
		}

		static void n_SetSingleSpheroMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSingleSpheroMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSingleSpheroMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setSingleSpheroMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSingleSpheroMode", "(Z)V", "GetSetSingleSpheroMode_ZHandler")]
		public virtual void SetSingleSpheroMode (bool p0)
		{
			if (id_setSingleSpheroMode_Z == IntPtr.Zero)
				id_setSingleSpheroMode_Z = JNIEnv.GetMethodID (class_ref, "setSingleSpheroMode", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSingleSpheroMode_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleSpheroMode", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
		public virtual void SetTextColor (int p0)
		{
			if (id_setTextColor_I == IntPtr.Zero)
				id_setTextColor_I = JNIEnv.GetMethodID (class_ref, "setTextColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTextColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual void SetTitle (string p0)
		{
			if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_showSpheros;
#pragma warning disable 0169
		static Delegate GetShowSpherosHandler ()
		{
			if (cb_showSpheros == null)
				cb_showSpheros = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowSpheros);
			return cb_showSpheros;
		}

		static void n_ShowSpheros (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSpheros ();
		}
#pragma warning restore 0169

		static IntPtr id_showSpheros;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='showSpheros' and count(parameter)=0]"
		[Register ("showSpheros", "()V", "GetShowSpherosHandler")]
		public virtual void ShowSpheros ()
		{
			if (id_showSpheros == IntPtr.Zero)
				id_showSpheros = JNIEnv.GetMethodID (class_ref, "showSpheros", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showSpheros);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSpheros", "()V"));
		}

		static Delegate cb_startDiscovery;
#pragma warning disable 0169
		static Delegate GetStartDiscoveryHandler ()
		{
			if (cb_startDiscovery == null)
				cb_startDiscovery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDiscovery);
			return cb_startDiscovery;
		}

		static void n_StartDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Connection.SpheroConnectionView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Connection.SpheroConnectionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_startDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.connection']/class[@name='SpheroConnectionView']/method[@name='startDiscovery' and count(parameter)=0]"
		[Register ("startDiscovery", "()V", "GetStartDiscoveryHandler")]
		public virtual void StartDiscovery ()
		{
			if (id_startDiscovery == IntPtr.Zero)
				id_startDiscovery = JNIEnv.GetMethodID (class_ref, "startDiscovery", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startDiscovery);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDiscovery", "()V"));
		}

#region "Event implementation for Orbotix.Sphero.IConnectionListener"
		public event EventHandler<global::Orbotix.Sphero.ConnectedEventArgs> Connected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.IConnectionListener, global::Orbotix.Sphero.IConnectionListenerImplementor>(
						ref weak_implementor_AddConnectionListener,
						__CreateIConnectionListenerImplementor,
						AddConnectionListener,
						__h => __h.OnConnectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.IConnectionListener, global::Orbotix.Sphero.IConnectionListenerImplementor>(
						ref weak_implementor_AddConnectionListener,
						global::Orbotix.Sphero.IConnectionListenerImplementor.__IsEmpty,
						RemoveConnectionListener,
						__h => __h.OnConnectedHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Sphero.ConnectionFailedEventArgs> ConnectionFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.IConnectionListener, global::Orbotix.Sphero.IConnectionListenerImplementor>(
						ref weak_implementor_AddConnectionListener,
						__CreateIConnectionListenerImplementor,
						AddConnectionListener,
						__h => __h.OnConnectionFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.IConnectionListener, global::Orbotix.Sphero.IConnectionListenerImplementor>(
						ref weak_implementor_AddConnectionListener,
						global::Orbotix.Sphero.IConnectionListenerImplementor.__IsEmpty,
						RemoveConnectionListener,
						__h => __h.OnConnectionFailedHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Sphero.DisconnectedEventArgs> Disconnected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.IConnectionListener, global::Orbotix.Sphero.IConnectionListenerImplementor>(
						ref weak_implementor_AddConnectionListener,
						__CreateIConnectionListenerImplementor,
						AddConnectionListener,
						__h => __h.OnDisconnectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.IConnectionListener, global::Orbotix.Sphero.IConnectionListenerImplementor>(
						ref weak_implementor_AddConnectionListener,
						global::Orbotix.Sphero.IConnectionListenerImplementor.__IsEmpty,
						RemoveConnectionListener,
						__h => __h.OnDisconnectedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddConnectionListener;

		global::Orbotix.Sphero.IConnectionListenerImplementor __CreateIConnectionListenerImplementor ()
		{
			return new global::Orbotix.Sphero.IConnectionListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Sphero.IDiscoveryListener"
		public event EventHandler<global::Orbotix.Sphero.DiscoveryCompleteEventArgs> DiscoveryComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.IDiscoveryListener, global::Orbotix.Sphero.IDiscoveryListenerImplementor>(
						ref weak_implementor_AddDiscoveryListener,
						__CreateIDiscoveryListenerImplementor,
						AddDiscoveryListener,
						__h => __h.DiscoveryCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.IDiscoveryListener, global::Orbotix.Sphero.IDiscoveryListenerImplementor>(
						ref weak_implementor_AddDiscoveryListener,
						global::Orbotix.Sphero.IDiscoveryListenerImplementor.__IsEmpty,
						RemoveDiscoveryListener,
						__h => __h.DiscoveryCompleteHandler -= value);
			}
		}

		public event EventHandler BluetoothDisabled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.IDiscoveryListener, global::Orbotix.Sphero.IDiscoveryListenerImplementor>(
						ref weak_implementor_AddDiscoveryListener,
						__CreateIDiscoveryListenerImplementor,
						AddDiscoveryListener,
						__h => __h.OnBluetoothDisabledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.IDiscoveryListener, global::Orbotix.Sphero.IDiscoveryListenerImplementor>(
						ref weak_implementor_AddDiscoveryListener,
						global::Orbotix.Sphero.IDiscoveryListenerImplementor.__IsEmpty,
						RemoveDiscoveryListener,
						__h => __h.OnBluetoothDisabledHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Sphero.FoundEventArgs> Found {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Sphero.IDiscoveryListener, global::Orbotix.Sphero.IDiscoveryListenerImplementor>(
						ref weak_implementor_AddDiscoveryListener,
						__CreateIDiscoveryListenerImplementor,
						AddDiscoveryListener,
						__h => __h.OnFoundHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Sphero.IDiscoveryListener, global::Orbotix.Sphero.IDiscoveryListenerImplementor>(
						ref weak_implementor_AddDiscoveryListener,
						global::Orbotix.Sphero.IDiscoveryListenerImplementor.__IsEmpty,
						RemoveDiscoveryListener,
						__h => __h.OnFoundHandler -= value);
			}
		}

		WeakReference weak_implementor_AddDiscoveryListener;

		global::Orbotix.Sphero.IDiscoveryListenerImplementor __CreateIDiscoveryListenerImplementor ()
		{
			return new global::Orbotix.Sphero.IDiscoveryListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener"
		public event EventHandler BluetoothNotEnabled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						__CreateIOnRobotConnectionEventListenerImplementor,
						SetOnRobotConnectionEventListener,
						__h => __h.OnBluetoothNotEnabledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor.__IsEmpty,
						__v => SetOnRobotConnectionEventListener (null),
						__h => __h.OnBluetoothNotEnabledHandler -= value);
			}
		}

		public event EventHandler NonePaired {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						__CreateIOnRobotConnectionEventListenerImplementor,
						SetOnRobotConnectionEventListener,
						__h => __h.OnNonePairedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor.__IsEmpty,
						__v => SetOnRobotConnectionEventListener (null),
						__h => __h.OnNonePairedHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.View.Connection.SpheroConnectionView.RobotConnectedEventArgs> RobotConnected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						__CreateIOnRobotConnectionEventListenerImplementor,
						SetOnRobotConnectionEventListener,
						__h => __h.OnRobotConnectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor.__IsEmpty,
						__v => SetOnRobotConnectionEventListener (null),
						__h => __h.OnRobotConnectedHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.View.Connection.SpheroConnectionView.RobotConnectionFailedEventArgs> RobotConnectionFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						__CreateIOnRobotConnectionEventListenerImplementor,
						SetOnRobotConnectionEventListener,
						__h => __h.OnRobotConnectionFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListener, global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionEventListener,
						global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor.__IsEmpty,
						__v => SetOnRobotConnectionEventListener (null),
						__h => __h.OnRobotConnectionFailedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRobotConnectionEventListener;

		global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor __CreateIOnRobotConnectionEventListenerImplementor ()
		{
			return new global::Orbotix.View.Connection.SpheroConnectionView.IOnRobotConnectionEventListenerImplementor (this);
		}
#endregion
	}
}
