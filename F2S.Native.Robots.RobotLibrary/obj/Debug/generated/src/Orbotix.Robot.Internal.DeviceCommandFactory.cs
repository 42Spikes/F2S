using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceCommandFactory", DoNotGenerateAcw=true)]
	public partial class DeviceCommandFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandAbortMacro']"
		[Register ("SpheroCommandAbortMacro")]
		protected const sbyte SpheroCommandAbortMacro = (sbyte) 85;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandBackLEDOutput']"
		[Register ("SpheroCommandBackLEDOutput")]
		protected const sbyte SpheroCommandBackLEDOutput = (sbyte) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandBoost']"
		[Register ("SpheroCommandBoost")]
		protected const sbyte SpheroCommandBoost = (sbyte) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandCalibrate']"
		[Register ("SpheroCommandCalibrate")]
		protected const sbyte SpheroCommandCalibrate = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandGetConfigurationBlock']"
		[Register ("SpheroCommandGetConfigurationBlock")]
		protected const sbyte SpheroCommandGetConfigurationBlock = (sbyte) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandRGBLEDOutput']"
		[Register ("SpheroCommandRGBLEDOutput")]
		protected const sbyte SpheroCommandRGBLEDOutput = (sbyte) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandRawMotor']"
		[Register ("SpheroCommandRawMotor")]
		protected const sbyte SpheroCommandRawMotor = (sbyte) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandRoll']"
		[Register ("SpheroCommandRoll")]
		protected const sbyte SpheroCommandRoll = (sbyte) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandRotationRate']"
		[Register ("SpheroCommandRotationRate")]
		protected const sbyte SpheroCommandRotationRate = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandRunMacro']"
		[Register ("SpheroCommandRunMacro")]
		protected const sbyte SpheroCommandRunMacro = (sbyte) 80;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandSaveMacro']"
		[Register ("SpheroCommandSaveMacro")]
		protected const sbyte SpheroCommandSaveMacro = (sbyte) 82;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandSaveTemporaryMacro']"
		[Register ("SpheroCommandSaveTemporaryMacro")]
		protected const sbyte SpheroCommandSaveTemporaryMacro = (sbyte) 81;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandSetDataStreaming']"
		[Register ("SpheroCommandSetDataStreaming")]
		protected const sbyte SpheroCommandSetDataStreaming = (sbyte) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/field[@name='SpheroCommandStabilization']"
		[Register ("SpheroCommandStabilization")]
		protected const sbyte SpheroCommandStabilization = (sbyte) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceCommandFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceCommandFactory); }
		}

		protected DeviceCommandFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/constructor[@name='DeviceCommandFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceCommandFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceCommandFactory)) {
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

		static IntPtr id_createFromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceCommandFactory']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/internal/DeviceCommand;", "")]
		public static global::Orbotix.Robot.Internal.DeviceCommand CreateFromJson (global::Org.Json.JSONObject p0)
		{
			if (id_createFromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createFromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "createFromJson", "(Lorg/json/JSONObject;)Lorbotix/robot/internal/DeviceCommand;");
			global::Orbotix.Robot.Internal.DeviceCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromJson_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
