using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']"
	[global::Android.Runtime.Register ("orbotix/robot/base/GetOptionFlagsResponse", DoNotGenerateAcw=true)]
	public partial class GetOptionFlagsResponse : global::Orbotix.Robot.Internal.DeviceResponse {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/field[@name='OPTION_FLAGS_DISABLE_SELF_LEVEL_IN_CHARGER']"
		[Register ("OPTION_FLAGS_DISABLE_SELF_LEVEL_IN_CHARGER")]
		public const long OptionFlagsDisableSelfLevelInCharger = (long) 4L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/field[@name='OPTION_FLAGS_ENABLE_MOTION_TIMOUT']"
		[Register ("OPTION_FLAGS_ENABLE_MOTION_TIMOUT")]
		public const long OptionFlagsEnableMotionTimout = (long) 16L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/field[@name='OPTION_FLAGS_ENABLE_VECTORE_DRIVE']"
		[Register ("OPTION_FLAGS_ENABLE_VECTORE_DRIVE")]
		public const long OptionFlagsEnableVectoreDrive = (long) 2L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/field[@name='OPTION_FLAGS_PREVENT_SLEEP_IN_CHARGER']"
		[Register ("OPTION_FLAGS_PREVENT_SLEEP_IN_CHARGER")]
		public const long OptionFlagsPreventSleepInCharger = (long) 1L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/field[@name='OPTION_FLAGS_TAIL_LIGHT_ALWAYS_ON']"
		[Register ("OPTION_FLAGS_TAIL_LIGHT_ALWAYS_ON")]
		public const long OptionFlagsTailLightAlwaysOn = (long) 8L;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/GetOptionFlagsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetOptionFlagsResponse); }
		}

		protected GetOptionFlagsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceCommand_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/constructor[@name='GetOptionFlagsResponse' and count(parameter)=2 and parameter[1][@type='orbotix.robot.internal.DeviceCommand'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceCommand;[B)V", "")]
		public GetOptionFlagsResponse (global::Orbotix.Robot.Internal.DeviceCommand p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (GetOptionFlagsResponse)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/constructor[@name='GetOptionFlagsResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected GetOptionFlagsResponse (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetOptionFlagsResponse)) {
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

		static Delegate cb_getOptionFlags;
#pragma warning disable 0169
		static Delegate GetGetOptionFlagsHandler ()
		{
			if (cb_getOptionFlags == null)
				cb_getOptionFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOptionFlags);
			return cb_getOptionFlags;
		}

		static long n_GetOptionFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.GetOptionFlagsResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetOptionFlagsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptionFlags;
		}
#pragma warning restore 0169

		static IntPtr id_getOptionFlags;
		public virtual long OptionFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/method[@name='getOptionFlags' and count(parameter)=0]"
			[Register ("getOptionFlags", "()J", "GetGetOptionFlagsHandler")]
			get {
				if (id_getOptionFlags == IntPtr.Zero)
					id_getOptionFlags = JNIEnv.GetMethodID (class_ref, "getOptionFlags", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getOptionFlags);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptionFlags", "()J"));
			}
		}

		static Delegate cb_isOptionFlagSet_J;
#pragma warning disable 0169
		static Delegate GetIsOptionFlagSet_JHandler ()
		{
			if (cb_isOptionFlagSet_J == null)
				cb_isOptionFlagSet_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsOptionFlagSet_J);
			return cb_isOptionFlagSet_J;
		}

		static bool n_IsOptionFlagSet_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Orbotix.Robot.Base.GetOptionFlagsResponse __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.GetOptionFlagsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOptionFlagSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isOptionFlagSet_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='GetOptionFlagsResponse']/method[@name='isOptionFlagSet' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isOptionFlagSet", "(J)Z", "GetIsOptionFlagSet_JHandler")]
		public virtual bool IsOptionFlagSet (long p0)
		{
			if (id_isOptionFlagSet_J == IntPtr.Zero)
				id_isOptionFlagSet_J = JNIEnv.GetMethodID (class_ref, "isOptionFlagSet", "(J)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isOptionFlagSet_J, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOptionFlagSet", "(J)Z"), new JValue (p0));
		}

	}
}
