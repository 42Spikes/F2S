using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.configuration']/class[@name='NonPersistentOptionFlagsCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/configuration/NonPersistentOptionFlagsCommand", DoNotGenerateAcw=true)]
	public partial class NonPersistentOptionFlagsCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.configuration']/class[@name='NonPersistentOptionFlagsCommand']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/configuration/NonPersistentOptionFlagsCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NonPersistentOptionFlagsCommand); }
		}

		protected NonPersistentOptionFlagsCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLorbotix_sphero_NonPersistentOptionFlags_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.configuration']/class[@name='NonPersistentOptionFlagsCommand']/constructor[@name='NonPersistentOptionFlagsCommand' and count(parameter)=1 and parameter[1][@type='orbotix.sphero.NonPersistentOptionFlags...']]"
		[Register (".ctor", "([Lorbotix/sphero/NonPersistentOptionFlags;)V", "")]
		public NonPersistentOptionFlagsCommand (params global:: Orbotix.Sphero.NonPersistentOptionFlags[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (NonPersistentOptionFlagsCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lorbotix/sphero/NonPersistentOptionFlags;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lorbotix/sphero/NonPersistentOptionFlags;)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayLorbotix_sphero_NonPersistentOptionFlags_ == IntPtr.Zero)
				id_ctor_arrayLorbotix_sphero_NonPersistentOptionFlags_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorbotix/sphero/NonPersistentOptionFlags;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorbotix_sphero_NonPersistentOptionFlags_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLorbotix_sphero_NonPersistentOptionFlags_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lorbotix_util_BitMask_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.configuration']/class[@name='NonPersistentOptionFlagsCommand']/constructor[@name='NonPersistentOptionFlagsCommand' and count(parameter)=1 and parameter[1][@type='orbotix.util.BitMask']]"
		[Register (".ctor", "(Lorbotix/util/BitMask;)V", "")]
		public NonPersistentOptionFlagsCommand (global::Orbotix.Util.BitMask p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NonPersistentOptionFlagsCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/util/BitMask;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/util/BitMask;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_util_BitMask_ == IntPtr.Zero)
				id_ctor_Lorbotix_util_BitMask_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/util/BitMask;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_util_BitMask_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_util_BitMask_, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.configuration']/class[@name='NonPersistentOptionFlagsCommand']/constructor[@name='NonPersistentOptionFlagsCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NonPersistentOptionFlagsCommand () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NonPersistentOptionFlagsCommand)) {
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

		static Delegate cb_getMask;
#pragma warning disable 0169
		static Delegate GetGetMaskHandler ()
		{
			if (cb_getMask == null)
				cb_getMask = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMask);
			return cb_getMask;
		}

		static IntPtr n_GetMask (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Configuration.NonPersistentOptionFlagsCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Configuration.NonPersistentOptionFlagsCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mask);
		}
#pragma warning restore 0169

		static IntPtr id_getMask;
		public virtual global::Orbotix.Util.BitMask Mask {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.configuration']/class[@name='NonPersistentOptionFlagsCommand']/method[@name='getMask' and count(parameter)=0]"
			[Register ("getMask", "()Lorbotix/util/BitMask;", "GetGetMaskHandler")]
			get {
				if (id_getMask == IntPtr.Zero)
					id_getMask = JNIEnv.GetMethodID (class_ref, "getMask", "()Lorbotix/util/BitMask;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (JNIEnv.CallObjectMethod  (Handle, id_getMask), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Util.BitMask> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMask", "()Lorbotix/util/BitMask;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
