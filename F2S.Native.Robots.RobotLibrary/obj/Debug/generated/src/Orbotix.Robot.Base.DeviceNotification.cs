using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DeviceNotification", DoNotGenerateAcw=true)]
	public partial class DeviceNotification : global::Orbotix.Robot.Internal.DeviceMessage {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/field[@name='DEVICE_NOTIFICATION_TYPE_AVAILABLE']"
		[Register ("DEVICE_NOTIFICATION_TYPE_AVAILABLE")]
		public const int DeviceNotificationTypeAvailable = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/field[@name='DEVICE_NOTIFICATION_TYPE_CONNECTED']"
		[Register ("DEVICE_NOTIFICATION_TYPE_CONNECTED")]
		public const int DeviceNotificationTypeConnected = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/field[@name='DEVICE_NOTIFICATION_TYPE_CONNECTION_FAILED']"
		[Register ("DEVICE_NOTIFICATION_TYPE_CONNECTION_FAILED")]
		public const int DeviceNotificationTypeConnectionFailed = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/field[@name='DEVICE_NOTIFICATION_TYPE_DISCONNECTED']"
		[Register ("DEVICE_NOTIFICATION_TYPE_DISCONNECTED")]
		public const int DeviceNotificationTypeDisconnected = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DeviceNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceNotification); }
		}

		protected DeviceNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/constructor[@name='DeviceNotification' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;I)V", "")]
		public DeviceNotification (global::Orbotix.Robot.Base.Robot p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceNotification)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_I == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/constructor[@name='DeviceNotification' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected DeviceNotification (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceNotification)) {
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

		static Delegate cb_getRobot;
#pragma warning disable 0169
		static Delegate GetGetRobotHandler ()
		{
			if (cb_getRobot == null)
				cb_getRobot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRobot);
			return cb_getRobot;
		}

		static IntPtr n_GetRobot (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DeviceNotification __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Robot);
		}
#pragma warning restore 0169

		static IntPtr id_getRobot;
		public virtual global::Orbotix.Robot.Base.Robot Robot {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/method[@name='getRobot' and count(parameter)=0]"
			[Register ("getRobot", "()Lorbotix/robot/base/Robot;", "GetGetRobotHandler")]
			get {
				if (id_getRobot == IntPtr.Zero)
					id_getRobot = JNIEnv.GetMethodID (class_ref, "getRobot", "()Lorbotix/robot/base/Robot;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (JNIEnv.CallObjectMethod  (Handle, id_getRobot), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobot", "()Lorbotix/robot/base/Robot;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Orbotix.Robot.Base.DeviceNotification __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceNotification']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

	}
}
