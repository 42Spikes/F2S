using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']"
	[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider", DoNotGenerateAcw=true)]
	public partial class RobotProvider : global::Java.Lang.Object, global::Java.Util.IObserver {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_CONNECTING']"
		[Register ("ACTION_ROBOT_CONNECTING")]
		public const string ActionRobotConnecting = (string) "orbotix.robot.provider.intent.action.CONNECTING";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_CONNECT_FAILED']"
		[Register ("ACTION_ROBOT_CONNECT_FAILED")]
		public const string ActionRobotConnectFailed = (string) "orbotix.robot.provider.intent.action.CONNECT_FAILED";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_CONNECT_SUCCESS']"
		[Register ("ACTION_ROBOT_CONNECT_SUCCESS")]
		public const string ActionRobotConnectSuccess = (string) "orbotix.robot.provider.intent.action.CONNECT_SUCCESS";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_DISCONNECTED']"
		[Register ("ACTION_ROBOT_DISCONNECTED")]
		public const string ActionRobotDisconnected = (string) "orbotix.robot.provider.intent.action.DISCONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_FOUND']"
		[Register ("ACTION_ROBOT_FOUND")]
		public const string ActionRobotFound = (string) "orbotix.robot.provider.intent.action.FOUND";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_MAIN_APP_CORRUPT']"
		[Register ("ACTION_ROBOT_MAIN_APP_CORRUPT")]
		public const string ActionRobotMainAppCorrupt = (string) "orbotix.robot.provider.intent.action.MAIN_APP_CORRUPT";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_MULTIPLE_FOUND']"
		[Register ("ACTION_ROBOT_MULTIPLE_FOUND")]
		public const string ActionRobotMultipleFound = (string) "orbotix.robot.provider.intent.action.MULTIPLE_FOUND";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_NONE_FOUND']"
		[Register ("ACTION_ROBOT_NONE_FOUND")]
		public const string ActionRobotNoneFound = (string) "orbotix.robot.provider.intent.action.NONE_FOUND";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='ACTION_ROBOT_NONE_PAIRED']"
		[Register ("ACTION_ROBOT_NONE_PAIRED")]
		public const string ActionRobotNonePaired = (string) "orbotix.robot.provider.intent.action.NONE_PAIRED";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/field[@name='EXTRA_ROBOT_ID']"
		[Register ("EXTRA_ROBOT_ID")]
		public const string ExtraRobotId = (string) "orbotix.robot.provider.RobotId";
		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnNoRobotsPairedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/robot/base/RobotProvider$OnNoRobotsPairedListener", "", "Orbotix.Robot.Base.RobotProvider/IOnNoRobotsPairedListenerInvoker")]
		public partial interface IOnNoRobotsPairedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnNoRobotsPairedListener']/method[@name='onNoRobotsPaired' and count(parameter)=0]"
			[Register ("onNoRobotsPaired", "()V", "GetOnNoRobotsPairedHandler:Orbotix.Robot.Base.RobotProvider/IOnNoRobotsPairedListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnNoRobotsPaired ();

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider$OnNoRobotsPairedListener", DoNotGenerateAcw=true)]
		internal class IOnNoRobotsPairedListenerInvoker : global::Java.Lang.Object, IOnNoRobotsPairedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/RobotProvider$OnNoRobotsPairedListener");
			IntPtr class_ref;

			public static IOnNoRobotsPairedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnNoRobotsPairedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.RobotProvider.OnNoRobotsPairedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnNoRobotsPairedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnNoRobotsPairedListenerInvoker); }
			}

			static Delegate cb_onNoRobotsPaired;
#pragma warning disable 0169
			static Delegate GetOnNoRobotsPairedHandler ()
			{
				if (cb_onNoRobotsPaired == null)
					cb_onNoRobotsPaired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNoRobotsPaired);
				return cb_onNoRobotsPaired;
			}

			static void n_OnNoRobotsPaired (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNoRobotsPaired ();
			}
