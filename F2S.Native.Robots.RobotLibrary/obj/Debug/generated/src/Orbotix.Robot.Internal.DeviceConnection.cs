using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceConnection", DoNotGenerateAcw=true)]
	public partial class DeviceConnection : global::Java.Lang.Object {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Java.Lang.Boolean Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/field[@name='MESSAGE_DATA_KEY_COMMAND']"
		[Register ("MESSAGE_DATA_KEY_COMMAND")]
		protected const string MessageDataKeyCommand = (string) "command";
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession']"
		[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceConnection$DeviceSession", DoNotGenerateAcw=true)]
		protected internal partial class DeviceSession : global::Java.Lang.Object {


			static IntPtr sentQueue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession']/field[@name='sentQueue']"
			[Register ("sentQueue")]
			protected global::Java.Util.Concurrent.ConcurrentHashMap SentQueue {
				get {
					if (sentQueue_jfieldId == IntPtr.Zero)
						sentQueue_jfieldId = JNIEnv.GetFieldID (class_ref, "sentQueue", "Ljava/util/concurrent/ConcurrentHashMap;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, sentQueue_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ConcurrentHashMap> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (sentQueue_jfieldId == IntPtr.Zero)
						sentQueue_jfieldId = JNIEnv.GetFieldID (class_ref, "sentQueue", "Ljava/util/concurrent/ConcurrentHashMap;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, sentQueue_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession.ReadThread']"
			[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceConnection$DeviceSession$ReadThread", DoNotGenerateAcw=true)]
			public partial class ReadThread : global::Java.Lang.Thread {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("orbotix/robot/internal/DeviceConnection$DeviceSession$ReadThread", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (ReadThread); }
				}

				protected ReadThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_stopRunning;
#pragma warning disable 0169
				static Delegate GetStopRunningHandler ()
				{
					if (cb_stopRunning == null)
						cb_stopRunning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopRunning);
					return cb_stopRunning;
				}

				static void n_StopRunning (IntPtr jnienv, IntPtr native__this)
				{
					global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession.ReadThread __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession.ReadThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.StopRunning ();
				}
#pragma warning restore 0169

				static IntPtr id_stopRunning;
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession.ReadThread']/method[@name='stopRunning' and count(parameter)=0]"
				[Register ("stopRunning", "()V", "GetStopRunningHandler")]
				public virtual void StopRunning ()
				{
					if (id_stopRunning == IntPtr.Zero)
						id_stopRunning = JNIEnv.GetMethodID (class_ref, "stopRunning", "()V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_stopRunning);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopRunning", "()V"));
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/robot/internal/DeviceConnection$DeviceSession", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceSession); }
			}

			protected DeviceSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_robot_internal_DeviceConnection_Landroid_bluetooth_BluetoothSocket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession']/constructor[@name='DeviceConnection.DeviceSession' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceConnection'] and parameter[2][@type='android.bluetooth.BluetoothSocket']]"
			[Register (".ctor", "(Lorbotix/robot/internal/DeviceConnection;Landroid/bluetooth/BluetoothSocket;)V", "")]
			public DeviceSession (global::Orbotix.Robot.Internal.DeviceConnection __self, global::Android.Bluetooth.BluetoothSocket p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DeviceSession)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/bluetooth/BluetoothSocket;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/bluetooth/BluetoothSocket;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorbotix_robot_internal_DeviceConnection_Landroid_bluetooth_BluetoothSocket_ == IntPtr.Zero)
					id_ctor_Lorbotix_robot_internal_DeviceConnection_Landroid_bluetooth_BluetoothSocket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/internal/DeviceConnection;Landroid/bluetooth/BluetoothSocket;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_internal_DeviceConnection_Landroid_bluetooth_BluetoothSocket_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_internal_DeviceConnection_Landroid_bluetooth_BluetoothSocket_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_getWriteHandler;
#pragma warning disable 0169
			static Delegate GetGetWriteHandlerHandler ()
			{
				if (cb_getWriteHandler == null)
					cb_getWriteHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWriteHandler);
				return cb_getWriteHandler;
			}

			static IntPtr n_GetWriteHandler (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WriteHandler);
			}
#pragma warning restore 0169

			static IntPtr id_getWriteHandler;
			public virtual global::Android.OS.Handler WriteHandler {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession']/method[@name='getWriteHandler' and count(parameter)=0]"
				[Register ("getWriteHandler", "()Landroid/os/Handler;", "GetGetWriteHandlerHandler")]
				get {
					if (id_getWriteHandler == IntPtr.Zero)
						id_getWriteHandler = JNIEnv.GetMethodID (class_ref, "getWriteHandler", "()Landroid/os/Handler;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod  (Handle, id_getWriteHandler), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteHandler", "()Landroid/os/Handler;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_shutDown;
#pragma warning disable 0169
			static Delegate GetShutDownHandler ()
			{
				if (cb_shutDown == null)
					cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
				return cb_shutDown;
			}

			static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShutDown ();
			}
#pragma warning restore 0169

			static IntPtr id_shutDown;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession']/method[@name='shutDown' and count(parameter)=0]"
			[Register ("shutDown", "()V", "GetShutDownHandler")]
			public virtual void ShutDown ()
			{
				if (id_shutDown == IntPtr.Zero)
					id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			}

			static Delegate cb_start;
#pragma warning disable 0169
			static Delegate GetStartHandler ()
			{
				if (cb_start == null)
					cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
				return cb_start;
			}

			static void n_Start (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection.DeviceSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Start ();
			}
#pragma warning restore 0169

			static IntPtr id_start;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection.DeviceSession']/method[@name='start' and count(parameter)=0]"
			[Register ("start", "()V", "GetStartHandler")]
			public virtual void Start ()
			{
				if (id_start == IntPtr.Zero)
					id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceConnection); }
		}

		protected DeviceConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/constructor[@name='DeviceConnection' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;)V", "")]
		public DeviceConnection (global::Orbotix.Robot.Base.Robot p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceConnection)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_, new JValue (p0));
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
			global::Orbotix.Robot.Internal.DeviceConnection __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Robot);
		}
