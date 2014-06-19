using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.internal']/interface[@name='DeviceMessageSerializable']"
	[Register ("orbotix/robot/internal/DeviceMessageSerializable", "", "Orbotix.Robot.Internal.IDeviceMessageSerializableInvoker")]
	public partial interface IDeviceMessageSerializable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/interface[@name='DeviceMessageSerializable']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
		[Register ("encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V", "GetEncode_Lorbotix_robot_internal_DeviceMessageEncoder_Handler:Orbotix.Robot.Internal.IDeviceMessageSerializableInvoker, F2S.Native.Robots.RobotLibrary")]
		void Encode (global::Orbotix.Robot.Internal.DeviceMessageEncoder p0);

	}

	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceMessageSerializable", DoNotGenerateAcw=true)]
	internal class IDeviceMessageSerializableInvoker : global::Java.Lang.Object, IDeviceMessageSerializable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/internal/DeviceMessageSerializable");
		IntPtr class_ref;

		public static IDeviceMessageSerializable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceMessageSerializable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.internal.DeviceMessageSerializable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceMessageSerializableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDeviceMessageSerializableInvoker); }
		}

		static Delegate cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
#pragma warning disable 0169
		static Delegate GetEncode_Lorbotix_robot_internal_DeviceMessageEncoder_Handler ()
		{
			if (cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ == null)
				cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lorbotix_robot_internal_DeviceMessageEncoder_);
			return cb_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		}

		static void n_Encode_Lorbotix_robot_internal_DeviceMessageEncoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Internal.IDeviceMessageSerializable __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.IDeviceMessageSerializable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		public void Encode (global::Orbotix.Robot.Internal.DeviceMessageEncoder p0)
		{
			if (id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ == IntPtr.Zero)
				id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V");
			JNIEnv.CallVoidMethod (Handle, id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_, new JValue (p0));
		}

	}

}