#pragma warning restore 0169

			IntPtr id_onNoRobotsPaired;
			public void OnNoRobotsPaired ()
			{
				if (id_onNoRobotsPaired == IntPtr.Zero)
					id_onNoRobotsPaired = JNIEnv.GetMethodID (class_ref, "onNoRobotsPaired", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onNoRobotsPaired);
			}

		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/RobotProvider_OnNoRobotsPairedListenerImplementor")]
		internal sealed class IOnNoRobotsPairedListenerImplementor : global::Java.Lang.Object, IOnNoRobotsPairedListener {

			object sender;

			public IOnNoRobotsPairedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/RobotProvider_OnNoRobotsPairedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnNoRobotsPaired ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnNoRobotsPairedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotConnectedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/robot/base/RobotProvider$OnRobotConnectedListener", "", "Orbotix.Robot.Base.RobotProvider/IOnRobotConnectedListenerInvoker")]
		public partial interface IOnRobotConnectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotConnectedListener']/method[@name='onRobotConnected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
			[Register ("onRobotConnected", "(Lorbotix/robot/base/Robot;)V", "GetOnRobotConnected_Lorbotix_robot_base_Robot_Handler:Orbotix.Robot.Base.RobotProvider/IOnRobotConnectedListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnRobotConnected (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider$OnRobotConnectedListener", DoNotGenerateAcw=true)]
		internal class IOnRobotConnectedListenerInvoker : global::Java.Lang.Object, IOnRobotConnectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/RobotProvider$OnRobotConnectedListener");
			IntPtr class_ref;

			public static IOnRobotConnectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRobotConnectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.RobotProvider.OnRobotConnectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRobotConnectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRobotConnectedListenerInvoker); }
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
				global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/RobotProvider_OnRobotConnectedListenerImplementor")]
		internal sealed class IOnRobotConnectedListenerImplementor : global::Java.Lang.Object, IOnRobotConnectedListener {

			object sender;

			public IOnRobotConnectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/RobotProvider_OnRobotConnectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RobotConnectedEventArgs> Handler;
#pragma warning restore 0649

			public void OnRobotConnected (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RobotConnectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRobotConnectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotConnectionFailedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/robot/base/RobotProvider$OnRobotConnectionFailedListener", "", "Orbotix.Robot.Base.RobotProvider/IOnRobotConnectionFailedListenerInvoker")]
		public partial interface IOnRobotConnectionFailedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotConnectionFailedListener']/method[@name='onRobotConnectionFailed' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
			[Register ("onRobotConnectionFailed", "(Lorbotix/robot/base/Robot;)V", "GetOnRobotConnectionFailed_Lorbotix_robot_base_Robot_Handler:Orbotix.Robot.Base.RobotProvider/IOnRobotConnectionFailedListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnRobotConnectionFailed (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider$OnRobotConnectionFailedListener", DoNotGenerateAcw=true)]
		internal class IOnRobotConnectionFailedListenerInvoker : global::Java.Lang.Object, IOnRobotConnectionFailedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/RobotProvider$OnRobotConnectionFailedListener");
			IntPtr class_ref;

			public static IOnRobotConnectionFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRobotConnectionFailedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.RobotProvider.OnRobotConnectionFailedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRobotConnectionFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRobotConnectionFailedListenerInvoker); }
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
				global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/RobotProvider_OnRobotConnectionFailedListenerImplementor")]
		internal sealed class IOnRobotConnectionFailedListenerImplementor : global::Java.Lang.Object, IOnRobotConnectionFailedListener {

			object sender;

			public IOnRobotConnectionFailedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/RobotProvider_OnRobotConnectionFailedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RobotConnectionFailedEventArgs> Handler;
#pragma warning restore 0649

			public void OnRobotConnectionFailed (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RobotConnectionFailedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRobotConnectionFailedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotDisconnectedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/robot/base/RobotProvider$OnRobotDisconnectedListener", "", "Orbotix.Robot.Base.RobotProvider/IOnRobotDisconnectedListenerInvoker")]
		public partial interface IOnRobotDisconnectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotDisconnectedListener']/method[@name='onRobotDisconnected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
			[Register ("onRobotDisconnected", "(Lorbotix/robot/base/Robot;)V", "GetOnRobotDisconnected_Lorbotix_robot_base_Robot_Handler:Orbotix.Robot.Base.RobotProvider/IOnRobotDisconnectedListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnRobotDisconnected (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider$OnRobotDisconnectedListener", DoNotGenerateAcw=true)]
		internal class IOnRobotDisconnectedListenerInvoker : global::Java.Lang.Object, IOnRobotDisconnectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/RobotProvider$OnRobotDisconnectedListener");
			IntPtr class_ref;

			public static IOnRobotDisconnectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRobotDisconnectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.RobotProvider.OnRobotDisconnectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRobotDisconnectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRobotDisconnectedListenerInvoker); }
			}

			static Delegate cb_onRobotDisconnected_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
			static Delegate GetOnRobotDisconnected_Lorbotix_robot_base_Robot_Handler ()
			{
				if (cb_onRobotDisconnected_Lorbotix_robot_base_Robot_ == null)
					cb_onRobotDisconnected_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRobotDisconnected_Lorbotix_robot_base_Robot_);
				return cb_onRobotDisconnected_Lorbotix_robot_base_Robot_;
			}

			static void n_OnRobotDisconnected_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRobotDisconnected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRobotDisconnected_Lorbotix_robot_base_Robot_;
			public void OnRobotDisconnected (global::Orbotix.Robot.Base.Robot p0)
			{
				if (id_onRobotDisconnected_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_onRobotDisconnected_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onRobotDisconnected", "(Lorbotix/robot/base/Robot;)V");
				JNIEnv.CallVoidMethod (Handle, id_onRobotDisconnected_Lorbotix_robot_base_Robot_, new JValue (p0));
			}

		}

		public partial class RobotDisconnectedEventArgs : global::System.EventArgs {

			public RobotDisconnectedEventArgs (global::Orbotix.Robot.Base.Robot p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.Robot p0;
			public global::Orbotix.Robot.Base.Robot P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/RobotProvider_OnRobotDisconnectedListenerImplementor")]
		internal sealed class IOnRobotDisconnectedListenerImplementor : global::Java.Lang.Object, IOnRobotDisconnectedListener {

			object sender;

			public IOnRobotDisconnectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/RobotProvider_OnRobotDisconnectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RobotDisconnectedEventArgs> Handler;
#pragma warning restore 0649

			public void OnRobotDisconnected (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RobotDisconnectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRobotDisconnectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotFoundListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/robot/base/RobotProvider$OnRobotFoundListener", "", "Orbotix.Robot.Base.RobotProvider/IOnRobotFoundListenerInvoker")]
		public partial interface IOnRobotFoundListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotFoundListener']/method[@name='onRobotFound' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
			[Register ("onRobotFound", "(Lorbotix/robot/base/Robot;)V", "GetOnRobotFound_Lorbotix_robot_base_Robot_Handler:Orbotix.Robot.Base.RobotProvider/IOnRobotFoundListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnRobotFound (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider$OnRobotFoundListener", DoNotGenerateAcw=true)]
		internal class IOnRobotFoundListenerInvoker : global::Java.Lang.Object, IOnRobotFoundListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/RobotProvider$OnRobotFoundListener");
			IntPtr class_ref;

			public static IOnRobotFoundListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRobotFoundListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.RobotProvider.OnRobotFoundListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRobotFoundListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRobotFoundListenerInvoker); }
			}

			static Delegate cb_onRobotFound_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
			static Delegate GetOnRobotFound_Lorbotix_robot_base_Robot_Handler ()
			{
				if (cb_onRobotFound_Lorbotix_robot_base_Robot_ == null)
					cb_onRobotFound_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRobotFound_Lorbotix_robot_base_Robot_);
				return cb_onRobotFound_Lorbotix_robot_base_Robot_;
			}

			static void n_OnRobotFound_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRobotFound (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRobotFound_Lorbotix_robot_base_Robot_;
			public void OnRobotFound (global::Orbotix.Robot.Base.Robot p0)
			{
				if (id_onRobotFound_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_onRobotFound_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onRobotFound", "(Lorbotix/robot/base/Robot;)V");
				JNIEnv.CallVoidMethod (Handle, id_onRobotFound_Lorbotix_robot_base_Robot_, new JValue (p0));
			}

		}

		public partial class RobotFoundEventArgs : global::System.EventArgs {

			public RobotFoundEventArgs (global::Orbotix.Robot.Base.Robot p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.Robot p0;
			public global::Orbotix.Robot.Base.Robot P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/RobotProvider_OnRobotFoundListenerImplementor")]
		internal sealed class IOnRobotFoundListenerImplementor : global::Java.Lang.Object, IOnRobotFoundListener {

			object sender;

			public IOnRobotFoundListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/RobotProvider_OnRobotFoundListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RobotFoundEventArgs> Handler;
#pragma warning restore 0649

			public void OnRobotFound (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RobotFoundEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRobotFoundListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotOneFoundListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("orbotix/robot/base/RobotProvider$OnRobotOneFoundListener", "", "Orbotix.Robot.Base.RobotProvider/IOnRobotOneFoundListenerInvoker")]
		public partial interface IOnRobotOneFoundListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='RobotProvider.OnRobotOneFoundListener']/method[@name='onOneRobotFound' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
			[Register ("onOneRobotFound", "(Lorbotix/robot/base/Robot;)V", "GetOnOneRobotFound_Lorbotix_robot_base_Robot_Handler:Orbotix.Robot.Base.RobotProvider/IOnRobotOneFoundListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnOneRobotFound (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/RobotProvider$OnRobotOneFoundListener", DoNotGenerateAcw=true)]
		internal class IOnRobotOneFoundListenerInvoker : global::Java.Lang.Object, IOnRobotOneFoundListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/RobotProvider$OnRobotOneFoundListener");
			IntPtr class_ref;

			public static IOnRobotOneFoundListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRobotOneFoundListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.RobotProvider.OnRobotOneFoundListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRobotOneFoundListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRobotOneFoundListenerInvoker); }
			}

			static Delegate cb_onOneRobotFound_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
			static Delegate GetOnOneRobotFound_Lorbotix_robot_base_Robot_Handler ()
			{
				if (cb_onOneRobotFound_Lorbotix_robot_base_Robot_ == null)
					cb_onOneRobotFound_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOneRobotFound_Lorbotix_robot_base_Robot_);
				return cb_onOneRobotFound_Lorbotix_robot_base_Robot_;
			}

			static void n_OnOneRobotFound_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOneRobotFound (p0);
			}
