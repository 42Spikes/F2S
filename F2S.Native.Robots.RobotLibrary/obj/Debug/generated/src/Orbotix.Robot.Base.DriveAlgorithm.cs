using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']"
	[global::Android.Runtime.Register ("orbotix/robot/base/DriveAlgorithm", DoNotGenerateAcw=true)]
	public abstract partial class DriveAlgorithm : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='MAX_COORDINATES']"
		[Register ("MAX_COORDINATES")]
		public const int MaxCoordinates = (int) 3;

		static IntPtr adjustedHeading_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='adjustedHeading']"
		[Register ("adjustedHeading")]
		public double AdjustedHeading {
			get {
				if (adjustedHeading_jfieldId == IntPtr.Zero)
					adjustedHeading_jfieldId = JNIEnv.GetFieldID (class_ref, "adjustedHeading", "D");
				return JNIEnv.GetDoubleField (Handle, adjustedHeading_jfieldId);
			}
			set {
				if (adjustedHeading_jfieldId == IntPtr.Zero)
					adjustedHeading_jfieldId = JNIEnv.GetFieldID (class_ref, "adjustedHeading", "D");
				JNIEnv.SetField (Handle, adjustedHeading_jfieldId, value);
			}
		}

		static IntPtr convertListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='convertListener']"
		[Register ("convertListener")]
		protected global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener ConvertListener {
			get {
				if (convertListener_jfieldId == IntPtr.Zero)
					convertListener_jfieldId = JNIEnv.GetFieldID (class_ref, "convertListener", "Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, convertListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (convertListener_jfieldId == IntPtr.Zero)
					convertListener_jfieldId = JNIEnv.GetFieldID (class_ref, "convertListener", "Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, convertListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr deadZoneDelta_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='deadZoneDelta']"
		[Register ("deadZoneDelta")]
		public IList<double> DeadZoneDelta {
			get {
				if (deadZoneDelta_jfieldId == IntPtr.Zero)
					deadZoneDelta_jfieldId = JNIEnv.GetFieldID (class_ref, "deadZoneDelta", "[D");
				return JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (Handle, deadZoneDelta_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (deadZoneDelta_jfieldId == IntPtr.Zero)
					deadZoneDelta_jfieldId = JNIEnv.GetFieldID (class_ref, "deadZoneDelta", "[D");
				IntPtr native_value = JavaArray<double>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, deadZoneDelta_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr heading_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='heading']"
		[Register ("heading")]
		public double Heading {
			get {
				if (heading_jfieldId == IntPtr.Zero)
					heading_jfieldId = JNIEnv.GetFieldID (class_ref, "heading", "D");
				return JNIEnv.GetDoubleField (Handle, heading_jfieldId);
			}
			set {
				if (heading_jfieldId == IntPtr.Zero)
					heading_jfieldId = JNIEnv.GetFieldID (class_ref, "heading", "D");
				JNIEnv.SetField (Handle, heading_jfieldId, value);
			}
		}

		static IntPtr headingOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='headingOffset']"
		[Register ("headingOffset")]
		public double HeadingOffset {
			get {
				if (headingOffset_jfieldId == IntPtr.Zero)
					headingOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "headingOffset", "D");
				return JNIEnv.GetDoubleField (Handle, headingOffset_jfieldId);
			}
			set {
				if (headingOffset_jfieldId == IntPtr.Zero)
					headingOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "headingOffset", "D");
				JNIEnv.SetField (Handle, headingOffset_jfieldId, value);
			}
		}

		static IntPtr speed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='speed']"
		[Register ("speed")]
		public double Speed {
			get {
				if (speed_jfieldId == IntPtr.Zero)
					speed_jfieldId = JNIEnv.GetFieldID (class_ref, "speed", "D");
				return JNIEnv.GetDoubleField (Handle, speed_jfieldId);
			}
			set {
				if (speed_jfieldId == IntPtr.Zero)
					speed_jfieldId = JNIEnv.GetFieldID (class_ref, "speed", "D");
				JNIEnv.SetField (Handle, speed_jfieldId, value);
			}
		}

		static IntPtr speedScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='speedScale']"
		[Register ("speedScale")]
		public double SpeedScale {
			get {
				if (speedScale_jfieldId == IntPtr.Zero)
					speedScale_jfieldId = JNIEnv.GetFieldID (class_ref, "speedScale", "D");
				return JNIEnv.GetDoubleField (Handle, speedScale_jfieldId);
			}
			set {
				if (speedScale_jfieldId == IntPtr.Zero)
					speedScale_jfieldId = JNIEnv.GetFieldID (class_ref, "speedScale", "D");
				JNIEnv.SetField (Handle, speedScale_jfieldId, value);
			}
		}

		static IntPtr stopPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/field[@name='stopPosition']"
		[Register ("stopPosition")]
		public IList<double> StopPosition {
			get {
				if (stopPosition_jfieldId == IntPtr.Zero)
					stopPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "stopPosition", "[D");
				return JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (Handle, stopPosition_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (stopPosition_jfieldId == IntPtr.Zero)
					stopPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "stopPosition", "[D");
				IntPtr native_value = JavaArray<double>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, stopPosition_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DriveAlgorithm.OnConvertListener']"
		[Register ("orbotix/robot/base/DriveAlgorithm$OnConvertListener", "", "Orbotix.Robot.Base.DriveAlgorithm/IOnConvertListenerInvoker")]
		public partial interface IOnConvertListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='DriveAlgorithm.OnConvertListener']/method[@name='onConvert' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
			[Register ("onConvert", "(DDD)V", "GetOnConvert_DDDHandler:Orbotix.Robot.Base.DriveAlgorithm/IOnConvertListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnConvert (double p0, double p1, double p2);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/DriveAlgorithm$OnConvertListener", DoNotGenerateAcw=true)]
		internal class IOnConvertListenerInvoker : global::Java.Lang.Object, IOnConvertListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/DriveAlgorithm$OnConvertListener");
			IntPtr class_ref;

			public static IOnConvertListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnConvertListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.DriveAlgorithm.OnConvertListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnConvertListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnConvertListenerInvoker); }
			}

			static Delegate cb_onConvert_DDD;
