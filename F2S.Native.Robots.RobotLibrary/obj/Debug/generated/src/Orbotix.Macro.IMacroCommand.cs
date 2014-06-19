using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Macro {

	[Register ("orbotix/macro/MacroCommand")]
	public abstract class MacroCommand {

		internal MacroCommand ()
		{
		}

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

		// The following are fields from: java.io.Serializable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable
	}

	[System.Obsolete ("Use the 'MacroCommand' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class MacroCommandConsts : MacroCommand {

		private MacroCommandConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']"
	[Register ("orbotix/macro/MacroCommand", "", "Orbotix.Macro.IMacroCommandInvoker")]
	public partial interface IMacroCommand : global::Java.IO.ISerializable {

		sbyte CommandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/method[@name='getCommandId' and count(parameter)=0]"
			[Register ("getCommandId", "()B", "GetGetCommandIdHandler:Orbotix.Macro.IMacroCommandInvoker, F2S.Native.Robots.RobotLibrary")] get;
		}

		int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler:Orbotix.Macro.IMacroCommandInvoker, F2S.Native.Robots.RobotLibrary")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Orbotix.Macro.IMacroCommandInvoker, F2S.Native.Robots.RobotLibrary")] get;
		}

		string SettingsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/method[@name='getSettingsString' and count(parameter)=0]"
			[Register ("getSettingsString", "()Ljava/lang/String;", "GetGetSettingsStringHandler:Orbotix.Macro.IMacroCommandInvoker, F2S.Native.Robots.RobotLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroCommand']/method[@name='getByteRepresentation' and count(parameter)=0]"
		[Register ("getByteRepresentation", "()[B", "GetGetByteRepresentationHandler:Orbotix.Macro.IMacroCommandInvoker, F2S.Native.Robots.RobotLibrary")]
		byte[] GetByteRepresentation ();

	}

	[global::Android.Runtime.Register ("orbotix/macro/MacroCommand", DoNotGenerateAcw=true)]
	internal class IMacroCommandInvoker : global::Java.Lang.Object, IMacroCommand {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/macro/MacroCommand");
		IntPtr class_ref;

		public static IMacroCommand GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMacroCommand> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.macro.MacroCommand"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMacroCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMacroCommandInvoker); }
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
			global::Orbotix.Macro.IMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommandId;
		}
#pragma warning restore 0169

		IntPtr id_getCommandId;
		public sbyte CommandId {
			get {
				if (id_getCommandId == IntPtr.Zero)
					id_getCommandId = JNIEnv.GetMethodID (class_ref, "getCommandId", "()B");
				return JNIEnv.CallByteMethod (Handle, id_getCommandId);
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
			global::Orbotix.Macro.IMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		IntPtr id_getLength;
		public int Length {
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLength);
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
			global::Orbotix.Macro.IMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Macro.IMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SettingsString);
		}
#pragma warning restore 0169

		IntPtr id_getSettingsString;
		public string SettingsString {
			get {
				if (id_getSettingsString == IntPtr.Zero)
					id_getSettingsString = JNIEnv.GetMethodID (class_ref, "getSettingsString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getSettingsString), JniHandleOwnership.TransferLocalRef);
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
			global::Orbotix.Macro.IMacroCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetByteRepresentation ());
		}
#pragma warning restore 0169

		IntPtr id_getByteRepresentation;
		public byte[] GetByteRepresentation ()
		{
			if (id_getByteRepresentation == IntPtr.Zero)
				id_getByteRepresentation = JNIEnv.GetMethodID (class_ref, "getByteRepresentation", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getByteRepresentation), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}

}