#pragma warning restore 0169

			IntPtr id_onOneRobotFound_Lorbotix_robot_base_Robot_;
			public void OnOneRobotFound (global::Orbotix.Robot.Base.Robot p0)
			{
				if (id_onOneRobotFound_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_onOneRobotFound_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onOneRobotFound", "(Lorbotix/robot/base/Robot;)V");
				JNIEnv.CallVoidMethod (Handle, id_onOneRobotFound_Lorbotix_robot_base_Robot_, new JValue (p0));
			}

		}

		public partial class RobotOneFoundEventArgs : global::System.EventArgs {

			public RobotOneFoundEventArgs (global::Orbotix.Robot.Base.Robot p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.Robot p0;
			public global::Orbotix.Robot.Base.Robot P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/RobotProvider_OnRobotOneFoundListenerImplementor")]
		internal sealed class IOnRobotOneFoundListenerImplementor : global::Java.Lang.Object, IOnRobotOneFoundListener {

			object sender;

			public IOnRobotOneFoundListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/RobotProvider_OnRobotOneFoundListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RobotOneFoundEventArgs> Handler;
#pragma warning restore 0649

			public void OnOneRobotFound (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RobotOneFoundEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRobotOneFoundListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/RobotProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RobotProvider); }
		}

		protected RobotProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/constructor[@name='RobotProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected RobotProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RobotProvider)) {
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

		static Delegate cb_getControlledRobots;
#pragma warning disable 0169
		static Delegate GetGetControlledRobotsHandler ()
		{
			if (cb_getControlledRobots == null)
				cb_getControlledRobots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControlledRobots);
			return cb_getControlledRobots;
		}

		static IntPtr n_GetControlledRobots (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.ToLocalJniHandle (__this.ControlledRobots);
		}
#pragma warning restore 0169

		static IntPtr id_getControlledRobots;
		public virtual global::System.Collections.Generic.IList<global::Orbotix.Robot.Base.Robot> ControlledRobots {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='getControlledRobots' and count(parameter)=0]"
			[Register ("getControlledRobots", "()Ljava/util/List;", "GetGetControlledRobotsHandler")]
			get {
				if (id_getControlledRobots == IntPtr.Zero)
					id_getControlledRobots = JNIEnv.GetMethodID (class_ref, "getControlledRobots", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getControlledRobots), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.Robot>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getControlledRobots", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDefaultProvider;
		public static global::Orbotix.Robot.Base.RobotProvider DefaultProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='getDefaultProvider' and count(parameter)=0]"
			[Register ("getDefaultProvider", "()Lorbotix/robot/base/RobotProvider;", "GetGetDefaultProviderHandler")]
			get {
				if (id_getDefaultProvider == IntPtr.Zero)
					id_getDefaultProvider = JNIEnv.GetStaticMethodID (class_ref, "getDefaultProvider", "()Lorbotix/robot/base/RobotProvider;");
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasRobotControl;
#pragma warning disable 0169
		static Delegate GetHasRobotControlHandler ()
		{
			if (cb_hasRobotControl == null)
				cb_hasRobotControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasRobotControl);
			return cb_hasRobotControl;
		}

		static bool n_HasRobotControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRobotControl;
		}
#pragma warning restore 0169

		static IntPtr id_hasRobotControl;
		public virtual bool HasRobotControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='hasRobotControl' and count(parameter)=0]"
			[Register ("hasRobotControl", "()Z", "GetHasRobotControlHandler")]
			get {
				if (id_hasRobotControl == IntPtr.Zero)
					id_hasRobotControl = JNIEnv.GetMethodID (class_ref, "hasRobotControl", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasRobotControl);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasRobotControl", "()Z"));
			}
		}

		static Delegate cb_isAdapterEnabled;
