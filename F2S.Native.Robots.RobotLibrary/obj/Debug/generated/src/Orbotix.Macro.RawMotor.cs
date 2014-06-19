using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Macro {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']"
	[global::Android.Runtime.Register ("orbotix/macro/RawMotor", DoNotGenerateAcw=true)]
	public partial class RawMotor : global::Java.Lang.Object, global::Orbotix.Macro.IMacroCommand {


		public static class InterfaceConsts {

			// The following are fields from: orbotix.macro.MacroCommand

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_CALIBRATE']"
			[Register ("MAC_CALIBRATE")]
			public const sbyte MacCalibrate = (sbyte) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_DELAY']"
			[Register ("MAC_DELAY")]
			public const sbyte MacDelay = (sbyte) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_EMIT']"
			[Register ("MAC_EMIT")]
			public const sbyte MacEmit = (sbyte) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_END']"
			[Register ("MAC_END")]
			public const sbyte MacEnd = (sbyte) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_FADE']"
			[Register ("MAC_FADE")]
			public const sbyte MacFade = (sbyte) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_FRONT_LED']"
			[Register ("MAC_FRONT_LED")]
			public const sbyte MacFrontLed = (sbyte) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_GOSUB']"
			[Register ("MAC_GOSUB")]
			public const sbyte MacGosub = (sbyte) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_GOTO']"
			[Register ("MAC_GOTO")]
			public const sbyte MacGoto = (sbyte) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_RAW_MOTOR']"
			[Register ("MAC_RAW_MOTOR")]
			public const sbyte MacRawMotor = (sbyte) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_RGB']"
			[Register ("MAC_RGB")]
			public const sbyte MacRgb = (sbyte) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_RGB_SD2']"
			[Register ("MAC_RGB_SD2")]
			public const sbyte MacRgbSd2 = (sbyte) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_ROLL']"
			[Register ("MAC_ROLL")]
			public const sbyte MacRoll = (sbyte) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_ROLL_SD1']"
			[Register ("MAC_ROLL_SD1")]
			public const sbyte MacRollSd1 = (sbyte) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_ROLL_SPD1_SD1']"
			[Register ("MAC_ROLL_SPD1_SD1")]
			public const sbyte MacRollSpd1Sd1 = (sbyte) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_ROLL_SPD2_SD1']"
			[Register ("MAC_ROLL_SPD2_SD1")]
			public const sbyte MacRollSpd2Sd1 = (sbyte) 18;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_ROTATE']"
			[Register ("MAC_ROTATE")]
			public const sbyte MacRotate = (sbyte) 26;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_ROTATION_RATE']"
			[Register ("MAC_ROTATION_RATE")]
			public const sbyte MacRotationRate = (sbyte) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_SD1']"
			[Register ("MAC_SD1")]
			public const sbyte MacSd1 = (sbyte) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_SD2']"
			[Register ("MAC_SD2")]
			public const sbyte MacSd2 = (sbyte) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_SLEEP']"
			[Register ("MAC_SLEEP")]
			public const sbyte MacSleep = (sbyte) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_SPD1']"
			[Register ("MAC_SPD1")]
			public const sbyte MacSpd1 = (sbyte) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_SPD2']"
			[Register ("MAC_SPD2")]
			public const sbyte MacSpd2 = (sbyte) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_STABILIZATION']"
			[Register ("MAC_STABILIZATION")]
			public const sbyte MacStabilization = (sbyte) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_STREAM_END']"
			[Register ("MAC_STREAM_END")]
			public const sbyte MacStreamEnd = (sbyte) 27;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/field[@name='MAC_WAIT_UNTIL_STOP']"
			[Register ("MAC_WAIT_UNTIL_STOP")]
			public const sbyte MacWaitUntilStop = (sbyte) 25;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']"
		[global::Android.Runtime.Register ("orbotix/macro/RawMotor$DriveMode", DoNotGenerateAcw=true)]
		public sealed partial class DriveMode : global::Java.Lang.Enum {


			static IntPtr BRAKE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/field[@name='BRAKE']"
			[Register ("BRAKE")]
			public static global::Orbotix.Macro.RawMotor.DriveMode Brake {
				get {
					if (BRAKE_jfieldId == IntPtr.Zero)
						BRAKE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BRAKE", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BRAKE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BRAKE_jfieldId == IntPtr.Zero)
						BRAKE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BRAKE", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BRAKE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FORWARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/field[@name='FORWARD']"
			[Register ("FORWARD")]
			public static global::Orbotix.Macro.RawMotor.DriveMode Forward {
				get {
					if (FORWARD_jfieldId == IntPtr.Zero)
						FORWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORWARD", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORWARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FORWARD_jfieldId == IntPtr.Zero)
						FORWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORWARD", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FORWARD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IGNORE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/field[@name='IGNORE']"
			[Register ("IGNORE")]
			public static global::Orbotix.Macro.RawMotor.DriveMode Ignore {
				get {
					if (IGNORE_jfieldId == IntPtr.Zero)
						IGNORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IGNORE", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IGNORE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IGNORE_jfieldId == IntPtr.Zero)
						IGNORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IGNORE", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IGNORE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/field[@name='OFF']"
			[Register ("OFF")]
			public static global::Orbotix.Macro.RawMotor.DriveMode Off {
				get {
					if (OFF_jfieldId == IntPtr.Zero)
						OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFF", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OFF_jfieldId == IntPtr.Zero)
						OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFF", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OFF_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REVERSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/field[@name='REVERSE']"
			[Register ("REVERSE")]
			public static global::Orbotix.Macro.RawMotor.DriveMode Reverse {
				get {
					if (REVERSE_jfieldId == IntPtr.Zero)
						REVERSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSE", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REVERSE_jfieldId == IntPtr.Zero)
						REVERSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSE", "Lorbotix/macro/RawMotor$DriveMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REVERSE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/macro/RawMotor$DriveMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DriveMode); }
			}

			internal DriveMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDriveMode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/method[@name='getDriveMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getDriveMode", "(I)Lorbotix/macro/RawMotor$DriveMode;", "")]
			public static global::Orbotix.Macro.RawMotor.DriveMode GetDriveMode (int p0)
			{
				if (id_getDriveMode_I == IntPtr.Zero)
					id_getDriveMode_I = JNIEnv.GetStaticMethodID (class_ref, "getDriveMode", "(I)Lorbotix/macro/RawMotor$DriveMode;");
				return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDriveMode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/macro/RawMotor$DriveMode;", "")]
			public static global::Orbotix.Macro.RawMotor.DriveMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/macro/RawMotor$DriveMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Orbotix.Macro.RawMotor.DriveMode __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor.DriveMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorbotix/macro/RawMotor$DriveMode;", "")]
			public static global::Orbotix.Macro.RawMotor.DriveMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/macro/RawMotor$DriveMode;");
				return (global::Orbotix.Macro.RawMotor.DriveMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Macro.RawMotor.DriveMode));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/macro/RawMotor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RawMotor); }
		}

		protected RawMotor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/constructor[@name='RawMotor' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public RawMotor (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (RawMotor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lorbotix_macro_RawMotor_DriveMode_ILorbotix_macro_RawMotor_DriveMode_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/constructor[@name='RawMotor' and count(parameter)=5 and parameter[1][@type='orbotix.macro.RawMotor.DriveMode'] and parameter[2][@type='int'] and parameter[3][@type='orbotix.macro.RawMotor.DriveMode'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lorbotix/macro/RawMotor$DriveMode;ILorbotix/macro/RawMotor$DriveMode;II)V", "")]
		public RawMotor (global::Orbotix.Macro.RawMotor.DriveMode p0, int p1, global::Orbotix.Macro.RawMotor.DriveMode p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RawMotor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/macro/RawMotor$DriveMode;ILorbotix/macro/RawMotor$DriveMode;II)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/macro/RawMotor$DriveMode;ILorbotix/macro/RawMotor$DriveMode;II)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_Lorbotix_macro_RawMotor_DriveMode_ILorbotix_macro_RawMotor_DriveMode_II == IntPtr.Zero)
				id_ctor_Lorbotix_macro_RawMotor_DriveMode_ILorbotix_macro_RawMotor_DriveMode_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/macro/RawMotor$DriveMode;ILorbotix/macro/RawMotor$DriveMode;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_macro_RawMotor_DriveMode_ILorbotix_macro_RawMotor_DriveMode_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_macro_RawMotor_DriveMode_ILorbotix_macro_RawMotor_DriveMode_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_getCommandID;
		public static sbyte CommandID {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getCommandID' and count(parameter)=0]"
			[Register ("getCommandID", "()B", "GetGetCommandIDHandler")]
			get {
				if (id_getCommandID == IntPtr.Zero)
					id_getCommandID = JNIEnv.GetStaticMethodID (class_ref, "getCommandID", "()B");
				return JNIEnv.CallStaticByteMethod  (class_ref, id_getCommandID);
			}
		}

		static Delegate cb_getCommandId;
#pragma warning disable 0169
		static Delegate GetGetCommandIdHandler ()
		{
			if (cb_getCommandId == null)
				cb_getCommandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetCommandId);
			return cb_getCommandId;
		}

		static sbyte n_GetCommandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommandId;
		}
#pragma warning restore 0169

		static IntPtr id_getCommandId;
		public virtual sbyte CommandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getCommandId' and count(parameter)=0]"
			[Register ("getCommandId", "()B", "GetGetCommandIdHandler")]
			get {
				if (id_getCommandId == IntPtr.Zero)
					id_getCommandId = JNIEnv.GetMethodID (class_ref, "getCommandId", "()B");

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getCommandId);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommandId", "()B"));
			}
		}

		static Delegate cb_getDelay;
#pragma warning disable 0169
		static Delegate GetGetDelayHandler ()
		{
			if (cb_getDelay == null)
				cb_getDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDelay);
			return cb_getDelay;
		}

		static int n_GetDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static Delegate cb_setDelay_I;
#pragma warning disable 0169
		static Delegate GetSetDelay_IHandler ()
		{
			if (cb_setDelay_I == null)
				cb_setDelay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDelay_I);
			return cb_setDelay_I;
		}

		static void n_SetDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		static IntPtr id_setDelay_I;
		public virtual int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()I", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDelay);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setDelay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDelay", "(I)V", "GetSetDelay_IHandler")]
			set {
				if (id_setDelay_I == IntPtr.Zero)
					id_setDelay_I = JNIEnv.GetMethodID (class_ref, "setDelay", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDelay_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelay", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getLeftDriveMode;
#pragma warning disable 0169
		static Delegate GetGetLeftDriveModeHandler ()
		{
			if (cb_getLeftDriveMode == null)
				cb_getLeftDriveMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeftDriveMode);
			return cb_getLeftDriveMode;
		}

		static IntPtr n_GetLeftDriveMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LeftDriveMode);
		}
#pragma warning restore 0169

		static Delegate cb_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_;
#pragma warning disable 0169
		static Delegate GetSetLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_Handler ()
		{
			if (cb_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_ == null)
				cb_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_);
			return cb_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_;
		}

		static void n_SetLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.RawMotor.DriveMode p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LeftDriveMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftDriveMode;
		static IntPtr id_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_;
		public virtual global::Orbotix.Macro.RawMotor.DriveMode LeftDriveMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getLeftDriveMode' and count(parameter)=0]"
			[Register ("getLeftDriveMode", "()Lorbotix/macro/RawMotor$DriveMode;", "GetGetLeftDriveModeHandler")]
			get {
				if (id_getLeftDriveMode == IntPtr.Zero)
					id_getLeftDriveMode = JNIEnv.GetMethodID (class_ref, "getLeftDriveMode", "()Lorbotix/macro/RawMotor$DriveMode;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (JNIEnv.CallObjectMethod  (Handle, id_getLeftDriveMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftDriveMode", "()Lorbotix/macro/RawMotor$DriveMode;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setLeftDriveMode' and count(parameter)=1 and parameter[1][@type='orbotix.macro.RawMotor.DriveMode']]"
			[Register ("setLeftDriveMode", "(Lorbotix/macro/RawMotor$DriveMode;)V", "GetSetLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_Handler")]
			set {
				if (id_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_ == IntPtr.Zero)
					id_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_ = JNIEnv.GetMethodID (class_ref, "setLeftDriveMode", "(Lorbotix/macro/RawMotor$DriveMode;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLeftDriveMode_Lorbotix_macro_RawMotor_DriveMode_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeftDriveMode", "(Lorbotix/macro/RawMotor$DriveMode;)V"), new JValue (value));
			}
		}

		static Delegate cb_getLeftDriveModeId;
#pragma warning disable 0169
		static Delegate GetGetLeftDriveModeIdHandler ()
		{
			if (cb_getLeftDriveModeId == null)
				cb_getLeftDriveModeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeftDriveModeId);
			return cb_getLeftDriveModeId;
		}

		static int n_GetLeftDriveModeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftDriveModeId;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftDriveModeId;
		public virtual int LeftDriveModeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getLeftDriveModeId' and count(parameter)=0]"
			[Register ("getLeftDriveModeId", "()I", "GetGetLeftDriveModeIdHandler")]
			get {
				if (id_getLeftDriveModeId == IntPtr.Zero)
					id_getLeftDriveModeId = JNIEnv.GetMethodID (class_ref, "getLeftDriveModeId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLeftDriveModeId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftDriveModeId", "()I"));
			}
		}

		static Delegate cb_getLeftPower;
