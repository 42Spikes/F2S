using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Macro {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']"
	[global::Android.Runtime.Register ("orbotix/macro/Stabilization", DoNotGenerateAcw=true)]
	public partial class Stabilization : global::Java.Lang.Object, global::Orbotix.Macro.IMacroCommand {


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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/macro/Stabilization", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stabilization); }
		}

		protected Stabilization (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/constructor[@name='Stabilization' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register (".ctor", "(ZI)V", "")]
		public Stabilization (bool p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Stabilization)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZI)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZI)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ZI == IntPtr.Zero)
				id_ctor_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(ZI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZI, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZI, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/constructor[@name='Stabilization' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public Stabilization (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (Stabilization)) {
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

		static IntPtr id_getCommandID;
		public static sbyte CommandID {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getCommandID' and count(parameter)=0]"
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommandId;
		}
#pragma warning restore 0169

		static IntPtr id_getCommandId;
		public virtual sbyte CommandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getCommandId' and count(parameter)=0]"
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		static IntPtr id_setDelay_I;
		public virtual int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()I", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDelay);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='setDelay' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getIsStabilized;
#pragma warning disable 0169
		static Delegate GetGetIsStabilizedHandler ()
		{
			if (cb_getIsStabilized == null)
				cb_getIsStabilized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsStabilized);
			return cb_getIsStabilized;
		}

		static bool n_GetIsStabilized (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStabilized;
		}
#pragma warning restore 0169

		static IntPtr id_getIsStabilized;
		public virtual bool IsStabilized {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getIsStabilized' and count(parameter)=0]"
			[Register ("getIsStabilized", "()Z", "GetGetIsStabilizedHandler")]
			get {
				if (id_getIsStabilized == IntPtr.Zero)
					id_getIsStabilized = JNIEnv.GetMethodID (class_ref, "getIsStabilized", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getIsStabilized);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsStabilized", "()Z"));
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		static IntPtr id_getLength;
		public virtual int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getLength' and count(parameter)=0]"
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getName' and count(parameter)=0]"
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SettingsString);
		}
#pragma warning restore 0169

		static IntPtr id_getSettingsString;
		public virtual string SettingsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getSettingsString' and count(parameter)=0]"
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
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetByteRepresentation ());
		}
#pragma warning restore 0169

		static IntPtr id_getByteRepresentation;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='getByteRepresentation' and count(parameter)=0]"
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

		static Delegate cb_setStabilization_Z;
#pragma warning disable 0169
		static Delegate GetSetStabilization_ZHandler ()
		{
			if (cb_setStabilization_Z == null)
				cb_setStabilization_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStabilization_Z);
			return cb_setStabilization_Z;
		}

		static void n_SetStabilization_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Macro.Stabilization __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.Stabilization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStabilization (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStabilization_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='Stabilization']/method[@name='setStabilization' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStabilization", "(Z)V", "GetSetStabilization_ZHandler")]
		public virtual void SetStabilization (bool p0)
		{
			if (id_setStabilization_Z == IntPtr.Zero)
				id_setStabilization_Z = JNIEnv.GetMethodID (class_ref, "setStabilization", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStabilization_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStabilization", "(Z)V"), new JValue (p0));
		}

	}
}