#pragma warning disable 0169
		static Delegate GetIsAdapterEnabledHandler ()
		{
			if (cb_isAdapterEnabled == null)
				cb_isAdapterEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAdapterEnabled);
			return cb_isAdapterEnabled;
		}

		static bool n_IsAdapterEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAdapterEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isAdapterEnabled;
		public virtual bool IsAdapterEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='isAdapterEnabled' and count(parameter)=0]"
			[Register ("isAdapterEnabled", "()Z", "GetIsAdapterEnabledHandler")]
			get {
				if (id_isAdapterEnabled == IntPtr.Zero)
					id_isAdapterEnabled = JNIEnv.GetMethodID (class_ref, "isAdapterEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAdapterEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAdapterEnabled", "()Z"));
			}
		}

		static Delegate cb_getRobotControls;
#pragma warning disable 0169
		static Delegate GetGetRobotControlsHandler ()
		{
			if (cb_getRobotControls == null)
				cb_getRobotControls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobotControls);
			return cb_getRobotControls;
		}

		static IntPtr n_GetRobotControls (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.RobotControl>.ToLocalJniHandle (__this.RobotControls);
		}
#pragma warning restore 0169

		static IntPtr id_getRobotControls;
		public virtual global::System.Collections.Generic.IList<global::Orbotix.Robot.Base.RobotControl> RobotControls {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='getRobotControls' and count(parameter)=0]"
			[Register ("getRobotControls", "()Ljava/util/List;", "GetGetRobotControlsHandler")]
			get {
				if (id_getRobotControls == IntPtr.Zero)
					id_getRobotControls = JNIEnv.GetMethodID (class_ref, "getRobotControls", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.RobotControl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRobotControls), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Base.RobotControl>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotControls", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRobotResponseDeliverers;
#pragma warning disable 0169
		static Delegate GetGetRobotResponseDeliverersHandler ()
		{
			if (cb_getRobotResponseDeliverers == null)
				cb_getRobotResponseDeliverers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobotResponseDeliverers);
			return cb_getRobotResponseDeliverers;
		}

		static IntPtr n_GetRobotResponseDeliverers (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Orbotix.Robot.Internal.IRobotResponseDeliverer>.ToLocalJniHandle (__this.RobotResponseDeliverers);
		}
#pragma warning restore 0169

		static IntPtr id_getRobotResponseDeliverers;
		public virtual global::System.Collections.Generic.ICollection<global::Orbotix.Robot.Internal.IRobotResponseDeliverer> RobotResponseDeliverers {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='getRobotResponseDeliverers' and count(parameter)=0]"
			[Register ("getRobotResponseDeliverers", "()Ljava/util/Set;", "GetGetRobotResponseDeliverersHandler")]
			get {
				if (id_getRobotResponseDeliverers == IntPtr.Zero)
					id_getRobotResponseDeliverers = JNIEnv.GetMethodID (class_ref, "getRobotResponseDeliverers", "()Ljava/util/Set;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Orbotix.Robot.Internal.IRobotResponseDeliverer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRobotResponseDeliverers), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Orbotix.Robot.Internal.IRobotResponseDeliverer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotResponseDeliverers", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRobots;
#pragma warning disable 0169
		static Delegate GetGetRobotsHandler ()
		{
			if (cb_getRobots == null)
				cb_getRobots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobots);
			return cb_getRobots;
		}

		static IntPtr n_GetRobots (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.ToLocalJniHandle (__this.Robots);
		}
#pragma warning restore 0169

		static IntPtr id_getRobots;
		public virtual global::System.Collections.Generic.IList<global::Orbotix.Sphero.Sphero> Robots {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='getRobots' and count(parameter)=0]"
			[Register ("getRobots", "()Ljava/util/List;", "GetGetRobotsHandler")]
			get {
				if (id_getRobots == IntPtr.Zero)
					id_getRobots = JNIEnv.GetMethodID (class_ref, "getRobots", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRobots), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Orbotix.Sphero.Sphero>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobots", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IConnectionListener p0 = (global::Orbotix.Sphero.IConnectionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddConnectionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addConnectionListener_Lorbotix_sphero_ConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='addConnectionListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.ConnectionListener']]"
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
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IDiscoveryListener p0 = (global::Orbotix.Sphero.IDiscoveryListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddDiscoveryListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='addDiscoveryListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.DiscoveryListener']]"
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

		static Delegate cb_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_;
#pragma warning disable 0169
		static Delegate GetAddResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_Handler ()
		{
			if (cb_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ == null)
				cb_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_);
			return cb_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_;
		}

		static void n_AddResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.IRobotResponseDeliverer p0 = (global::Orbotix.Robot.Internal.IRobotResponseDeliverer)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.IRobotResponseDeliverer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddResponseDeliverer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='addResponseDeliverer' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.RobotResponseDeliverer']]"
		[Register ("addResponseDeliverer", "(Lorbotix/robot/internal/RobotResponseDeliverer;)V", "GetAddResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_Handler")]
		public virtual void AddResponseDeliverer (global::Orbotix.Robot.Internal.IRobotResponseDeliverer p0)
		{
			if (id_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ == IntPtr.Zero)
				id_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ = JNIEnv.GetMethodID (class_ref, "addResponseDeliverer", "(Lorbotix/robot/internal/RobotResponseDeliverer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addResponseDeliverer", "(Lorbotix/robot/internal/RobotResponseDeliverer;)V"), new JValue (p0));
		}

		static Delegate cb_connect_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_connect_Lorbotix_robot_base_Robot_ == null)
				cb_connect_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Lorbotix_robot_base_Robot_);
			return cb_connect_Lorbotix_robot_base_Robot_;
		}

		static void n_Connect_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("connect", "(Lorbotix/robot/base/Robot;)V", "GetConnect_Lorbotix_robot_base_Robot_Handler")]
		public virtual void Connect (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_connect_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_connect_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorbotix/robot/base/Robot;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connect_Lorbotix_robot_base_Robot_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lorbotix/robot/base/Robot;)V"), new JValue (p0));
		}

		static Delegate cb_connectControlledRobots;
#pragma warning disable 0169
		static Delegate GetConnectControlledRobotsHandler ()
		{
			if (cb_connectControlledRobots == null)
				cb_connectControlledRobots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConnectControlledRobots);
			return cb_connectControlledRobots;
		}

		static IntPtr n_ConnectControlledRobots (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectControlledRobots ());
		}
