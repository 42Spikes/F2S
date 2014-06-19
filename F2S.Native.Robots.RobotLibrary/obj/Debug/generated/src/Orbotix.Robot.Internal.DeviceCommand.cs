using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceCommand", DoNotGenerateAcw=true)]
	public partial class DeviceCommand : global::Orbotix.Robot.Internal.DeviceMessage {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='BootloaderCommandJumpToMain']"
		[Register ("BootloaderCommandJumpToMain")]
		public const sbyte BootloaderCommandJumpToMain = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='BootloaderDeviceId']"
		[Register ("BootloaderDeviceId")]
		public const sbyte BootloaderDeviceId = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandGetBluetoothInfo']"
		[Register ("CoreCommandGetBluetoothInfo")]
		public const sbyte CoreCommandGetBluetoothInfo = (sbyte) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandGetPowerState']"
		[Register ("CoreCommandGetPowerState")]
		public const sbyte CoreCommandGetPowerState = (sbyte) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandGoToSleep']"
		[Register ("CoreCommandGoToSleep")]
		public const sbyte CoreCommandGoToSleep = (sbyte) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandJumpToBootloader']"
		[Register ("CoreCommandJumpToBootloader")]
		public const sbyte CoreCommandJumpToBootloader = (sbyte) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandLevel1Diagnostics']"
		[Register ("CoreCommandLevel1Diagnostics")]
		public const sbyte CoreCommandLevel1Diagnostics = (sbyte) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandPing']"
		[Register ("CoreCommandPing")]
		public const sbyte CoreCommandPing = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandPollPacketTimes']"
		[Register ("CoreCommandPollPacketTimes")]
		public const sbyte CoreCommandPollPacketTimes = (sbyte) 81;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandSetBluetoothName']"
		[Register ("CoreCommandSetBluetoothName")]
		public const sbyte CoreCommandSetBluetoothName = (sbyte) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandSetInactivityTimeout']"
		[Register ("CoreCommandSetInactivityTimeout")]
		public const sbyte CoreCommandSetInactivityTimeout = (sbyte) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandSetPowerNotification']"
		[Register ("CoreCommandSetPowerNotification")]
		public const sbyte CoreCommandSetPowerNotification = (sbyte) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreCommandVersioning']"
		[Register ("CoreCommandVersioning")]
		public const sbyte CoreCommandVersioning = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='CoreDeviceId']"
		[Register ("CoreDeviceId")]
		public const sbyte CoreDeviceId = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='INDEX_COMMAND_SEQUENCE_NO']"
		[Register ("INDEX_COMMAND_SEQUENCE_NO")]
		protected const int IndexCommandSequenceNo = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandAbortMacro']"
		[Register ("SpheroCommandAbortMacro")]
		public const sbyte SpheroCommandAbortMacro = (sbyte) 85;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandBackLEDOutput']"
		[Register ("SpheroCommandBackLEDOutput")]
		public const sbyte SpheroCommandBackLEDOutput = (sbyte) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandBoost']"
		[Register ("SpheroCommandBoost")]
		public const sbyte SpheroCommandBoost = (sbyte) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandCalibrate']"
		[Register ("SpheroCommandCalibrate")]
		public const sbyte SpheroCommandCalibrate = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandConfigureCollisionDetection']"
		[Register ("SpheroCommandConfigureCollisionDetection")]
		public const sbyte SpheroCommandConfigureCollisionDetection = (sbyte) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandConfigureLocator']"
		[Register ("SpheroCommandConfigureLocator")]
		public const sbyte SpheroCommandConfigureLocator = (sbyte) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandGetConfigurationBlock']"
		[Register ("SpheroCommandGetConfigurationBlock")]
		public const sbyte SpheroCommandGetConfigurationBlock = (sbyte) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandGetDeviceMode']"
		[Register ("SpheroCommandGetDeviceMode")]
		public const sbyte SpheroCommandGetDeviceMode = (sbyte) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandGetLEDColor']"
		[Register ("SpheroCommandGetLEDColor")]
		public const sbyte SpheroCommandGetLEDColor = (sbyte) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandGetNonPersistentOptionFlags']"
		[Register ("SpheroCommandGetNonPersistentOptionFlags")]
		public const sbyte SpheroCommandGetNonPersistentOptionFlags = (sbyte) 56;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandGetOptionFlags']"
		[Register ("SpheroCommandGetOptionFlags")]
		public const sbyte SpheroCommandGetOptionFlags = (sbyte) 54;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandInitMacroExecutive']"
		[Register ("SpheroCommandInitMacroExecutive")]
		public const sbyte SpheroCommandInitMacroExecutive = (sbyte) 84;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandOrbBasicAbortProgram']"
		[Register ("SpheroCommandOrbBasicAbortProgram")]
		public const sbyte SpheroCommandOrbBasicAbortProgram = (sbyte) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandOrbBasicAppendFragment']"
		[Register ("SpheroCommandOrbBasicAppendFragment")]
		public const sbyte SpheroCommandOrbBasicAppendFragment = (sbyte) 97;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandOrbBasicEraseStorage']"
		[Register ("SpheroCommandOrbBasicEraseStorage")]
		public const sbyte SpheroCommandOrbBasicEraseStorage = (sbyte) 96;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandOrbBasicExecuteProgram']"
		[Register ("SpheroCommandOrbBasicExecuteProgram")]
		public const sbyte SpheroCommandOrbBasicExecuteProgram = (sbyte) 98;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandRGBLEDOutput']"
		[Register ("SpheroCommandRGBLEDOutput")]
		public const sbyte SpheroCommandRGBLEDOutput = (sbyte) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandRawMotor']"
		[Register ("SpheroCommandRawMotor")]
		public const sbyte SpheroCommandRawMotor = (sbyte) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandRoll']"
		[Register ("SpheroCommandRoll")]
		public const sbyte SpheroCommandRoll = (sbyte) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandRotationRate']"
		[Register ("SpheroCommandRotationRate")]
		public const sbyte SpheroCommandRotationRate = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandRunMacro']"
		[Register ("SpheroCommandRunMacro")]
		public const sbyte SpheroCommandRunMacro = (sbyte) 80;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSaveMacro']"
		[Register ("SpheroCommandSaveMacro")]
		public const sbyte SpheroCommandSaveMacro = (sbyte) 82;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSaveTemporaryMacro']"
		[Register ("SpheroCommandSaveTemporaryMacro")]
		public const sbyte SpheroCommandSaveTemporaryMacro = (sbyte) 81;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSaveTemporaryMacroChunk']"
		[Register ("SpheroCommandSaveTemporaryMacroChunk")]
		public const sbyte SpheroCommandSaveTemporaryMacroChunk = (sbyte) 88;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSelfLevel']"
		[Register ("SpheroCommandSelfLevel")]
		public const sbyte SpheroCommandSelfLevel = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSetDataStreaming']"
		[Register ("SpheroCommandSetDataStreaming")]
		public const sbyte SpheroCommandSetDataStreaming = (sbyte) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSetDeviceMode']"
		[Register ("SpheroCommandSetDeviceMode")]
		public const sbyte SpheroCommandSetDeviceMode = (sbyte) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSetHeading']"
		[Register ("SpheroCommandSetHeading")]
		public const sbyte SpheroCommandSetHeading = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSetMotionTimeout']"
		[Register ("SpheroCommandSetMotionTimeout")]
		public const sbyte SpheroCommandSetMotionTimeout = (sbyte) 52;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSetNonPersistentOptionFlags']"
		[Register ("SpheroCommandSetNonPersistentOptionFlags")]
		public const sbyte SpheroCommandSetNonPersistentOptionFlags = (sbyte) 55;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandSetOptionFlags']"
		[Register ("SpheroCommandSetOptionFlags")]
		public const sbyte SpheroCommandSetOptionFlags = (sbyte) 53;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroCommandStabilization']"
		[Register ("SpheroCommandStabilization")]
		public const sbyte SpheroCommandStabilization = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/field[@name='SpheroDeviceId']"
		[Register ("SpheroDeviceId")]
		public const sbyte SpheroDeviceId = (sbyte) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']"
		[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceCommand$JsonProtocol", DoNotGenerateAcw=true)]
		public partial class JsonProtocol : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']/field[@name='COMMAND_IDENTIFIER_KEY']"
			[Register ("COMMAND_IDENTIFIER_KEY")]
			public const string CommandIdentifierKey = (string) "IDENTIFIER";

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']/field[@name='DEVICE_IDENTIFIER_KEY']"
			[Register ("DEVICE_IDENTIFIER_KEY")]
			public const string DeviceIdentifierKey = (string) "DEVICEIDENTIFIER";

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']/field[@name='PARAMS_KEY']"
			[Register ("PARAMS_KEY")]
			public const string ParamsKey = (string) "PARAMS";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/robot/internal/DeviceCommand$JsonProtocol", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JsonProtocol); }
			}

			protected JsonProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']/constructor[@name='DeviceCommand.JsonProtocol' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public JsonProtocol () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (JsonProtocol)) {
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

			static IntPtr id_getCommandJson_Lorbotix_robot_internal_DeviceCommand_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']/method[@name='getCommandJson' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("getCommandJson", "(Lorbotix/robot/internal/DeviceCommand;[Ljava/lang/Object;)Lorg/json/JSONObject;", "")]
			public static global::Org.Json.JSONObject GetCommandJson (global::Orbotix.Robot.Internal.DeviceCommand p0, params global:: Java.Lang.Object[] p1)
			{
				if (id_getCommandJson_Lorbotix_robot_internal_DeviceCommand_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_getCommandJson_Lorbotix_robot_internal_DeviceCommand_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getCommandJson", "(Lorbotix/robot/internal/DeviceCommand;[Ljava/lang/Object;)Lorg/json/JSONObject;");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommandJson_Lorbotix_robot_internal_DeviceCommand_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

			static IntPtr id_getCommandParamsFromJson_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand.JsonProtocol']/method[@name='getCommandParamsFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("getCommandParamsFromJson", "(Lorg/json/JSONObject;)[Ljava/lang/Object;", "")]
			public static global::Java.Lang.Object[] GetCommandParamsFromJson (global::Org.Json.JSONObject p0)
			{
				if (id_getCommandParamsFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_getCommandParamsFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getCommandParamsFromJson", "(Lorg/json/JSONObject;)[Ljava/lang/Object;");
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommandParamsFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceCommand); }
		}

		protected DeviceCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/constructor[@name='DeviceCommand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public DeviceCommand (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (DeviceCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_BBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/constructor[@name='DeviceCommand' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(BB[B)V", "")]
		public DeviceCommand (sbyte p0, sbyte p1, byte[] p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);;
			if (GetType () != typeof (DeviceCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(BB[B)V", new JValue (p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(BB[B)V", new JValue (p0), new JValue (p1), new JValue (native_p2));
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return;
			}

			if (id_ctor_BBarrayB == IntPtr.Zero)
				id_ctor_BBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(BB[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BBarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_BBarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/constructor[@name='DeviceCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected DeviceCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

		static IntPtr id_ctor_BB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/constructor[@name='DeviceCommand' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register (".ctor", "(BB)V", "")]
		public DeviceCommand (sbyte p0, sbyte p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(BB)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(BB)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_BB == IntPtr.Zero)
				id_ctor_BB = JNIEnv.GetMethodID (class_ref, "<init>", "(BB)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BB, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_BB, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getCommandId;
#pragma warning disable 0169
		static Delegate GetGetCommandIdHandler ()
		{
			if (cb_getCommandId == null)
				cb_getCommandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetCommandId);
			return cb_getCommandId;
		}

		static sbyte n_GetCommandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommandId;
		}
#pragma warning restore 0169

		static IntPtr id_getCommandId;
		public virtual sbyte CommandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getCommandId' and count(parameter)=0]"
			[Register ("getCommandId", "()B", "GetGetCommandIdHandler")]
			get {
				if (id_getCommandId == IntPtr.Zero)
					id_getCommandId = JNIEnv.GetMethodID (class_ref, "getCommandId", "()B");

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getCommandId);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommandId", "()B"));
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static sbyte n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceId;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId;
		public virtual sbyte DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()B", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()B");

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getDeviceId);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceId", "()B"));
			}
		}

		static Delegate cb_isResponseRequested;
#pragma warning disable 0169
		static Delegate GetIsResponseRequestedHandler ()
		{
			if (cb_isResponseRequested == null)
				cb_isResponseRequested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsResponseRequested);
			return cb_isResponseRequested;
		}

		static bool n_IsResponseRequested (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseRequested;
		}
#pragma warning restore 0169

		static Delegate cb_setResponseRequested_Z;
#pragma warning disable 0169
		static Delegate GetSetResponseRequested_ZHandler ()
		{
			if (cb_setResponseRequested_Z == null)
				cb_setResponseRequested_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetResponseRequested_Z);
			return cb_setResponseRequested_Z;
		}

		static void n_SetResponseRequested_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResponseRequested = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isResponseRequested;
		static IntPtr id_setResponseRequested_Z;
		public virtual bool ResponseRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='isResponseRequested' and count(parameter)=0]"
			[Register ("isResponseRequested", "()Z", "GetIsResponseRequestedHandler")]
			get {
				if (id_isResponseRequested == IntPtr.Zero)
					id_isResponseRequested = JNIEnv.GetMethodID (class_ref, "isResponseRequested", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isResponseRequested);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isResponseRequested", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='setResponseRequested' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setResponseRequested", "(Z)V", "GetSetResponseRequested_ZHandler")]
			set {
				if (id_setResponseRequested_Z == IntPtr.Zero)
					id_setResponseRequested_Z = JNIEnv.GetMethodID (class_ref, "setResponseRequested", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResponseRequested_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseRequested", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getSentTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetSentTimeStampHandler ()
		{
			if (cb_getSentTimeStamp == null)
				cb_getSentTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSentTimeStamp);
			return cb_getSentTimeStamp;
		}

		static long n_GetSentTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentTimeStamp;
		}
