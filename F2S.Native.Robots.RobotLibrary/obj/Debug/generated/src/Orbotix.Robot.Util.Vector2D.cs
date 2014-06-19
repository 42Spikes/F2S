using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector2D']"
	[global::Android.Runtime.Register ("orbotix/robot/util/Vector2D", DoNotGenerateAcw=true)]
	public partial class Vector2D : global::Java.Lang.Object {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector2D']/field[@name='x']"
		[Register ("x")]
		public double X {
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

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector2D']/field[@name='y']"
		[Register ("y")]
		public double Y {
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/util/Vector2D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Vector2D); }
		}

		protected Vector2D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector2D']/constructor[@name='Vector2D' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public Vector2D (double p0, double p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Vector2D)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_magnitude;
#pragma warning disable 0169
		static Delegate GetMagnitudeHandler ()
		{
			if (cb_magnitude == null)
				cb_magnitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Magnitude);
			return cb_magnitude;
		}

		static double n_Magnitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Util.Vector2D __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Util.Vector2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Magnitude ();
		}
#pragma warning restore 0169

		static IntPtr id_magnitude;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector2D']/method[@name='magnitude' and count(parameter)=0]"
		[Register ("magnitude", "()D", "GetMagnitudeHandler")]
		public virtual double Magnitude ()
		{
			if (id_magnitude == IntPtr.Zero)
				id_magnitude = JNIEnv.GetMethodID (class_ref, "magnitude", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_magnitude);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "magnitude", "()D"));
		}

		static IntPtr id_magnitude_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.util']/class[@name='Vector2D']/method[@name='magnitude' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("magnitude", "(DD)D", "")]
		public static double Magnitude (double p0, double p1)
		{
			if (id_magnitude_DD == IntPtr.Zero)
				id_magnitude_DD = JNIEnv.GetStaticMethodID (class_ref, "magnitude", "(DD)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_magnitude_DD, new JValue (p0), new JValue (p1));
		}

	}
}
