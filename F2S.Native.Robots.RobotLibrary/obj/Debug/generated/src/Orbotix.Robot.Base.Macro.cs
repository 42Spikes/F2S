using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']"
	[global::Android.Runtime.Register ("orbotix/robot/base/Macro", DoNotGenerateAcw=true)]
	public partial class Macro : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/field[@name='RAW_MOTOR_FORWARD']"
		[Register ("RAW_MOTOR_FORWARD")]
		public const int RawMotorForward = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/field[@name='RAW_MOTOR_REVERSE']"
		[Register ("RAW_MOTOR_REVERSE")]
		public const int RawMotorReverse = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/Macro", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Macro); }
		}

		protected Macro (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/constructor[@name='Macro' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Macro () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Macro)) {
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

		static Delegate cb_getAvailableBytes;
#pragma warning disable 0169
		static Delegate GetGetAvailableBytesHandler ()
		{
			if (cb_getAvailableBytes == null)
				cb_getAvailableBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAvailableBytes);
			return cb_getAvailableBytes;
		}

		static int n_GetAvailableBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvailableBytes;
		}
#pragma warning restore 0169

		static IntPtr id_getAvailableBytes;
		public virtual int AvailableBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='getAvailableBytes' and count(parameter)=0]"
			[Register ("getAvailableBytes", "()I", "GetGetAvailableBytesHandler")]
			get {
				if (id_getAvailableBytes == IntPtr.Zero)
					id_getAvailableBytes = JNIEnv.GetMethodID (class_ref, "getAvailableBytes", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAvailableBytes);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvailableBytes", "()I"));
			}
		}

		static Delegate cb_calibrate_II;
#pragma warning disable 0169
		static Delegate GetCalibrate_IIHandler ()
		{
			if (cb_calibrate_II == null)
				cb_calibrate_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_Calibrate_II);
			return cb_calibrate_II;
		}

		static bool n_Calibrate_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Calibrate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_calibrate_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='calibrate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("calibrate", "(II)Z", "GetCalibrate_IIHandler")]
		public virtual bool Calibrate (int p0, int p1)
		{
			if (id_calibrate_II == IntPtr.Zero)
				id_calibrate_II = JNIEnv.GetMethodID (class_ref, "calibrate", "(II)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_calibrate_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calibrate", "(II)Z"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_delay_I;
#pragma warning disable 0169
		static Delegate GetDelay_IHandler ()
		{
			if (cb_delay_I == null)
				cb_delay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Delay_I);
			return cb_delay_I;
		}

		static bool n_Delay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='delay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("delay", "(I)Z", "GetDelay_IHandler")]
		public virtual bool Delay (int p0)
		{
			if (id_delay_I == IntPtr.Zero)
				id_delay_I = JNIEnv.GetMethodID (class_ref, "delay", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_delay_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delay", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_endStreaming;
#pragma warning disable 0169
		static Delegate GetEndStreamingHandler ()
		{
			if (cb_endStreaming == null)
				cb_endStreaming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EndStreaming);
			return cb_endStreaming;
		}

		static bool n_EndStreaming (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndStreaming ();
		}
#pragma warning restore 0169

		static IntPtr id_endStreaming;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='endStreaming' and count(parameter)=0]"
		[Register ("endStreaming", "()Z", "GetEndStreamingHandler")]
		public virtual bool EndStreaming ()
		{
			if (id_endStreaming == IntPtr.Zero)
				id_endStreaming = JNIEnv.GetMethodID (class_ref, "endStreaming", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_endStreaming);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endStreaming", "()Z"));
		}

		static Delegate cb_frontLED_FI;
#pragma warning disable 0169
		static Delegate GetFrontLED_FIHandler ()
		{
			if (cb_frontLED_FI == null)
				cb_frontLED_FI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int, bool>) n_FrontLED_FI);
			return cb_frontLED_FI;
		}

		static bool n_FrontLED_FI (IntPtr jnienv, IntPtr native__this, float p0, int p1)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrontLED (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_frontLED_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='frontLED' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("frontLED", "(FI)Z", "GetFrontLED_FIHandler")]
		public virtual bool FrontLED (float p0, int p1)
		{
			if (id_frontLED_FI == IntPtr.Zero)
				id_frontLED_FI = JNIEnv.GetMethodID (class_ref, "frontLED", "(FI)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_frontLED_FI, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "frontLED", "(FI)Z"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_macroBytes;
#pragma warning disable 0169
		static Delegate GetMacroBytesHandler ()
		{
			if (cb_macroBytes == null)
				cb_macroBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MacroBytes);
			return cb_macroBytes;
		}

		static IntPtr n_MacroBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.MacroBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_macroBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='macroBytes' and count(parameter)=0]"
		[Register ("macroBytes", "()[B", "GetMacroBytesHandler")]
		public virtual byte[] MacroBytes ()
		{
			if (id_macroBytes == IntPtr.Zero)
				id_macroBytes = JNIEnv.GetMethodID (class_ref, "macroBytes", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_macroBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "macroBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_macroLength;
#pragma warning disable 0169
		static Delegate GetMacroLengthHandler ()
		{
			if (cb_macroLength == null)
				cb_macroLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MacroLength);
			return cb_macroLength;
		}

		static int n_MacroLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MacroLength ();
		}
