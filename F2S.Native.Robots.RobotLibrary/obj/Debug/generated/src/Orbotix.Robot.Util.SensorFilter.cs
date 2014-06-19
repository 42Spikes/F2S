using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']"
	[global::Android.Runtime.Register ("orbotix/robot/util/SensorFilter", DoNotGenerateAcw=true)]
	public partial class SensorFilter : global::Java.Lang.Object {


		static IntPtr adaptive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/field[@name='adaptive']"
		[Register ("adaptive")]
		protected bool Adaptive {
			get {
				if (adaptive_jfieldId == IntPtr.Zero)
					adaptive_jfieldId = JNIEnv.GetFieldID (class_ref, "adaptive", "Z");
				return JNIEnv.GetBooleanField (Handle, adaptive_jfieldId);
			}
			set {
				if (adaptive_jfieldId == IntPtr.Zero)
					adaptive_jfieldId = JNIEnv.GetFieldID (class_ref, "adaptive", "Z");
				JNIEnv.SetField (Handle, adaptive_jfieldId, value);
			}
		}

		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/field[@name='x']"
		[Register ("x")]
		protected double X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "D");
				return JNIEnv.GetDoubleField (Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "D");
				JNIEnv.SetField (Handle, x_jfieldId, value);
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/field[@name='y']"
		[Register ("y")]
		protected double Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "D");
				return JNIEnv.GetDoubleField (Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "D");
				JNIEnv.SetField (Handle, y_jfieldId, value);
			}
		}

		static IntPtr z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/field[@name='z']"
		[Register ("z")]
		protected double Z {
			get {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "D");
				return JNIEnv.GetDoubleField (Handle, z_jfieldId);
			}
			set {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "D");
				JNIEnv.SetField (Handle, z_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/util/SensorFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SensorFilter); }
		}

		protected SensorFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/constructor[@name='SensorFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SensorFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SensorFilter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_addDatum_DDD;
#pragma warning disable 0169
		static Delegate GetAddDatum_DDDHandler ()
		{
			if (cb_addDatum_DDD == null)
				cb_addDatum_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double>) n_AddDatum_DDD);
			return cb_addDatum_DDD;
		}

		static void n_AddDatum_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
		{
			global::Orbotix.Robot.Util.SensorFilter __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Util.SensorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddDatum (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addDatum_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/method[@name='addDatum' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("addDatum", "(DDD)V", "GetAddDatum_DDDHandler")]
		public virtual void AddDatum (double p0, double p1, double p2)
		{
			if (id_addDatum_DDD == IntPtr.Zero)
				id_addDatum_DDD = JNIEnv.GetMethodID (class_ref, "addDatum", "(DDD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addDatum_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDatum", "(DDD)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Util.SensorFilter __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Util.SensorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[F", "GetGetValuesHandler")]
		public virtual float[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[F");

			if (GetType () == ThresholdType)
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (float));
			else
				return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetX);
			return cb_getX;
		}

		static double n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Util.SensorFilter __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Util.SensorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()D", "GetGetXHandler")]
		public virtual double GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getX);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()D"));
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetY);
			return cb_getY;
		}

		static double n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Util.SensorFilter __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Util.SensorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()D", "GetGetYHandler")]
		public virtual double GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getY);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()D"));
		}

		static Delegate cb_getZ;
#pragma warning disable 0169
		static Delegate GetGetZHandler ()
		{
			if (cb_getZ == null)
				cb_getZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetZ);
			return cb_getZ;
		}

		static double n_GetZ (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Util.SensorFilter __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Util.SensorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetZ ();
		}
#pragma warning restore 0169

		static IntPtr id_getZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='SensorFilter']/method[@name='getZ' and count(parameter)=0]"
		[Register ("getZ", "()D", "GetGetZHandler")]
		public virtual double GetZ ()
		{
			if (id_getZ == IntPtr.Zero)
				id_getZ = JNIEnv.GetMethodID (class_ref, "getZ", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getZ);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZ", "()D"));
		}

	}
}