#pragma warning restore 0169

		static Delegate cb_setSentTimeStamp_J;
#pragma warning disable 0169
		static Delegate GetSetSentTimeStamp_JHandler ()
		{
			if (cb_setSentTimeStamp_J == null)
				cb_setSentTimeStamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSentTimeStamp_J);
			return cb_setSentTimeStamp_J;
		}

		static void n_SetSentTimeStamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SentTimeStamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSentTimeStamp;
		static IntPtr id_setSentTimeStamp_J;
		protected virtual long SentTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getSentTimeStamp' and count(parameter)=0]"
			[Register ("getSentTimeStamp", "()J", "GetGetSentTimeStampHandler")]
			get {
				if (id_getSentTimeStamp == IntPtr.Zero)
					id_getSentTimeStamp = JNIEnv.GetMethodID (class_ref, "getSentTimeStamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getSentTimeStamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentTimeStamp", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='setSentTimeStamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSentTimeStamp", "(J)V", "GetSetSentTimeStamp_JHandler")]
			set {
				if (id_setSentTimeStamp_J == IntPtr.Zero)
					id_setSentTimeStamp_J = JNIEnv.GetMethodID (class_ref, "setSentTimeStamp", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSentTimeStamp_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentTimeStamp", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_getSequenceNumber;
#pragma warning disable 0169
		static Delegate GetGetSequenceNumberHandler ()
		{
			if (cb_getSequenceNumber == null)
				cb_getSequenceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetSequenceNumber);
			return cb_getSequenceNumber;
		}

		static sbyte n_GetSequenceNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SequenceNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getSequenceNumber;
		public virtual sbyte SequenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getSequenceNumber' and count(parameter)=0]"
			[Register ("getSequenceNumber", "()B", "GetGetSequenceNumberHandler")]
			get {
				if (id_getSequenceNumber == IntPtr.Zero)
					id_getSequenceNumber = JNIEnv.GetMethodID (class_ref, "getSequenceNumber", "()B");

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getSequenceNumber);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSequenceNumber", "()B"));
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static Delegate cb_getCommandLength_I;
#pragma warning disable 0169
		static Delegate GetGetCommandLength_IHandler ()
		{
			if (cb_getCommandLength_I == null)
				cb_getCommandLength_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte>) n_GetCommandLength_I);
			return cb_getCommandLength_I;
		}

		static sbyte n_GetCommandLength_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCommandLength (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getCommandLength_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getCommandLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCommandLength", "(I)B", "GetGetCommandLength_IHandler")]
		public virtual sbyte GetCommandLength (int p0)
		{
			if (id_getCommandLength_I == IntPtr.Zero)
				id_getCommandLength_I = JNIEnv.GetMethodID (class_ref, "getCommandLength", "(I)B");

			if (GetType () == ThresholdType)
				return JNIEnv.CallByteMethod  (Handle, id_getCommandLength_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommandLength", "(I)B"), new JValue (p0));
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		protected virtual byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getFullPacket;
#pragma warning disable 0169
		static Delegate GetGetFullPacketHandler ()
		{
			if (cb_getFullPacket == null)
				cb_getFullPacket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFullPacket);
			return cb_getFullPacket;
		}

		static IntPtr n_GetFullPacket (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFullPacket ());
		}
#pragma warning restore 0169

		static IntPtr id_getFullPacket;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getFullPacket' and count(parameter)=0]"
		[Register ("getFullPacket", "()[B", "GetGetFullPacketHandler")]
		public virtual byte[] GetFullPacket ()
		{
			if (id_getFullPacket == IntPtr.Zero)
				id_getFullPacket = JNIEnv.GetMethodID (class_ref, "getFullPacket", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getFullPacket), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullPacket", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getPacket;
#pragma warning disable 0169
		static Delegate GetGetPacketHandler ()
		{
			if (cb_getPacket == null)
				cb_getPacket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPacket);
			return cb_getPacket;
		}

		static IntPtr n_GetPacket (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPacket ());
		}
#pragma warning restore 0169

		static IntPtr id_getPacket;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getPacket' and count(parameter)=0]"
		[Register ("getPacket", "()[B", "GetGetPacketHandler")]
		protected virtual byte[] GetPacket ()
		{
			if (id_getPacket == IntPtr.Zero)
				id_getPacket = JNIEnv.GetMethodID (class_ref, "getPacket", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPacket), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacket", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPrefix ());
		}
#pragma warning restore 0169

		static IntPtr id_getPrefix;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='getPrefix' and count(parameter)=0]"
		[Register ("getPrefix", "()[B", "GetGetPrefixHandler")]
		public virtual byte[] GetPrefix ()
		{
			if (id_getPrefix == IntPtr.Zero)
				id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefix", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_setKeepAlive_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepAlive_ZHandler ()
		{
			if (cb_setKeepAlive_Z == null)
				cb_setKeepAlive_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetKeepAlive_Z);
			return cb_setKeepAlive_Z;
		}

		static void n_SetKeepAlive_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Robot.Internal.DeviceCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepAlive (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeepAlive_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommand']/method[@name='setKeepAlive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKeepAlive", "(Z)V", "GetSetKeepAlive_ZHandler")]
		public virtual void SetKeepAlive (bool p0)
		{
			if (id_setKeepAlive_Z == IntPtr.Zero)
				id_setKeepAlive_Z = JNIEnv.GetMethodID (class_ref, "setKeepAlive", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setKeepAlive_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAlive", "(Z)V"), new JValue (p0));
		}

	}
}
