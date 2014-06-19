using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SpheroConfigResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SpheroConfigResponse", DoNotGenerateAcw=true)]
	public abstract partial class SpheroConfigResponse : global::Orbotix.Robot.Internal.DeviceResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/SpheroConfigResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpheroConfigResponse); }
		}

		protected SpheroConfigResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SpheroConfigResponse']/constructor[@name='SpheroConfigResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public SpheroConfigResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (SpheroConfigResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/internal/DeviceCommand;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/internal/DeviceCommand;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/internal/DeviceCommand;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SpheroConfigResponse']/constructor[@name='SpheroConfigResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected SpheroConfigResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpheroConfigResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

	}

	[global::Android.Runtime.Register ("orbotix/robot/base/SpheroConfigResponse", DoNotGenerateAcw=true)]
	internal partial class SpheroConfigResponseInvoker : SpheroConfigResponse {

		public SpheroConfigResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpheroConfigResponseInvoker); }
		}

	}

}
