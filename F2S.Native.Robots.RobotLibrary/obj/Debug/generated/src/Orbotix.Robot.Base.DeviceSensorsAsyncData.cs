using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceSensorsAsyncData']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DeviceSensorsAsyncData", DoNotGenerateAcw=true)]
	public partial class DeviceSensorsAsyncData : global::Orbotix.Robot.Base.DeviceAsyncData {


		static IntPtr sMask_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceSensorsAsyncData']/field[@name='sMask']"
		[Register ("sMask")]
		public static long SMask {
			get {
				if (sMask_jfieldId == IntPtr.Zero)
					sMask_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sMask", "J");
				return JNIEnv.GetStaticLongField (class_ref, sMask_jfieldId);
			}
			set {
				if (sMask_jfieldId == IntPtr.Zero)
					sMask_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sMask", "J");
				JNIEnv.SetStaticField (class_ref, sMask_jfieldId, value);
			}
		}

		static IntPtr sPacketFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceSensorsAsyncData']/field[@name='sPacketFrames']"
		[Register ("sPacketFrames")]
		public static int SPacketFrames {
			get {
				if (sPacketFrames_jfieldId == IntPtr.Zero)
					sPacketFrames_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sPacketFrames", "I");
				return JNIEnv.GetStaticIntField (class_ref, sPacketFrames_jfieldId);
			}
			set {
				if (sPacketFrames_jfieldId == IntPtr.Zero)
					sPacketFrames_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sPacketFrames", "I");
				JNIEnv.SetStaticField (class_ref, sPacketFrames_jfieldId, value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DeviceSensorsAsyncData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceSensorsAsyncData); }
		}

		protected DeviceSensorsAsyncData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceSensorsAsyncData']/constructor[@name='DeviceSensorsAsyncData' and count(parameter)=2 and parameter[1][@type='orbotix.robot.base.Robot'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;[B)V", "")]
		public DeviceSensorsAsyncData (global::Orbotix.Robot.Base.Robot p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (DeviceSensorsAsyncData)) {
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

		static Delegate cb_getAsyncData;
#pragma warning disable 0169
		static Delegate GetGetAsyncDataHandler ()
		{
			if (cb_getAsyncData == null)
				cb_getAsyncData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsyncData);
			return cb_getAsyncData;
		}

		static IntPtr n_GetAsyncData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DeviceSensorsAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceSensorsAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Orbotix.Robot.Sensor.DeviceSensorsData>.ToLocalJniHandle (__this.AsyncData);
		}
#pragma warning restore 0169

		static IntPtr id_getAsyncData;
		public virtual global::System.Collections.Generic.IList<global::Orbotix.Robot.Sensor.DeviceSensorsData> AsyncData {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceSensorsAsyncData']/method[@name='getAsyncData' and count(parameter)=0]"
			[Register ("getAsyncData", "()Ljava/util/ArrayList;", "GetGetAsyncDataHandler")]
			get {
				if (id_getAsyncData == IntPtr.Zero)
					id_getAsyncData = JNIEnv.GetMethodID (class_ref, "getAsyncData", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Sensor.DeviceSensorsData>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAsyncData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Orbotix.Robot.Sensor.DeviceSensorsData>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsyncData", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRawData;
#pragma warning disable 0169
		static Delegate GetGetRawDataHandler ()
		{
			if (cb_getRawData == null)
				cb_getRawData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawData);
			return cb_getRawData;
		}

		static IntPtr n_GetRawData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DeviceSensorsAsyncData __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DeviceSensorsAsyncData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRawData ());
		}
#pragma warning restore 0169

		static IntPtr id_getRawData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DeviceSensorsAsyncData']/method[@name='getRawData' and count(parameter)=0]"
		[Register ("getRawData", "()[B", "GetGetRawDataHandler")]
		public virtual byte[] GetRawData ()
		{
			if (id_getRawData == IntPtr.Zero)
				id_getRawData = JNIEnv.GetMethodID (class_ref, "getRawData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRawData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}
}
