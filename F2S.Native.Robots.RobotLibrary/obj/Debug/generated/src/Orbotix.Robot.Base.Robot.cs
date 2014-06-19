using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']"
	[global::Android.Runtime.Register ("orbotix/robot/base/Robot", DoNotGenerateAcw=true)]
	public partial class Robot : global::Java.Util.Observable, global::Android.OS.IParcelable, global::Java.IO.ICloseable {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='ACTION_FOUND']"
		[Register ("ACTION_FOUND")]
		public const string ActionFound = (string) "orbotix.robot.initent.action.FOUND";

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='EXTRA_ROBOT_ID']"
		[Register ("EXTRA_ROBOT_ID")]
		public const string ExtraRobotId = (string) "orbotix.robot.RobotId";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='OBERVABLE_MAIN_APP_CORRUPT_STATE_CHANGED']"
		[Register ("OBERVABLE_MAIN_APP_CORRUPT_STATE_CHANGED")]
		public const int ObervableMainAppCorruptStateChanged = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='OBSERVABLE_CONNECTED_STATE_CHANGED']"
		[Register ("OBSERVABLE_CONNECTED_STATE_CHANGED")]
		public const int ObservableConnectedStateChanged = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='OBSERVABLE_NAME_CHANGED']"
		[Register ("OBSERVABLE_NAME_CHANGED")]
		public const int ObservableNameChanged = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/field[@name='OBSERVABLE_UNDER_CONTROL_STATE_CHANGED']"
		[Register ("OBSERVABLE_UNDER_CONTROL_STATE_CHANGED")]
		public const int ObservableUnderControlStateChanged = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/Robot", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Robot); }
		}

		protected Robot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_bluetooth_BluetoothDevice_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/constructor[@name='Robot' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;)V", "")]
		protected Robot (global::Android.Bluetooth.BluetoothDevice p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Robot)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/bluetooth/BluetoothDevice;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/bluetooth/BluetoothDevice;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
				id_ctor_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothDevice;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorbotix_robot_base_ControlStrategy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/constructor[@name='Robot' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.ControlStrategy']]"
		[Register (".ctor", "(Lorbotix/robot/base/ControlStrategy;)V", "")]
		public Robot (global::Orbotix.Robot.Base.IControlStrategy p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Robot)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/ControlStrategy;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/ControlStrategy;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_base_ControlStrategy_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_ControlStrategy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/ControlStrategy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_ControlStrategy_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_ControlStrategy_, new JValue (p0));
		}

		static Delegate cb_getBluetoothName;
#pragma warning disable 0169
		static Delegate GetGetBluetoothNameHandler ()
		{
			if (cb_getBluetoothName == null)
				cb_getBluetoothName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBluetoothName);
			return cb_getBluetoothName;
		}

		static IntPtr n_GetBluetoothName (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BluetoothName);
		}
#pragma warning restore 0169

		static IntPtr id_getBluetoothName;
		public virtual string BluetoothName {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getBluetoothName' and count(parameter)=0]"
			[Register ("getBluetoothName", "()Ljava/lang/String;", "GetGetBluetoothNameHandler")]
			get {
				if (id_getBluetoothName == IntPtr.Zero)
					id_getBluetoothName = JNIEnv.GetMethodID (class_ref, "getBluetoothName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBluetoothName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
			}
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		static IntPtr id_getDevice;
		public virtual global::Android.Bluetooth.BluetoothDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Landroid/bluetooth/BluetoothDevice;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallObjectMethod  (Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevice", "()Landroid/bluetooth/BluetoothDevice;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isKnown;
#pragma warning disable 0169
		static Delegate GetIsKnownHandler ()
		{
			if (cb_isKnown == null)
				cb_isKnown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKnown);
			return cb_isKnown;
		}

		static bool n_IsKnown (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKnown;
		}
#pragma warning restore 0169

		static IntPtr id_isKnown;
		public virtual bool IsKnown {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='isKnown' and count(parameter)=0]"
			[Register ("isKnown", "()Z", "GetIsKnownHandler")]
			get {
				if (id_isKnown == IntPtr.Zero)
					id_isKnown = JNIEnv.GetMethodID (class_ref, "isKnown", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isKnown);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isKnown", "()Z"));
			}
		}

		static Delegate cb_isMainAppCorrupt;
#pragma warning disable 0169
		static Delegate GetIsMainAppCorruptHandler ()
		{
			if (cb_isMainAppCorrupt == null)
				cb_isMainAppCorrupt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMainAppCorrupt);
			return cb_isMainAppCorrupt;
		}

		static bool n_IsMainAppCorrupt (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMainAppCorrupt;
		}
