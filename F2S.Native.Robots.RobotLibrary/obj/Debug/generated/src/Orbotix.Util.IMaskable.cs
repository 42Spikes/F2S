using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.util']/interface[@name='Maskable']"
	[Register ("orbotix/util/Maskable", "", "Orbotix.Util.IMaskableInvoker")]
	public partial interface IMaskable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/interface[@name='Maskable']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "GetLongValueHandler:Orbotix.Util.IMaskableInvoker, F2S.Native.Robots.RobotLibrary")]
		long LongValue ();

	}

	[global::Android.Runtime.Register ("orbotix/util/Maskable", DoNotGenerateAcw=true)]
	internal class IMaskableInvoker : global::Java.Lang.Object, IMaskable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/util/Maskable");
		IntPtr class_ref;

		public static IMaskable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaskable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.util.Maskable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaskableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMaskableInvoker); }
		}

		static Delegate cb_longValue;
#pragma warning disable 0169
		static Delegate GetLongValueHandler ()
		{
			if (cb_longValue == null)
				cb_longValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_LongValue);
			return cb_longValue;
		}

		static long n_LongValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Util.IMaskable __this = global::Java.Lang.Object.GetObject<global::Orbotix.Util.IMaskable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue ();
		}
#pragma warning restore 0169

		IntPtr id_longValue;
		public long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			return JNIEnv.CallLongMethod (Handle, id_longValue);
		}

	}

}
