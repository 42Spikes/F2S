using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Macro {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroCommandFactory']"
	[global::Android.Runtime.Register ("orbotix/macro/MacroCommandFactory", DoNotGenerateAcw=true)]
	public partial class MacroCommandFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/macro/MacroCommandFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MacroCommandFactory); }
		}

		protected MacroCommandFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroCommandFactory']/constructor[@name='MacroCommandFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MacroCommandFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MacroCommandFactory)) {
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

		static IntPtr id_createFromBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroCommandFactory']/method[@name='createFromBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createFromBytes", "([B)Lorbotix/macro/MacroCommand;", "")]
		public static global::Orbotix.Macro.IMacroCommand CreateFromBytes (byte[] p0)
		{
			if (id_createFromBytes_arrayB == IntPtr.Zero)
				id_createFromBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "createFromBytes", "([B)Lorbotix/macro/MacroCommand;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Orbotix.Macro.IMacroCommand __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromBytes_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
