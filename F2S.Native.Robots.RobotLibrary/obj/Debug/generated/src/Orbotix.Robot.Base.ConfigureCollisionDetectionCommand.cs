using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/ConfigureCollisionDetectionCommand", DoNotGenerateAcw=true)]
	public partial class ConfigureCollisionDetectionCommand : global::Orbotix.Robot.Internal.DeviceCommand {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/field[@name='DEFAULT_DETECTION_METHOD']"
		[Register ("DEFAULT_DETECTION_METHOD")]
		public const int DefaultDetectionMethod = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/field[@name='DISABLE_DETECTION_METHOD']"
		[Register ("DISABLE_DETECTION_METHOD")]
		public const int DisableDetectionMethod = (int) 0;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/ConfigureCollisionDetectionCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigureCollisionDetectionCommand); }
		}

		protected ConfigureCollisionDetectionCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/constructor[@name='ConfigureCollisionDetectionCommand' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(IIIIII)V", "")]
		public ConfigureCollisionDetectionCommand (int p0, int p1, int p2, int p3, int p4, int p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConfigureCollisionDetectionCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIII)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIIII)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				return;
			}

			if (id_ctor_IIIIII == IntPtr.Zero)
				id_ctor_IIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIII)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/constructor[@name='ConfigureCollisionDetectionCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected ConfigureCollisionDetectionCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConfigureCollisionDetectionCommand)) {
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

		static Delegate cb_getDeadTime;
#pragma warning disable 0169
		static Delegate GetGetDeadTimeHandler ()
		{
			if (cb_getDeadTime == null)
				cb_getDeadTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDeadTime);
			return cb_getDeadTime;
		}

		static int n_GetDeadTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeadTime;
		}
#pragma warning restore 0169

		static IntPtr id_getDeadTime;
		public virtual int DeadTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='getDeadTime' and count(parameter)=0]"
			[Register ("getDeadTime", "()I", "GetGetDeadTimeHandler")]
			get {
				if (id_getDeadTime == IntPtr.Zero)
					id_getDeadTime = JNIEnv.GetMethodID (class_ref, "getDeadTime", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDeadTime);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeadTime", "()I"));
			}
		}

		static Delegate cb_getDetectionMethod;
#pragma warning disable 0169
		static Delegate GetGetDetectionMethodHandler ()
		{
			if (cb_getDetectionMethod == null)
				cb_getDetectionMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDetectionMethod);
			return cb_getDetectionMethod;
		}

		static int n_GetDetectionMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DetectionMethod;
		}
#pragma warning restore 0169

		static IntPtr id_getDetectionMethod;
		public virtual int DetectionMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='getDetectionMethod' and count(parameter)=0]"
			[Register ("getDetectionMethod", "()I", "GetGetDetectionMethodHandler")]
			get {
				if (id_getDetectionMethod == IntPtr.Zero)
					id_getDetectionMethod = JNIEnv.GetMethodID (class_ref, "getDetectionMethod", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDetectionMethod);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetectionMethod", "()I"));
			}
		}

		static Delegate cb_getXSpeedThreshold;
#pragma warning disable 0169
		static Delegate GetGetXSpeedThresholdHandler ()
		{
			if (cb_getXSpeedThreshold == null)
				cb_getXSpeedThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXSpeedThreshold);
			return cb_getXSpeedThreshold;
		}

		static int n_GetXSpeedThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XSpeedThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getXSpeedThreshold;
		public virtual int XSpeedThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='getXSpeedThreshold' and count(parameter)=0]"
			[Register ("getXSpeedThreshold", "()I", "GetGetXSpeedThresholdHandler")]
			get {
				if (id_getXSpeedThreshold == IntPtr.Zero)
					id_getXSpeedThreshold = JNIEnv.GetMethodID (class_ref, "getXSpeedThreshold", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getXSpeedThreshold);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXSpeedThreshold", "()I"));
			}
		}

		static Delegate cb_getXThreshold;
#pragma warning disable 0169
		static Delegate GetGetXThresholdHandler ()
		{
			if (cb_getXThreshold == null)
				cb_getXThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXThreshold);
			return cb_getXThreshold;
		}

		static int n_GetXThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getXThreshold;
		public virtual int XThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='getXThreshold' and count(parameter)=0]"
			[Register ("getXThreshold", "()I", "GetGetXThresholdHandler")]
			get {
				if (id_getXThreshold == IntPtr.Zero)
					id_getXThreshold = JNIEnv.GetMethodID (class_ref, "getXThreshold", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getXThreshold);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXThreshold", "()I"));
			}
		}

		static Delegate cb_getYSpeedThreshold;
#pragma warning disable 0169
		static Delegate GetGetYSpeedThresholdHandler ()
		{
			if (cb_getYSpeedThreshold == null)
				cb_getYSpeedThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYSpeedThreshold);
			return cb_getYSpeedThreshold;
		}

		static int n_GetYSpeedThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YSpeedThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getYSpeedThreshold;
		public virtual int YSpeedThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='getYSpeedThreshold' and count(parameter)=0]"
			[Register ("getYSpeedThreshold", "()I", "GetGetYSpeedThresholdHandler")]
			get {
				if (id_getYSpeedThreshold == IntPtr.Zero)
					id_getYSpeedThreshold = JNIEnv.GetMethodID (class_ref, "getYSpeedThreshold", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getYSpeedThreshold);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYSpeedThreshold", "()I"));
			}
		}

		static Delegate cb_getYThreshold;
#pragma warning disable 0169
		static Delegate GetGetYThresholdHandler ()
		{
			if (cb_getYThreshold == null)
				cb_getYThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYThreshold);
			return cb_getYThreshold;
		}

		static int n_GetYThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.ConfigureCollisionDetectionCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getYThreshold;
		public virtual int YThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='getYThreshold' and count(parameter)=0]"
			[Register ("getYThreshold", "()I", "GetGetYThresholdHandler")]
			get {
				if (id_getYThreshold == IntPtr.Zero)
					id_getYThreshold = JNIEnv.GetMethodID (class_ref, "getYThreshold", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getYThreshold);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYThreshold", "()I"));
			}
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='ConfigureCollisionDetectionCommand']/method[@name='sendCommand' and count(parameter)=7 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;IIIIII)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_IIIIII == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_IIIIII = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;IIIIII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_IIIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
		}

	}
}