#pragma warning disable 0169
		static Delegate GetGetLeftPowerHandler ()
		{
			if (cb_getLeftPower == null)
				cb_getLeftPower = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeftPower);
			return cb_getLeftPower;
		}

		static int n_GetLeftPower (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftPower;
		}
#pragma warning restore 0169

		static Delegate cb_setLeftPower_I;
#pragma warning disable 0169
		static Delegate GetSetLeftPower_IHandler ()
		{
			if (cb_setLeftPower_I == null)
				cb_setLeftPower_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLeftPower_I);
			return cb_setLeftPower_I;
		}

		static void n_SetLeftPower_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LeftPower = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftPower;
		static IntPtr id_setLeftPower_I;
		public virtual int LeftPower {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getLeftPower' and count(parameter)=0]"
			[Register ("getLeftPower", "()I", "GetGetLeftPowerHandler")]
			get {
				if (id_getLeftPower == IntPtr.Zero)
					id_getLeftPower = JNIEnv.GetMethodID (class_ref, "getLeftPower", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLeftPower);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftPower", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setLeftPower' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLeftPower", "(I)V", "GetSetLeftPower_IHandler")]
			set {
				if (id_setLeftPower_I == IntPtr.Zero)
					id_setLeftPower_I = JNIEnv.GetMethodID (class_ref, "setLeftPower", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLeftPower_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeftPower", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLength);
			return cb_getLength;
		}

		static int n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		static IntPtr id_getLength;
		public virtual int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler")]
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLength);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLength", "()I"));
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRightDriveMode;
#pragma warning disable 0169
		static Delegate GetGetRightDriveModeHandler ()
		{
			if (cb_getRightDriveMode == null)
				cb_getRightDriveMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRightDriveMode);
			return cb_getRightDriveMode;
		}

		static IntPtr n_GetRightDriveMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RightDriveMode);
		}