#pragma warning disable 0169
			static Delegate GetOnConvert_DDDHandler ()
			{
				if (cb_onConvert_DDD == null)
					cb_onConvert_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double>) n_OnConvert_DDD);
				return cb_onConvert_DDD;
			}

			static void n_OnConvert_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
			{
				global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConvert (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onConvert_DDD;
			public void OnConvert (double p0, double p1, double p2)
			{
				if (id_onConvert_DDD == IntPtr.Zero)
					id_onConvert_DDD = JNIEnv.GetMethodID (class_ref, "onConvert", "(DDD)V");
				JNIEnv.CallVoidMethod (Handle, id_onConvert_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}

		public partial class ConvertEventArgs : global::System.EventArgs {

			public ConvertEventArgs (double p0, double p1, double p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			double p0;
			public double P0 {
				get { return p0; }
			}

			double p1;
			public double P1 {
				get { return p1; }
			}

			double p2;
			public double P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/DriveAlgorithm_OnConvertListenerImplementor")]
		internal sealed class IOnConvertListenerImplementor : global::Java.Lang.Object, IOnConvertListener {

			object sender;

			public IOnConvertListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/DriveAlgorithm_OnConvertListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ConvertEventArgs> Handler;
#pragma warning restore 0649

			public void OnConvert (double p0, double p1, double p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ConvertEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnConvertListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/DriveAlgorithm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DriveAlgorithm); }
		}

		protected DriveAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/constructor[@name='DriveAlgorithm' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DriveAlgorithm () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DriveAlgorithm)) {
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

		static Delegate cb_adjustHeading;
#pragma warning disable 0169
		static Delegate GetAdjustHeadingHandler ()
		{
			if (cb_adjustHeading == null)
				cb_adjustHeading = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdjustHeading);
			return cb_adjustHeading;
		}

		static void n_AdjustHeading (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveAlgorithm __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustHeading ();
		}
#pragma warning restore 0169

		static IntPtr id_adjustHeading;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/method[@name='adjustHeading' and count(parameter)=0]"
		[Register ("adjustHeading", "()V", "GetAdjustHeadingHandler")]
		protected virtual void AdjustHeading ()
		{
			if (id_adjustHeading == IntPtr.Zero)
				id_adjustHeading = JNIEnv.GetMethodID (class_ref, "adjustHeading", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adjustHeading);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustHeading", "()V"));
		}

		static Delegate cb_convert_DDD;
#pragma warning disable 0169
		static Delegate GetConvert_DDDHandler ()
		{
			if (cb_convert_DDD == null)
				cb_convert_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double>) n_Convert_DDD);
			return cb_convert_DDD;
		}

		static void n_Convert_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
		{
			global::Orbotix.Robot.Base.DriveAlgorithm __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Convert (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/method[@name='convert' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("convert", "(DDD)V", "GetConvert_DDDHandler")]
		public abstract void Convert (double p0, double p1, double p2);

		static Delegate cb_postOnConvert;
#pragma warning disable 0169
		static Delegate GetPostOnConvertHandler ()
		{
			if (cb_postOnConvert == null)
				cb_postOnConvert = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostOnConvert);
			return cb_postOnConvert;
		}

		static void n_PostOnConvert (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.DriveAlgorithm __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostOnConvert ();
		}
#pragma warning restore 0169

		static IntPtr id_postOnConvert;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/method[@name='postOnConvert' and count(parameter)=0]"
		[Register ("postOnConvert", "()V", "GetPostOnConvertHandler")]
		protected virtual void PostOnConvert ()
		{
			if (id_postOnConvert == IntPtr.Zero)
				id_postOnConvert = JNIEnv.GetMethodID (class_ref, "postOnConvert", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postOnConvert);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postOnConvert", "()V"));
		}

		static Delegate cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_;
#pragma warning disable 0169
		static Delegate GetSetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_Handler ()
		{
			if (cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ == null)
				cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_);
			return cb_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_;
		}

		static void n_SetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.DriveAlgorithm __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener p0 = (global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnConvertListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/method[@name='setOnConvertListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.DriveAlgorithm.OnConvertListener']]"
		[Register ("setOnConvertListener", "(Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;)V", "GetSetOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_Handler")]
		public virtual void SetOnConvertListener (global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener p0)
		{
			if (id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ == IntPtr.Zero)
				id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_ = JNIEnv.GetMethodID (class_ref, "setOnConvertListener", "(Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnConvertListener_Lorbotix_robot_base_DriveAlgorithm_OnConvertListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnConvertListener", "(Lorbotix/robot/base/DriveAlgorithm$OnConvertListener;)V"), new JValue (p0));
		}

#region "Event implementation for Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener"
		public event EventHandler<global::Orbotix.Robot.Base.DriveAlgorithm.ConvertEventArgs> ConvertEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener, global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor>(
						ref weak_implementor_SetOnConvertListener,
						__CreateIOnConvertListenerImplementor,
						SetOnConvertListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListener, global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor>(
						ref weak_implementor_SetOnConvertListener,
						global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor.__IsEmpty,
						__v => SetOnConvertListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnConvertListener;

		global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor __CreateIOnConvertListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.DriveAlgorithm.IOnConvertListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("orbotix/robot/base/DriveAlgorithm", DoNotGenerateAcw=true)]
	internal partial class DriveAlgorithmInvoker : DriveAlgorithm {

		public DriveAlgorithmInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DriveAlgorithmInvoker); }
		}

		static IntPtr id_convert_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='DriveAlgorithm']/method[@name='convert' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("convert", "(DDD)V", "GetConvert_DDDHandler")]
		public override void Convert (double p0, double p1, double p2)
		{
			if (id_convert_DDD == IntPtr.Zero)
				id_convert_DDD = JNIEnv.GetMethodID (class_ref, "convert", "(DDD)V");
			JNIEnv.CallVoidMethod  (Handle, id_convert_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

}
