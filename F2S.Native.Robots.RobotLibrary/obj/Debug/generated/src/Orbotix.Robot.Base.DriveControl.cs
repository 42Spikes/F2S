using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DriveControl", DoNotGenerateAcw=true)]
	public partial class DriveControl : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener, global::Java.Util.IObserver {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Orbotix.Robot.Base.DriveControl Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lorbotix/robot/base/DriveControl;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lorbotix/robot/base/DriveControl;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INSTANCE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/field[@name='JOY_STICK']"
		[Register ("JOY_STICK")]
		public const int JoyStick = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/field[@name='RC']"
		[Register ("RC")]
		public const int Rc = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/field[@name='TILT']"
		[Register ("TILT")]
		public const int Tilt = (int) 1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DriveControl.ConnectionListener']"
		[Register ("orbotix/robot/base/DriveControl$ConnectionListener", "", "Orbotix.Robot.Base.DriveControl/IConnectionListenerInvoker")]
		public partial interface IConnectionListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DriveControl.ConnectionListener']/method[@name='onLostControl' and count(parameter)=0]"
			[Register ("onLostControl", "()V", "GetOnLostControlHandler:Orbotix.Robot.Base.DriveControl/IConnectionListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnLostControl ();

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/DriveControl$ConnectionListener", DoNotGenerateAcw=true)]
		internal class IConnectionListenerInvoker : global::Java.Lang.Object, IConnectionListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/DriveControl$ConnectionListener");
			IntPtr class_ref;

			public static IConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConnectionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.DriveControl.ConnectionListener"));
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

			static Delegate cb_onLostControl;
#pragma warning disable 0169
			static Delegate GetOnLostControlHandler ()
			{
				if (cb_onLostControl == null)
					cb_onLostControl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLostControl);
				return cb_onLostControl;
			}

			static void n_OnLostControl (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.DriveControl.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLostControl ();
			}
#pragma warning restore 0169

			IntPtr id_onLostControl;
			public void OnLostControl ()
			{
				if (id_onLostControl == IntPtr.Zero)
					id_onLostControl = JNIEnv.GetMethodID (class_ref, "onLostControl", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onLostControl);
			}

		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/DriveControl_ConnectionListenerImplementor")]
		internal sealed class IConnectionListenerImplementor : global::Java.Lang.Object, IConnectionListener {

			object sender;

			public IConnectionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/DriveControl_ConnectionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnLostControl ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IConnectionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DriveControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DriveControl); }
		}

		protected DriveControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRobotControl;
		}
#pragma warning restore 0169

		static IntPtr id_hasRobotControl;
		public virtual bool HasRobotControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='hasRobotControl' and count(parameter)=0]"
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
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Robot);
		}
#pragma warning restore 0169

		static IntPtr id_getRobot;
		public virtual global::Orbotix.Robot.Base.Robot Robot {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='getRobot' and count(parameter)=0]"
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

		static Delegate cb_getRobotControl;
#pragma warning disable 0169
		static Delegate GetGetRobotControlHandler ()
		{
			if (cb_getRobotControl == null)
				cb_getRobotControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobotControl);
			return cb_getRobotControl;
		}

		static IntPtr n_GetRobotControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RobotControl);
		}
