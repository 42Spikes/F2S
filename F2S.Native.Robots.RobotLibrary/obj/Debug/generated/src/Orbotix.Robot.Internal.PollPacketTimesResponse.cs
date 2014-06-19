using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/PollPacketTimesResponse", DoNotGenerateAcw=true)]
	public partial class PollPacketTimesResponse : global::Orbotix.Robot.Internal.DeviceResponse {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/PollPacketTimesResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PollPacketTimesResponse); }
		}

		protected PollPacketTimesResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/constructor[@name='PollPacketTimesResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected PollPacketTimesResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PollPacketTimesResponse)) {
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

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/constructor[@name='PollPacketTimesResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public PollPacketTimesResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (PollPacketTimesResponse)) {
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

		static Delegate cb_getCommandTransmitTime;
#pragma warning disable 0169
		static Delegate GetGetCommandTransmitTimeHandler ()
		{
			if (cb_getCommandTransmitTime == null)
				cb_getCommandTransmitTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCommandTransmitTime);
			return cb_getCommandTransmitTime;
		}

		static long n_GetCommandTransmitTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.PollPacketTimesResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.PollPacketTimesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommandTransmitTime;
		}
#pragma warning restore 0169

		static IntPtr id_getCommandTransmitTime;
		public virtual long CommandTransmitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/method[@name='getCommandTransmitTime' and count(parameter)=0]"
			[Register ("getCommandTransmitTime", "()J", "GetGetCommandTransmitTimeHandler")]
			get {
				if (id_getCommandTransmitTime == IntPtr.Zero)
					id_getCommandTransmitTime = JNIEnv.GetMethodID (class_ref, "getCommandTransmitTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getCommandTransmitTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommandTransmitTime", "()J"));
			}
		}

		static Delegate cb_getRobotReceiveTime;
#pragma warning disable 0169
		static Delegate GetGetRobotReceiveTimeHandler ()
		{
			if (cb_getRobotReceiveTime == null)
				cb_getRobotReceiveTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRobotReceiveTime);
			return cb_getRobotReceiveTime;
		}

		static long n_GetRobotReceiveTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.PollPacketTimesResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.PollPacketTimesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RobotReceiveTime;
		}
#pragma warning restore 0169

		static IntPtr id_getRobotReceiveTime;
		public virtual long RobotReceiveTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/method[@name='getRobotReceiveTime' and count(parameter)=0]"
			[Register ("getRobotReceiveTime", "()J", "GetGetRobotReceiveTimeHandler")]
			get {
				if (id_getRobotReceiveTime == IntPtr.Zero)
					id_getRobotReceiveTime = JNIEnv.GetMethodID (class_ref, "getRobotReceiveTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getRobotReceiveTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotReceiveTime", "()J"));
			}
		}

		static Delegate cb_getRobotTransmitTime;
#pragma warning disable 0169
		static Delegate GetGetRobotTransmitTimeHandler ()
		{
			if (cb_getRobotTransmitTime == null)
				cb_getRobotTransmitTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRobotTransmitTime);
			return cb_getRobotTransmitTime;
		}

		static long n_GetRobotTransmitTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.PollPacketTimesResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.PollPacketTimesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RobotTransmitTime;
		}
#pragma warning restore 0169

		static IntPtr id_getRobotTransmitTime;
		public virtual long RobotTransmitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/method[@name='getRobotTransmitTime' and count(parameter)=0]"
			[Register ("getRobotTransmitTime", "()J", "GetGetRobotTransmitTimeHandler")]
			get {
				if (id_getRobotTransmitTime == IntPtr.Zero)
					id_getRobotTransmitTime = JNIEnv.GetMethodID (class_ref, "getRobotTransmitTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getRobotTransmitTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRobotTransmitTime", "()J"));
			}
		}

		static Delegate cb_getTimeDelay;
#pragma warning disable 0169
		static Delegate GetGetTimeDelayHandler ()
		{
			if (cb_getTimeDelay == null)
				cb_getTimeDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeDelay);
			return cb_getTimeDelay;
		}

		static long n_GetTimeDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.PollPacketTimesResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.PollPacketTimesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeDelay;
		public virtual long TimeDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/method[@name='getTimeDelay' and count(parameter)=0]"
			[Register ("getTimeDelay", "()J", "GetGetTimeDelayHandler")]
			get {
				if (id_getTimeDelay == IntPtr.Zero)
					id_getTimeDelay = JNIEnv.GetMethodID (class_ref, "getTimeDelay", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimeDelay);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeDelay", "()J"));
			}
		}

		static Delegate cb_getTimeOffset;
#pragma warning disable 0169
		static Delegate GetGetTimeOffsetHandler ()
		{
			if (cb_getTimeOffset == null)
				cb_getTimeOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeOffset);
			return cb_getTimeOffset;
		}

		static long n_GetTimeOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.PollPacketTimesResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.PollPacketTimesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeOffset;
		public virtual long TimeOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='PollPacketTimesResponse']/method[@name='getTimeOffset' and count(parameter)=0]"
			[Register ("getTimeOffset", "()J", "GetGetTimeOffsetHandler")]
			get {
				if (id_getTimeOffset == IntPtr.Zero)
					id_getTimeOffset = JNIEnv.GetMethodID (class_ref, "getTimeOffset", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimeOffset);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeOffset", "()J"));
			}
		}

	}
}
