using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponseFactory']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceResponseFactory", DoNotGenerateAcw=true)]
	public partial class DeviceResponseFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceResponseFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceResponseFactory); }
		}

		protected DeviceResponseFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponseFactory']/constructor[@name='DeviceResponseFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceResponseFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceResponseFactory)) {
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

		static IntPtr id_create_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponseFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register ("create", "(Lorbotix/robot/internal/DeviceCommand;[B)Lorbotix/robot/internal/DeviceResponse;", "")]
		protected static global::Orbotix.Robot.Internal.DeviceResponse Create (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1)
		{
			if (id_create_Lorbotix_robot_internal_DeviceCommand_arrayB == IntPtr.Zero)
				id_create_Lorbotix_robot_internal_DeviceCommand_arrayB = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorbotix/robot/internal/DeviceCommand;[B)Lorbotix/robot/internal/DeviceResponse;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Orbotix.Robot.Internal.DeviceResponse __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponseFactory']/method[@name='createTimeoutResponse' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceCommand']]"
		[Register ("createTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;)Lorbotix/robot/internal/DeviceResponse;", "")]
		protected static global::Orbotix.Robot.Internal.DeviceResponse CreateTimeoutResponse (global::Orbotix.Robot.Internal.DeviceCommand p0)
		{
			if (id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_ == IntPtr.Zero)
				id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_ = JNIEnv.GetStaticMethodID (class_ref, "createTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;)Lorbotix/robot/internal/DeviceResponse;");
			global::Orbotix.Robot.Internal.DeviceResponse __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_register_BBLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceResponseFactory']/method[@name='register' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='java.lang.Class']]"
		[Register ("register", "(BBLjava/lang/Class;)V", "")]
		public static void Register (sbyte p0, sbyte p1, global::Java.Lang.Class p2)
		{
			if (id_register_BBLjava_lang_Class_ == IntPtr.Zero)
				id_register_BBLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(BBLjava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_register_BBLjava_lang_Class_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
