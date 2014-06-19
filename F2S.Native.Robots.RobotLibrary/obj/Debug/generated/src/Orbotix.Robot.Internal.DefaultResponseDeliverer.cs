using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DefaultResponseDeliverer']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DefaultResponseDeliverer", DoNotGenerateAcw=true)]
	public partial class DefaultResponseDeliverer : global::Java.Lang.Object, global::Orbotix.Robot.Internal.IRobotResponseDeliverer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DefaultResponseDeliverer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultResponseDeliverer); }
		}

		protected DefaultResponseDeliverer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DefaultResponseDeliverer']/constructor[@name='DefaultResponseDeliverer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DefaultResponseDeliverer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultResponseDeliverer)) {
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

		static Delegate cb_deliverData_Lorbotix_robot_base_Robot_arrayB;
#pragma warning disable 0169
		static Delegate GetDeliverData_Lorbotix_robot_base_Robot_arrayBHandler ()
		{
			if (cb_deliverData_Lorbotix_robot_base_Robot_arrayB == null)
				cb_deliverData_Lorbotix_robot_base_Robot_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeliverData_Lorbotix_robot_base_Robot_arrayB);
			return cb_deliverData_Lorbotix_robot_base_Robot_arrayB;
		}

		static void n_DeliverData_Lorbotix_robot_base_Robot_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Internal.DefaultResponseDeliverer __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DefaultResponseDeliverer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DeliverData (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_deliverData_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DefaultResponseDeliverer']/method[@name='deliverData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register ("deliverData", "(Lorbotix/robot/base/Robot;[B)V", "GetDeliverData_Lorbotix_robot_base_Robot_arrayBHandler")]
		public virtual void DeliverData (global::Orbotix.Robot.Base.Robot p0, byte[] p1)
		{
			if (id_deliverData_Lorbotix_robot_base_Robot_arrayB == IntPtr.Zero)
				id_deliverData_Lorbotix_robot_base_Robot_arrayB = JNIEnv.GetMethodID (class_ref, "deliverData", "(Lorbotix/robot/base/Robot;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deliverData_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverData", "(Lorbotix/robot/base/Robot;[B)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB;
#pragma warning disable 0169
		static Delegate GetDeliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayBHandler ()
		{
			if (cb_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB == null)
				cb_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB);
			return cb_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB;
		}

		static void n_DeliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Orbotix.Robot.Internal.DefaultResponseDeliverer __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DefaultResponseDeliverer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p1 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DeliverResponse (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DefaultResponseDeliverer']/method[@name='deliverResponse' and count(parameter)=3 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='orbotix.robot.base.Robot'] and parameter[3][@type='byte[]']]"
		[Register ("deliverResponse", "(Lorbotix/robot/internal/DeviceCommand;Lorbotix/robot/base/Robot;[B)V", "GetDeliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayBHandler")]
		public virtual void DeliverResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, global::Orbotix.Robot.Base.Robot p1, byte[] p2)
		{
			if (id_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB == IntPtr.Zero)
				id_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB = JNIEnv.GetMethodID (class_ref, "deliverResponse", "(Lorbotix/robot/internal/DeviceCommand;Lorbotix/robot/base/Robot;[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deliverResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverResponse", "(Lorbotix/robot/internal/DeviceCommand;Lorbotix/robot/base/Robot;[B)V"), new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_;
#pragma warning disable 0169
		static Delegate GetDeliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_Handler ()
		{
			if (cb_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ == null)
				cb_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_);
			return cb_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_;
		}

		static void n_DeliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Orbotix.Robot.Internal.DefaultResponseDeliverer __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DefaultResponseDeliverer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p1 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceResponse p2 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceResponse> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DeliverTimeoutResponse (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DefaultResponseDeliverer']/method[@name='deliverTimeoutResponse' and count(parameter)=3 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='orbotix.robot.base.Robot'] and parameter[3][@type='orbotix.robot.internal.DeviceResponse']]"
		[Register ("deliverTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceResponse;)V", "GetDeliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_Handler")]
		public virtual void DeliverTimeoutResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, global::Orbotix.Robot.Base.Robot p1, global::Orbotix.Robot.Internal.DeviceResponse p2)
		{
			if (id_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ == IntPtr.Zero)
				id_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_ = JNIEnv.GetMethodID (class_ref, "deliverTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deliverTimeoutResponse_Lorbotix_robot_internal_DeviceCommand_Lorbotix_robot_base_Robot_Lorbotix_robot_internal_DeviceResponse_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverTimeoutResponse", "(Lorbotix/robot/internal/DeviceCommand;Lorbotix/robot/base/Robot;Lorbotix/robot/internal/DeviceResponse;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
