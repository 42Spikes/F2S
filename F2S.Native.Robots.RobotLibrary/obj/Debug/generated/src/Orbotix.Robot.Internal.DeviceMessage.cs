using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceMessage", DoNotGenerateAcw=true)]
	public abstract partial class DeviceMessage : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Orbotix.Robot.Internal.IDeviceMessageSerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceMessage); }
		}

		protected DeviceMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/constructor[@name='DeviceMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceMessage () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceMessage)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/constructor[@name='DeviceMessage' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected DeviceMessage (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceMessage)) {
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

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static IntPtr n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceMessage __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeStamp);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public virtual global::Java.Util.Date TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()Ljava/util/Date;", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getTimeStamp), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Orbotix.Robot.Internal.DeviceMessage __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceMessageEncoder p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageEncoder']]"
		[Register ("encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V", "GetEncode_Lorbotix_robot_internal_DeviceMessageEncoder_Handler")]
		public virtual void Encode (global::Orbotix.Robot.Internal.DeviceMessageEncoder p0)
		{
			if (id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ == IntPtr.Zero)
				id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encode_Lorbotix_robot_internal_DeviceMessageEncoder_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lorbotix/robot/internal/DeviceMessageEncoder;)V"), new JValue (p0));
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessage __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceMessage __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public abstract global::System.Int32 DescribeContents ();

	}

	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceMessage", DoNotGenerateAcw=true)]
	internal partial class DeviceMessageInvoker : DeviceMessage {

		public DeviceMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceMessageInvoker); }
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessage']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

	}

}