#pragma warning restore 0169

		static IntPtr id_getRobotControl;
		public virtual global::Orbotix.Robot.Base.RobotControl RobotControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='getRobotControl' and count(parameter)=0]"
			[Register ("getRobotControl", "()Lorbotix/robot/base/RobotControl;", "GetGetRobotControlHandler")]
			get {
				if (id_getRobotControl == IntPtr.Zero)
					id_getRobotControl = JNIEnv.GetMethodID (class_ref, "getRobotControl", "()Lorbotix/robot/base/RobotControl;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (JNIEnv.CallObjectMethod  (Handle, id_getRobotControl), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotControl", "()Lorbotix/robot/base/RobotControl;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRobotProvider;
#pragma warning disable 0169
		static Delegate GetGetRobotProviderHandler ()
		{
			if (cb_getRobotProvider == null)
				cb_getRobotProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobotProvider);
			return cb_getRobotProvider;
		}

		static IntPtr n_GetRobotProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RobotProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getRobotProvider;
		public virtual global::Orbotix.Robot.Base.RobotProvider RobotProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='getRobotProvider' and count(parameter)=0]"
			[Register ("getRobotProvider", "()Lorbotix/robot/base/RobotProvider;", "GetGetRobotProviderHandler")]
			get {
				if (id_getRobotProvider == IntPtr.Zero)
					id_getRobotProvider = JNIEnv.GetMethodID (class_ref, "getRobotProvider", "()Lorbotix/robot/base/RobotProvider;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (JNIEnv.CallObjectMethod  (Handle, id_getRobotProvider), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotProvider> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotProvider", "()Lorbotix/robot/base/RobotProvider;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_connectRobot;
#pragma warning disable 0169
		static Delegate GetConnectRobotHandler ()
		{
			if (cb_connectRobot == null)
				cb_connectRobot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectRobot);
			return cb_connectRobot;
		}

		static void n_ConnectRobot (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectRobot ();
		}
#pragma warning restore 0169

		static IntPtr id_connectRobot;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='connectRobot' and count(parameter)=0]"
		[Register ("connectRobot", "()V", "GetConnectRobotHandler")]
		public virtual void ConnectRobot ()
		{
			if (id_connectRobot == IntPtr.Zero)
				id_connectRobot = JNIEnv.GetMethodID (class_ref, "connectRobot", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connectRobot);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectRobot", "()V"));
		}

		static Delegate cb_disableDirectionalDrive_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDisableDirectionalDrive_Landroid_content_Context_Handler ()
		{
			if (cb_disableDirectionalDrive_Landroid_content_Context_ == null)
				cb_disableDirectionalDrive_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DisableDirectionalDrive_Landroid_content_Context_);
			return cb_disableDirectionalDrive_Landroid_content_Context_;
		}

		static void n_DisableDirectionalDrive_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisableDirectionalDrive (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disableDirectionalDrive_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='disableDirectionalDrive' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disableDirectionalDrive", "(Landroid/content/Context;)V", "GetDisableDirectionalDrive_Landroid_content_Context_Handler")]
		public virtual void DisableDirectionalDrive (global::Android.Content.Context p0)
		{
			if (id_disableDirectionalDrive_Landroid_content_Context_ == IntPtr.Zero)
				id_disableDirectionalDrive_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "disableDirectionalDrive", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableDirectionalDrive_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableDirectionalDrive", "(Landroid/content/Context;)V"), new JValue (p0));
		}

		static Delegate cb_disconnectRobot;
#pragma warning disable 0169
		static Delegate GetDisconnectRobotHandler ()
		{
			if (cb_disconnectRobot == null)
				cb_disconnectRobot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectRobot);
			return cb_disconnectRobot;
		}

		static void n_DisconnectRobot (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectRobot ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectRobot;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='disconnectRobot' and count(parameter)=0]"
		[Register ("disconnectRobot", "()V", "GetDisconnectRobotHandler")]
		public virtual void DisconnectRobot ()
		{
			if (id_disconnectRobot == IntPtr.Zero)
				id_disconnectRobot = JNIEnv.GetMethodID (class_ref, "disconnectRobot", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disconnectRobot);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectRobot", "()V"));
		}

		static Delegate cb_driveAlgorithm;
#pragma warning disable 0169
		static Delegate GetDriveAlgorithmHandler ()
		{
			if (cb_driveAlgorithm == null)
				cb_driveAlgorithm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DriveAlgorithm);
			return cb_driveAlgorithm;
		}

		static IntPtr n_DriveAlgorithm (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DriveAlgorithm ());
		}