#pragma warning restore 0169

		static IntPtr id_macroLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='macroLength' and count(parameter)=0]"
		[Register ("macroLength", "()I", "GetMacroLengthHandler")]
		public virtual int MacroLength ()
		{
			if (id_macroLength == IntPtr.Zero)
				id_macroLength = JNIEnv.GetMethodID (class_ref, "macroLength", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_macroLength);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "macroLength", "()I"));
		}

		static Delegate cb_rawMotor_IIIII;
#pragma warning disable 0169
		static Delegate GetRawMotor_IIIIIHandler ()
		{
			if (cb_rawMotor_IIIII == null)
				cb_rawMotor_IIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, bool>) n_RawMotor_IIIII);
			return cb_rawMotor_IIIII;
		}

		static bool n_RawMotor_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawMotor (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_rawMotor_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rawMotor' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("rawMotor", "(IIIII)Z", "GetRawMotor_IIIIIHandler")]
		public virtual bool RawMotor (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_rawMotor_IIIII == IntPtr.Zero)
				id_rawMotor_IIIII = JNIEnv.GetMethodID (class_ref, "rawMotor", "(IIIII)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rawMotor_IIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rawMotor", "(IIIII)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_rgb_FFFI;
#pragma warning disable 0169
		static Delegate GetRgb_FFFIHandler ()
		{
			if (cb_rgb_FFFI == null)
				cb_rgb_FFFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, int, bool>) n_Rgb_FFFI);
			return cb_rgb_FFFI;
		}

		static bool n_Rgb_FFFI (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, int p3)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rgb (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_rgb_FFFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rgb' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register ("rgb", "(FFFI)Z", "GetRgb_FFFIHandler")]
		public virtual bool Rgb (float p0, float p1, float p2, int p3)
		{
			if (id_rgb_FFFI == IntPtr.Zero)
				id_rgb_FFFI = JNIEnv.GetMethodID (class_ref, "rgb", "(FFFI)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rgb_FFFI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rgb", "(FFFI)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_rgb_IIII;
#pragma warning disable 0169
		static Delegate GetRgb_IIIIHandler ()
		{
			if (cb_rgb_IIII == null)
				cb_rgb_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, bool>) n_Rgb_IIII);
			return cb_rgb_IIII;
		}

		static bool n_Rgb_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rgb (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_rgb_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rgb' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rgb", "(IIII)Z", "GetRgb_IIIIHandler")]
		public virtual bool Rgb (int p0, int p1, int p2, int p3)
		{
			if (id_rgb_IIII == IntPtr.Zero)
				id_rgb_IIII = JNIEnv.GetMethodID (class_ref, "rgb", "(IIII)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rgb_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rgb", "(IIII)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_rgbSD2_FFF;
#pragma warning disable 0169
		static Delegate GetRgbSD2_FFFHandler ()
		{
			if (cb_rgbSD2_FFF == null)
				cb_rgbSD2_FFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, bool>) n_RgbSD2_FFF);
			return cb_rgbSD2_FFF;
		}

		static bool n_RgbSD2_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RgbSD2 (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_rgbSD2_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rgbSD2' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("rgbSD2", "(FFF)Z", "GetRgbSD2_FFFHandler")]
		public virtual bool RgbSD2 (float p0, float p1, float p2)
		{
			if (id_rgbSD2_FFF == IntPtr.Zero)
				id_rgbSD2_FFF = JNIEnv.GetMethodID (class_ref, "rgbSD2", "(FFF)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rgbSD2_FFF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rgbSD2", "(FFF)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_roll_FII;
#pragma warning disable 0169
		static Delegate GetRoll_FIIHandler ()
		{
			if (cb_roll_FII == null)
				cb_roll_FII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int, int, bool>) n_Roll_FII);
			return cb_roll_FII;
		}

		static bool n_Roll_FII (IntPtr jnienv, IntPtr native__this, float p0, int p1, int p2)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Roll (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_roll_FII;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='roll' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("roll", "(FII)Z", "GetRoll_FIIHandler")]
		public virtual bool Roll (float p0, int p1, int p2)
		{
			if (id_roll_FII == IntPtr.Zero)
				id_roll_FII = JNIEnv.GetMethodID (class_ref, "roll", "(FII)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_roll_FII, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "roll", "(FII)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_rollSD1_FI;
#pragma warning disable 0169
		static Delegate GetRollSD1_FIHandler ()
		{
			if (cb_rollSD1_FI == null)
				cb_rollSD1_FI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int, bool>) n_RollSD1_FI);
			return cb_rollSD1_FI;
		}

		static bool n_RollSD1_FI (IntPtr jnienv, IntPtr native__this, float p0, int p1)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RollSD1 (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_rollSD1_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rollSD1' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("rollSD1", "(FI)Z", "GetRollSD1_FIHandler")]
		public virtual bool RollSD1 (float p0, int p1)
		{
			if (id_rollSD1_FI == IntPtr.Zero)
				id_rollSD1_FI = JNIEnv.GetMethodID (class_ref, "rollSD1", "(FI)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rollSD1_FI, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rollSD1", "(FI)Z"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_rollSD1SPD1_I;
#pragma warning disable 0169
		static Delegate GetRollSD1SPD1_IHandler ()
		{
			if (cb_rollSD1SPD1_I == null)
				cb_rollSD1SPD1_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RollSD1SPD1_I);
			return cb_rollSD1SPD1_I;
		}

		static bool n_RollSD1SPD1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RollSD1SPD1 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rollSD1SPD1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rollSD1SPD1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rollSD1SPD1", "(I)Z", "GetRollSD1SPD1_IHandler")]
		public virtual bool RollSD1SPD1 (int p0)
		{
			if (id_rollSD1SPD1_I == IntPtr.Zero)
				id_rollSD1SPD1_I = JNIEnv.GetMethodID (class_ref, "rollSD1SPD1", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rollSD1SPD1_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rollSD1SPD1", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_rollSD1SPD2_I;
#pragma warning disable 0169
		static Delegate GetRollSD1SPD2_IHandler ()
		{
			if (cb_rollSD1SPD2_I == null)
				cb_rollSD1SPD2_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RollSD1SPD2_I);
			return cb_rollSD1SPD2_I;
		}

		static bool n_RollSD1SPD2_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RollSD1SPD2 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rollSD1SPD2_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rollSD1SPD2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rollSD1SPD2", "(I)Z", "GetRollSD1SPD2_IHandler")]
		public virtual bool RollSD1SPD2 (int p0)
		{
			if (id_rollSD1SPD2_I == IntPtr.Zero)
				id_rollSD1SPD2_I = JNIEnv.GetMethodID (class_ref, "rollSD1SPD2", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rollSD1SPD2_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rollSD1SPD2", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_rotationRate_F;
#pragma warning disable 0169
		static Delegate GetRotationRate_FHandler ()
		{
			if (cb_rotationRate_F == null)
				cb_rotationRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_RotationRate_F);
			return cb_rotationRate_F;
		}

		static bool n_RotationRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotationRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rotationRate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='rotationRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationRate", "(F)Z", "GetRotationRate_FHandler")]
		public virtual bool RotationRate (float p0)
		{
			if (id_rotationRate_F == IntPtr.Zero)
				id_rotationRate_F = JNIEnv.GetMethodID (class_ref, "rotationRate", "(F)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_rotationRate_F, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotationRate", "(F)Z"), new JValue (p0));
		}

		static Delegate cb_setSD1_I;
#pragma warning disable 0169
		static Delegate GetSetSD1_IHandler ()
		{
			if (cb_setSD1_I == null)
				cb_setSD1_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetSD1_I);
			return cb_setSD1_I;
		}

		static bool n_SetSD1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSD1 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSD1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='setSD1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSD1", "(I)Z", "GetSetSD1_IHandler")]
		public virtual bool SetSD1 (int p0)
		{
			if (id_setSD1_I == IntPtr.Zero)
				id_setSD1_I = JNIEnv.GetMethodID (class_ref, "setSD1", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_setSD1_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSD1", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_setSD2_I;
#pragma warning disable 0169
		static Delegate GetSetSD2_IHandler ()
		{
			if (cb_setSD2_I == null)
				cb_setSD2_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetSD2_I);
			return cb_setSD2_I;
		}

		static bool n_SetSD2_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSD2 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSD2_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='setSD2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSD2", "(I)Z", "GetSetSD2_IHandler")]
		public virtual bool SetSD2 (int p0)
		{
			if (id_setSD2_I == IntPtr.Zero)
				id_setSD2_I = JNIEnv.GetMethodID (class_ref, "setSD2", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_setSD2_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSD2", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_setSPD1_F;
#pragma warning disable 0169
		static Delegate GetSetSPD1_FHandler ()
		{
			if (cb_setSPD1_F == null)
				cb_setSPD1_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_SetSPD1_F);
			return cb_setSPD1_F;
		}

		static bool n_SetSPD1_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSPD1 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSPD1_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='setSPD1' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSPD1", "(F)Z", "GetSetSPD1_FHandler")]
		public virtual bool SetSPD1 (float p0)
		{
			if (id_setSPD1_F == IntPtr.Zero)
				id_setSPD1_F = JNIEnv.GetMethodID (class_ref, "setSPD1", "(F)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_setSPD1_F, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSPD1", "(F)Z"), new JValue (p0));
		}

		static Delegate cb_setSPD2_F;
#pragma warning disable 0169
		static Delegate GetSetSPD2_FHandler ()
		{
			if (cb_setSPD2_F == null)
				cb_setSPD2_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_SetSPD2_F);
			return cb_setSPD2_F;
		}

		static bool n_SetSPD2_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSPD2 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSPD2_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='setSPD2' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSPD2", "(F)Z", "GetSetSPD2_FHandler")]
		public virtual bool SetSPD2 (float p0)
		{
			if (id_setSPD2_F == IntPtr.Zero)
				id_setSPD2_F = JNIEnv.GetMethodID (class_ref, "setSPD2", "(F)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_setSPD2_F, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSPD2", "(F)Z"), new JValue (p0));
		}

		static Delegate cb_sleepnow_I;
#pragma warning disable 0169
		static Delegate GetSleepnow_IHandler ()
		{
			if (cb_sleepnow_I == null)
				cb_sleepnow_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Sleepnow_I);
			return cb_sleepnow_I;
		}

		static bool n_Sleepnow_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sleepnow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sleepnow_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='sleepnow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sleepnow", "(I)Z", "GetSleepnow_IHandler")]
		public virtual bool Sleepnow (int p0)
		{
			if (id_sleepnow_I == IntPtr.Zero)
				id_sleepnow_I = JNIEnv.GetMethodID (class_ref, "sleepnow", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_sleepnow_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sleepnow", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_slew_FFFI;
#pragma warning disable 0169
		static Delegate GetSlew_FFFIHandler ()
		{
			if (cb_slew_FFFI == null)
				cb_slew_FFFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, int, bool>) n_Slew_FFFI);
			return cb_slew_FFFI;
		}

		static bool n_Slew_FFFI (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, int p3)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Slew (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_slew_FFFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='slew' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register ("slew", "(FFFI)Z", "GetSlew_FFFIHandler")]
		public virtual bool Slew (float p0, float p1, float p2, int p3)
		{
			if (id_slew_FFFI == IntPtr.Zero)
				id_slew_FFFI = JNIEnv.GetMethodID (class_ref, "slew", "(FFFI)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_slew_FFFI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slew", "(FFFI)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_stabilization_ZI;
#pragma warning disable 0169
		static Delegate GetStabilization_ZIHandler ()
		{
			if (cb_stabilization_ZI == null)
				cb_stabilization_ZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int, bool>) n_Stabilization_ZI);
			return cb_stabilization_ZI;
		}

		static bool n_Stabilization_ZI (IntPtr jnienv, IntPtr native__this, bool p0, int p1)
		{
			global::Orbotix.Robot.Base.Macro __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Macro> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stabilization (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_stabilization_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Macro']/method[@name='stabilization' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("stabilization", "(ZI)Z", "GetStabilization_ZIHandler")]
		public virtual bool Stabilization (bool p0, int p1)
		{
			if (id_stabilization_ZI == IntPtr.Zero)
				id_stabilization_ZI = JNIEnv.GetMethodID (class_ref, "stabilization", "(ZI)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_stabilization_ZI, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stabilization", "(ZI)Z"), new JValue (p0), new JValue (p1));
		}

	}
}
