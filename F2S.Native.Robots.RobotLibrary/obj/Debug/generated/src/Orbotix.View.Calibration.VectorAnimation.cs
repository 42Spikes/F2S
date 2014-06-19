using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/VectorAnimation", DoNotGenerateAcw=true)]
	public abstract partial class VectorAnimation : global::Java.Lang.Object {


		static IntPtr mCurrentFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mCurrentFrame']"
		[Register ("mCurrentFrame")]
		protected int MCurrentFrame {
			get {
				if (mCurrentFrame_jfieldId == IntPtr.Zero)
					mCurrentFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentFrame", "I");
				return JNIEnv.GetIntField (Handle, mCurrentFrame_jfieldId);
			}
			set {
				if (mCurrentFrame_jfieldId == IntPtr.Zero)
					mCurrentFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentFrame", "I");
				JNIEnv.SetField (Handle, mCurrentFrame_jfieldId, value);
			}
		}

		static IntPtr mDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mDuration']"
		[Register ("mDuration")]
		protected int MDuration {
			get {
				if (mDuration_jfieldId == IntPtr.Zero)
					mDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mDuration", "I");
				return JNIEnv.GetIntField (Handle, mDuration_jfieldId);
			}
			set {
				if (mDuration_jfieldId == IntPtr.Zero)
					mDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mDuration", "I");
				JNIEnv.SetField (Handle, mDuration_jfieldId, value);
			}
		}

		static IntPtr mEndTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mEndTime']"
		[Register ("mEndTime")]
		protected long MEndTime {
			get {
				if (mEndTime_jfieldId == IntPtr.Zero)
					mEndTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mEndTime", "J");
				return JNIEnv.GetLongField (Handle, mEndTime_jfieldId);
			}
			set {
				if (mEndTime_jfieldId == IntPtr.Zero)
					mEndTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mEndTime", "J");
				JNIEnv.SetField (Handle, mEndTime_jfieldId, value);
			}
		}

		static IntPtr mFrameDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mFrameDuration']"
		[Register ("mFrameDuration")]
		protected int MFrameDuration {
			get {
				if (mFrameDuration_jfieldId == IntPtr.Zero)
					mFrameDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameDuration", "I");
				return JNIEnv.GetIntField (Handle, mFrameDuration_jfieldId);
			}
			set {
				if (mFrameDuration_jfieldId == IntPtr.Zero)
					mFrameDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameDuration", "I");
				JNIEnv.SetField (Handle, mFrameDuration_jfieldId, value);
			}
		}

		static IntPtr mNextFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mNextFrame']"
		[Register ("mNextFrame")]
		protected long MNextFrame {
			get {
				if (mNextFrame_jfieldId == IntPtr.Zero)
					mNextFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mNextFrame", "J");
				return JNIEnv.GetLongField (Handle, mNextFrame_jfieldId);
			}
			set {
				if (mNextFrame_jfieldId == IntPtr.Zero)
					mNextFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mNextFrame", "J");
				JNIEnv.SetField (Handle, mNextFrame_jfieldId, value);
			}
		}

		static IntPtr mRepeats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mRepeats']"
		[Register ("mRepeats")]
		protected int MRepeats {
			get {
				if (mRepeats_jfieldId == IntPtr.Zero)
					mRepeats_jfieldId = JNIEnv.GetFieldID (class_ref, "mRepeats", "I");
				return JNIEnv.GetIntField (Handle, mRepeats_jfieldId);
			}
			set {
				if (mRepeats_jfieldId == IntPtr.Zero)
					mRepeats_jfieldId = JNIEnv.GetFieldID (class_ref, "mRepeats", "I");
				JNIEnv.SetField (Handle, mRepeats_jfieldId, value);
			}
		}

		static IntPtr mScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mScale']"
		[Register ("mScale")]
		protected float MScale {
			get {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				return JNIEnv.GetFloatField (Handle, mScale_jfieldId);
			}
			set {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				JNIEnv.SetField (Handle, mScale_jfieldId, value);
			}
		}

		static IntPtr mStartTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mStartTime']"
		[Register ("mStartTime")]
		protected long MStartTime {
			get {
				if (mStartTime_jfieldId == IntPtr.Zero)
					mStartTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mStartTime", "J");
				return JNIEnv.GetLongField (Handle, mStartTime_jfieldId);
			}
			set {
				if (mStartTime_jfieldId == IntPtr.Zero)
					mStartTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mStartTime", "J");
				JNIEnv.SetField (Handle, mStartTime_jfieldId, value);
			}
		}

		static IntPtr mTotalFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/field[@name='mTotalFrames']"
		[Register ("mTotalFrames")]
		protected int MTotalFrames {
			get {
				if (mTotalFrames_jfieldId == IntPtr.Zero)
					mTotalFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "mTotalFrames", "I");
				return JNIEnv.GetIntField (Handle, mTotalFrames_jfieldId);
			}
			set {
				if (mTotalFrames_jfieldId == IntPtr.Zero)
					mTotalFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "mTotalFrames", "I");
				JNIEnv.SetField (Handle, mTotalFrames_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/VectorAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VectorAnimation); }
		}

		protected VectorAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/constructor[@name='VectorAnimation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public VectorAnimation (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (VectorAnimation)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDuration);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
			}
		}

		static Delegate cb_getIsFullInvalidation;