#pragma warning restore 0169

		static IntPtr id_driveAlgorithm;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='driveAlgorithm' and count(parameter)=0]"
		[Register ("driveAlgorithm", "()Lorbotix/robot/base/DriveAlgorithm;", "GetDriveAlgorithmHandler")]
		public virtual global::Orbotix.Robot.Base.DriveAlgorithm DriveAlgorithm ()
		{
			if (id_driveAlgorithm == IntPtr.Zero)
				id_driveAlgorithm = JNIEnv.GetMethodID (class_ref, "driveAlgorithm", "()Lorbotix/robot/base/DriveAlgorithm;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (JNIEnv.CallObjectMethod  (Handle, id_driveAlgorithm), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "driveAlgorithm", "()Lorbotix/robot/base/DriveAlgorithm;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_driveJoyStick_DD;
#pragma warning disable 0169
		static Delegate GetDriveJoyStick_DDHandler ()
		{
			if (cb_driveJoyStick_DD == null)
				cb_driveJoyStick_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_DriveJoyStick_DD);
			return cb_driveJoyStick_DD;
		}

		static void n_DriveJoyStick_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DriveJoyStick (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_driveJoyStick_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='driveJoyStick' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("driveJoyStick", "(DD)V", "GetDriveJoyStick_DDHandler")]
		public virtual void DriveJoyStick (double p0, double p1)
		{
			if (id_driveJoyStick_DD == IntPtr.Zero)
				id_driveJoyStick_DD = JNIEnv.GetMethodID (class_ref, "driveJoyStick", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_driveJoyStick_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "driveJoyStick", "(DD)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_driveRc_DD;
#pragma warning disable 0169
		static Delegate GetDriveRc_DDHandler ()
		{
			if (cb_driveRc_DD == null)
				cb_driveRc_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_DriveRc_DD);
			return cb_driveRc_DD;
		}

		static void n_DriveRc_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DriveRc (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_driveRc_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='driveRc' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("driveRc", "(DD)V", "GetDriveRc_DDHandler")]
		public virtual void DriveRc (double p0, double p1)
		{
			if (id_driveRc_DD == IntPtr.Zero)
				id_driveRc_DD = JNIEnv.GetMethodID (class_ref, "driveRc", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_driveRc_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "driveRc", "(DD)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_enableDirectionalDrive_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetEnableDirectionalDrive_Landroid_content_Context_Handler ()
		{
			if (cb_enableDirectionalDrive_Landroid_content_Context_ == null)
				cb_enableDirectionalDrive_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EnableDirectionalDrive_Landroid_content_Context_);
			return cb_enableDirectionalDrive_Landroid_content_Context_;
		}

		static void n_EnableDirectionalDrive_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableDirectionalDrive (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableDirectionalDrive_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='enableDirectionalDrive' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("enableDirectionalDrive", "(Landroid/content/Context;)V", "GetEnableDirectionalDrive_Landroid_content_Context_Handler")]
		public virtual void EnableDirectionalDrive (global::Android.Content.Context p0)
		{
			if (id_enableDirectionalDrive_Landroid_content_Context_ == IntPtr.Zero)
				id_enableDirectionalDrive_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "enableDirectionalDrive", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableDirectionalDrive_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableDirectionalDrive", "(Landroid/content/Context;)V"), new JValue (p0));
		}

		static Delegate cb_isDriving;
#pragma warning disable 0169
		static Delegate GetIsDrivingHandler ()
		{
			if (cb_isDriving == null)
				cb_isDriving = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsDriving);
			return cb_isDriving;
		}

		static IntPtr n_IsDriving (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsDriving ());
		}
#pragma warning restore 0169

		static IntPtr id_isDriving;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='isDriving' and count(parameter)=0]"
		[Register ("isDriving", "()Ljava/lang/Boolean;", "GetIsDrivingHandler")]
		public virtual global::Java.Lang.Boolean IsDriving ()
		{
			if (id_isDriving == IntPtr.Zero)
				id_isDriving = JNIEnv.GetMethodID (class_ref, "isDriving", "()Ljava/lang/Boolean;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isDriving), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDriving", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
#pragma warning disable 0169
		static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler ()
		{
			if (cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
				cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAccuracyChanged_Landroid_hardware_Sensor_I);
			return cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Sensor p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Sensor> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorStatus p1 = (global::Android.Hardware.SensorStatus) native_p1;
			__this.OnAccuracyChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAccuracyChanged_Landroid_hardware_Sensor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public virtual void OnAccuracyChanged (global::Android.Hardware.Sensor p0, global::Android.Hardware.SensorStatus p1)
		{
			if (id_onAccuracyChanged_Landroid_hardware_Sensor_I == IntPtr.Zero)
				id_onAccuracyChanged_Landroid_hardware_Sensor_I = JNIEnv.GetMethodID (class_ref, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAccuracyChanged_Landroid_hardware_Sensor_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V"), new JValue (p0), new JValue ((int) p1));
		}

		static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
#pragma warning disable 0169
		static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler ()
		{
			if (cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
				cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSensorChanged_Landroid_hardware_SensorEvent_);
			return cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		static void n_OnSensorChanged_Landroid_hardware_SensorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSensorChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSensorChanged_Landroid_hardware_SensorEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public virtual void OnSensorChanged (global::Android.Hardware.SensorEvent p0)
		{
			if (id_onSensorChanged_Landroid_hardware_SensorEvent_ == IntPtr.Zero)
				id_onSensorChanged_Landroid_hardware_SensorEvent_ = JNIEnv.GetMethodID (class_ref, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSensorChanged_Landroid_hardware_SensorEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V"), new JValue (p0));
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
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBroadcastContext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBroadcastContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='setBroadcastContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_;
#pragma warning disable 0169
		static Delegate GetSetConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_Handler ()
		{
			if (cb_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_ == null)
				cb_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_);
			return cb_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_;
		}

		static void n_SetConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DriveControl.IConnectionListener p0 = (global::Orbotix.Robot.Base.DriveControl.IConnectionListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl.IConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='setConnectionListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.DriveControl.ConnectionListener']]"
		[Register ("setConnectionListener", "(Lorbotix/robot/base/DriveControl$ConnectionListener;)V", "GetSetConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_Handler")]
		public virtual void SetConnectionListener (global::Orbotix.Robot.Base.DriveControl.IConnectionListener p0)
		{
			if (id_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_ == IntPtr.Zero)
				id_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_ = JNIEnv.GetMethodID (class_ref, "setConnectionListener", "(Lorbotix/robot/base/DriveControl$ConnectionListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConnectionListener_Lorbotix_robot_base_DriveControl_ConnectionListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectionListener", "(Lorbotix/robot/base/DriveControl$ConnectionListener;)V"), new JValue (p0));
		}

		static Delegate cb_setJoyStickPadSize_DD;
#pragma warning disable 0169
		static Delegate GetSetJoyStickPadSize_DDHandler ()
		{
			if (cb_setJoyStickPadSize_DD == null)
				cb_setJoyStickPadSize_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_SetJoyStickPadSize_DD);
			return cb_setJoyStickPadSize_DD;
		}

		static void n_SetJoyStickPadSize_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetJoyStickPadSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setJoyStickPadSize_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='setJoyStickPadSize' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("setJoyStickPadSize", "(DD)V", "GetSetJoyStickPadSize_DDHandler")]
		public virtual void SetJoyStickPadSize (double p0, double p1)
		{
			if (id_setJoyStickPadSize_DD == IntPtr.Zero)
				id_setJoyStickPadSize_DD = JNIEnv.GetMethodID (class_ref, "setJoyStickPadSize", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setJoyStickPadSize_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJoyStickPadSize", "(DD)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_;
#pragma warning disable 0169
		static Delegate GetSetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_Handler ()
		{
			if (cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ == null)
				cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_);
			return cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_;
		}

		static void n_SetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener p0 = (global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnConvertListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='setOnConvertListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.DriveAlgorithm.OnConvertListener']]"
		[Register ("setOnConvertListener", "(Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;)V", "GetSetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_Handler")]
		public virtual void SetOnConvertListener (global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener p0)
		{
			if (id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ == IntPtr.Zero)
				id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ = JNIEnv.GetMethodID (class_ref, "setOnConvertListener", "(Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnConvertListener", "(Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;)V"), new JValue (p0));
		}

		static Delegate cb_setSpeedScale_D;
#pragma warning disable 0169
		static Delegate GetSetSpeedScale_DHandler ()
		{
			if (cb_setSpeedScale_D == null)
				cb_setSpeedScale_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetSpeedScale_D);
			return cb_setSpeedScale_D;
		}

		static void n_SetSpeedScale_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpeedScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSpeedScale_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='setSpeedScale' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setSpeedScale", "(D)V", "GetSetSpeedScale_DHandler")]
		public virtual void SetSpeedScale (double p0)
		{
			if (id_setSpeedScale_D == IntPtr.Zero)
				id_setSpeedScale_D = JNIEnv.GetMethodID (class_ref, "setSpeedScale", "(D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSpeedScale_D, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpeedScale", "(D)V"), new JValue (p0));
		}

		static Delegate cb_startDriving_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetStartDriving_Landroid_content_Context_IHandler ()
		{
			if (cb_startDriving_Landroid_content_Context_I == null)
				cb_startDriving_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartDriving_Landroid_content_Context_I);
			return cb_startDriving_Landroid_content_Context_I;
		}

		static void n_StartDriving_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartDriving (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startDriving_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='startDriving' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("startDriving", "(Landroid/content/Context;I)V", "GetStartDriving_Landroid_content_Context_IHandler")]
		public virtual void StartDriving (global::Android.Content.Context p0, int p1)
		{
			if (id_startDriving_Landroid_content_Context_I == IntPtr.Zero)
				id_startDriving_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "startDriving", "(Landroid/content/Context;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startDriving_Landroid_content_Context_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDriving", "(Landroid/content/Context;I)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_stopDriving;
#pragma warning disable 0169
		static Delegate GetStopDrivingHandler ()
		{
			if (cb_stopDriving == null)
				cb_stopDriving = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopDriving);
			return cb_stopDriving;
		}

		static void n_StopDriving (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDriving ();
		}