#pragma warning restore 0169

		static IntPtr id_connectControlledRobots;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='connectControlledRobots' and count(parameter)=0]"
		[Register ("connectControlledRobots", "()Ljava/lang/Boolean;", "GetConnectControlledRobotsHandler")]
		public virtual global::Java.Lang.Boolean ConnectControlledRobots ()
		{
			if (id_connectControlledRobots == IntPtr.Zero)
				id_connectControlledRobots = JNIEnv.GetMethodID (class_ref, "connectControlledRobots", "()Ljava/lang/Boolean;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_connectControlledRobots), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectControlledRobots", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_control_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetControl_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_control_Lorbotix_robot_base_Robot_ == null)
				cb_control_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Control_Lorbotix_robot_base_Robot_);
			return cb_control_Lorbotix_robot_base_Robot_;
		}

		static void n_Control_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Control (p0);
		}
#pragma warning restore 0169

		static IntPtr id_control_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='control' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("control", "(Lorbotix/robot/base/Robot;)V", "GetControl_Lorbotix_robot_base_Robot_Handler")]
		public virtual void Control (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_control_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_control_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "control", "(Lorbotix/robot/base/Robot;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_control_Lorbotix_robot_base_Robot_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "control", "(Lorbotix/robot/base/Robot;)V"), new JValue (p0));
		}

		static Delegate cb_disconnect_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_disconnect_Lorbotix_robot_base_Robot_ == null)
				cb_disconnect_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Lorbotix_robot_base_Robot_);
			return cb_disconnect_Lorbotix_robot_base_Robot_;
		}

		static void n_Disconnect_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("disconnect", "(Lorbotix/robot/base/Robot;)V", "GetDisconnect_Lorbotix_robot_base_Robot_Handler")]
		public virtual void Disconnect (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_disconnect_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_disconnect_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Lorbotix/robot/base/Robot;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disconnect_Lorbotix_robot_base_Robot_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Lorbotix/robot/base/Robot;)V"), new JValue (p0));
		}

		static Delegate cb_disconnectControlledRobots;
#pragma warning disable 0169
		static Delegate GetDisconnectControlledRobotsHandler ()
		{
			if (cb_disconnectControlledRobots == null)
				cb_disconnectControlledRobots = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectControlledRobots);
			return cb_disconnectControlledRobots;
		}

		static void n_DisconnectControlledRobots (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectControlledRobots ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectControlledRobots;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='disconnectControlledRobots' and count(parameter)=0]"
		[Register ("disconnectControlledRobots", "()V", "GetDisconnectControlledRobotsHandler")]
		public virtual void DisconnectControlledRobots ()
		{
			if (id_disconnectControlledRobots == IntPtr.Zero)
				id_disconnectControlledRobots = JNIEnv.GetMethodID (class_ref, "disconnectControlledRobots", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disconnectControlledRobots);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectControlledRobots", "()V"));
		}

		static Delegate cb_endDiscovery;
