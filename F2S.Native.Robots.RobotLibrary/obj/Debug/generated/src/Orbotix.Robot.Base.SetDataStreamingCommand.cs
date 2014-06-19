using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']"
	[global::Android.Runtime.Register ("orbotix/robot/base/SetDataStreamingCommand", DoNotGenerateAcw=true)]
	public partial class SetDataStreamingCommand : global::Orbotix.Robot.Internal.DeviceCommand, global::Orbotix.Robot.Internal.IRemotelyExecutable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/field[@name='DATA_STREAMING_MASK_ACCELEROMETER_FILTERED_ALL']"
		[Register ("DATA_STREAMING_MASK_ACCELEROMETER_FILTERED_ALL")]
		[Obsolete ("deprecated")]
		public const long DataStreamingMaskAccelerometerFilteredAll = (long) 57344L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/field[@name='DATA_STREAMING_MASK_IMU_ANGLES_FILTERED_ALL']"
		[Register ("DATA_STREAMING_MASK_IMU_ANGLES_FILTERED_ALL")]
		[Obsolete ("deprecated")]
		public const long DataStreamingMaskImuAnglesFilteredAll = (long) 458752L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/field[@name='DATA_STREAMING_MASK_LOCATOR_ALL']"
		[Register ("DATA_STREAMING_MASK_LOCATOR_ALL")]
		[Obsolete ("deprecated")]
		public const long DataStreamingMaskLocatorAll = (long) 972777519512027136L;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/field[@name='DATA_STREAMING_MASK_QUATERNIONS_ALL']"
		[Register ("DATA_STREAMING_MASK_QUATERNIONS_ALL")]
		[Obsolete ("deprecated")]
		public const long DataStreamingMaskQuaternionsAll = (long) -1152921504606846976L;
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']"
		[global::Android.Runtime.Register ("orbotix/robot/base/SetDataStreamingCommand$RobotDataStreamingProfile", DoNotGenerateAcw=true)]
		public partial class RobotDataStreamingProfile : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/robot/base/SetDataStreamingCommand$RobotDataStreamingProfile", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RobotDataStreamingProfile); }
			}

			protected RobotDataStreamingProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIJI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/constructor[@name='SetDataStreamingCommand.RobotDataStreamingProfile' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IIJI)V", "")]
			public RobotDataStreamingProfile (int p0, int p1, long p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (RobotDataStreamingProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIJI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIJI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_IIJI == IntPtr.Zero)
					id_ctor_IIJI = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIJI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_getDivisor;
#pragma warning disable 0169
			static Delegate GetGetDivisorHandler ()
			{
				if (cb_getDivisor == null)
					cb_getDivisor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDivisor);
				return cb_getDivisor;
			}

			static int n_GetDivisor (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Divisor;
			}
#pragma warning restore 0169

			static IntPtr id_getDivisor;
			public virtual int Divisor {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='getDivisor' and count(parameter)=0]"
				[Register ("getDivisor", "()I", "GetGetDivisorHandler")]
				get {
					if (id_getDivisor == IntPtr.Zero)
						id_getDivisor = JNIEnv.GetMethodID (class_ref, "getDivisor", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDivisor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDivisor", "()I"));
				}
			}

			static Delegate cb_isInfinite;
#pragma warning disable 0169
			static Delegate GetIsInfiniteHandler ()
			{
				if (cb_isInfinite == null)
					cb_isInfinite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInfinite);
				return cb_isInfinite;
			}

			static bool n_IsInfinite (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsInfinite;
			}
#pragma warning restore 0169

			static IntPtr id_isInfinite;
			public virtual bool IsInfinite {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='isInfinite' and count(parameter)=0]"
				[Register ("isInfinite", "()Z", "GetIsInfiniteHandler")]
				get {
					if (id_isInfinite == IntPtr.Zero)
						id_isInfinite = JNIEnv.GetMethodID (class_ref, "isInfinite", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInfinite);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInfinite", "()Z"));
				}
			}

			static Delegate cb_getPacketCommandCount;
#pragma warning disable 0169
			static Delegate GetGetPacketCommandCountHandler ()
			{
				if (cb_getPacketCommandCount == null)
					cb_getPacketCommandCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPacketCommandCount);
				return cb_getPacketCommandCount;
			}

			static int n_GetPacketCommandCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PacketCommandCount;
			}
#pragma warning restore 0169

			static IntPtr id_getPacketCommandCount;
			public virtual int PacketCommandCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='getPacketCommandCount' and count(parameter)=0]"
				[Register ("getPacketCommandCount", "()I", "GetGetPacketCommandCountHandler")]
				get {
					if (id_getPacketCommandCount == IntPtr.Zero)
						id_getPacketCommandCount = JNIEnv.GetMethodID (class_ref, "getPacketCommandCount", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPacketCommandCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacketCommandCount", "()I"));
				}
			}

			static Delegate cb_getPacketCount;
#pragma warning disable 0169
			static Delegate GetGetPacketCountHandler ()
			{
				if (cb_getPacketCount == null)
					cb_getPacketCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPacketCount);
				return cb_getPacketCount;
			}

			static int n_GetPacketCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PacketCount;
			}
#pragma warning restore 0169

			static IntPtr id_getPacketCount;
			public virtual int PacketCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='getPacketCount' and count(parameter)=0]"
				[Register ("getPacketCount", "()I", "GetGetPacketCountHandler")]
				get {
					if (id_getPacketCount == IntPtr.Zero)
						id_getPacketCount = JNIEnv.GetMethodID (class_ref, "getPacketCount", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPacketCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacketCount", "()I"));
				}
			}

			static Delegate cb_getPacketCounter;