#pragma warning restore 0169

		static Delegate cb_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_;
#pragma warning disable 0169
		static Delegate GetSetRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_Handler ()
		{
			if (cb_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_ == null)
				cb_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_);
			return cb_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_;
		}

		static void n_SetRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.RawMotor.DriveMode p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RightDriveMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRightDriveMode;
		static IntPtr id_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_;
		public virtual global::Orbotix.Macro.RawMotor.DriveMode RightDriveMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getRightDriveMode' and count(parameter)=0]"
			[Register ("getRightDriveMode", "()Lorbotix/macro/RawMotor$DriveMode;", "GetGetRightDriveModeHandler")]
			get {
				if (id_getRightDriveMode == IntPtr.Zero)
					id_getRightDriveMode = JNIEnv.GetMethodID (class_ref, "getRightDriveMode", "()Lorbotix/macro/RawMotor$DriveMode;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (JNIEnv.CallObjectMethod  (Handle, id_getRightDriveMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor.DriveMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightDriveMode", "()Lorbotix/macro/RawMotor$DriveMode;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setRightDriveMode' and count(parameter)=1 and parameter[1][@type='orbotix.macro.RawMotor.DriveMode']]"
			[Register ("setRightDriveMode", "(Lorbotix/macro/RawMotor$DriveMode;)V", "GetSetRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_Handler")]
			set {
				if (id_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_ == IntPtr.Zero)
					id_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_ = JNIEnv.GetMethodID (class_ref, "setRightDriveMode", "(Lorbotix/macro/RawMotor$DriveMode;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRightDriveMode_Lorbotix_macro_RawMotor_DriveMode_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightDriveMode", "(Lorbotix/macro/RawMotor$DriveMode;)V"), new JValue (value));
			}
		}

		static Delegate cb_getRightDriveModeId;
