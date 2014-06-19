using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveTemporaryMacroChunkCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SaveTemporaryMacroChunkCommand", DoNotGenerateAcw=true)]
	public partial class SaveTemporaryMacroChunkCommand : global::Orbotix.Robot.Base.SaveTemporaryMacroCommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/SaveTemporaryMacroChunkCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SaveTemporaryMacroChunkCommand); }
		}

		protected SaveTemporaryMacroChunkCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_BarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveTemporaryMacroChunkCommand']/constructor[@name='SaveTemporaryMacroChunkCommand' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(B[B)V", "")]
		public SaveTemporaryMacroChunkCommand (sbyte p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (SaveTemporaryMacroChunkCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(B[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(B[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_BarrayB == IntPtr.Zero)
				id_ctor_BarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(B[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BarrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_BarrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setIsFirst_Z;
#pragma warning disable 0169
		static Delegate GetSetIsFirst_ZHandler ()
		{
			if (cb_setIsFirst_Z == null)
				cb_setIsFirst_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsFirst_Z);
			return cb_setIsFirst_Z;
		}

		static void n_SetIsFirst_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Robot.Base.SaveTemporaryMacroChunkCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SaveTemporaryMacroChunkCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsFirst (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsFirst_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SaveTemporaryMacroChunkCommand']/method[@name='setIsFirst' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsFirst", "(Z)V", "GetSetIsFirst_ZHandler")]
		public virtual void SetIsFirst (bool p0)
		{
			if (id_setIsFirst_Z == IntPtr.Zero)
				id_setIsFirst_Z = JNIEnv.GetMethodID (class_ref, "setIsFirst", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIsFirst_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsFirst", "(Z)V"), new JValue (p0));
		}

	}
}
