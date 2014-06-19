using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceAsyncDataFactory']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceAsyncDataFactory", DoNotGenerateAcw=true)]
	public partial class DeviceAsyncDataFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceAsyncDataFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceAsyncDataFactory); }
		}

		protected DeviceAsyncDataFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceAsyncDataFactory']/constructor[@name='DeviceAsyncDataFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceAsyncDataFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceAsyncDataFactory)) {
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

		static IntPtr id_create_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_Type_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceAsyncDataFactory']/method[@name='create' and count(parameter)=3 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='orbotix.robot.base.DeviceAsyncData.Type'] and parameter[3][@type='byte[]']]"
		[Register ("create", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceAsyncData$Type;[B)Lorbotix/robot/base/DeviceAsyncData;", "")]
		protected static global::Orbotix.Robot.Base.DeviceAsyncData Create (global::Orbotix.Robot.Base.Robot p0, global::Orbotix.Robot.Base.DeviceAsyncData.Type p1, byte[] p2)
		{
			if (id_create_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_Type_arrayB == IntPtr.Zero)
				id_create_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_Type_arrayB = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorbotix/robot/base/Robot;Lorbotix/robot/base/DeviceAsyncData$Type;[B)Lorbotix/robot/base/DeviceAsyncData;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Orbotix.Robot.Base.DeviceAsyncData __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceAsyncData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorbotix_robot_base_Robot_Lorbotix_robot_base_DeviceAsyncData_Type_arrayB, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_register_Lorbotix_robot_base_DeviceAsyncData_Type_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceAsyncDataFactory']/method[@name='register' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.DeviceAsyncData.Type'] and parameter[2][@type='java.lang.Class']]"
		[Register ("register", "(Lorbotix/robot/base/DeviceAsyncData$Type;Ljava/lang/Class;)V", "")]
		public static void Register (global::Orbotix.Robot.Base.DeviceAsyncData.Type p0, global::Java.Lang.Class p1)
		{
			if (id_register_Lorbotix_robot_base_DeviceAsyncData_Type_Ljava_lang_Class_ == IntPtr.Zero)
				id_register_Lorbotix_robot_base_DeviceAsyncData_Type_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Lorbotix/robot/base/DeviceAsyncData$Type;Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Lorbotix_robot_base_DeviceAsyncData_Type_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
		}

	}
}