#pragma warning restore 0169

		static IntPtr id_isMainAppCorrupt;
		public virtual bool IsMainAppCorrupt {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='isMainAppCorrupt' and count(parameter)=0]"
			[Register ("isMainAppCorrupt", "()Z", "GetIsMainAppCorruptHandler")]
			get {
				if (id_isMainAppCorrupt == IntPtr.Zero)
					id_isMainAppCorrupt = JNIEnv.GetMethodID (class_ref, "isMainAppCorrupt", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMainAppCorrupt);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMainAppCorrupt", "()Z"));
			}
		}

		static Delegate cb_isUnderControl;
#pragma warning disable 0169
		static Delegate GetIsUnderControlHandler ()
		{
			if (cb_isUnderControl == null)
				cb_isUnderControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnderControl);
			return cb_isUnderControl;
		}

		static bool n_IsUnderControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderControl;
		}
#pragma warning restore 0169

		static IntPtr id_isUnderControl;
		public virtual bool IsUnderControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='isUnderControl' and count(parameter)=0]"
			[Register ("isUnderControl", "()Z", "GetIsUnderControlHandler")]
			get {
				if (id_isUnderControl == IntPtr.Zero)
					id_isUnderControl = JNIEnv.GetMethodID (class_ref, "isUnderControl", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isUnderControl);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUnderControl", "()Z"));
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
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setName_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeOffset_J;
#pragma warning disable 0169
		static Delegate GetSetTimeOffset_JHandler ()
		{
			if (cb_setTimeOffset_J == null)
				cb_setTimeOffset_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimeOffset_J);
			return cb_setTimeOffset_J;
		}

		static void n_SetTimeOffset_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimeOffset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeOffset;
		static IntPtr id_setTimeOffset_J;
		public virtual long TimeOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getTimeOffset' and count(parameter)=0]"
			[Register ("getTimeOffset", "()J", "GetGetTimeOffsetHandler")]
			get {
				if (id_getTimeOffset == IntPtr.Zero)
					id_getTimeOffset = JNIEnv.GetMethodID (class_ref, "getTimeOffset", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimeOffset);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeOffset", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setTimeOffset' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimeOffset", "(J)V", "GetSetTimeOffset_JHandler")]
			set {
				if (id_setTimeOffset_J == IntPtr.Zero)
					id_setTimeOffset_J = JNIEnv.GetMethodID (class_ref, "setTimeOffset", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeOffset_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeOffset", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_getUniqueId;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdHandler ()
		{
			if (cb_getUniqueId == null)
				cb_getUniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueId);
			return cb_getUniqueId;
		}

		static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueId);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueId;
		public virtual string UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Ljava/lang/String;", "GetGetUniqueIdHandler")]
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniqueId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserColorBlueIntensity;
#pragma warning disable 0169
		static Delegate GetGetUserColorBlueIntensityHandler ()
		{
			if (cb_getUserColorBlueIntensity == null)
				cb_getUserColorBlueIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserColorBlueIntensity);
			return cb_getUserColorBlueIntensity;
		}

		static int n_GetUserColorBlueIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserColorBlueIntensity;
		}
#pragma warning restore 0169

		static Delegate cb_setUserColorBlueIntensity_I;