#pragma warning disable 0169
		static Delegate GetGetIsFullInvalidationHandler ()
		{
			if (cb_getIsFullInvalidation == null)
				cb_getIsFullInvalidation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsFullInvalidation);
			return cb_getIsFullInvalidation;
		}

		static bool n_GetIsFullInvalidation (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FullInvalidation;
		}
#pragma warning restore 0169

		static Delegate cb_setFullInvalidation_Z;
#pragma warning disable 0169
		static Delegate GetSetFullInvalidation_ZHandler ()
		{
			if (cb_setFullInvalidation_Z == null)
				cb_setFullInvalidation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFullInvalidation_Z);
			return cb_setFullInvalidation_Z;
		}

		static void n_SetFullInvalidation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FullInvalidation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsFullInvalidation;
		static IntPtr id_setFullInvalidation_Z;
		public virtual bool FullInvalidation {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='getIsFullInvalidation' and count(parameter)=0]"
			[Register ("getIsFullInvalidation", "()Z", "GetGetIsFullInvalidationHandler")]
			get {
				if (id_getIsFullInvalidation == IntPtr.Zero)
					id_getIsFullInvalidation = JNIEnv.GetMethodID (class_ref, "getIsFullInvalidation", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getIsFullInvalidation);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsFullInvalidation", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='setFullInvalidation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFullInvalidation", "(Z)V", "GetSetFullInvalidation_ZHandler")]
			set {
				if (id_setFullInvalidation_Z == IntPtr.Zero)
					id_setFullInvalidation_Z = JNIEnv.GetMethodID (class_ref, "setFullInvalidation", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFullInvalidation_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullInvalidation", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getInterpolatedScale;
#pragma warning disable 0169
		static Delegate GetGetInterpolatedScaleHandler ()
		{
			if (cb_getInterpolatedScale == null)
				cb_getInterpolatedScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetInterpolatedScale);
			return cb_getInterpolatedScale;
		}

		static float n_GetInterpolatedScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InterpolatedScale;
		}
#pragma warning restore 0169

		static IntPtr id_getInterpolatedScale;
		protected virtual float InterpolatedScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='getInterpolatedScale' and count(parameter)=0]"
			[Register ("getInterpolatedScale", "()F", "GetGetInterpolatedScaleHandler")]
			get {
				if (id_getInterpolatedScale == IntPtr.Zero)
					id_getInterpolatedScale = JNIEnv.GetMethodID (class_ref, "getInterpolatedScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getInterpolatedScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterpolatedScale", "()F"));
			}
		}

		static Delegate cb_isEnded;
#pragma warning disable 0169
		static Delegate GetIsEndedHandler ()
		{
			if (cb_isEnded == null)
				cb_isEnded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnded);
			return cb_isEnded;
		}

		static bool n_IsEnded (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnded;
		}
#pragma warning restore 0169

		static IntPtr id_isEnded;
		public virtual bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler")]
			get {
				if (id_isEnded == IntPtr.Zero)
					id_isEnded = JNIEnv.GetMethodID (class_ref, "isEnded", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEnded);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnded", "()Z"));
			}
		}

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		static IntPtr id_isStarted;
		public virtual bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isStarted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStarted", "()Z"));
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		protected virtual float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
			}
		}

		static Delegate cb_getAdjustedScale_II;
#pragma warning disable 0169
		static Delegate GetGetAdjustedScale_IIHandler ()
		{
			if (cb_getAdjustedScale_II == null)
				cb_getAdjustedScale_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetAdjustedScale_II);
			return cb_getAdjustedScale_II;
		}

		static float n_GetAdjustedScale_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdjustedScale (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getAdjustedScale_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='getAdjustedScale' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getAdjustedScale", "(II)F", "GetGetAdjustedScale_IIHandler")]
		protected virtual float GetAdjustedScale (int p0, int p1)
		{
			if (id_getAdjustedScale_II == IntPtr.Zero)
				id_getAdjustedScale_II = JNIEnv.GetMethodID (class_ref, "getAdjustedScale", "(II)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_getAdjustedScale_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdjustedScale", "(II)F"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_initialize_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_ == null)
				cb_initialize_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Initialize_Landroid_content_Context_);
			return cb_initialize_Landroid_content_Context_;
		}

		static void n_Initialize_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "GetInitialize_Landroid_content_Context_Handler")]
		public virtual void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initialize_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Landroid/content/Context;)V"), new JValue (p0));
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
		}

		static Delegate cb_restart;
#pragma warning disable 0169
		static Delegate GetRestartHandler ()
		{
			if (cb_restart == null)
				cb_restart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Restart);
			return cb_restart;
		}

		static void n_Restart (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restart ();
		}
