using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.util']/interface[@name='FirmwareRevision']"
	[Register ("orbotix/util/FirmwareRevision", "", "Orbotix.Util.IFirmwareRevisionInvoker")]
	public partial interface IFirmwareRevision : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/interface[@name='FirmwareRevision']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()D", "GetMaxHandler:Orbotix.Util.IFirmwareRevisionInvoker, F2S.Native.Robots.RobotLibrary")]
		double Max ();

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/interface[@name='FirmwareRevision']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()D", "GetMinHandler:Orbotix.Util.IFirmwareRevisionInvoker, F2S.Native.Robots.RobotLibrary")]
		double Min ();

	}

	[global::Android.Runtime.Register ("orbotix/util/FirmwareRevision", DoNotGenerateAcw=true)]
	internal class IFirmwareRevisionInvoker : global::Java.Lang.Object, IFirmwareRevision {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/util/FirmwareRevision");
		IntPtr class_ref;

		public static IFirmwareRevision GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFirmwareRevision> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.util.FirmwareRevision"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFirmwareRevisionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFirmwareRevisionInvoker); }
		}

		static Delegate cb_max;
#pragma warning disable 0169
		static Delegate GetMaxHandler ()
		{
			if (cb_max == null)
				cb_max = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Max);
			return cb_max;
		}

		static double n_Max (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.IFirmwareRevision __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IFirmwareRevision> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max ();
		}
#pragma warning restore 0169

		IntPtr id_max;
		public double Max ()
		{
			if (id_max == IntPtr.Zero)
				id_max = JNIEnv.GetMethodID (class_ref, "max", "()D");
			return JNIEnv.CallDoubleMethod (Handle, id_max);
		}

		static Delegate cb_min;
#pragma warning disable 0169
		static Delegate GetMinHandler ()
		{
			if (cb_min == null)
				cb_min = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Min);
			return cb_min;
		}

		static double n_Min (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.IFirmwareRevision __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IFirmwareRevision> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Min ();
		}
#pragma warning restore 0169

		IntPtr id_min;
		public double Min ()
		{
			if (id_min == IntPtr.Zero)
				id_min = JNIEnv.GetMethodID (class_ref, "min", "()D");
			return JNIEnv.CallDoubleMethod (Handle, id_min);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.IFirmwareRevision __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IFirmwareRevision> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Orbotix.Util.IFirmwareRevision __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IFirmwareRevision> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, new JValue (obj));
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.IFirmwareRevision __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IFirmwareRevision> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.IFirmwareRevision __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IFirmwareRevision> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
