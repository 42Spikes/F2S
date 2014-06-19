using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.util']/class[@name='ByteUtil']"
	[global::Android.Runtime.Register ("orbotix/robot/util/ByteUtil", DoNotGenerateAcw=true)]
	public partial class ByteUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/util/ByteUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteUtil); }
		}

		protected ByteUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.util']/class[@name='ByteUtil']/constructor[@name='ByteUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ByteUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ByteUtil)) {
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

		static IntPtr id_byteArrayToString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='ByteUtil']/method[@name='byteArrayToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteArrayToString", "([B)Ljava/lang/String;", "")]
		public static string ByteArrayToString (byte[] p0)
		{
			if (id_byteArrayToString_arrayB == IntPtr.Zero)
				id_byteArrayToString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byteArrayToString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteArrayToString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_convertUnsignedToInt_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='ByteUtil']/method[@name='convertUnsignedToInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("convertUnsignedToInt", "(B)I", "")]
		public static int ConvertUnsignedToInt (sbyte p0)
		{
			if (id_convertUnsignedToInt_B == IntPtr.Zero)
				id_convertUnsignedToInt_B = JNIEnv.GetStaticMethodID (class_ref, "convertUnsignedToInt", "(B)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_convertUnsignedToInt_B, new JValue (p0));
		}

		static IntPtr id_convertUnsignedToInt_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='ByteUtil']/method[@name='convertUnsignedToInt' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("convertUnsignedToInt", "(BB)I", "")]
		public static int ConvertUnsignedToInt (sbyte p0, sbyte p1)
		{
			if (id_convertUnsignedToInt_BB == IntPtr.Zero)
				id_convertUnsignedToInt_BB = JNIEnv.GetStaticMethodID (class_ref, "convertUnsignedToInt", "(BB)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_convertUnsignedToInt_BB, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_convertUnsignedToShort_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='ByteUtil']/method[@name='convertUnsignedToShort' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("convertUnsignedToShort", "(B)S", "")]
		public static short ConvertUnsignedToShort (sbyte p0)
		{
			if (id_convertUnsignedToShort_B == IntPtr.Zero)
				id_convertUnsignedToShort_B = JNIEnv.GetStaticMethodID (class_ref, "convertUnsignedToShort", "(B)S");
			return JNIEnv.CallStaticShortMethod  (class_ref, id_convertUnsignedToShort_B, new JValue (p0));
		}

	}
}