#pragma warning restore 0169

		static IntPtr id_restart;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='restart' and count(parameter)=0]"
		[Register ("restart", "()V", "GetRestartHandler")]
		public virtual void Restart ()
		{
			if (id_restart == IntPtr.Zero)
				id_restart = JNIEnv.GetMethodID (class_ref, "restart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_restart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restart", "()V"));
		}

		static Delegate cb_run_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRun_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_run_Landroid_graphics_Canvas_ == null)
				cb_run_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Run_Landroid_graphics_Canvas_);
			return cb_run_Landroid_graphics_Canvas_;
		}

		static IntPtr n_Run_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Run (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_run_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='run' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("run", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;", "GetRun_Landroid_graphics_Canvas_Handler")]
		public virtual global::Android.Graphics.Rect Run (global::Android.Graphics.Canvas p0)
		{
			if (id_run_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_run_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "run", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;");

			global::Android.Graphics.Rect __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_run_Landroid_graphics_Canvas_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_run_Landroid_graphics_Canvas_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRun_Landroid_graphics_Canvas_Landroid_view_View_Handler ()
		{
			if (cb_run_Landroid_graphics_Canvas_Landroid_view_View_ == null)
				cb_run_Landroid_graphics_Canvas_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Run_Landroid_graphics_Canvas_Landroid_view_View_);
			return cb_run_Landroid_graphics_Canvas_Landroid_view_View_;
		}

		static IntPtr n_Run_Landroid_graphics_Canvas_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Run (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_run_Landroid_graphics_Canvas_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='run' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.view.View']]"
		[Register ("run", "(Landroid/graphics/Canvas;Landroid/view/View;)Landroid/graphics/Rect;", "GetRun_Landroid_graphics_Canvas_Landroid_view_View_Handler")]
		public virtual global::Android.Graphics.Rect Run (global::Android.Graphics.Canvas p0, global::Android.Views.View p1)
		{
			if (id_run_Landroid_graphics_Canvas_Landroid_view_View_ == IntPtr.Zero)
				id_run_Landroid_graphics_Canvas_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "run", "(Landroid/graphics/Canvas;Landroid/view/View;)Landroid/graphics/Rect;");

			global::Android.Graphics.Rect __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_run_Landroid_graphics_Canvas_Landroid_view_View_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "(Landroid/graphics/Canvas;Landroid/view/View;)Landroid/graphics/Rect;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setEndCallback_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetEndCallback_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setEndCallback_Ljava_lang_Runnable_ == null)
				cb_setEndCallback_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndCallback_Ljava_lang_Runnable_);
			return cb_setEndCallback_Ljava_lang_Runnable_;
		}

		static void n_SetEndCallback_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEndCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEndCallback_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setEndCallback", "(Ljava/lang/Runnable;)V", "GetSetEndCallback_Ljava_lang_Runnable_Handler")]
		public virtual void SetEndCallback (global::Java.Lang.IRunnable p0)
		{
			if (id_setEndCallback_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setEndCallback_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setEndCallback", "(Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEndCallback_Ljava_lang_Runnable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndCallback", "(Ljava/lang/Runnable;)V"), new JValue (p0));
		}

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public virtual void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"), new JValue (p0));
		}

		static Delegate cb_setStartCallback_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetStartCallback_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setStartCallback_Ljava_lang_Runnable_ == null)
				cb_setStartCallback_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartCallback_Ljava_lang_Runnable_);
			return cb_setStartCallback_Ljava_lang_Runnable_;
		}

		static void n_SetStartCallback_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStartCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStartCallback_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='setStartCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setStartCallback", "(Ljava/lang/Runnable;)V", "GetSetStartCallback_Ljava_lang_Runnable_Handler")]
		public virtual void SetStartCallback (global::Java.Lang.IRunnable p0)
		{
			if (id_setStartCallback_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setStartCallback_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setStartCallback", "(Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStartCallback_Ljava_lang_Runnable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartCallback", "(Ljava/lang/Runnable;)V"), new JValue (p0));
		}

		static Delegate cb_showFrame_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetShowFrame_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_showFrame_Landroid_graphics_Canvas_ == null)
				cb_showFrame_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowFrame_Landroid_graphics_Canvas_);
			return cb_showFrame_Landroid_graphics_Canvas_;
		}

		static IntPtr n_ShowFrame_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowFrame (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='showFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("showFrame", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;", "GetShowFrame_Landroid_graphics_Canvas_Handler")]
		protected abstract global::Android.Graphics.Rect ShowFrame (global::Android.Graphics.Canvas p0);

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.VectorAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.VectorAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
		}

	}

	[global::Android.Runtime.Register ("orbotix/view/calibration/VectorAnimation", DoNotGenerateAcw=true)]
	internal partial class VectorAnimationInvoker : VectorAnimation {

		public VectorAnimationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (VectorAnimationInvoker); }
		}

		static IntPtr id_showFrame_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='VectorAnimation']/method[@name='showFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("showFrame", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;", "GetShowFrame_Landroid_graphics_Canvas_Handler")]
		protected override global::Android.Graphics.Rect ShowFrame (global::Android.Graphics.Canvas p0)
		{
			if (id_showFrame_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_showFrame_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "showFrame", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;");
			global::Android.Graphics.Rect __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_showFrame_Landroid_graphics_Canvas_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