#pragma warning restore 0169

		static IntPtr id_stopDriving;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='stopDriving' and count(parameter)=0]"
		[Register ("stopDriving", "()V", "GetStopDrivingHandler")]
		public virtual void StopDriving ()
		{
			if (id_stopDriving == IntPtr.Zero)
				id_stopDriving = JNIEnv.GetMethodID (class_ref, "stopDriving", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopDriving);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopDriving", "()V"));
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
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Observable p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Observable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_util_Observable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.util.Observable'] and parameter[2][@type='java.lang.Object']]"
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

		static Delegate cb_updateCalibratedHeading;
#pragma warning disable 0169
		static Delegate GetUpdateCalibratedHeadingHandler ()
		{
			if (cb_updateCalibratedHeading == null)
				cb_updateCalibratedHeading = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateCalibratedHeading);
			return cb_updateCalibratedHeading;
		}

		static void n_UpdateCalibratedHeading (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCalibratedHeading ();
		}
#pragma warning restore 0169

		static IntPtr id_updateCalibratedHeading;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveControl']/method[@name='updateCalibratedHeading' and count(parameter)=0]"
		[Register ("updateCalibratedHeading", "()V", "GetUpdateCalibratedHeadingHandler")]
		public virtual void UpdateCalibratedHeading ()
		{
			if (id_updateCalibratedHeading == IntPtr.Zero)
				id_updateCalibratedHeading = JNIEnv.GetMethodID (class_ref, "updateCalibratedHeading", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_updateCalibratedHeading);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCalibratedHeading", "()V"));
		}

