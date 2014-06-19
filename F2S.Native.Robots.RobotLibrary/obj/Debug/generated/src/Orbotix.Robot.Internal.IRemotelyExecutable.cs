using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.internal']/interface[@name='RemotelyExecutable']"
	[Register ("orbotix/robot/internal/RemotelyExecutable", "", "Orbotix.Robot.Internal.IRemotelyExecutableInvoker")]
	public partial interface IRemotelyExecutable : global::Orbotix.Robot.Internal.IJsonSerializable {

	}

	[global::Android.Runtime.Register ("orbotix/robot/internal/RemotelyExecutable", DoNotGenerateAcw=true)]
	internal class IRemotelyExecutableInvoker : global::Java.Lang.Object, IRemotelyExecutable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/internal/RemotelyExecutable");
		IntPtr class_ref;

		public static IRemotelyExecutable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemotelyExecutable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.internal.RemotelyExecutable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemotelyExecutableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRemotelyExecutableInvoker); }
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
			global::Orbotix.Robot.Internal.IRemotelyExecutable __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Internal.IRemotelyExecutable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