#pragma warning disable 0169
			static Delegate GetGetPacketCounterHandler ()
			{
				if (cb_getPacketCounter == null)
					cb_getPacketCounter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPacketCounter);
				return cb_getPacketCounter;
			}

			static int n_GetPacketCounter (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PacketCounter;
			}
#pragma warning restore 0169

			static IntPtr id_getPacketCounter;
			public virtual int PacketCounter {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='getPacketCounter' and count(parameter)=0]"
				[Register ("getPacketCounter", "()I", "GetGetPacketCounterHandler")]
				get {
					if (id_getPacketCounter == IntPtr.Zero)
						id_getPacketCounter = JNIEnv.GetMethodID (class_ref, "getPacketCounter", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPacketCounter);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacketCounter", "()I"));
				}
			}

			static Delegate cb_getPacketFrames;
#pragma warning disable 0169
			static Delegate GetGetPacketFramesHandler ()
			{
				if (cb_getPacketFrames == null)
					cb_getPacketFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPacketFrames);
				return cb_getPacketFrames;
			}

			static int n_GetPacketFrames (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PacketFrames;
			}
#pragma warning restore 0169

			static IntPtr id_getPacketFrames;
			public virtual int PacketFrames {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='getPacketFrames' and count(parameter)=0]"
				[Register ("getPacketFrames", "()I", "GetGetPacketFramesHandler")]
				get {
					if (id_getPacketFrames == IntPtr.Zero)
						id_getPacketFrames = JNIEnv.GetMethodID (class_ref, "getPacketFrames", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPacketFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacketFrames", "()I"));
				}
			}

			static Delegate cb_getSensorMask;
#pragma warning disable 0169
			static Delegate GetGetSensorMaskHandler ()
			{
				if (cb_getSensorMask == null)
					cb_getSensorMask = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSensorMask);
				return cb_getSensorMask;
			}

			static long n_GetSensorMask (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SensorMask;
			}
#pragma warning restore 0169

			static IntPtr id_getSensorMask;
			public virtual long SensorMask {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='getSensorMask' and count(parameter)=0]"
				[Register ("getSensorMask", "()J", "GetGetSensorMaskHandler")]
				get {
					if (id_getSensorMask == IntPtr.Zero)
						id_getSensorMask = JNIEnv.GetMethodID (class_ref, "getSensorMask", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getSensorMask);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSensorMask", "()J"));
				}
			}

			static Delegate cb_resetPacketCounter;
#pragma warning disable 0169
			static Delegate GetResetPacketCounterHandler ()
			{
				if (cb_resetPacketCounter == null)
					cb_resetPacketCounter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetPacketCounter);
				return cb_resetPacketCounter;
			}

			static void n_ResetPacketCounter (IntPtr jnienv, IntPtr native__this)
			{
				global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand.RobotDataStreamingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ResetPacketCounter ();
			}
#pragma warning restore 0169

			static IntPtr id_resetPacketCounter;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand.RobotDataStreamingProfile']/method[@name='resetPacketCounter' and count(parameter)=0]"
			[Register ("resetPacketCounter", "()V", "GetResetPacketCounterHandler")]
			public virtual void ResetPacketCounter ()
			{
				if (id_resetPacketCounter == IntPtr.Zero)
					id_resetPacketCounter = JNIEnv.GetMethodID (class_ref, "resetPacketCounter", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resetPacketCounter);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetPacketCounter", "()V"));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/SetDataStreamingCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SetDataStreamingCommand); }
		}

		protected SetDataStreamingCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/constructor[@name='SetDataStreamingCommand' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public SetDataStreamingCommand (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SetDataStreamingCommand)) {
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

		static IntPtr id_ctor_IIJI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/constructor[@name='SetDataStreamingCommand' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIJI)V", "")]
		public SetDataStreamingCommand (int p0, int p1, long p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SetDataStreamingCommand)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIJI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIJI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_IIJI == IntPtr.Zero)
				id_ctor_IIJI = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIJI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_getJSON;
#pragma warning disable 0169
		static Delegate GetGetJSONHandler ()
		{
			if (cb_getJSON == null)
				cb_getJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSON);
			return cb_getJSON;
		}

		static IntPtr n_GetJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SetDataStreamingCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler")]
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSON", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMask;
#pragma warning disable 0169
		static Delegate GetGetMaskHandler ()
		{
			if (cb_getMask == null)
				cb_getMask = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMask);
			return cb_getMask;
		}

		static long n_GetMask (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.SetDataStreamingCommand __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.SetDataStreamingCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mask;
		}
#pragma warning restore 0169

		static IntPtr id_getMask;
		public virtual long Mask {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/method[@name='getMask' and count(parameter)=0]"
			[Register ("getMask", "()J", "GetGetMaskHandler")]
			get {
				if (id_getMask == IntPtr.Zero)
					id_getMask = JNIEnv.GetMethodID (class_ref, "getMask", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getMask);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMask", "()J"));
			}
		}

		static IntPtr id_sendCommand_Lorbotix_robot_base_Robot_IIJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='SetDataStreamingCommand']/method[@name='sendCommand' and count(parameter)=5 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='int']]"
		[Register ("sendCommand", "(Lorbotix/robot/base/Robot;IIJI)V", "")]
		public static void SendCommand (global::Orbotix.Robot.Base.Robot p0, int p1, int p2, long p3, int p4)
		{
			if (id_sendCommand_Lorbotix_robot_base_Robot_IIJI == IntPtr.Zero)
				id_sendCommand_Lorbotix_robot_base_Robot_IIJI = JNIEnv.GetStaticMethodID (class_ref, "sendCommand", "(Lorbotix/robot/base/Robot;IIJI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommand_Lorbotix_robot_base_Robot_IIJI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}
}
