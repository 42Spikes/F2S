using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.sphero']/interface[@name='CollisionListener']"
	[Register ("orbotix/sphero/CollisionListener", "", "Orbotix.Sphero.ICollisionListenerInvoker")]
	public partial interface ICollisionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/interface[@name='CollisionListener']/method[@name='collisionDetected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.CollisionDetectedAsyncData']]"
		[Register ("collisionDetected", "(Lorbotix/robot/base/CollisionDetectedAsyncData;)V", "GetCollisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_Handler:Orbotix.Sphero.ICollisionListenerInvoker, F2S.Native.Robots.RobotLibrary")]
		void CollisionDetected (global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0);

	}

	[global::Android.Runtime.Register ("orbotix/sphero/CollisionListener", DoNotGenerateAcw=true)]
	internal class ICollisionListenerInvoker : global::Java.Lang.Object, ICollisionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/sphero/CollisionListener");
		IntPtr class_ref;

		public static ICollisionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollisionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "orbotix.sphero.CollisionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollisionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICollisionListenerInvoker); }
		}

		static Delegate cb_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_;
#pragma warning disable 0169
		static Delegate GetCollisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_Handler ()
		{
			if (cb_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ == null)
				cb_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CollisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_);
			return cb_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_;
		}

		static void n_CollisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.ICollisionListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ICollisionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.CollisionDetectedAsyncData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CollisionDetected (p0);
		}
#pragma warning restore 0169

		IntPtr id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_;
		public void CollisionDetected (global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0)
		{
			if (id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ == IntPtr.Zero)
				id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ = JNIEnv.GetMethodID (class_ref, "collisionDetected", "(Lorbotix/robot/base/CollisionDetectedAsyncData;)V");
			JNIEnv.CallVoidMethod (Handle, id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_, new JValue (p0));
		}

	}

	public partial class CollisionEventArgs : global::System.EventArgs {

		public CollisionEventArgs (global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0)
		{
			this.p0 = p0;
		}

		global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0;
		public global::Orbotix.Robot.Base.CollisionDetectedAsyncData P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/orbotix/sphero/CollisionListenerImplementor")]
	internal sealed class ICollisionListenerImplementor : global::Java.Lang.Object, ICollisionListener {

		object sender;

		public ICollisionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/sphero/CollisionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CollisionEventArgs> Handler;
#pragma warning restore 0649

		public void CollisionDetected (global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CollisionEventArgs (p0));
		}

		internal static bool __IsEmpty (ICollisionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