#pragma warning disable 0169
		static Delegate GetEndDiscoveryHandler ()
		{
			if (cb_endDiscovery == null)
				cb_endDiscovery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndDiscovery);
			return cb_endDiscovery;
		}

		static void n_EndDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_endDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='endDiscovery' and count(parameter)=0]"
		[Register ("endDiscovery", "()V", "GetEndDiscoveryHandler")]
		public virtual void EndDiscovery ()
		{
			if (id_endDiscovery == IntPtr.Zero)
				id_endDiscovery = JNIEnv.GetMethodID (class_ref, "endDiscovery", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_endDiscovery);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endDiscovery", "()V"));
		}

		static Delegate cb_findRobot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindRobot_Ljava_lang_String_Handler ()
		{
			if (cb_findRobot_Ljava_lang_String_ == null)
				cb_findRobot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindRobot_Ljava_lang_String_);
			return cb_findRobot_Ljava_lang_String_;
		}

		static IntPtr n_FindRobot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindRobot (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findRobot_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='findRobot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findRobot", "(Ljava/lang/String;)Lorbotix/robot/base/Robot;", "GetFindRobot_Ljava_lang_String_Handler")]
		public virtual global::Orbotix.Robot.Base.Robot FindRobot (string p0)
		{
			if (id_findRobot_Ljava_lang_String_ == IntPtr.Zero)
				id_findRobot_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findRobot", "(Ljava/lang/String;)Lorbotix/robot/base/Robot;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Orbotix.Robot.Base.Robot __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (JNIEnv.CallObjectMethod  (Handle, id_findRobot_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findRobot", "(Ljava/lang/String;)Lorbotix/robot/base/Robot;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_findRobots;
#pragma warning disable 0169
		static Delegate GetFindRobotsHandler ()
		{
			if (cb_findRobots == null)
				cb_findRobots = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FindRobots);
			return cb_findRobots;
		}

		static void n_FindRobots (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FindRobots ();
		}
#pragma warning restore 0169

		static IntPtr id_findRobots;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='findRobots' and count(parameter)=0]"
		[Register ("findRobots", "()V", "GetFindRobotsHandler")]
		public virtual void FindRobots ()
		{
			if (id_findRobots == IntPtr.Zero)
				id_findRobots = JNIEnv.GetMethodID (class_ref, "findRobots", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_findRobots);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findRobots", "()V"));
		}

		static Delegate cb_getRobotControl_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetGetRobotControl_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_getRobotControl_Lorbotix_robot_base_Robot_ == null)
				cb_getRobotControl_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRobotControl_Lorbotix_robot_base_Robot_);
			return cb_getRobotControl_Lorbotix_robot_base_Robot_;
		}

		static IntPtr n_GetRobotControl_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRobotControl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRobotControl_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='getRobotControl' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("getRobotControl", "(Lorbotix/robot/base/Robot;)Lorbotix/robot/base/RobotControl;", "GetGetRobotControl_Lorbotix_robot_base_Robot_Handler")]
		public virtual global::Orbotix.Robot.Base.RobotControl GetRobotControl (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_getRobotControl_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_getRobotControl_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "getRobotControl", "(Lorbotix/robot/base/Robot;)Lorbotix/robot/base/RobotControl;");

			global::Orbotix.Robot.Base.RobotControl __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (JNIEnv.CallObjectMethod  (Handle, id_getRobotControl_Lorbotix_robot_base_Robot_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotControl", "(Lorbotix/robot/base/Robot;)Lorbotix/robot/base/RobotControl;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initiateConnection_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitiateConnection_Ljava_lang_String_Handler ()
		{
			if (cb_initiateConnection_Ljava_lang_String_ == null)
				cb_initiateConnection_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InitiateConnection_Ljava_lang_String_);
			return cb_initiateConnection_Ljava_lang_String_;
		}

		static bool n_InitiateConnection_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InitiateConnection (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_initiateConnection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='initiateConnection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initiateConnection", "(Ljava/lang/String;)Z", "GetInitiateConnection_Ljava_lang_String_Handler")]
		public virtual bool InitiateConnection (string p0)
		{
			if (id_initiateConnection_Ljava_lang_String_ == IntPtr.Zero)
				id_initiateConnection_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initiateConnection", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_initiateConnection_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initiateConnection", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeAllControls;
#pragma warning disable 0169
		static Delegate GetRemoveAllControlsHandler ()
		{
			if (cb_removeAllControls == null)
				cb_removeAllControls = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllControls);
			return cb_removeAllControls;
		}

		static void n_RemoveAllControls (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllControls ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllControls;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeAllControls' and count(parameter)=0]"
		[Register ("removeAllControls", "()V", "GetRemoveAllControlsHandler")]
		public virtual void RemoveAllControls ()
		{
			if (id_removeAllControls == IntPtr.Zero)
				id_removeAllControls = JNIEnv.GetMethodID (class_ref, "removeAllControls", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAllControls);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllControls", "()V"));
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
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IConnectionListener p0 = (global::Orbotix.Sphero.IConnectionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeConnectionListener_Lorbotix_sphero_ConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeConnectionListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.ConnectionListener']]"
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

		static Delegate cb_removeConnectionListeners;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionListenersHandler ()
		{
			if (cb_removeConnectionListeners == null)
				cb_removeConnectionListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveConnectionListeners);
			return cb_removeConnectionListeners;
		}

		static void n_RemoveConnectionListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeConnectionListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeConnectionListeners' and count(parameter)=0]"
		[Register ("removeConnectionListeners", "()V", "GetRemoveConnectionListenersHandler")]
		public virtual void RemoveConnectionListeners ()
		{
			if (id_removeConnectionListeners == IntPtr.Zero)
				id_removeConnectionListeners = JNIEnv.GetMethodID (class_ref, "removeConnectionListeners", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeConnectionListeners);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeConnectionListeners", "()V"));
		}

		static Delegate cb_removeControl_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetRemoveControl_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_removeControl_Lorbotix_robot_base_Robot_ == null)
				cb_removeControl_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveControl_Lorbotix_robot_base_Robot_);
			return cb_removeControl_Lorbotix_robot_base_Robot_;
		}

		static void n_RemoveControl_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeControl_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeControl' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("removeControl", "(Lorbotix/robot/base/Robot;)V", "GetRemoveControl_Lorbotix_robot_base_Robot_Handler")]
		public virtual void RemoveControl (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_removeControl_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_removeControl_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "removeControl", "(Lorbotix/robot/base/Robot;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeControl_Lorbotix_robot_base_Robot_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeControl", "(Lorbotix/robot/base/Robot;)V"), new JValue (p0));
		}

		static Delegate cb_removeControl_Lorbotix_robot_base_RobotControl_;
#pragma warning disable 0169
		static Delegate GetRemoveControl_Lorbotix_robot_base_RobotControl_Handler ()
		{
			if (cb_removeControl_Lorbotix_robot_base_RobotControl_ == null)
				cb_removeControl_Lorbotix_robot_base_RobotControl_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveControl_Lorbotix_robot_base_RobotControl_);
			return cb_removeControl_Lorbotix_robot_base_RobotControl_;
		}

		static void n_RemoveControl_Lorbotix_robot_base_RobotControl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotControl p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeControl_Lorbotix_robot_base_RobotControl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeControl' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotControl']]"
		[Register ("removeControl", "(Lorbotix/robot/base/RobotControl;)V", "GetRemoveControl_Lorbotix_robot_base_RobotControl_Handler")]
		public virtual void RemoveControl (global::Orbotix.Robot.Base.RobotControl p0)
		{
			if (id_removeControl_Lorbotix_robot_base_RobotControl_ == IntPtr.Zero)
				id_removeControl_Lorbotix_robot_base_RobotControl_ = JNIEnv.GetMethodID (class_ref, "removeControl", "(Lorbotix/robot/base/RobotControl;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeControl_Lorbotix_robot_base_RobotControl_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeControl", "(Lorbotix/robot/base/RobotControl;)V"), new JValue (p0));
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
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Sphero.IDiscoveryListener p0 = (global::Orbotix.Sphero.IDiscoveryListener)global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.IDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDiscoveryListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeDiscoveryListener_Lorbotix_sphero_DiscoveryListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeDiscoveryListener' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.DiscoveryListener']]"
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

		static Delegate cb_removeDiscoveryListeners;
#pragma warning disable 0169
		static Delegate GetRemoveDiscoveryListenersHandler ()
		{
			if (cb_removeDiscoveryListeners == null)
				cb_removeDiscoveryListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveDiscoveryListeners);
			return cb_removeDiscoveryListeners;
		}

		static void n_RemoveDiscoveryListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDiscoveryListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeDiscoveryListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeDiscoveryListeners' and count(parameter)=0]"
		[Register ("removeDiscoveryListeners", "()V", "GetRemoveDiscoveryListenersHandler")]
		public virtual void RemoveDiscoveryListeners ()
		{
			if (id_removeDiscoveryListeners == IntPtr.Zero)
				id_removeDiscoveryListeners = JNIEnv.GetMethodID (class_ref, "removeDiscoveryListeners", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeDiscoveryListeners);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeDiscoveryListeners", "()V"));
		}

		static Delegate cb_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_;
