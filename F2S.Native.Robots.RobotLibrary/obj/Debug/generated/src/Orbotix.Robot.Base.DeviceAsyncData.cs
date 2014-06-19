using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DeviceAsyncData", DoNotGenerateAcw=true)]
	public abstract partial class DeviceAsyncData : global::Orbotix.Robot.Internal.DeviceMessage {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/field[@name='TOTAL_PACKET_PREFIX_LENGTH']"
		[Register ("TOTAL_PACKET_PREFIX_LENGTH")]
		protected const int TotalPacketPrefixLength = (int) 5;

		static IntPtr dataLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/field[@name='dataLength']"
		[Register ("dataLength")]
		protected int DataLength {
			get {
				if (dataLength_jfieldId == IntPtr.Zero)
					dataLength_jfieldId = JNIEnv.GetFieldID (class_ref, "dataLength", "I");
				return JNIEnv.GetIntField (Handle, dataLength_jfieldId);
			}
			set {
				if (dataLength_jfieldId == IntPtr.Zero)
					dataLength_jfieldId = JNIEnv.GetFieldID (class_ref, "dataLength", "I");
				JNIEnv.SetField (Handle, dataLength_jfieldId, value);
			}
		}

		static IntPtr packet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/field[@name='packet']"
		[Register ("packet")]
		protected IList<byte> Packet {
			get {
				if (packet_jfieldId == IntPtr.Zero)
					packet_jfieldId = JNIEnv.GetFieldID (class_ref, "packet", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, packet_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (packet_jfieldId == IntPtr.Zero)
					packet_jfieldId = JNIEnv.GetFieldID (class_ref, "packet", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, packet_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']"
		[global::Android.Runtime.Register ("orbotix/robot/base/DeviceAsyncData$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr CollisionDetected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='CollisionDetected']"
			[Register ("CollisionDetected")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type CollisionDetected {
				get {
					if (CollisionDetected_jfieldId == IntPtr.Zero)
						CollisionDetected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CollisionDetected", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CollisionDetected_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CollisionDetected_jfieldId == IntPtr.Zero)
						CollisionDetected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CollisionDetected", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CollisionDetected_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ConfigBlockContents_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='ConfigBlockContents']"
			[Register ("ConfigBlockContents")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type ConfigBlockContents {
				get {
					if (ConfigBlockContents_jfieldId == IntPtr.Zero)
						ConfigBlockContents_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ConfigBlockContents", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ConfigBlockContents_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ConfigBlockContents_jfieldId == IntPtr.Zero)
						ConfigBlockContents_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ConfigBlockContents", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ConfigBlockContents_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr Error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='Error']"
			[Register ("Error")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type Error {
				get {
					if (Error_jfieldId == IntPtr.Zero)
						Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Error", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Error_jfieldId == IntPtr.Zero)
						Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Error", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Error_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GyroLimitsExceeded_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='GyroLimitsExceeded']"
			[Register ("GyroLimitsExceeded")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type GyroLimitsExceeded {
				get {
					if (GyroLimitsExceeded_jfieldId == IntPtr.Zero)
						GyroLimitsExceeded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GyroLimitsExceeded", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GyroLimitsExceeded_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GyroLimitsExceeded_jfieldId == IntPtr.Zero)
						GyroLimitsExceeded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GyroLimitsExceeded", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GyroLimitsExceeded_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr Level1DiagnosticResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='Level1DiagnosticResponse']"
			[Register ("Level1DiagnosticResponse")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type Level1DiagnosticResponse {
				get {
					if (Level1DiagnosticResponse_jfieldId == IntPtr.Zero)
						Level1DiagnosticResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Level1DiagnosticResponse", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Level1DiagnosticResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Level1DiagnosticResponse_jfieldId == IntPtr.Zero)
						Level1DiagnosticResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Level1DiagnosticResponse", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Level1DiagnosticResponse_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MacroEmitMarker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='MacroEmitMarker']"
			[Register ("MacroEmitMarker")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type MacroEmitMarker {
				get {
					if (MacroEmitMarker_jfieldId == IntPtr.Zero)
						MacroEmitMarker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MacroEmitMarker", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MacroEmitMarker_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MacroEmitMarker_jfieldId == IntPtr.Zero)
						MacroEmitMarker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MacroEmitMarker", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MacroEmitMarker_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OrbBasicErrorASCII_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='OrbBasicErrorASCII']"
			[Register ("OrbBasicErrorASCII")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type OrbBasicErrorASCII {
				get {
					if (OrbBasicErrorASCII_jfieldId == IntPtr.Zero)
						OrbBasicErrorASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OrbBasicErrorASCII", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OrbBasicErrorASCII_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OrbBasicErrorASCII_jfieldId == IntPtr.Zero)
						OrbBasicErrorASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OrbBasicErrorASCII", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OrbBasicErrorASCII_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OrbBasicErrorBinary_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='OrbBasicErrorBinary']"
			[Register ("OrbBasicErrorBinary")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type OrbBasicErrorBinary {
				get {
					if (OrbBasicErrorBinary_jfieldId == IntPtr.Zero)
						OrbBasicErrorBinary_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OrbBasicErrorBinary", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OrbBasicErrorBinary_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OrbBasicErrorBinary_jfieldId == IntPtr.Zero)
						OrbBasicErrorBinary_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OrbBasicErrorBinary", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OrbBasicErrorBinary_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OrbBasicPrint_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='OrbBasicPrint']"
			[Register ("OrbBasicPrint")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type OrbBasicPrint {
				get {
					if (OrbBasicPrint_jfieldId == IntPtr.Zero)
						OrbBasicPrint_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OrbBasicPrint", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OrbBasicPrint_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OrbBasicPrint_jfieldId == IntPtr.Zero)
						OrbBasicPrint_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OrbBasicPrint", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OrbBasicPrint_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PowerNotifications_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='PowerNotifications']"
			[Register ("PowerNotifications")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type PowerNotifications {
				get {
					if (PowerNotifications_jfieldId == IntPtr.Zero)
						PowerNotifications_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PowerNotifications", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PowerNotifications_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PowerNotifications_jfieldId == IntPtr.Zero)
						PowerNotifications_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PowerNotifications", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PowerNotifications_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PreSleepWarning_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='PreSleepWarning']"
			[Register ("PreSleepWarning")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type PreSleepWarning {
				get {
					if (PreSleepWarning_jfieldId == IntPtr.Zero)
						PreSleepWarning_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PreSleepWarning", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PreSleepWarning_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PreSleepWarning_jfieldId == IntPtr.Zero)
						PreSleepWarning_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PreSleepWarning", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PreSleepWarning_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SelfLevelComplete_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='SelfLevelComplete']"
			[Register ("SelfLevelComplete")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type SelfLevelComplete {
				get {
					if (SelfLevelComplete_jfieldId == IntPtr.Zero)
						SelfLevelComplete_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SelfLevelComplete", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SelfLevelComplete_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SelfLevelComplete_jfieldId == IntPtr.Zero)
						SelfLevelComplete_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SelfLevelComplete", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SelfLevelComplete_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SensorDataStreaming_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/field[@name='SensorDataStreaming']"
			[Register ("SensorDataStreaming")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type SensorDataStreaming {
				get {
					if (SensorDataStreaming_jfieldId == IntPtr.Zero)
						SensorDataStreaming_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SensorDataStreaming", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SensorDataStreaming_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SensorDataStreaming_jfieldId == IntPtr.Zero)
						SensorDataStreaming_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SensorDataStreaming", "Lorbotix/robot/base/DeviceAsyncData$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SensorDataStreaming_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/robot/base/DeviceAsyncData$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public sbyte Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()B", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()B");
					return JNIEnv.CallByteMethod  (Handle, id_getValue);
				}
			}

			static IntPtr id_fromByte_B;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/method[@name='fromByte' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("fromByte", "(B)Lorbotix/robot/base/DeviceAsyncData$Type;", "")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type FromByte (sbyte p0)
			{
				if (id_fromByte_B == IntPtr.Zero)
					id_fromByte_B = JNIEnv.GetStaticMethodID (class_ref, "fromByte", "(B)Lorbotix/robot/base/DeviceAsyncData$Type;");
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromByte_B, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/robot/base/DeviceAsyncData$Type;", "")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/robot/base/DeviceAsyncData$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Orbotix.Robot.Base.DeviceAsyncData.Type __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorbotix/robot/base/DeviceAsyncData$Type;", "")]
			public static global::Orbotix.Robot.Base.DeviceAsyncData.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/robot/base/DeviceAsyncData$Type;");
				return (global::Orbotix.Robot.Base.DeviceAsyncData.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Robot.Base.DeviceAsyncData.Type));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DeviceAsyncData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceAsyncData); }
		}

		protected DeviceAsyncData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/constructor[@name='DeviceAsyncData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected DeviceAsyncData (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceAsyncData)) {
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

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/constructor[@name='DeviceAsyncData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;[B)V", "")]
		public DeviceAsyncData (global::Orbotix.Robot.Base.Robot p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (DeviceAsyncData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAsyncDataType;
#pragma warning disable 0169
		static Delegate GetGetAsyncDataTypeHandler ()
		{
			if (cb_getAsyncDataType == null)
				cb_getAsyncDataType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsyncDataType);
			return cb_getAsyncDataType;
		}

		static IntPtr n_GetAsyncDataType (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DeviceAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsyncDataType);
		}
#pragma warning restore 0169

		static IntPtr id_getAsyncDataType;
		public virtual global::Orbotix.Robot.Base.DeviceAsyncData.Type AsyncDataType {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/method[@name='getAsyncDataType' and count(parameter)=0]"
			[Register ("getAsyncDataType", "()Lorbotix/robot/base/DeviceAsyncData$Type;", "GetGetAsyncDataTypeHandler")]
			get {
				if (id_getAsyncDataType == IntPtr.Zero)
					id_getAsyncDataType = JNIEnv.GetMethodID (class_ref, "getAsyncDataType", "()Lorbotix/robot/base/DeviceAsyncData$Type;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (JNIEnv.CallObjectMethod  (Handle, id_getAsyncDataType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsyncDataType", "()Lorbotix/robot/base/DeviceAsyncData$Type;")), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Robot.Base.DeviceAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Robot);
		}
#pragma warning restore 0169

		static IntPtr id_getRobot;
		public virtual global::Orbotix.Robot.Base.Robot Robot {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/method[@name='getRobot' and count(parameter)=0]"
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
			global::Orbotix.Robot.Base.DeviceAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Orbotix.Robot.Base.DeviceAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/method[@name='getData' and count(parameter)=0]"
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
			global::Orbotix.Robot.Base.DeviceAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPacket ());
		}
#pragma warning restore 0169

		static IntPtr id_getPacket;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/method[@name='getPacket' and count(parameter)=0]"
		[Register ("getPacket", "()[B", "GetGetPacketHandler")]
		public virtual byte[] GetPacket ()
		{
			if (id_getPacket == IntPtr.Zero)
				id_getPacket = JNIEnv.GetMethodID (class_ref, "getPacket", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPacket), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacket", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_parseData;
#pragma warning disable 0169
		static Delegate GetParseDataHandler ()
		{
			if (cb_parseData == null)
				cb_parseData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ParseData);
			return cb_parseData;
		}

		static void n_ParseData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DeviceAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseData ();
		}
#pragma warning restore 0169

		static IntPtr id_parseData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceAsyncData']/method[@name='parseData' and count(parameter)=0]"
		[Register ("parseData", "()V", "GetParseDataHandler")]
		protected virtual void ParseData ()
		{
			if (id_parseData == IntPtr.Zero)
				id_parseData = JNIEnv.GetMethodID (class_ref, "parseData", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_parseData);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseData", "()V"));
		}

	}

	[global::Android.Runtime.Register ("orbotix/robot/base/DeviceAsyncData", DoNotGenerateAcw=true)]
	internal partial class DeviceAsyncDataInvoker : DeviceAsyncData {

		public DeviceAsyncDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceAsyncDataInvoker); }
		}

	}

}
