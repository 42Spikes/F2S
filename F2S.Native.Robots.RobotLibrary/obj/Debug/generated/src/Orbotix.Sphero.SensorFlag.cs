using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']"
	[global::Android.Runtime.Register ("orbotix/sphero/SensorFlag", DoNotGenerateAcw=true)]
	public sealed partial class SensorFlag : global::Java.Lang.Enum, global::Orbotix.Util.IMaskable {


		static IntPtr ACCELEROMETER_NORMALIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='ACCELEROMETER_NORMALIZED']"
		[Register ("ACCELEROMETER_NORMALIZED")]
		public static global::Orbotix.Sphero.SensorFlag AccelerometerNormalized {
			get {
				if (ACCELEROMETER_NORMALIZED_jfieldId == IntPtr.Zero)
					ACCELEROMETER_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCELEROMETER_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCELEROMETER_NORMALIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACCELEROMETER_NORMALIZED_jfieldId == IntPtr.Zero)
					ACCELEROMETER_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCELEROMETER_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ACCELEROMETER_NORMALIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ACCELEROMETER_RAW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='ACCELEROMETER_RAW']"
		[Register ("ACCELEROMETER_RAW")]
		public static global::Orbotix.Sphero.SensorFlag AccelerometerRaw {
			get {
				if (ACCELEROMETER_RAW_jfieldId == IntPtr.Zero)
					ACCELEROMETER_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCELEROMETER_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCELEROMETER_RAW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACCELEROMETER_RAW_jfieldId == IntPtr.Zero)
					ACCELEROMETER_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCELEROMETER_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ACCELEROMETER_RAW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ATTITUDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='ATTITUDE']"
		[Register ("ATTITUDE")]
		public static global::Orbotix.Sphero.SensorFlag Attitude {
			get {
				if (ATTITUDE_jfieldId == IntPtr.Zero)
					ATTITUDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATTITUDE", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATTITUDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ATTITUDE_jfieldId == IntPtr.Zero)
					ATTITUDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATTITUDE", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ATTITUDE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GYRO_NORMALIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='GYRO_NORMALIZED']"
		[Register ("GYRO_NORMALIZED")]
		public static global::Orbotix.Sphero.SensorFlag GyroNormalized {
			get {
				if (GYRO_NORMALIZED_jfieldId == IntPtr.Zero)
					GYRO_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GYRO_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GYRO_NORMALIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GYRO_NORMALIZED_jfieldId == IntPtr.Zero)
					GYRO_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GYRO_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GYRO_NORMALIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GYRO_RAW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='GYRO_RAW']"
		[Register ("GYRO_RAW")]
		public static global::Orbotix.Sphero.SensorFlag GyroRaw {
			get {
				if (GYRO_RAW_jfieldId == IntPtr.Zero)
					GYRO_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GYRO_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GYRO_RAW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GYRO_RAW_jfieldId == IntPtr.Zero)
					GYRO_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GYRO_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GYRO_RAW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LOCATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='LOCATOR']"
		[Register ("LOCATOR")]
		public static global::Orbotix.Sphero.SensorFlag Locator {
			get {
				if (LOCATOR_jfieldId == IntPtr.Zero)
					LOCATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATOR", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOCATOR_jfieldId == IntPtr.Zero)
					LOCATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATOR", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LOCATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAG_NORMALIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='MAG_NORMALIZED']"
		[Register ("MAG_NORMALIZED")]
		public static global::Orbotix.Sphero.SensorFlag MagNormalized {
			get {
				if (MAG_NORMALIZED_jfieldId == IntPtr.Zero)
					MAG_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAG_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAG_NORMALIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAG_NORMALIZED_jfieldId == IntPtr.Zero)
					MAG_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAG_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MAG_NORMALIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAG_RAW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='MAG_RAW']"
		[Register ("MAG_RAW")]
		public static global::Orbotix.Sphero.SensorFlag MagRaw {
			get {
				if (MAG_RAW_jfieldId == IntPtr.Zero)
					MAG_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAG_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAG_RAW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAG_RAW_jfieldId == IntPtr.Zero)
					MAG_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAG_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MAG_RAW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MOTOR_BACKEMF_NORMALIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='MOTOR_BACKEMF_NORMALIZED']"
		[Register ("MOTOR_BACKEMF_NORMALIZED")]
		public static global::Orbotix.Sphero.SensorFlag MotorBackemfNormalized {
			get {
				if (MOTOR_BACKEMF_NORMALIZED_jfieldId == IntPtr.Zero)
					MOTOR_BACKEMF_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOTOR_BACKEMF_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOTOR_BACKEMF_NORMALIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MOTOR_BACKEMF_NORMALIZED_jfieldId == IntPtr.Zero)
					MOTOR_BACKEMF_NORMALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOTOR_BACKEMF_NORMALIZED", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MOTOR_BACKEMF_NORMALIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MOTOR_BACKEMF_RAW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='MOTOR_BACKEMF_RAW']"
		[Register ("MOTOR_BACKEMF_RAW")]
		public static global::Orbotix.Sphero.SensorFlag MotorBackemfRaw {
			get {
				if (MOTOR_BACKEMF_RAW_jfieldId == IntPtr.Zero)
					MOTOR_BACKEMF_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOTOR_BACKEMF_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOTOR_BACKEMF_RAW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MOTOR_BACKEMF_RAW_jfieldId == IntPtr.Zero)
					MOTOR_BACKEMF_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOTOR_BACKEMF_RAW", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MOTOR_BACKEMF_RAW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr QUATERNION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='QUATERNION']"
		[Register ("QUATERNION")]
		public static global::Orbotix.Sphero.SensorFlag Quaternion {
			get {
				if (QUATERNION_jfieldId == IntPtr.Zero)
					QUATERNION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUATERNION", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUATERNION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QUATERNION_jfieldId == IntPtr.Zero)
					QUATERNION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUATERNION", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, QUATERNION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr VELOCITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/field[@name='VELOCITY']"
		[Register ("VELOCITY")]
		public static global::Orbotix.Sphero.SensorFlag Velocity {
			get {
				if (VELOCITY_jfieldId == IntPtr.Zero)
					VELOCITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VELOCITY", "Lorbotix/sphero/SensorFlag;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VELOCITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VELOCITY_jfieldId == IntPtr.Zero)
					VELOCITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VELOCITY", "Lorbotix/sphero/SensorFlag;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, VELOCITY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/SensorFlag", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SensorFlag); }
		}

		internal SensorFlag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_longValue);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/sphero/SensorFlag;", "")]
		public static global::Orbotix.Sphero.SensorFlag ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/sphero/SensorFlag;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Orbotix.Sphero.SensorFlag __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorFlag> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='SensorFlag']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorbotix/sphero/SensorFlag;", "")]
		public static global::Orbotix.Sphero.SensorFlag[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/sphero/SensorFlag;");
			return (global::Orbotix.Sphero.SensorFlag[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Sphero.SensorFlag));
		}

	}
}