#pragma warning disable 0169
		static Delegate GetRemoveResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_Handler ()
		{
			if (cb_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ == null)
				cb_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_);
			return cb_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_;
		}

		static void n_RemoveResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.IRobotResponseDeliverer p0 = (global::Orbotix.Robot.Internal.IRobotResponseDeliverer)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.IRobotResponseDeliverer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveResponseDeliverer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='removeResponseDeliverer' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.RobotResponseDeliverer']]"
		[Register ("removeResponseDeliverer", "(Lorbotix/robot/internal/RobotResponseDeliverer;)V", "GetRemoveResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_Handler")]
		public virtual void RemoveResponseDeliverer (global::Orbotix.Robot.Internal.IRobotResponseDeliverer p0)
		{
			if (id_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ == IntPtr.Zero)
				id_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_ = JNIEnv.GetMethodID (class_ref, "removeResponseDeliverer", "(Lorbotix/robot/internal/RobotResponseDeliverer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeResponseDeliverer_Lorbotix_robot_internal_RobotResponseDeliverer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeResponseDeliverer", "(Lorbotix/robot/internal/RobotResponseDeliverer;)V"), new JValue (p0));
		}

		static Delegate cb_setBroadcastContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetBroadcastContext_Landroid_content_Context_Handler ()
		{
			if (cb_setBroadcastContext_Landroid_content_Context_ == null)
				cb_setBroadcastContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBroadcastContext_Landroid_content_Context_);
			return cb_setBroadcastContext_Landroid_content_Context_;
		}

		static void n_SetBroadcastContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBroadcastContext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBroadcastContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setBroadcastContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setBroadcastContext", "(Landroid/content/Context;)V", "GetSetBroadcastContext_Landroid_content_Context_Handler")]
		public virtual void SetBroadcastContext (global::Android.Content.Context p0)
		{
			if (id_setBroadcastContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setBroadcastContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setBroadcastContext", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBroadcastContext_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBroadcastContext", "(Landroid/content/Context;)V"), new JValue (p0));
		}

		static Delegate cb_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_Handler ()
		{
			if (cb_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_ == null)
				cb_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_);
			return cb_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_;
		}

		static void n_SetOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener p0 = (global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnNoRobotsPairedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setOnNoRobotsPairedListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotProvider.OnNoRobotsPairedListener']]"
		[Register ("setOnNoRobotsPairedListener", "(Lorbotix/robot/base/RobotProvider$OnNoRobotsPairedListener;)V", "GetSetOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_Handler")]
		public virtual void SetOnNoRobotsPairedListener (global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener p0)
		{
			if (id_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_ == IntPtr.Zero)
				id_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_ = JNIEnv.GetMethodID (class_ref, "setOnNoRobotsPairedListener", "(Lorbotix/robot/base/RobotProvider$OnNoRobotsPairedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnNoRobotsPairedListener_Lorbotix_robot_base_RobotProvider_OnNoRobotsPairedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnNoRobotsPairedListener", "(Lorbotix/robot/base/RobotProvider$OnNoRobotsPairedListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_Handler ()
		{
			if (cb_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_ == null)
				cb_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_);
			return cb_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_;
		}

		static void n_SetOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener p0 = (global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRobotConnectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setOnRobotConnectedListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotProvider.OnRobotConnectedListener']]"
		[Register ("setOnRobotConnectedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotConnectedListener;)V", "GetSetOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_Handler")]
		public virtual void SetOnRobotConnectedListener (global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener p0)
		{
			if (id_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_ == IntPtr.Zero)
				id_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnRobotConnectedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotConnectedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRobotConnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRobotConnectedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotConnectedListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_Handler ()
		{
			if (cb_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_ == null)
				cb_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_);
			return cb_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_;
		}

		static void n_SetOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener p0 = (global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRobotConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setOnRobotConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotProvider.OnRobotConnectionFailedListener']]"
		[Register ("setOnRobotConnectionFailedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotConnectionFailedListener;)V", "GetSetOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_Handler")]
		public virtual void SetOnRobotConnectionFailedListener (global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener p0)
		{
			if (id_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_ == IntPtr.Zero)
				id_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "setOnRobotConnectionFailedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotConnectionFailedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRobotConnectionFailedListener_Lorbotix_robot_base_RobotProvider_OnRobotConnectionFailedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRobotConnectionFailedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotConnectionFailedListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_Handler ()
		{
			if (cb_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_ == null)
				cb_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_);
			return cb_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_;
		}

		static void n_SetOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener p0 = (global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRobotDisconnectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setOnRobotDisconnectedListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotProvider.OnRobotDisconnectedListener']]"
		[Register ("setOnRobotDisconnectedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotDisconnectedListener;)V", "GetSetOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_Handler")]
		public virtual void SetOnRobotDisconnectedListener (global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener p0)
		{
			if (id_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_ == IntPtr.Zero)
				id_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnRobotDisconnectedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotDisconnectedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRobotDisconnectedListener_Lorbotix_robot_base_RobotProvider_OnRobotDisconnectedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRobotDisconnectedListener", "(Lorbotix/robot/base/RobotProvider$OnRobotDisconnectedListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_Handler ()
		{
			if (cb_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_ == null)
				cb_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_);
			return cb_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_;
		}

		static void n_SetOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener p0 = (global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRobotFoundListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setOnRobotFoundListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotProvider.OnRobotFoundListener']]"
		[Register ("setOnRobotFoundListener", "(Lorbotix/robot/base/RobotProvider$OnRobotFoundListener;)V", "GetSetOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_Handler")]
		public virtual void SetOnRobotFoundListener (global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener p0)
		{
			if (id_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_ == IntPtr.Zero)
				id_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_ = JNIEnv.GetMethodID (class_ref, "setOnRobotFoundListener", "(Lorbotix/robot/base/RobotProvider$OnRobotFoundListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRobotFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotFoundListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRobotFoundListener", "(Lorbotix/robot/base/RobotProvider$OnRobotFoundListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_Handler ()
		{
			if (cb_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_ == null)
				cb_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_);
			return cb_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_;
		}

		static void n_SetOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener p0 = (global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRobotOneFoundListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='setOnRobotOneFoundListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RobotProvider.OnRobotOneFoundListener']]"
		[Register ("setOnRobotOneFoundListener", "(Lorbotix/robot/base/RobotProvider$OnRobotOneFoundListener;)V", "GetSetOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_Handler")]
		public virtual void SetOnRobotOneFoundListener (global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener p0)
		{
			if (id_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_ == IntPtr.Zero)
				id_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_ = JNIEnv.GetMethodID (class_ref, "setOnRobotOneFoundListener", "(Lorbotix/robot/base/RobotProvider$OnRobotOneFoundListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRobotOneFoundListener_Lorbotix_robot_base_RobotProvider_OnRobotOneFoundListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRobotOneFoundListener", "(Lorbotix/robot/base/RobotProvider$OnRobotOneFoundListener;)V"), new JValue (p0));
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shutdown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
		}

		static Delegate cb_startDiscovery_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_Landroid_content_Context_Handler ()
		{
			if (cb_startDiscovery_Landroid_content_Context_ == null)
				cb_startDiscovery_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartDiscovery_Landroid_content_Context_);
			return cb_startDiscovery_Landroid_content_Context_;
		}

		static bool n_StartDiscovery_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startDiscovery_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='startDiscovery' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startDiscovery", "(Landroid/content/Context;)Z", "GetStartDiscovery_Landroid_content_Context_Handler")]
		public virtual bool StartDiscovery (global::Android.Content.Context p0)
		{
			if (id_startDiscovery_Landroid_content_Context_ == IntPtr.Zero)
				id_startDiscovery_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "startDiscovery", "(Landroid/content/Context;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startDiscovery_Landroid_content_Context_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDiscovery", "(Landroid/content/Context;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_update_Ljava_util_Observable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler ()
		{
			if (cb_update_Ljava_util_Observable_Ljava_lang_Object_ == null)
				cb_update_Ljava_util_Observable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Ljava_util_Observable_Ljava_lang_Object_);
			return cb_update_Ljava_util_Observable_Ljava_lang_Object_;
		}

		static void n_Update_Ljava_util_Observable_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.RobotProvider __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Observable p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Observable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_util_Observable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotProvider']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.util.Observable'] and parameter[2][@type='java.lang.Object']]"
		[Register ("update", "(Ljava/util/Observable;Ljava/lang/Object;)V", "GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler")]
		public virtual void Update (global::Java.Util.Observable p0, global::Java.Lang.Object p1)
		{
			if (id_update_Ljava_util_Observable_Ljava_lang_Object_ == IntPtr.Zero)
				id_update_Ljava_util_Observable_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_Ljava_util_Observable_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1));
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
#region "Event implementation for Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener"
		public event EventHandler NoRobotsPaired {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener, global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListenerImplementor>(
						ref weak_implementor_SetOnNoRobotsPairedListener,
						__CreateIOnNoRobotsPairedListenerImplementor,
						SetOnNoRobotsPairedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListener, global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListenerImplementor>(
						ref weak_implementor_SetOnNoRobotsPairedListener,
						global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListenerImplementor.__IsEmpty,
						__v => SetOnNoRobotsPairedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnNoRobotsPairedListener;

		global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListenerImplementor __CreateIOnNoRobotsPairedListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.RobotProvider.IOnNoRobotsPairedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener"
		public event EventHandler<global::Orbotix.Robot.Base.RobotProvider.RobotConnectedEventArgs> RobotConnected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectedListener,
						__CreateIOnRobotConnectedListenerImplementor,
						SetOnRobotConnectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectedListener,
						global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListenerImplementor.__IsEmpty,
						__v => SetOnRobotConnectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRobotConnectedListener;

		global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListenerImplementor __CreateIOnRobotConnectedListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener"
		public event EventHandler<global::Orbotix.Robot.Base.RobotProvider.RobotConnectionFailedEventArgs> RobotConnectionFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionFailedListener,
						__CreateIOnRobotConnectionFailedListenerImplementor,
						SetOnRobotConnectionFailedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListenerImplementor>(
						ref weak_implementor_SetOnRobotConnectionFailedListener,
						global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListenerImplementor.__IsEmpty,
						__v => SetOnRobotConnectionFailedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRobotConnectionFailedListener;

		global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListenerImplementor __CreateIOnRobotConnectionFailedListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.RobotProvider.IOnRobotConnectionFailedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener"
		public event EventHandler<global::Orbotix.Robot.Base.RobotProvider.RobotDisconnectedEventArgs> RobotDisconnected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListenerImplementor>(
						ref weak_implementor_SetOnRobotDisconnectedListener,
						__CreateIOnRobotDisconnectedListenerImplementor,
						SetOnRobotDisconnectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListenerImplementor>(
						ref weak_implementor_SetOnRobotDisconnectedListener,
						global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListenerImplementor.__IsEmpty,
						__v => SetOnRobotDisconnectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRobotDisconnectedListener;

		global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListenerImplementor __CreateIOnRobotDisconnectedListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.RobotProvider.IOnRobotDisconnectedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener"
		public event EventHandler<global::Orbotix.Robot.Base.RobotProvider.RobotFoundEventArgs> RobotFound {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListenerImplementor>(
						ref weak_implementor_SetOnRobotFoundListener,
						__CreateIOnRobotFoundListenerImplementor,
						SetOnRobotFoundListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListenerImplementor>(
						ref weak_implementor_SetOnRobotFoundListener,
						global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListenerImplementor.__IsEmpty,
						__v => SetOnRobotFoundListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRobotFoundListener;

		global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListenerImplementor __CreateIOnRobotFoundListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.RobotProvider.IOnRobotFoundListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener"
		public event EventHandler<global::Orbotix.Robot.Base.RobotProvider.RobotOneFoundEventArgs> RobotOneFound {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListenerImplementor>(
						ref weak_implementor_SetOnRobotOneFoundListener,
						__CreateIOnRobotOneFoundListenerImplementor,
						SetOnRobotOneFoundListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListener, global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListenerImplementor>(
						ref weak_implementor_SetOnRobotOneFoundListener,
						global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListenerImplementor.__IsEmpty,
						__v => SetOnRobotOneFoundListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRobotOneFoundListener;

		global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListenerImplementor __CreateIOnRobotOneFoundListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.RobotProvider.IOnRobotOneFoundListenerImplementor (this);
		}
#endregion
	}
}
