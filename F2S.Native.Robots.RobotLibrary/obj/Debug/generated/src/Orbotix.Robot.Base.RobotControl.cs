using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']"
	[global::Android.Runtime.Register ("orbotix/robot/base/RobotControl", DoNotGenerateAcw=true)]
	public partial class RobotControl : global::Java.Lang.Object, global::Java.Util.IObserver {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/field[@name='LED_STATE_OFF']"
		[Register ("LED_STATE_OFF")]
		public const float LedStateOff = (float) 0.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/field[@name='LED_STATE_ON']"
		[Register ("LED_STATE_ON")]
		public const float LedStateOn = (float) 1.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/field[@name='MAX_JUMP_TIME']"
		[Register ("MAX_JUMP_TIME")]
		public const float MaxJumpTime = (float) 3.000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/RobotControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RobotControl); }
		}

		protected RobotControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/constructor[@name='RobotControl' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;)V", "")]
		public RobotControl (global::Orbotix.Robot.Base.Robot p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RobotControl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static Delegate cb_getDeviceConnecction;
#pragma warning disable 0169
		static Delegate GetGetDeviceConnecctionHandler ()
		{
			if (cb_getDeviceConnecction == null)
				cb_getDeviceConnecction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceConnecction);
			return cb_getDeviceConnecction;
		}

		static IntPtr n_GetDeviceConnecction (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceConnecction);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceConnecction;
		public virtual global::Orbotix.Robot.Internal.DeviceConnection DeviceConnecction {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='getDeviceConnecction' and count(parameter)=0]"
			[Register ("getDeviceConnecction", "()Lorbotix/robot/internal/DeviceConnection;", "GetGetDeviceConnecctionHandler")]
			get {
				if (id_getDeviceConnecction == IntPtr.Zero)
					id_getDeviceConnecction = JNIEnv.GetMethodID (class_ref, "getDeviceConnecction", "()Lorbotix/robot/internal/DeviceConnection;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceConnecction), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceConnecction", "()Lorbotix/robot/internal/DeviceConnection;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDriveAlgorithm;
#pragma warning disable 0169
		static Delegate GetGetDriveAlgorithmHandler ()
		{
			if (cb_getDriveAlgorithm == null)
				cb_getDriveAlgorithm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDriveAlgorithm);
			return cb_getDriveAlgorithm;
		}

		static IntPtr n_GetDriveAlgorithm (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DriveAlgorithm);
		}
#pragma warning restore 0169

		static Delegate cb_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_;
#pragma warning disable 0169
		static Delegate GetSetDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_Handler ()
		{
			if (cb_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_ == null)
				cb_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_);
			return cb_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_;
		}

		static void n_SetDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DriveAlgorithm p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DriveAlgorithm = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDriveAlgorithm;
		static IntPtr id_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_;
		public virtual global::Orbotix.Robot.Base.DriveAlgorithm DriveAlgorithm {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='getDriveAlgorithm' and count(parameter)=0]"
			[Register ("getDriveAlgorithm", "()Lorbotix/robot/base/DriveAlgorithm;", "GetGetDriveAlgorithmHandler")]
			get {
				if (id_getDriveAlgorithm == IntPtr.Zero)
					id_getDriveAlgorithm = JNIEnv.GetMethodID (class_ref, "getDriveAlgorithm", "()Lorbotix/robot/base/DriveAlgorithm;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (JNIEnv.CallObjectMethod  (Handle, id_getDriveAlgorithm), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDriveAlgorithm", "()Lorbotix/robot/base/DriveAlgorithm;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='setDriveAlgorithm' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.DriveAlgorithm']]"
			[Register ("setDriveAlgorithm", "(Lorbotix/robot/base/DriveAlgorithm;)V", "GetSetDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_Handler")]
			set {
				if (id_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_ == IntPtr.Zero)
					id_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_ = JNIEnv.GetMethodID (class_ref, "setDriveAlgorithm", "(Lorbotix/robot/base/DriveAlgorithm;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDriveAlgorithm_Lorbotix_robot_base_DriveAlgorithm_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDriveAlgorithm", "(Lorbotix/robot/base/DriveAlgorithm;)V"), new JValue (value));
			}
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
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Robot);
		}
#pragma warning restore 0169

		static IntPtr id_getRobot;
		public virtual global::Orbotix.Robot.Base.Robot Robot {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='getRobot' and count(parameter)=0]"
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

		static Delegate cb_drive_DDD;
