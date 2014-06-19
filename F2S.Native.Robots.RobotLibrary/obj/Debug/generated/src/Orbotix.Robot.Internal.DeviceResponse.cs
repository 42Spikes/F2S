using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceResponse", DoNotGenerateAcw=true)]
	public partial class DeviceResponse : global::Orbotix.Robot.Internal.DeviceMessage {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/field[@name='TOTAL_PACKET_PREFIX_LENGTH']"
		[Register ("TOTAL_PACKET_PREFIX_LENGTH")]
		protected const int TotalPacketPrefixLength = (int) 5;

		static IntPtr dataCorrupt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/field[@name='dataCorrupt']"
		[Register ("dataCorrupt")]
		protected bool DataCorrupt {
			get {
				if (dataCorrupt_jfieldId == IntPtr.Zero)
					dataCorrupt_jfieldId = JNIEnv.GetFieldID (class_ref, "dataCorrupt", "Z");
				return JNIEnv.GetBooleanField (Handle, dataCorrupt_jfieldId);
			}
			set {
				if (dataCorrupt_jfieldId == IntPtr.Zero)
					dataCorrupt_jfieldId = JNIEnv.GetFieldID (class_ref, "dataCorrupt", "Z");
				JNIEnv.SetField (Handle, dataCorrupt_jfieldId, value);
			}
		}

		static IntPtr dataLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/field[@name='dataLength']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/field[@name='packet']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']"
		[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceResponse$ResponseCode", DoNotGenerateAcw=true)]
		public sealed partial class ResponseCode : global::Java.Lang.Enum {


			static IntPtr BAD_COMMAND_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='BAD_COMMAND_ERROR']"
			[Register ("BAD_COMMAND_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode BadCommandError {
				get {
					if (BAD_COMMAND_ERROR_jfieldId == IntPtr.Zero)
						BAD_COMMAND_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_COMMAND_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_COMMAND_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BAD_COMMAND_ERROR_jfieldId == IntPtr.Zero)
						BAD_COMMAND_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_COMMAND_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BAD_COMMAND_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BAD_MESSAGE_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='BAD_MESSAGE_ERROR']"
			[Register ("BAD_MESSAGE_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode BadMessageError {
				get {
					if (BAD_MESSAGE_ERROR_jfieldId == IntPtr.Zero)
						BAD_MESSAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_MESSAGE_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_MESSAGE_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BAD_MESSAGE_ERROR_jfieldId == IntPtr.Zero)
						BAD_MESSAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_MESSAGE_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BAD_MESSAGE_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CHECKSUM_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='CHECKSUM_ERROR']"
			[Register ("CHECKSUM_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode ChecksumError {
				get {
					if (CHECKSUM_ERROR_jfieldId == IntPtr.Zero)
						CHECKSUM_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECKSUM_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHECKSUM_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CHECKSUM_ERROR_jfieldId == IntPtr.Zero)
						CHECKSUM_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECKSUM_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CHECKSUM_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXECUTE_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='EXECUTE_ERROR']"
			[Register ("EXECUTE_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode ExecuteError {
				get {
					if (EXECUTE_ERROR_jfieldId == IntPtr.Zero)
						EXECUTE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXECUTE_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXECUTE_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXECUTE_ERROR_jfieldId == IntPtr.Zero)
						EXECUTE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXECUTE_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXECUTE_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FLASH_FAIL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='FLASH_FAIL']"
			[Register ("FLASH_FAIL")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode FlashFail {
				get {
					if (FLASH_FAIL_jfieldId == IntPtr.Zero)
						FLASH_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLASH_FAIL", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLASH_FAIL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FLASH_FAIL_jfieldId == IntPtr.Zero)
						FLASH_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLASH_FAIL", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FLASH_FAIL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FRAGMENT_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='FRAGMENT_ERROR']"
			[Register ("FRAGMENT_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode FragmentError {
				get {
					if (FRAGMENT_ERROR_jfieldId == IntPtr.Zero)
						FRAGMENT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAGMENT_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRAGMENT_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FRAGMENT_ERROR_jfieldId == IntPtr.Zero)
						FRAGMENT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAGMENT_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FRAGMENT_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GENERAL_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='GENERAL_ERROR']"
			[Register ("GENERAL_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode GeneralError {
				get {
					if (GENERAL_ERROR_jfieldId == IntPtr.Zero)
						GENERAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERAL_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERAL_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GENERAL_ERROR_jfieldId == IntPtr.Zero)
						GENERAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERAL_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GENERAL_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ILLEGAL_PAGE_NUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='ILLEGAL_PAGE_NUM']"
			[Register ("ILLEGAL_PAGE_NUM")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode IllegalPageNum {
				get {
					if (ILLEGAL_PAGE_NUM_jfieldId == IntPtr.Zero)
						ILLEGAL_PAGE_NUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ILLEGAL_PAGE_NUM", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ILLEGAL_PAGE_NUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ILLEGAL_PAGE_NUM_jfieldId == IntPtr.Zero)
						ILLEGAL_PAGE_NUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ILLEGAL_PAGE_NUM", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ILLEGAL_PAGE_NUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOW_VOLTAGE_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='LOW_VOLTAGE_ERROR']"
			[Register ("LOW_VOLTAGE_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode LowVoltageError {
				get {
					if (LOW_VOLTAGE_ERROR_jfieldId == IntPtr.Zero)
						LOW_VOLTAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW_VOLTAGE_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_VOLTAGE_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOW_VOLTAGE_ERROR_jfieldId == IntPtr.Zero)
						LOW_VOLTAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW_VOLTAGE_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOW_VOLTAGE_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MAIN_APP_CORRUPT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='MAIN_APP_CORRUPT']"
			[Register ("MAIN_APP_CORRUPT")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode MainAppCorrupt {
				get {
					if (MAIN_APP_CORRUPT_jfieldId == IntPtr.Zero)
						MAIN_APP_CORRUPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN_APP_CORRUPT", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAIN_APP_CORRUPT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MAIN_APP_CORRUPT_jfieldId == IntPtr.Zero)
						MAIN_APP_CORRUPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN_APP_CORRUPT", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MAIN_APP_CORRUPT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='OK']"
			[Register ("OK")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode Ok {
				get {
					if (OK_jfieldId == IntPtr.Zero)
						OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OK_jfieldId == IntPtr.Zero)
						OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PARAMETER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='PARAMETER_ERROR']"
			[Register ("PARAMETER_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode ParameterError {
				get {
					if (PARAMETER_ERROR_jfieldId == IntPtr.Zero)
						PARAMETER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARAMETER_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARAMETER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PARAMETER_ERROR_jfieldId == IntPtr.Zero)
						PARAMETER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARAMETER_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PARAMETER_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESPONSE_TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='RESPONSE_TIMEOUT']"
			[Register ("RESPONSE_TIMEOUT")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode ResponseTimeout {
				get {
					if (RESPONSE_TIMEOUT_jfieldId == IntPtr.Zero)
						RESPONSE_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESPONSE_TIMEOUT", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESPONSE_TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESPONSE_TIMEOUT_jfieldId == IntPtr.Zero)
						RESPONSE_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESPONSE_TIMEOUT", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESPONSE_TIMEOUT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TIMEOUT_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='TIMEOUT_ERROR']"
			[Register ("TIMEOUT_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode TimeoutError {
				get {
					if (TIMEOUT_ERROR_jfieldId == IntPtr.Zero)
						TIMEOUT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMEOUT_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TIMEOUT_ERROR_jfieldId == IntPtr.Zero)
						TIMEOUT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TIMEOUT_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_DEVICE_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='UNKNOWN_DEVICE_ID']"
			[Register ("UNKNOWN_DEVICE_ID")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode UnknownDeviceId {
				get {
					if (UNKNOWN_DEVICE_ID_jfieldId == IntPtr.Zero)
						UNKNOWN_DEVICE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_DEVICE_ID", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_DEVICE_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_DEVICE_ID_jfieldId == IntPtr.Zero)
						UNKNOWN_DEVICE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_DEVICE_ID", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_DEVICE_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNSUPPORTED_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/field[@name='UNSUPPORTED_ERROR']"
			[Register ("UNSUPPORTED_ERROR")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode UnsupportedError {
				get {
					if (UNSUPPORTED_ERROR_jfieldId == IntPtr.Zero)
						UNSUPPORTED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPPORTED_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNSUPPORTED_ERROR_jfieldId == IntPtr.Zero)
						UNSUPPORTED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_ERROR", "Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNSUPPORTED_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/robot/internal/DeviceResponse$ResponseCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResponseCode); }
			}

			internal ResponseCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCode;
			public sbyte Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()B", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()B");
					return JNIEnv.CallByteMethod  (Handle, id_getCode);
				}
			}

			static IntPtr id_byteToResponseCode_B;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/method[@name='byteToResponseCode' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("byteToResponseCode", "(B)Lorbotix/robot/internal/DeviceResponse$ResponseCode;", "")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode ByteToResponseCode (sbyte p0)
			{
				if (id_byteToResponseCode_B == IntPtr.Zero)
					id_byteToResponseCode_B = JNIEnv.GetStaticMethodID (class_ref, "byteToResponseCode", "(B)Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteToResponseCode_B, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/robot/internal/DeviceResponse$ResponseCode;", "")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse.ResponseCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorbotix/robot/internal/DeviceResponse$ResponseCode;", "")]
			public static global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/robot/internal/DeviceResponse$ResponseCode;");
				return (global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceResponse); }
		}

		protected DeviceResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/constructor[@name='DeviceResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected DeviceResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceResponse)) {
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

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/constructor[@name='DeviceResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public DeviceResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (DeviceResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/internal/DeviceCommand;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/internal/DeviceCommand;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/internal/DeviceCommand;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommandId;
		}
#pragma warning restore 0169

		static IntPtr id_getCommandId;
		public virtual sbyte CommandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getCommandId' and count(parameter)=0]"
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
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceId;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId;
		public virtual sbyte DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getDeviceId' and count(parameter)=0]"
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

		static Delegate cb_getIsDataCorrupt;
#pragma warning disable 0169
		static Delegate GetGetIsDataCorruptHandler ()
		{
			if (cb_getIsDataCorrupt == null)
				cb_getIsDataCorrupt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsDataCorrupt);
			return cb_getIsDataCorrupt;
		}

		static bool n_GetIsDataCorrupt (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataCorrupt;
		}
#pragma warning restore 0169

		static IntPtr id_getIsDataCorrupt;
		public virtual bool IsDataCorrupt {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getIsDataCorrupt' and count(parameter)=0]"
			[Register ("getIsDataCorrupt", "()Z", "GetGetIsDataCorruptHandler")]
			get {
				if (id_getIsDataCorrupt == IntPtr.Zero)
					id_getIsDataCorrupt = JNIEnv.GetMethodID (class_ref, "getIsDataCorrupt", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getIsDataCorrupt);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsDataCorrupt", "()Z"));
			}
		}

		static Delegate cb_getReceivedTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetReceivedTimeStampHandler ()
		{
			if (cb_getReceivedTimeStamp == null)
				cb_getReceivedTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetReceivedTimeStamp);
			return cb_getReceivedTimeStamp;
		}

		static long n_GetReceivedTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedTimeStamp;
		}
#pragma warning restore 0169

		static Delegate cb_setReceivedTimeStamp_J;
#pragma warning disable 0169
		static Delegate GetSetReceivedTimeStamp_JHandler ()
		{
			if (cb_setReceivedTimeStamp_J == null)
				cb_setReceivedTimeStamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetReceivedTimeStamp_J);
			return cb_setReceivedTimeStamp_J;
		}

		static void n_SetReceivedTimeStamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReceivedTimeStamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedTimeStamp;
		static IntPtr id_setReceivedTimeStamp_J;
		protected virtual long ReceivedTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getReceivedTimeStamp' and count(parameter)=0]"
			[Register ("getReceivedTimeStamp", "()J", "GetGetReceivedTimeStampHandler")]
			get {
				if (id_getReceivedTimeStamp == IntPtr.Zero)
					id_getReceivedTimeStamp = JNIEnv.GetMethodID (class_ref, "getReceivedTimeStamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getReceivedTimeStamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedTimeStamp", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='setReceivedTimeStamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setReceivedTimeStamp", "(J)V", "GetSetReceivedTimeStamp_JHandler")]
			set {
				if (id_setReceivedTimeStamp_J == IntPtr.Zero)
					id_setReceivedTimeStamp_J = JNIEnv.GetMethodID (class_ref, "setReceivedTimeStamp", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setReceivedTimeStamp_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedTimeStamp", "(J)V"), new JValue (value));
			}
		}

		static IntPtr id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='createTimeoutResponse' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceCommand']]"
		[Register ("createTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;)Lorbotix/robot/internal/DeviceResponse;", "")]
		public static global::Orbotix.Robot.Internal.DeviceResponse CreateTimeoutResponse (global::Orbotix.Robot.Internal.DeviceCommand p0)
		{
			if (id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_ == IntPtr.Zero)
				id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_ = JNIEnv.GetStaticMethodID (class_ref, "createTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;)Lorbotix/robot/internal/DeviceResponse;");
			global::Orbotix.Robot.Internal.DeviceResponse __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getData' and count(parameter)=0]"
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
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPacket ());
		}
#pragma warning restore 0169

		static IntPtr id_getPacket;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getPacket' and count(parameter)=0]"
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

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static IntPtr n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetResponseCode ());
		}
#pragma warning restore 0169

		static IntPtr id_getResponseCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='getResponseCode' and count(parameter)=0]"
		[Register ("getResponseCode", "()Lorbotix/robot/internal/DeviceResponse$ResponseCode;", "GetGetResponseCodeHandler")]
		public virtual global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode GetResponseCode ()
		{
			if (id_getResponseCode == IntPtr.Zero)
				id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()Lorbotix/robot/internal/DeviceResponse$ResponseCode;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (JNIEnv.CallObjectMethod  (Handle, id_getResponseCode), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse.ResponseCode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseCode", "()Lorbotix/robot/internal/DeviceResponse$ResponseCode;")), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Robot.Internal.DeviceResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseData ();
		}
#pragma warning restore 0169

		static IntPtr id_parseData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponse']/method[@name='parseData' and count(parameter)=0]"
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
}
