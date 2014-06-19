using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']"
	[global::Android.Runtime.Register ("orbotix/robot/base/CollisionDetectedAsyncData", DoNotGenerateAcw=true)]
	public partial class CollisionDetectedAsyncData : global::Orbotix.Robot.Base.DeviceAsyncData {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/field[@name='CREATOR']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData.CollisionPower']"
		[global::Android.Runtime.Register ("orbotix/robot/base/CollisionDetectedAsyncData$CollisionPower", DoNotGenerateAcw=true)]
		public partial class CollisionPower : global::Java.Lang.Object {


			static IntPtr x_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData.CollisionPower']/field[@name='x']"
			[Register ("x")]
			public short X {
				get {
					if (x_jfieldId == IntPtr.Zero)
						x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "S");
					return JNIEnv.GetShortField (Handle, x_jfieldId);
				}
				set {
					if (x_jfieldId == IntPtr.Zero)
						x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "S");
					JNIEnv.SetField (Handle, x_jfieldId, value);
				}
			}

			static IntPtr y_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData.CollisionPower']/field[@name='y']"
			[Register ("y")]
			public short Y {
				get {
					if (y_jfieldId == IntPtr.Zero)
						y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "S");
					return JNIEnv.GetShortField (Handle, y_jfieldId);
				}
				set {
					if (y_jfieldId == IntPtr.Zero)
						y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "S");
					JNIEnv.SetField (Handle, y_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/robot/base/CollisionDetectedAsyncData$CollisionPower", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CollisionPower); }
			}

			protected CollisionPower (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_SS;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData.CollisionPower']/constructor[@name='CollisionDetectedAsyncData.CollisionPower' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
			[Register (".ctor", "(SS)V", "")]
			public CollisionPower (short p0, short p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CollisionPower)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(SS)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(SS)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_SS == IntPtr.Zero)
					id_ctor_SS = JNIEnv.GetMethodID (class_ref, "<init>", "(SS)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_SS, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_SS, new JValue (p0), new JValue (p1));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/CollisionDetectedAsyncData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CollisionDetectedAsyncData); }
		}

		protected CollisionDetectedAsyncData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/constructor[@name='CollisionDetectedAsyncData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;[B)V", "")]
		public CollisionDetectedAsyncData (global::Orbotix.Robot.Base.Robot p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (CollisionDetectedAsyncData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_arrayB == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/constructor[@name='CollisionDetectedAsyncData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected CollisionDetectedAsyncData (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CollisionDetectedAsyncData)) {
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

		static Delegate cb_hasImpactXAxis;
#pragma warning disable 0169
		static Delegate GetHasImpactXAxisHandler ()
		{
			if (cb_hasImpactXAxis == null)
				cb_hasImpactXAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasImpactXAxis);
			return cb_hasImpactXAxis;
		}

		static bool n_HasImpactXAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasImpactXAxis;
		}
#pragma warning restore 0169

		static IntPtr id_hasImpactXAxis;
		public virtual bool HasImpactXAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/method[@name='hasImpactXAxis' and count(parameter)=0]"
			[Register ("hasImpactXAxis", "()Z", "GetHasImpactXAxisHandler")]
			get {
				if (id_hasImpactXAxis == IntPtr.Zero)
					id_hasImpactXAxis = JNIEnv.GetMethodID (class_ref, "hasImpactXAxis", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasImpactXAxis);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasImpactXAxis", "()Z"));
			}
		}

		static Delegate cb_hasImpactYAxis;
#pragma warning disable 0169
		static Delegate GetHasImpactYAxisHandler ()
		{
			if (cb_hasImpactYAxis == null)
				cb_hasImpactYAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasImpactYAxis);
			return cb_hasImpactYAxis;
		}

		static bool n_HasImpactYAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasImpactYAxis;
		}
#pragma warning restore 0169

		static IntPtr id_hasImpactYAxis;
		public virtual bool HasImpactYAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/method[@name='hasImpactYAxis' and count(parameter)=0]"
			[Register ("hasImpactYAxis", "()Z", "GetHasImpactYAxisHandler")]
			get {
				if (id_hasImpactYAxis == IntPtr.Zero)
					id_hasImpactYAxis = JNIEnv.GetMethodID (class_ref, "hasImpactYAxis", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasImpactYAxis);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasImpactYAxis", "()Z"));
			}
		}

		static Delegate cb_getImpactAcceleration;