#pragma warning disable 0169
		static Delegate GetGetRightDriveModeIdHandler ()
		{
			if (cb_getRightDriveModeId == null)
				cb_getRightDriveModeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRightDriveModeId);
			return cb_getRightDriveModeId;
		}

		static int n_GetRightDriveModeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightDriveModeId;
		}
#pragma warning restore 0169

		static IntPtr id_getRightDriveModeId;
		public virtual int RightDriveModeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getRightDriveModeId' and count(parameter)=0]"
			[Register ("getRightDriveModeId", "()I", "GetGetRightDriveModeIdHandler")]
			get {
				if (id_getRightDriveModeId == IntPtr.Zero)
					id_getRightDriveModeId = JNIEnv.GetMethodID (class_ref, "getRightDriveModeId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRightDriveModeId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightDriveModeId", "()I"));
			}
		}

		static Delegate cb_getRightPower;
#pragma warning disable 0169
		static Delegate GetGetRightPowerHandler ()
		{
			if (cb_getRightPower == null)
				cb_getRightPower = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRightPower);
			return cb_getRightPower;
		}

		static int n_GetRightPower (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightPower;
		}
#pragma warning restore 0169

		static Delegate cb_setRightPower_I;
#pragma warning disable 0169
		static Delegate GetSetRightPower_IHandler ()
		{
			if (cb_setRightPower_I == null)
				cb_setRightPower_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRightPower_I);
			return cb_setRightPower_I;
		}

		static void n_SetRightPower_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RightPower = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRightPower;
		static IntPtr id_setRightPower_I;
		public virtual int RightPower {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getRightPower' and count(parameter)=0]"
			[Register ("getRightPower", "()I", "GetGetRightPowerHandler")]
			get {
				if (id_getRightPower == IntPtr.Zero)
					id_getRightPower = JNIEnv.GetMethodID (class_ref, "getRightPower", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRightPower);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightPower", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setRightPower' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRightPower", "(I)V", "GetSetRightPower_IHandler")]
			set {
				if (id_setRightPower_I == IntPtr.Zero)
					id_setRightPower_I = JNIEnv.GetMethodID (class_ref, "setRightPower", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRightPower_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightPower", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getSettingsString;
#pragma warning disable 0169
		static Delegate GetGetSettingsStringHandler ()
		{
			if (cb_getSettingsString == null)
				cb_getSettingsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSettingsString);
			return cb_getSettingsString;
		}

		static IntPtr n_GetSettingsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SettingsString);
		}