#pragma warning disable 0169
		static Delegate GetSetUserColorBlueIntensity_IHandler ()
		{
			if (cb_setUserColorBlueIntensity_I == null)
				cb_setUserColorBlueIntensity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUserColorBlueIntensity_I);
			return cb_setUserColorBlueIntensity_I;
		}

		static void n_SetUserColorBlueIntensity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserColorBlueIntensity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserColorBlueIntensity;
		static IntPtr id_setUserColorBlueIntensity_I;
		public virtual int UserColorBlueIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getUserColorBlueIntensity' and count(parameter)=0]"
			[Register ("getUserColorBlueIntensity", "()I", "GetGetUserColorBlueIntensityHandler")]
			get {
				if (id_getUserColorBlueIntensity == IntPtr.Zero)
					id_getUserColorBlueIntensity = JNIEnv.GetMethodID (class_ref, "getUserColorBlueIntensity", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUserColorBlueIntensity);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserColorBlueIntensity", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setUserColorBlueIntensity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserColorBlueIntensity", "(I)V", "GetSetUserColorBlueIntensity_IHandler")]
			set {
				if (id_setUserColorBlueIntensity_I == IntPtr.Zero)
					id_setUserColorBlueIntensity_I = JNIEnv.GetMethodID (class_ref, "setUserColorBlueIntensity", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserColorBlueIntensity_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserColorBlueIntensity", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getUserColorGreenIntensity;
#pragma warning disable 0169
		static Delegate GetGetUserColorGreenIntensityHandler ()
		{
			if (cb_getUserColorGreenIntensity == null)
				cb_getUserColorGreenIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserColorGreenIntensity);
			return cb_getUserColorGreenIntensity;
		}

		static int n_GetUserColorGreenIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserColorGreenIntensity;
		}
#pragma warning restore 0169

		static Delegate cb_setUserColorGreenIntensity_I;
#pragma warning disable 0169
		static Delegate GetSetUserColorGreenIntensity_IHandler ()
		{
			if (cb_setUserColorGreenIntensity_I == null)
				cb_setUserColorGreenIntensity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUserColorGreenIntensity_I);
			return cb_setUserColorGreenIntensity_I;
		}

		static void n_SetUserColorGreenIntensity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserColorGreenIntensity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserColorGreenIntensity;
		static IntPtr id_setUserColorGreenIntensity_I;
		public virtual int UserColorGreenIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getUserColorGreenIntensity' and count(parameter)=0]"
			[Register ("getUserColorGreenIntensity", "()I", "GetGetUserColorGreenIntensityHandler")]
			get {
				if (id_getUserColorGreenIntensity == IntPtr.Zero)
					id_getUserColorGreenIntensity = JNIEnv.GetMethodID (class_ref, "getUserColorGreenIntensity", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUserColorGreenIntensity);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserColorGreenIntensity", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setUserColorGreenIntensity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserColorGreenIntensity", "(I)V", "GetSetUserColorGreenIntensity_IHandler")]
			set {
				if (id_setUserColorGreenIntensity_I == IntPtr.Zero)
					id_setUserColorGreenIntensity_I = JNIEnv.GetMethodID (class_ref, "setUserColorGreenIntensity", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserColorGreenIntensity_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserColorGreenIntensity", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getUserColorRedIntensity;
#pragma warning disable 0169
		static Delegate GetGetUserColorRedIntensityHandler ()
		{
			if (cb_getUserColorRedIntensity == null)
				cb_getUserColorRedIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserColorRedIntensity);
			return cb_getUserColorRedIntensity;
		}

		static int n_GetUserColorRedIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserColorRedIntensity;
		}
#pragma warning restore 0169

		static Delegate cb_setUserColorRedIntensity_I;
