using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']"
	[global::Android.Runtime.Register ("orbotix/sphero/PersistentOptionFlags", DoNotGenerateAcw=true)]
	public sealed partial class PersistentOptionFlags : global::Java.Lang.Enum, global::Orbotix.Util.IMaskable {


		static IntPtr DefaultSettings_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/field[@name='DefaultSettings']"
		[Register ("DefaultSettings")]
		public static global::Orbotix.Sphero.PersistentOptionFlags DefaultSettings {
			get {
				if (DefaultSettings_jfieldId == IntPtr.Zero)
					DefaultSettings_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DefaultSettings", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DefaultSettings_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DefaultSettings_jfieldId == IntPtr.Zero)
					DefaultSettings_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DefaultSettings", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DefaultSettings_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DisableSelfLevelInCharger_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/field[@name='DisableSelfLevelInCharger']"
		[Register ("DisableSelfLevelInCharger")]
		public static global::Orbotix.Sphero.PersistentOptionFlags DisableSelfLevelInCharger {
			get {
				if (DisableSelfLevelInCharger_jfieldId == IntPtr.Zero)
					DisableSelfLevelInCharger_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DisableSelfLevelInCharger", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DisableSelfLevelInCharger_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DisableSelfLevelInCharger_jfieldId == IntPtr.Zero)
					DisableSelfLevelInCharger_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DisableSelfLevelInCharger", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DisableSelfLevelInCharger_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EnableMotionTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/field[@name='EnableMotionTimeout']"
		[Register ("EnableMotionTimeout")]
		public static global::Orbotix.Sphero.PersistentOptionFlags EnableMotionTimeout {
			get {
				if (EnableMotionTimeout_jfieldId == IntPtr.Zero)
					EnableMotionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EnableMotionTimeout", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EnableMotionTimeout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EnableMotionTimeout_jfieldId == IntPtr.Zero)
					EnableMotionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EnableMotionTimeout", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EnableMotionTimeout_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EnablePersistentTailLight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/field[@name='EnablePersistentTailLight']"
		[Register ("EnablePersistentTailLight")]
		public static global::Orbotix.Sphero.PersistentOptionFlags EnablePersistentTailLight {
			get {
				if (EnablePersistentTailLight_jfieldId == IntPtr.Zero)
					EnablePersistentTailLight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EnablePersistentTailLight", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EnablePersistentTailLight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EnablePersistentTailLight_jfieldId == IntPtr.Zero)
					EnablePersistentTailLight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EnablePersistentTailLight", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EnablePersistentTailLight_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EnableVectorDrive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/field[@name='EnableVectorDrive']"
		[Register ("EnableVectorDrive")]
		public static global::Orbotix.Sphero.PersistentOptionFlags EnableVectorDrive {
			get {
				if (EnableVectorDrive_jfieldId == IntPtr.Zero)
					EnableVectorDrive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EnableVectorDrive", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EnableVectorDrive_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EnableVectorDrive_jfieldId == IntPtr.Zero)
					EnableVectorDrive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EnableVectorDrive", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EnableVectorDrive_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PreventSleepInCharger_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/field[@name='PreventSleepInCharger']"
		[Register ("PreventSleepInCharger")]
		public static global::Orbotix.Sphero.PersistentOptionFlags PreventSleepInCharger {
			get {
				if (PreventSleepInCharger_jfieldId == IntPtr.Zero)
					PreventSleepInCharger_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PreventSleepInCharger", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PreventSleepInCharger_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PreventSleepInCharger_jfieldId == IntPtr.Zero)
					PreventSleepInCharger_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PreventSleepInCharger", "Lorbotix/sphero/PersistentOptionFlags;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PreventSleepInCharger_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/PersistentOptionFlags", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersistentOptionFlags); }
		}

		internal PersistentOptionFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_longValue);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/sphero/PersistentOptionFlags;", "")]
		public static global::Orbotix.Sphero.PersistentOptionFlags ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/sphero/PersistentOptionFlags;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Orbotix.Sphero.PersistentOptionFlags __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.PersistentOptionFlags> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='PersistentOptionFlags']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorbotix/sphero/PersistentOptionFlags;", "")]
		public static global::Orbotix.Sphero.PersistentOptionFlags[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/sphero/PersistentOptionFlags;");
			return (global::Orbotix.Sphero.PersistentOptionFlags[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Sphero.PersistentOptionFlags));
		}

	}
}