#pragma warning disable 0169
		static Delegate GetGetImpactAccelerationHandler ()
		{
			if (cb_getImpactAcceleration == null)
				cb_getImpactAcceleration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImpactAcceleration);
			return cb_getImpactAcceleration;
		}

		static IntPtr n_GetImpactAcceleration (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImpactAcceleration);
		}
#pragma warning restore 0169

		static IntPtr id_getImpactAcceleration;
		public virtual global::Orbotix.Robot.Sensor.Acceleration ImpactAcceleration {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/method[@name='getImpactAcceleration' and count(parameter)=0]"
			[Register ("getImpactAcceleration", "()Lorbotix/robot/sensor/Acceleration;", "GetGetImpactAccelerationHandler")]
			get {
				if (id_getImpactAcceleration == IntPtr.Zero)
					id_getImpactAcceleration = JNIEnv.GetMethodID (class_ref, "getImpactAcceleration", "()Lorbotix/robot/sensor/Acceleration;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.Acceleration> (JNIEnv.CallObjectMethod  (Handle, id_getImpactAcceleration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Sensor.Acceleration> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpactAcceleration", "()Lorbotix/robot/sensor/Acceleration;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImpactPower;
#pragma warning disable 0169
		static Delegate GetGetImpactPowerHandler ()
		{
			if (cb_getImpactPower == null)
				cb_getImpactPower = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImpactPower);
			return cb_getImpactPower;
		}

		static IntPtr n_GetImpactPower (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImpactPower);
		}
#pragma warning restore 0169

		static IntPtr id_getImpactPower;
		public virtual global::Orbotix.Robot.Base.CollisionDetectedAsyncData.CollisionPower ImpactPower {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/method[@name='getImpactPower' and count(parameter)=0]"
			[Register ("getImpactPower", "()Lorbotix/robot/base/CollisionDetectedAsyncData$CollisionPower;", "GetGetImpactPowerHandler")]
			get {
				if (id_getImpactPower == IntPtr.Zero)
					id_getImpactPower = JNIEnv.GetMethodID (class_ref, "getImpactPower", "()Lorbotix/robot/base/CollisionDetectedAsyncData$CollisionPower;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData.CollisionPower> (JNIEnv.CallObjectMethod  (Handle, id_getImpactPower), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData.CollisionPower> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpactPower", "()Lorbotix/robot/base/CollisionDetectedAsyncData$CollisionPower;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImpactSpeed;
#pragma warning disable 0169
		static Delegate GetGetImpactSpeedHandler ()
		{
			if (cb_getImpactSpeed == null)
				cb_getImpactSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetImpactSpeed);
			return cb_getImpactSpeed;
		}

		static float n_GetImpactSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImpactSpeed;
		}
#pragma warning restore 0169

		static IntPtr id_getImpactSpeed;
		public virtual float ImpactSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/method[@name='getImpactSpeed' and count(parameter)=0]"
			[Register ("getImpactSpeed", "()F", "GetGetImpactSpeedHandler")]
			get {
				if (id_getImpactSpeed == IntPtr.Zero)
					id_getImpactSpeed = JNIEnv.GetMethodID (class_ref, "getImpactSpeed", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getImpactSpeed);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpactSpeed", "()F"));
			}
		}

		static Delegate cb_getImpactTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetImpactTimeStampHandler ()
		{
			if (cb_getImpactTimeStamp == null)
				cb_getImpactTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetImpactTimeStamp);
			return cb_getImpactTimeStamp;
		}

		static long n_GetImpactTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImpactTimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getImpactTimeStamp;
		public virtual long ImpactTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='CollisionDetectedAsyncData']/method[@name='getImpactTimeStamp' and count(parameter)=0]"
			[Register ("getImpactTimeStamp", "()J", "GetGetImpactTimeStampHandler")]
			get {
				if (id_getImpactTimeStamp == IntPtr.Zero)
					id_getImpactTimeStamp = JNIEnv.GetMethodID (class_ref, "getImpactTimeStamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getImpactTimeStamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpactTimeStamp", "()J"));
			}
		}

	}
}
