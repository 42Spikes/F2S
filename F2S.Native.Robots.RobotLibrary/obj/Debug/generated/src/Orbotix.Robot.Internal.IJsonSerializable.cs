using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.internal']/interface[@name='JsonSerializable']"
	[Register ("orbotix/robot/internal/JsonSerializable", "", "Orbotix.Robot.Internal.IJsonSerializableInvoker")]
	public partial interface IJsonSerializable : IJavaObject {

		global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.internal']/interface[@name='JsonSerializable']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler:Orbotix.Robot.Internal.IJsonSerializableInvoker, F2S.Native.Robots.RobotLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("orbotix/robot/internal/JsonSerializable", DoNotGenerateAcw=true)]
	internal class IJsonSerializableInvoker : global::Java.Lang.Object, IJsonSerializable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/internal/JsonSerializable");
		IntPtr class_ref;

		public static IJsonSerializable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonSerializable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.internal.JsonSerializable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonSerializableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IJsonSerializableInvoker); }
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
			global::Orbotix.Robot.Internal.IJsonSerializable __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.IJsonSerializable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		IntPtr id_getJSON;
		public global::Org.Json.JSONObject JSON {
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
