using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']"
	[global::Android.Runtime.Register ("orbotix/robot/internal/DeviceMessageEncoder", DoNotGenerateAcw=true)]
	public partial class DeviceMessageEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/internal/DeviceMessageEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceMessageEncoder); }
		}

		protected DeviceMessageEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_internal_DeviceMessageSerializable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/constructor[@name='DeviceMessageEncoder' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessageSerializable']]"
		[Register (".ctor", "(Lorbotix/robot/internal/DeviceMessageSerializable;)V", "")]
		public DeviceMessageEncoder (global::Orbotix.Robot.Internal.IDeviceMessageSerializable p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceMessageEncoder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/internal/DeviceMessageSerializable;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/internal/DeviceMessageSerializable;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_internal_DeviceMessageSerializable_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_internal_DeviceMessageSerializable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/internal/DeviceMessageSerializable;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_internal_DeviceMessageSerializable_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_internal_DeviceMessageSerializable_, new JValue (p0));
		}

		static Delegate cb_getJson;
#pragma warning disable 0169
		static Delegate GetGetJsonHandler ()
		{
			if (cb_getJson == null)
				cb_getJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJson);
			return cb_getJson;
		}

		static IntPtr n_GetJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Json);
		}
#pragma warning restore 0169

		static IntPtr id_getJson;
		protected virtual global::Org.Json.JSONObject Json {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='getJson' and count(parameter)=0]"
			[Register ("getJson", "()Lorg/json/JSONObject;", "GetGetJsonHandler")]
			get {
				if (id_getJson == IntPtr.Zero)
					id_getJson = JNIEnv.GetMethodID (class_ref, "getJson", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJson), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJson", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_encodeMessage_Lorbotix_robot_internal_DeviceMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeMessage' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceMessage']]"
		[Register ("encodeMessage", "(Lorbotix/robot/internal/DeviceMessage;)Lorbotix/robot/internal/DeviceMessageEncoder;", "")]
		public static global::Orbotix.Robot.Internal.DeviceMessageEncoder EncodeMessage (global::Orbotix.Robot.Internal.DeviceMessage p0)
		{
			if (id_encodeMessage_Lorbotix_robot_internal_DeviceMessage_ == IntPtr.Zero)
				id_encodeMessage_Lorbotix_robot_internal_DeviceMessage_ = JNIEnv.GetStaticMethodID (class_ref, "encodeMessage", "(Lorbotix/robot/internal/DeviceMessage;)Lorbotix/robot/internal/DeviceMessageEncoder;");
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeMessage_Lorbotix_robot_internal_DeviceMessage_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_encodeUnsignedNumber_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetEncodeUnsignedNumber_Ljava_lang_String_IHandler ()
		{
			if (cb_encodeUnsignedNumber_Ljava_lang_String_I == null)
				cb_encodeUnsignedNumber_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_EncodeUnsignedNumber_Ljava_lang_String_I);
			return cb_encodeUnsignedNumber_Ljava_lang_String_I;
		}

		static void n_EncodeUnsignedNumber_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeUnsignedNumber (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeUnsignedNumber_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeUnsignedNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("encodeUnsignedNumber", "(Ljava/lang/String;I)V", "GetEncodeUnsignedNumber_Ljava_lang_String_IHandler")]
		public virtual void EncodeUnsignedNumber (string p0, int p1)
		{
			if (id_encodeUnsignedNumber_Ljava_lang_String_I == IntPtr.Zero)
				id_encodeUnsignedNumber_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "encodeUnsignedNumber", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeUnsignedNumber_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeUnsignedNumber", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeUnsignedNumber_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetEncodeUnsignedNumber_Ljava_lang_String_JHandler ()
		{
			if (cb_encodeUnsignedNumber_Ljava_lang_String_J == null)
				cb_encodeUnsignedNumber_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_EncodeUnsignedNumber_Ljava_lang_String_J);
			return cb_encodeUnsignedNumber_Ljava_lang_String_J;
		}

		static void n_EncodeUnsignedNumber_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeUnsignedNumber (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeUnsignedNumber_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeUnsignedNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("encodeUnsignedNumber", "(Ljava/lang/String;J)V", "GetEncodeUnsignedNumber_Ljava_lang_String_JHandler")]
		public virtual void EncodeUnsignedNumber (string p0, long p1)
		{
			if (id_encodeUnsignedNumber_Ljava_lang_String_J == IntPtr.Zero)
				id_encodeUnsignedNumber_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "encodeUnsignedNumber", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeUnsignedNumber_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeUnsignedNumber", "(Ljava/lang/String;J)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_ZHandler ()
		{
			if (cb_encodeValue_Ljava_lang_String_Z == null)
				cb_encodeValue_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_EncodeValue_Ljava_lang_String_Z);
			return cb_encodeValue_Ljava_lang_String_Z;
		}

		static void n_EncodeValue_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("encodeValue", "(Ljava/lang/String;Z)V", "GetEncodeValue_Ljava_lang_String_ZHandler")]
		public virtual void EncodeValue (string p0, bool p1)
		{
			if (id_encodeValue_Ljava_lang_String_Z == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_DHandler ()
		{
			if (cb_encodeValue_Ljava_lang_String_D == null)
				cb_encodeValue_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_EncodeValue_Ljava_lang_String_D);
			return cb_encodeValue_Ljava_lang_String_D;
		}

		static void n_EncodeValue_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("encodeValue", "(Ljava/lang/String;D)V", "GetEncodeValue_Ljava_lang_String_DHandler")]
		public virtual void EncodeValue (string p0, double p1)
		{
			if (id_encodeValue_Ljava_lang_String_D == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_IHandler ()
		{
			if (cb_encodeValue_Ljava_lang_String_I == null)
				cb_encodeValue_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_EncodeValue_Ljava_lang_String_I);
			return cb_encodeValue_Ljava_lang_String_I;
		}

		static void n_EncodeValue_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("encodeValue", "(Ljava/lang/String;I)V", "GetEncodeValue_Ljava_lang_String_IHandler")]
		public virtual void EncodeValue (string p0, int p1)
		{
			if (id_encodeValue_Ljava_lang_String_I == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_encodeValue_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_encodeValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeValue_Ljava_lang_String_Ljava_lang_String_);
			return cb_encodeValue_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EncodeValue_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeValue", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEncodeValue_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void EncodeValue (string p0, string p1)
		{
			if (id_encodeValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_Ljava_util_ArrayList_Handler ()
		{
			if (cb_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_ == null)
				cb_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeValue_Ljava_lang_String_Ljava_util_ArrayList_);
			return cb_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_;
		}

		static void n_EncodeValue_Ljava_lang_String_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Orbotix.Robot.Internal.IDeviceMessageSerializable> p1 = global::Android.Runtime.JavaList<global::Orbotix.Robot.Internal.IDeviceMessageSerializable>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList']]"
		[Register ("encodeValue", "(Ljava/lang/String;Ljava/util/ArrayList;)V", "GetEncodeValue_Ljava_lang_String_Ljava_util_ArrayList_Handler")]
		public virtual void EncodeValue (string p0, global::System.Collections.Generic.IList<global::Orbotix.Robot.Internal.IDeviceMessageSerializable> p1)
		{
			if (id_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Orbotix.Robot.Internal.IDeviceMessageSerializable>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_Ljava_util_ArrayList_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;Ljava/util/ArrayList;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_Ljava_util_Date_Handler ()
		{
			if (cb_encodeValue_Ljava_lang_String_Ljava_util_Date_ == null)
				cb_encodeValue_Ljava_lang_String_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeValue_Ljava_lang_String_Ljava_util_Date_);
			return cb_encodeValue_Ljava_lang_String_Ljava_util_Date_;
		}

		static void n_EncodeValue_Ljava_lang_String_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date']]"
		[Register ("encodeValue", "(Ljava/lang/String;Ljava/util/Date;)V", "GetEncodeValue_Ljava_lang_String_Ljava_util_Date_Handler")]
		public virtual void EncodeValue (string p0, global::Java.Util.Date p1)
		{
			if (id_encodeValue_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_Ljava_util_Date_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;Ljava/util/Date;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_JHandler ()
		{
			if (cb_encodeValue_Ljava_lang_String_J == null)
				cb_encodeValue_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_EncodeValue_Ljava_lang_String_J);
			return cb_encodeValue_Ljava_lang_String_J;
		}

		static void n_EncodeValue_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("encodeValue", "(Ljava/lang/String;J)V", "GetEncodeValue_Ljava_lang_String_JHandler")]
		public virtual void EncodeValue (string p0, long p1)
		{
			if (id_encodeValue_Ljava_lang_String_J == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;J)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_;
#pragma warning disable 0169
		static Delegate GetEncodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_Handler ()
		{
			if (cb_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_ == null)
				cb_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_);
			return cb_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_;
		}

		static void n_EncodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.Robot.Internal.DeviceMessageEncoder __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.DeviceMessageEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Internal.IDeviceMessageSerializable p1 = (global::Orbotix.Robot.Internal.IDeviceMessageSerializable)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.IDeviceMessageSerializable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EncodeValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/class[@name='DeviceMessageEncoder']/method[@name='encodeValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='orbotix.robot.internal.DeviceMessageSerializable']]"
		[Register ("encodeValue", "(Ljava/lang/String;Lorbotix/robot/internal/DeviceMessageSerializable;)V", "GetEncodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_Handler")]
		public virtual void EncodeValue (string p0, global::Orbotix.Robot.Internal.IDeviceMessageSerializable p1)
		{
			if (id_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_ == IntPtr.Zero)
				id_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_ = JNIEnv.GetMethodID (class_ref, "encodeValue", "(Ljava/lang/String;Lorbotix/robot/internal/DeviceMessageSerializable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encodeValue_Ljava_lang_String_Lorbotix_robot_internal_DeviceMessageSerializable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeValue", "(Ljava/lang/String;Lorbotix/robot/internal/DeviceMessageSerializable;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