#pragma warning disable 0169
		static Delegate GetSetUserColorRedIntensity_IHandler ()
		{
			if (cb_setUserColorRedIntensity_I == null)
				cb_setUserColorRedIntensity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUserColorRedIntensity_I);
			return cb_setUserColorRedIntensity_I;
		}

		static void n_SetUserColorRedIntensity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserColorRedIntensity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserColorRedIntensity;
		static IntPtr id_setUserColorRedIntensity_I;
		public virtual int UserColorRedIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='getUserColorRedIntensity' and count(parameter)=0]"
			[Register ("getUserColorRedIntensity", "()I", "GetGetUserColorRedIntensityHandler")]
			get {
				if (id_getUserColorRedIntensity == IntPtr.Zero)
					id_getUserColorRedIntensity = JNIEnv.GetMethodID (class_ref, "getUserColorRedIntensity", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUserColorRedIntensity);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserColorRedIntensity", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setUserColorRedIntensity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserColorRedIntensity", "(I)V", "GetSetUserColorRedIntensity_IHandler")]
			set {
				if (id_setUserColorRedIntensity_I == IntPtr.Zero)
					id_setUserColorRedIntensity_I = JNIEnv.GetMethodID (class_ref, "setUserColorRedIntensity", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserColorRedIntensity_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserColorRedIntensity", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
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
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static Delegate cb_doCommand_Lorbotix_robot_internal_DeviceCommand_;
#pragma warning disable 0169
		static Delegate GetDoCommand_Lorbotix_robot_internal_DeviceCommand_Handler ()
		{
			if (cb_doCommand_Lorbotix_robot_internal_DeviceCommand_ == null)
				cb_doCommand_Lorbotix_robot_internal_DeviceCommand_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoCommand_Lorbotix_robot_internal_DeviceCommand_);
			return cb_doCommand_Lorbotix_robot_internal_DeviceCommand_;
		}

		static void n_DoCommand_Lorbotix_robot_internal_DeviceCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoCommand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doCommand_Lorbotix_robot_internal_DeviceCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='doCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceCommand']]"
		[Register ("doCommand", "(Lorbotix/robot/internal/DeviceCommand;)V", "GetDoCommand_Lorbotix_robot_internal_DeviceCommand_Handler")]
		public virtual void DoCommand (global::Orbotix.Robot.Internal.DeviceCommand p0)
		{
			if (id_doCommand_Lorbotix_robot_internal_DeviceCommand_ == IntPtr.Zero)
				id_doCommand_Lorbotix_robot_internal_DeviceCommand_ = JNIEnv.GetMethodID (class_ref, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doCommand_Lorbotix_robot_internal_DeviceCommand_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;)V"), new JValue (p0));
		}

		static Delegate cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
#pragma warning disable 0169
		static Delegate GetDoCommand_Lorbotix_robot_internal_DeviceCommand_JHandler ()
		{
			if (cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J == null)
				cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_DoCommand_Lorbotix_robot_internal_DeviceCommand_J);
			return cb_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
		}

		static void n_DoCommand_Lorbotix_robot_internal_DeviceCommand_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.DeviceCommand p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doCommand_Lorbotix_robot_internal_DeviceCommand_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='doCommand' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='long']]"
		[Register ("doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V", "GetDoCommand_Lorbotix_robot_internal_DeviceCommand_JHandler")]
		public virtual void DoCommand (global::Orbotix.Robot.Internal.DeviceCommand p0, long p1)
		{
			if (id_doCommand_Lorbotix_robot_internal_DeviceCommand_J == IntPtr.Zero)
				id_doCommand_Lorbotix_robot_internal_DeviceCommand_J = JNIEnv.GetMethodID (class_ref, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doCommand_Lorbotix_robot_internal_DeviceCommand_J, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doCommand", "(Lorbotix/robot/internal/DeviceCommand;J)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsConnected);
			return cb_isConnected;
		}

		static IntPtr n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsConnected ());
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='isConnected' and count(parameter)=0]"
		[Register ("isConnected", "()Ljava/lang/Boolean;", "GetIsConnectedHandler")]
		public virtual global::Java.Lang.Boolean IsConnected ()
		{
			if (id_isConnected == IntPtr.Zero)
				id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Ljava/lang/Boolean;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isConnected), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setConnected_Z;