#pragma warning restore 0169

		static IntPtr id_getRobot;
		public virtual global::Orbotix.Robot.Base.Robot Robot {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/method[@name='getRobot' and count(parameter)=0]"
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceConnection __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceConnection __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connect);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()V"));
		}

		static Delegate cb_sendCommand_Lorbotix_robot_internal_DeviceCommand_J;
#pragma warning disable 0169
		static Delegate GetSendCommand_Lorbotix_robot_internal_DeviceCommand_JHandler ()
		{
			if (cb_sendCommand_Lorbotix_robot_internal_DeviceCommand_J == null)
				cb_sendCommand_Lorbotix_robot_internal_DeviceCommand_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SendCommand_Lorbotix_robot_internal_DeviceCommand_J);
			return cb_sendCommand_Lorbotix_robot_internal_DeviceCommand_J;
		}

		static void n_SendCommand_Lorbotix_robot_internal_DeviceCommand_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Orbotix.Robot.Internal.DeviceConnection __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendCommand_Lorbotix_robot_internal_DeviceCommand_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceConnection']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='long']]"
		[Register ("sendCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V", "GetSendCommand_Lorbotix_robot_internal_DeviceCommand_JHandler")]
		public virtual void SendCommand (global::Orbotix.Robot.Internal.DeviceCommand p0, long p1)
		{
			if (id_sendCommand_Lorbotix_robot_internal_DeviceCommand_J == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_internal_DeviceCommand_J = JNIEnv.GetMethodID (class_ref, "sendCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendCommand_Lorbotix_robot_internal_DeviceCommand_J, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V"), new JValue (p0), new JValue (p1));
		}

	}
}