#pragma warning restore 0169

		static IntPtr id_getSettingsString;
		public virtual string SettingsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getSettingsString' and count(parameter)=0]"
			[Register ("getSettingsString", "()Ljava/lang/String;", "GetGetSettingsStringHandler")]
			get {
				if (id_getSettingsString == IntPtr.Zero)
					id_getSettingsString = JNIEnv.GetMethodID (class_ref, "getSettingsString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSettingsString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSettingsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getByteRepresentation;
#pragma warning disable 0169
		static Delegate GetGetByteRepresentationHandler ()
		{
			if (cb_getByteRepresentation == null)
				cb_getByteRepresentation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetByteRepresentation);
			return cb_getByteRepresentation;
		}

		static IntPtr n_GetByteRepresentation (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetByteRepresentation ());
		}
#pragma warning restore 0169

		static IntPtr id_getByteRepresentation;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='getByteRepresentation' and count(parameter)=0]"
		[Register ("getByteRepresentation", "()[B", "GetGetByteRepresentationHandler")]
		public virtual byte[] GetByteRepresentation ()
		{
			if (id_getByteRepresentation == IntPtr.Zero)
				id_getByteRepresentation = JNIEnv.GetMethodID (class_ref, "getByteRepresentation", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getByteRepresentation), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByteRepresentation", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_setLeftDriveMode_I;
#pragma warning disable 0169
		static Delegate GetSetLeftDriveMode_IHandler ()
		{
			if (cb_setLeftDriveMode_I == null)
				cb_setLeftDriveMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLeftDriveMode_I);
			return cb_setLeftDriveMode_I;
		}

		static void n_SetLeftDriveMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLeftDriveMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLeftDriveMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setLeftDriveMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLeftDriveMode", "(I)V", "GetSetLeftDriveMode_IHandler")]
		public virtual void SetLeftDriveMode (int p0)
		{
			if (id_setLeftDriveMode_I == IntPtr.Zero)
				id_setLeftDriveMode_I = JNIEnv.GetMethodID (class_ref, "setLeftDriveMode", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLeftDriveMode_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeftDriveMode", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setRightDriveMode_I;
#pragma warning disable 0169
		static Delegate GetSetRightDriveMode_IHandler ()
		{
			if (cb_setRightDriveMode_I == null)
				cb_setRightDriveMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRightDriveMode_I);
			return cb_setRightDriveMode_I;
		}

		static void n_SetRightDriveMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Macro.RawMotor __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.RawMotor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRightDriveMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRightDriveMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='RawMotor']/method[@name='setRightDriveMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRightDriveMode", "(I)V", "GetSetRightDriveMode_IHandler")]
		public virtual void SetRightDriveMode (int p0)
		{
			if (id_setRightDriveMode_I == IntPtr.Zero)
				id_setRightDriveMode_I = JNIEnv.GetMethodID (class_ref, "setRightDriveMode", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRightDriveMode_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightDriveMode", "(I)V"), new JValue (p0));
		}

	}
}