#pragma warning disable 0169
		static Delegate GetDrive_DDDHandler ()
		{
			if (cb_drive_DDD == null)
				cb_drive_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double>) n_Drive_DDD);
			return cb_drive_DDD;
		}

		static void n_Drive_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Drive (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_drive_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='drive' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("drive", "(DDD)V", "GetDrive_DDDHandler")]
		public virtual void Drive (double p0, double p1, double p2)
		{
			if (id_drive_DDD == IntPtr.Zero)
				id_drive_DDD = JNIEnv.GetMethodID (class_ref, "drive", "(DDD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drive_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drive", "(DDD)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_roll_FF;
#pragma warning disable 0169
		static Delegate GetRoll_FFHandler ()
		{
			if (cb_roll_FF == null)
				cb_roll_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_Roll_FF);
			return cb_roll_FF;
		}

		static void n_Roll_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Roll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_roll_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='roll' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("roll", "(FF)V", "GetRoll_FFHandler")]
		public virtual void Roll (float p0, float p1)
		{
			if (id_roll_FF == IntPtr.Zero)
				id_roll_FF = JNIEnv.GetMethodID (class_ref, "roll", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_roll_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "roll", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_rotate_F;
#pragma warning disable 0169
		static Delegate GetRotate_FHandler ()
		{
			if (cb_rotate_F == null)
				cb_rotate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_Rotate_F);
			return cb_rotate_F;
		}

		static void n_Rotate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rotate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rotate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)V", "GetRotate_FHandler")]
		public virtual void Rotate (float p0)
		{
			if (id_rotate_F == IntPtr.Zero)
				id_rotate_F = JNIEnv.GetMethodID (class_ref, "rotate", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rotate_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotate", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setHeadingOffset_D;
#pragma warning disable 0169
		static Delegate GetSetHeadingOffset_DHandler ()
		{
			if (cb_setHeadingOffset_D == null)
				cb_setHeadingOffset_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetHeadingOffset_D);
			return cb_setHeadingOffset_D;
		}

		static void n_SetHeadingOffset_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHeadingOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHeadingOffset_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='setHeadingOffset' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setHeadingOffset", "(D)V", "GetSetHeadingOffset_DHandler")]
		protected virtual void SetHeadingOffset (double p0)
		{
			if (id_setHeadingOffset_D == IntPtr.Zero)
				id_setHeadingOffset_D = JNIEnv.GetMethodID (class_ref, "setHeadingOffset", "(D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHeadingOffset_D, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeadingOffset", "(D)V"), new JValue (p0));
		}

		static Delegate cb_setRGBColor_III;
#pragma warning disable 0169
		static Delegate GetSetRGBColor_IIIHandler ()
		{
			if (cb_setRGBColor_III == null)
				cb_setRGBColor_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetRGBColor_III);
			return cb_setRGBColor_III;
		}

		static void n_SetRGBColor_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRGBColor (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setRGBColor_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='setRGBColor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setRGBColor", "(III)V", "GetSetRGBColor_IIIHandler")]
		public virtual void SetRGBColor (int p0, int p1, int p2)
		{
			if (id_setRGBColor_III == IntPtr.Zero)
				id_setRGBColor_III = JNIEnv.GetMethodID (class_ref, "setRGBColor", "(III)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRGBColor_III, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRGBColor", "(III)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
		}

		static Delegate cb_stopMotors;
#pragma warning disable 0169
		static Delegate GetStopMotorsHandler ()
		{
			if (cb_stopMotors == null)
				cb_stopMotors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopMotors);
			return cb_stopMotors;
		}

		static void n_StopMotors (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMotors ();
		}
#pragma warning restore 0169

		static IntPtr id_stopMotors;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='stopMotors' and count(parameter)=0]"
		[Register ("stopMotors", "()V", "GetStopMotorsHandler")]
		public virtual void StopMotors ()
		{
			if (id_stopMotors == IntPtr.Zero)
				id_stopMotors = JNIEnv.GetMethodID (class_ref, "stopMotors", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopMotors);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopMotors", "()V"));
		}

		static Delegate cb_update_Ljava_util_Observable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler ()
		{
			if (cb_update_Ljava_util_Observable_Ljava_lang_Object_ == null)
				cb_update_Ljava_util_Observable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Ljava_util_Observable_Ljava_lang_Object_);
			return cb_update_Ljava_util_Observable_Ljava_lang_Object_;
		}

		static void n_Update_Ljava_util_Observable_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Base.RobotControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.RobotControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Observable p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Observable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_util_Observable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='RobotControl']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.util.Observable'] and parameter[2][@type='java.lang.Object']]"
		[Register ("update", "(Ljava/util/Observable;Ljava/lang/Object;)V", "GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler")]
		public virtual void Update (global::Java.Util.Observable p0, global::Java.Lang.Object p1)
		{
			if (id_update_Ljava_util_Observable_Ljava_lang_Object_ == IntPtr.Zero)
				id_update_Ljava_util_Observable_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_Ljava_util_Observable_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
