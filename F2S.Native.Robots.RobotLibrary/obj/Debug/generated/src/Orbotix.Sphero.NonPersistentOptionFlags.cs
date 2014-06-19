using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='NonPersistentOptionFlags']"
	[global::Android.Runtime.Register ("orbotix/sphero/NonPersistentOptionFlags", DoNotGenerateAcw=true)]
	public sealed partial class NonPersistentOptionFlags : global::Java.Lang.Enum, global::Orbotix.Util.IMaskable {


		static IntPtr StopOnDisconnect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='NonPersistentOptionFlags']/field[@name='StopOnDisconnect']"
		[Register ("StopOnDisconnect")]
		public static global::Orbotix.Sphero.NonPersistentOptionFlags StopOnDisconnect {
			get {
				if (StopOnDisconnect_jfieldId == IntPtr.Zero)
					StopOnDisconnect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StopOnDisconnect", "Lorbotix/sphero/NonPersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, StopOnDisconnect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.NonPersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (StopOnDisconnect_jfieldId == IntPtr.Zero)
					StopOnDisconnect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StopOnDisconnect", "Lorbotix/sphero/NonPersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, StopOnDisconnect_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/NonPersistentOptionFlags", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NonPersistentOptionFlags); }
		}

		internal NonPersistentOptionFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='NonPersistentOptionFlags']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_longValue);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='NonPersistentOptionFlags']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/sphero/NonPersistentOptionFlags;", "")]
		public static global::Orbotix.Sphero.NonPersistentOptionFlags ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/sphero/NonPersistentOptionFlags;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Orbotix.Sphero.NonPersistentOptionFlags __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.NonPersistentOptionFlags> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='NonPersistentOptionFlags']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorbotix/sphero/NonPersistentOptionFlags;", "")]
		public static global::Orbotix.Sphero.NonPersistentOptionFlags[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/sphero/NonPersistentOptionFlags;");
			return (global::Orbotix.Sphero.NonPersistentOptionFlags[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Sphero.NonPersistentOptionFlags));
		}

	}
}
