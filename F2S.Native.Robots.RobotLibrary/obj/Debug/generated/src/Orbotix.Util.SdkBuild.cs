using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.util']/class[@name='SdkBuild']"
	[global::Android.Runtime.Register ("orbotix/util/SdkBuild", DoNotGenerateAcw=true)]
	public partial class SdkBuild : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/util/SdkBuild", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SdkBuild); }
		}

		protected SdkBuild (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.util']/class[@name='SdkBuild']/constructor[@name='SdkBuild' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SdkBuild () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SdkBuild)) {
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

		static IntPtr id_isDebugConnected;
		public static bool IsDebugConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='SdkBuild']/method[@name='isDebugConnected' and count(parameter)=0]"
			[Register ("isDebugConnected", "()Z", "GetIsDebugConnectedHandler")]
			get {
				if (id_isDebugConnected == IntPtr.Zero)
					id_isDebugConnected = JNIEnv.GetStaticMethodID (class_ref, "isDebugConnected", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebugConnected);
			}
		}

		static IntPtr id_getMajor;
		public static string Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='SdkBuild']/method[@name='getMajor' and count(parameter)=0]"
			[Register ("getMajor", "()Ljava/lang/String;", "GetGetMajorHandler")]
			get {
				if (id_getMajor == IntPtr.Zero)
					id_getMajor = JNIEnv.GetStaticMethodID (class_ref, "getMajor", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMajor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMinor;
		public static string Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='SdkBuild']/method[@name='getMinor' and count(parameter)=0]"
			[Register ("getMinor", "()Ljava/lang/String;", "GetGetMinorHandler")]
			get {
				if (id_getMinor == IntPtr.Zero)
					id_getMinor = JNIEnv.GetStaticMethodID (class_ref, "getMinor", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMinor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMinorMinor;
		public static string MinorMinor {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.util']/class[@name='SdkBuild']/method[@name='getMinorMinor' and count(parameter)=0]"
			[Register ("getMinorMinor", "()Ljava/lang/String;", "GetGetMinorMinorHandler")]
			get {
				if (id_getMinorMinor == IntPtr.Zero)
					id_getMinorMinor = JNIEnv.GetStaticMethodID (class_ref, "getMinorMinor", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMinorMinor), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