#region "Event implementation for Orbotix.Robot.Base.DriveControl.IConnectionListener"
		public event EventHandler Connection {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.DriveControl.IConnectionListener, global::Orbotix.Robot.Base.DriveControl.IConnectionListenerImplementor>(
						ref weak_implementor_SetConnectionListener,
						__CreateIConnectionListenerImplementor,
						SetConnectionListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.DriveControl.IConnectionListener, global::Orbotix.Robot.Base.DriveControl.IConnectionListenerImplementor>(
						ref weak_implementor_SetConnectionListener,
						global::Orbotix.Robot.Base.DriveControl.IConnectionListenerImplementor.__IsEmpty,
						__v => SetConnectionListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetConnectionListener;

		global::Orbotix.Robot.Base.DriveControl.IConnectionListenerImplementor __CreateIConnectionListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.DriveControl.IConnectionListenerImplementor (this);
		}
#endregion
#region "Event implementation for Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener"
		public event EventHandler<global::Orbotix.Robot.Base.DriveAlgorithm.ConvertEventArgs> Convert {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener, global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor>(
						ref weak_implementor_SetOnConvertListener,
						__CreateIOnConvertListenerImplementor,
						SetOnConvertListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener, global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor>(
						ref weak_implementor_SetOnConvertListener,
						global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor.__IsEmpty,
						__v => SetOnConvertListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnConvertListener;

		global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor __CreateIOnConvertListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor (this);
		}
#endregion
	}
}
