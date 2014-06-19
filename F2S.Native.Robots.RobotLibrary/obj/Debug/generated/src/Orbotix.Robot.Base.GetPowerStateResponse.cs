using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/base/GetPowerStateResponse", DoNotGenerateAcw=true)]
	public partial class GetPowerStateResponse : global::Orbotix.Robot.Internal.DeviceResponse {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/field[@name='POWER_STATE_CHARGING']"
		[Register ("POWER_STATE_CHARGING")]
		public const short PowerStateCharging = (short) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/field[@name='POWER_STATE_CRITICAL']"
		[Register ("POWER_STATE_CRITICAL")]
		public const short PowerStateCritical = (short) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/field[@name='POWER_STATE_LOW']"
		[Register ("POWER_STATE_LOW")]
		public const short PowerStateLow = (short) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/field[@name='POWER_STATE_OK']"
		[Register ("POWER_STATE_OK")]
		public const short PowerStateOk = (short) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/GetPowerStateResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetPowerStateResponse); }
		}

		protected GetPowerStateResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/constructor[@name='GetPowerStateResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected GetPowerStateResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetPowerStateResponse)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/constructor[@name='GetPowerStateResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public GetPowerStateResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (GetPowerStateResponse)) {
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

		static Delegate cb_getBatteryVoltage;
#pragma warning disable 0169
		static Delegate GetGetBatteryVoltageHandler ()
		{
			if (cb_getBatteryVoltage == null)
				cb_getBatteryVoltage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBatteryVoltage);
			return cb_getBatteryVoltage;
		}

		static float n_GetBatteryVoltage (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetPowerStateResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetPowerStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BatteryVoltage;
		}
#pragma warning restore 0169

		static IntPtr id_getBatteryVoltage;
		public virtual float BatteryVoltage {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/method[@name='getBatteryVoltage' and count(parameter)=0]"
			[Register ("getBatteryVoltage", "()F", "GetGetBatteryVoltageHandler")]
			get {
				if (id_getBatteryVoltage == IntPtr.Zero)
					id_getBatteryVoltage = JNIEnv.GetMethodID (class_ref, "getBatteryVoltage", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getBatteryVoltage);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBatteryVoltage", "()F"));
			}
		}

		static Delegate cb_getNumberOfCharges;
#pragma warning disable 0169
		static Delegate GetGetNumberOfChargesHandler ()
		{
			if (cb_getNumberOfCharges == null)
				cb_getNumberOfCharges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfCharges);
			return cb_getNumberOfCharges;
		}

		static int n_GetNumberOfCharges (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetPowerStateResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetPowerStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfCharges;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfCharges;
		public virtual int NumberOfCharges {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/method[@name='getNumberOfCharges' and count(parameter)=0]"
			[Register ("getNumberOfCharges", "()I", "GetGetNumberOfChargesHandler")]
			get {
				if (id_getNumberOfCharges == IntPtr.Zero)
					id_getNumberOfCharges = JNIEnv.GetMethodID (class_ref, "getNumberOfCharges", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNumberOfCharges);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfCharges", "()I"));
			}
		}

		static Delegate cb_getPowerState;
#pragma warning disable 0169
		static Delegate GetGetPowerStateHandler ()
		{
			if (cb_getPowerState == null)
				cb_getPowerState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetPowerState);
			return cb_getPowerState;
		}

		static short n_GetPowerState (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetPowerStateResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetPowerStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PowerState;
		}
#pragma warning restore 0169

		static IntPtr id_getPowerState;
		public virtual short PowerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/method[@name='getPowerState' and count(parameter)=0]"
			[Register ("getPowerState", "()S", "GetGetPowerStateHandler")]
			get {
				if (id_getPowerState == IntPtr.Zero)
					id_getPowerState = JNIEnv.GetMethodID (class_ref, "getPowerState", "()S");

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_getPowerState);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPowerState", "()S"));
			}
		}

		static Delegate cb_getRecordVersion;
#pragma warning disable 0169
		static Delegate GetGetRecordVersionHandler ()
		{
			if (cb_getRecordVersion == null)
				cb_getRecordVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRecordVersion);
			return cb_getRecordVersion;
		}

		static int n_GetRecordVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetPowerStateResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetPowerStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getRecordVersion;
		protected virtual int RecordVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/method[@name='getRecordVersion' and count(parameter)=0]"
			[Register ("getRecordVersion", "()I", "GetGetRecordVersionHandler")]
			get {
				if (id_getRecordVersion == IntPtr.Zero)
					id_getRecordVersion = JNIEnv.GetMethodID (class_ref, "getRecordVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRecordVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordVersion", "()I"));
			}
		}

		static Delegate cb_getTimeSinceLastCharge;
#pragma warning disable 0169
		static Delegate GetGetTimeSinceLastChargeHandler ()
		{
			if (cb_getTimeSinceLastCharge == null)
				cb_getTimeSinceLastCharge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeSinceLastCharge);
			return cb_getTimeSinceLastCharge;
		}

		static int n_GetTimeSinceLastCharge (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetPowerStateResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetPowerStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeSinceLastCharge;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeSinceLastCharge;
		public virtual int TimeSinceLastCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetPowerStateResponse']/method[@name='getTimeSinceLastCharge' and count(parameter)=0]"
			[Register ("getTimeSinceLastCharge", "()I", "GetGetTimeSinceLastChargeHandler")]
			get {
				if (id_getTimeSinceLastCharge == IntPtr.Zero)
					id_getTimeSinceLastCharge = JNIEnv.GetMethodID (class_ref, "getTimeSinceLastCharge", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTimeSinceLastCharge);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeSinceLastCharge", "()I"));
			}
		}

	}
}