#pragma warning disable 0169
		static Delegate GetSetConnected_ZHandler ()
		{
			if (cb_setConnected_Z == null)
				cb_setConnected_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetConnected_Z);
			return cb_setConnected_Z;
		}

		static void n_SetConnected_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnected_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setConnected", "(Z)V", "GetSetConnected_ZHandler")]
		public virtual void SetConnected (bool p0)
		{
			if (id_setConnected_Z == IntPtr.Zero)
				id_setConnected_Z = JNIEnv.GetMethodID (class_ref, "setConnected", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConnected_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnected", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setControlStrategy_Lorbotix_robot_base_ControlStrategy_;
#pragma warning disable 0169
		static Delegate GetSetControlStrategy_Lorbotix_robot_base_ControlStrategy_Handler ()
		{
			if (cb_setControlStrategy_Lorbotix_robot_base_ControlStrategy_ == null)
				cb_setControlStrategy_Lorbotix_robot_base_ControlStrategy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControlStrategy_Lorbotix_robot_base_ControlStrategy_);
			return cb_setControlStrategy_Lorbotix_robot_base_ControlStrategy_;
		}

		static void n_SetControlStrategy_Lorbotix_robot_base_ControlStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.IControlStrategy p0 = (global::Orbotix.Robot.Base.IControlStrategy)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.IControlStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetControlStrategy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setControlStrategy_Lorbotix_robot_base_ControlStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setControlStrategy' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.ControlStrategy']]"
		[Register ("setControlStrategy", "(Lorbotix/robot/base/ControlStrategy;)V", "GetSetControlStrategy_Lorbotix_robot_base_ControlStrategy_Handler")]
		public virtual void SetControlStrategy (global::Orbotix.Robot.Base.IControlStrategy p0)
		{
			if (id_setControlStrategy_Lorbotix_robot_base_ControlStrategy_ == IntPtr.Zero)
				id_setControlStrategy_Lorbotix_robot_base_ControlStrategy_ = JNIEnv.GetMethodID (class_ref, "setControlStrategy", "(Lorbotix/robot/base/ControlStrategy;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setControlStrategy_Lorbotix_robot_base_ControlStrategy_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setControlStrategy", "(Lorbotix/robot/base/ControlStrategy;)V"), new JValue (p0));
		}

		static Delegate cb_setMainApplicationCorrupt_Z;
#pragma warning disable 0169
		static Delegate GetSetMainApplicationCorrupt_ZHandler ()
		{
			if (cb_setMainApplicationCorrupt_Z == null)
				cb_setMainApplicationCorrupt_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMainApplicationCorrupt_Z);
			return cb_setMainApplicationCorrupt_Z;
		}

		static void n_SetMainApplicationCorrupt_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMainApplicationCorrupt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMainApplicationCorrupt_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setMainApplicationCorrupt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMainApplicationCorrupt", "(Z)V", "GetSetMainApplicationCorrupt_ZHandler")]
		public virtual void SetMainApplicationCorrupt (bool p0)
		{
			if (id_setMainApplicationCorrupt_Z == IntPtr.Zero)
				id_setMainApplicationCorrupt_Z = JNIEnv.GetMethodID (class_ref, "setMainApplicationCorrupt", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMainApplicationCorrupt_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMainApplicationCorrupt", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setUnderControl_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetUnderControl_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setUnderControl_Ljava_lang_Boolean_ == null)
				cb_setUnderControl_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnderControl_Ljava_lang_Boolean_);
			return cb_setUnderControl_Ljava_lang_Boolean_;
		}

		static void n_SetUnderControl_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUnderControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUnderControl_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='setUnderControl' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setUnderControl", "(Ljava/lang/Boolean;)V", "GetSetUnderControl_Ljava_lang_Boolean_Handler")]
		public virtual void SetUnderControl (global::Java.Lang.Boolean p0)
		{
			if (id_setUnderControl_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setUnderControl_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setUnderControl", "(Ljava/lang/Boolean;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUnderControl_Ljava_lang_Boolean_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnderControl", "(Ljava/lang/Boolean;)V"), new JValue (p0));
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
			global::Orbotix.Robot.Base.Robot __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='Robot']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

	}
}
