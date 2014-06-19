using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationButtonView", DoNotGenerateAcw=true)]
	public partial class CalibrationButtonView : global::Orbotix.View.Calibration.WidgetGraphicView, global::Orbotix.View.Calibration.IController {

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation", DoNotGenerateAcw=true)]
		public sealed partial class CalibrationCircleLocation : global::Java.Lang.Enum {


			static IntPtr ABOVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']/field[@name='ABOVE']"
			[Register ("ABOVE")]
			public static global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation Above {
				get {
					if (ABOVE_jfieldId == IntPtr.Zero)
						ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABOVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ABOVE_jfieldId == IntPtr.Zero)
						ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ABOVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BELOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']/field[@name='BELOW']"
			[Register ("BELOW")]
			public static global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation Below {
				get {
					if (BELOW_jfieldId == IntPtr.Zero)
						BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BELOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BELOW_jfieldId == IntPtr.Zero)
						BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BELOW_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation Left {
				get {
					if (LEFT_jfieldId == IntPtr.Zero)
						LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LEFT_jfieldId == IntPtr.Zero)
						LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LEFT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public static global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation Right {
				get {
					if (RIGHT_jfieldId == IntPtr.Zero)
						RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RIGHT_jfieldId == IntPtr.Zero)
						RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RIGHT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CalibrationCircleLocation); }
			}

			internal CalibrationCircleLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;", "")]
			public static global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation __ret = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.CalibrationCircleLocation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;", "")]
			public static global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;");
				return (global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.OutroAnimation']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationButtonView$OutroAnimation", DoNotGenerateAcw=true)]
		public partial class OutroAnimation : global::Orbotix.View.Calibration.VectorAnimation {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationButtonView$OutroAnimation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OutroAnimation); }
			}

			protected OutroAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_calibration_CalibrationButtonView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.OutroAnimation']/constructor[@name='CalibrationButtonView.OutroAnimation' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationButtonView']]"
			[Register (".ctor", "(Lorbotix/view/calibration/CalibrationButtonView;)V", "")]
			public OutroAnimation (global::Orbotix.View.Calibration.CalibrationButtonView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (OutroAnimation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorbotix_view_calibration_CalibrationButtonView_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_calibration_CalibrationButtonView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/calibration/CalibrationButtonView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_calibration_CalibrationButtonView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_calibration_CalibrationButtonView_, new JValue (__self));
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
				global::Orbotix.View.Calibration.CalibrationButtonView.OutroAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.OutroAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowFrame (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_showFrame_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.OutroAnimation']/method[@name='showFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
			[Register ("showFrame", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;", "GetShowFrame_Landroid_graphics_Canvas_Handler")]
			protected override global::Android.Graphics.Rect ShowFrame (global::Android.Graphics.Canvas p0)
			{
				if (id_showFrame_Landroid_graphics_Canvas_ == IntPtr.Zero)
					id_showFrame_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "showFrame", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;");

				global::Android.Graphics.Rect __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_showFrame_Landroid_graphics_Canvas_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showFrame", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.TouchGestureDetector']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationButtonView$TouchGestureDetector", DoNotGenerateAcw=true)]
		public partial class TouchGestureDetector : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationButtonView$TouchGestureDetector", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TouchGestureDetector); }
			}

			protected TouchGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_calibration_CalibrationButtonView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.TouchGestureDetector']/constructor[@name='CalibrationButtonView.TouchGestureDetector' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationButtonView']]"
			[Register (".ctor", "(Lorbotix/view/calibration/CalibrationButtonView;)V", "")]
			public TouchGestureDetector (global::Orbotix.View.Calibration.CalibrationButtonView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (TouchGestureDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorbotix_view_calibration_CalibrationButtonView_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_calibration_CalibrationButtonView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/calibration/CalibrationButtonView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_calibration_CalibrationButtonView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_calibration_CalibrationButtonView_, new JValue (__self));
			}

			static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
					cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
				return cb_onTouchEvent_Landroid_view_MotionEvent_;
			}

			static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Calibration.CalibrationButtonView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouchEvent (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.TouchGestureDetector']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
			public virtual bool OnTouchEvent (global::Android.Views.MotionEvent p0)
			{
				if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_startCalibration_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetStartCalibration_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_startCalibration_Landroid_view_MotionEvent_ == null)
					cb_startCalibration_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartCalibration_Landroid_view_MotionEvent_);
				return cb_startCalibration_Landroid_view_MotionEvent_;
			}

			static void n_StartCalibration_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Calibration.CalibrationButtonView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.StartCalibration (p0);
			}
#pragma warning restore 0169

			static IntPtr id_startCalibration_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView.TouchGestureDetector']/method[@name='startCalibration' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("startCalibration", "(Landroid/view/MotionEvent;)V", "GetStartCalibration_Landroid_view_MotionEvent_Handler")]
			public virtual void StartCalibration (global::Android.Views.MotionEvent p0)
			{
				if (id_startCalibration_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_startCalibration_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "startCalibration", "(Landroid/view/MotionEvent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startCalibration_Landroid_view_MotionEvent_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startCalibration", "(Landroid/view/MotionEvent;)V"), new JValue (p0));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationButtonView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalibrationButtonView); }
		}

		protected CalibrationButtonView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/constructor[@name='CalibrationButtonView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public CalibrationButtonView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CalibrationButtonView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/constructor[@name='CalibrationButtonView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public CalibrationButtonView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CalibrationButtonView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isCalibrating;
#pragma warning disable 0169
		static Delegate GetIsCalibratingHandler ()
		{
			if (cb_isCalibrating == null)
				cb_isCalibrating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCalibrating);
			return cb_isCalibrating;
		}

		static bool n_IsCalibrating (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCalibrating;
		}
#pragma warning restore 0169

		static IntPtr id_isCalibrating;
		public virtual bool IsCalibrating {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='isCalibrating' and count(parameter)=0]"
			[Register ("isCalibrating", "()Z", "GetIsCalibratingHandler")]
			get {
				if (id_isCalibrating == IntPtr.Zero)
					id_isCalibrating = JNIEnv.GetMethodID (class_ref, "isCalibrating", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isCalibrating);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCalibrating", "()Z"));
			}
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public virtual void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler")]
		public virtual void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "()V"));
		}

		static Delegate cb_interpretMotionEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetInterpretMotionEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_interpretMotionEvent_Landroid_view_MotionEvent_ == null)
				cb_interpretMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InterpretMotionEvent_Landroid_view_MotionEvent_);
			return cb_interpretMotionEvent_Landroid_view_MotionEvent_;
		}

		static void n_InterpretMotionEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InterpretMotionEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_interpretMotionEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='interpretMotionEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("interpretMotionEvent", "(Landroid/view/MotionEvent;)V", "GetInterpretMotionEvent_Landroid_view_MotionEvent_Handler")]
		public virtual void InterpretMotionEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_interpretMotionEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_interpretMotionEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "interpretMotionEvent", "(Landroid/view/MotionEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_interpretMotionEvent_Landroid_view_MotionEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "interpretMotionEvent", "(Landroid/view/MotionEvent;)V"), new JValue (p0));
		}

		static Delegate cb_onRotation_DLandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetOnRotation_DLandroid_graphics_Point_Handler ()
		{
			if (cb_onRotation_DLandroid_graphics_Point_ == null)
				cb_onRotation_DLandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_OnRotation_DLandroid_graphics_Point_);
			return cb_onRotation_DLandroid_graphics_Point_;
		}

		static void n_OnRotation_DLandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRotation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onRotation_DLandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='onRotation' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("onRotation", "(DLandroid/graphics/Point;)V", "GetOnRotation_DLandroid_graphics_Point_Handler")]
		protected virtual void OnRotation (double p0, global::Android.Graphics.Point p1)
		{
			if (id_onRotation_DLandroid_graphics_Point_ == IntPtr.Zero)
				id_onRotation_DLandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotation", "(DLandroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRotation_DLandroid_graphics_Point_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotation", "(DLandroid/graphics/Point;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onRotationEnded_DLandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetOnRotationEnded_DLandroid_graphics_Point_Handler ()
		{
			if (cb_onRotationEnded_DLandroid_graphics_Point_ == null)
				cb_onRotationEnded_DLandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_OnRotationEnded_DLandroid_graphics_Point_);
			return cb_onRotationEnded_DLandroid_graphics_Point_;
		}

		static void n_OnRotationEnded_DLandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRotationEnded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onRotationEnded_DLandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='onRotationEnded' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("onRotationEnded", "(DLandroid/graphics/Point;)V", "GetOnRotationEnded_DLandroid_graphics_Point_Handler")]
		protected virtual void OnRotationEnded (double p0, global::Android.Graphics.Point p1)
		{
			if (id_onRotationEnded_DLandroid_graphics_Point_ == IntPtr.Zero)
				id_onRotationEnded_DLandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationEnded", "(DLandroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRotationEnded_DLandroid_graphics_Point_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationEnded", "(DLandroid/graphics/Point;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onRotationStarted_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetOnRotationStarted_Landroid_graphics_Point_Handler ()
		{
			if (cb_onRotationStarted_Landroid_graphics_Point_ == null)
				cb_onRotationStarted_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRotationStarted_Landroid_graphics_Point_);
			return cb_onRotationStarted_Landroid_graphics_Point_;
		}

		static void n_OnRotationStarted_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRotationStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRotationStarted_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='onRotationStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("onRotationStarted", "(Landroid/graphics/Point;)V", "GetOnRotationStarted_Landroid_graphics_Point_Handler")]
		protected virtual void OnRotationStarted (global::Android.Graphics.Point p0)
		{
			if (id_onRotationStarted_Landroid_graphics_Point_ == IntPtr.Zero)
				id_onRotationStarted_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationStarted", "(Landroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRotationStarted_Landroid_graphics_Point_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationStarted", "(Landroid/graphics/Point;)V"), new JValue (p0));
		}

		static Delegate cb_setBackgroundColors_II;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColors_IIHandler ()
		{
			if (cb_setBackgroundColors_II == null)
				cb_setBackgroundColors_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetBackgroundColors_II);
			return cb_setBackgroundColors_II;
		}

		static void n_SetBackgroundColors_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundColors (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundColors_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setBackgroundColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBackgroundColors", "(II)V", "GetSetBackgroundColors_IIHandler")]
		public virtual void SetBackgroundColors (int p0, int p1)
		{
			if (id_setBackgroundColors_II == IntPtr.Zero)
				id_setBackgroundColors_II = JNIEnv.GetMethodID (class_ref, "setBackgroundColors", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBackgroundColors_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundColors", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setCalibrationButton_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCalibrationButton_Landroid_view_View_Handler ()
		{
			if (cb_setCalibrationButton_Landroid_view_View_ == null)
				cb_setCalibrationButton_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCalibrationButton_Landroid_view_View_);
			return cb_setCalibrationButton_Landroid_view_View_;
		}

		static void n_SetCalibrationButton_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCalibrationButton (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCalibrationButton_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setCalibrationButton' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setCalibrationButton", "(Landroid/view/View;)V", "GetSetCalibrationButton_Landroid_view_View_Handler")]
		public virtual void SetCalibrationButton (global::Android.Views.View p0)
		{
			if (id_setCalibrationButton_Landroid_view_View_ == IntPtr.Zero)
				id_setCalibrationButton_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCalibrationButton", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCalibrationButton_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalibrationButton", "(Landroid/view/View;)V"), new JValue (p0));
		}

		static Delegate cb_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_;
#pragma warning disable 0169
		static Delegate GetSetCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_Handler ()
		{
			if (cb_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_ == null)
				cb_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_);
			return cb_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_;
		}

		static void n_SetCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation p0 = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCalibrationCircleLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setCalibrationCircleLocation' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationButtonView.CalibrationCircleLocation']]"
		[Register ("setCalibrationCircleLocation", "(Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;)V", "GetSetCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_Handler")]
		public virtual void SetCalibrationCircleLocation (global::Orbotix.View.Calibration.CalibrationButtonView.CalibrationCircleLocation p0)
		{
			if (id_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_ == IntPtr.Zero)
				id_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_ = JNIEnv.GetMethodID (class_ref, "setCalibrationCircleLocation", "(Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCalibrationCircleLocation_Lorbotix_view_calibration_CalibrationButtonView_CalibrationCircleLocation_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalibrationCircleLocation", "(Lorbotix/view/calibration/CalibrationButtonView$CalibrationCircleLocation;)V"), new JValue (p0));
		}

		static Delegate cb_setCircleColor_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetCircleColor_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_setCircleColor_arrayLjava_lang_Integer_ == null)
				cb_setCircleColor_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleColor_arrayLjava_lang_Integer_);
			return cb_setCircleColor_arrayLjava_lang_Integer_;
		}

		static void n_SetCircleColor_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetCircleColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCircleColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setCircleColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
		[Register ("setCircleColor", "([Ljava/lang/Integer;)V", "GetSetCircleColor_arrayLjava_lang_Integer_Handler")]
		public virtual void SetCircleColor (params global:: Java.Lang.Integer[] p0)
		{
			if (id_setCircleColor_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_setCircleColor_arrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setCircleColor", "([Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCircleColor_arrayLjava_lang_Integer_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCircleColor", "([Ljava/lang/Integer;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setColor_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetColor_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_setColor_arrayLjava_lang_Integer_ == null)
				cb_setColor_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColor_arrayLjava_lang_Integer_);
			return cb_setColor_arrayLjava_lang_Integer_;
		}

		static void n_SetColor_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
		[Register ("setColor", "([Ljava/lang/Integer;)V", "GetSetColor_arrayLjava_lang_Integer_Handler")]
		public virtual void SetColor (params global:: Java.Lang.Integer[] p0)
		{
			if (id_setColor_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_setColor_arrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setColor", "([Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setColor_arrayLjava_lang_Integer_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "([Ljava/lang/Integer;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDotColor_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetDotColor_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_setDotColor_arrayLjava_lang_Integer_ == null)
				cb_setDotColor_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDotColor_arrayLjava_lang_Integer_);
			return cb_setDotColor_arrayLjava_lang_Integer_;
		}

		static void n_SetDotColor_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetDotColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDotColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setDotColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
		[Register ("setDotColor", "([Ljava/lang/Integer;)V", "GetSetDotColor_arrayLjava_lang_Integer_Handler")]
		public virtual void SetDotColor (params global:: Java.Lang.Integer[] p0)
		{
			if (id_setDotColor_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_setDotColor_arrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setDotColor", "([Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDotColor_arrayLjava_lang_Integer_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDotColor", "([Ljava/lang/Integer;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDotSize_I;
#pragma warning disable 0169
		static Delegate GetSetDotSize_IHandler ()
		{
			if (cb_setDotSize_I == null)
				cb_setDotSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDotSize_I);
			return cb_setDotSize_I;
		}

		static void n_SetDotSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDotSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDotSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setDotSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDotSize", "(I)V", "GetSetDotSize_IHandler")]
		public virtual void SetDotSize (int p0)
		{
			if (id_setDotSize_I == IntPtr.Zero)
				id_setDotSize_I = JNIEnv.GetMethodID (class_ref, "setDotSize", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDotSize_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDotSize", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setOnEndRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetOnEndRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setOnEndRunnable_Ljava_lang_Runnable_ == null)
				cb_setOnEndRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnEndRunnable_Ljava_lang_Runnable_);
			return cb_setOnEndRunnable_Ljava_lang_Runnable_;
		}

		static void n_SetOnEndRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnEndRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnEndRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setOnEndRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnEndRunnable", "(Ljava/lang/Runnable;)V", "GetSetOnEndRunnable_Ljava_lang_Runnable_Handler")]
		public virtual void SetOnEndRunnable (global::Java.Lang.IRunnable p0)
		{
			if (id_setOnEndRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setOnEndRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setOnEndRunnable", "(Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnEndRunnable_Ljava_lang_Runnable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnEndRunnable", "(Ljava/lang/Runnable;)V"), new JValue (p0));
		}

		static Delegate cb_setOnRotationRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetOnRotationRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setOnRotationRunnable_Ljava_lang_Runnable_ == null)
				cb_setOnRotationRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnRotationRunnable_Ljava_lang_Runnable_);
			return cb_setOnRotationRunnable_Ljava_lang_Runnable_;
		}

		static void n_SetOnRotationRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRotationRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRotationRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setOnRotationRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnRotationRunnable", "(Ljava/lang/Runnable;)V", "GetSetOnRotationRunnable_Ljava_lang_Runnable_Handler")]
		public virtual void SetOnRotationRunnable (global::Java.Lang.IRunnable p0)
		{
			if (id_setOnRotationRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setOnRotationRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setOnRotationRunnable", "(Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnRotationRunnable_Ljava_lang_Runnable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRotationRunnable", "(Ljava/lang/Runnable;)V"), new JValue (p0));
		}

		static Delegate cb_setOnStartRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetOnStartRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setOnStartRunnable_Ljava_lang_Runnable_ == null)
				cb_setOnStartRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnStartRunnable_Ljava_lang_Runnable_);
			return cb_setOnStartRunnable_Ljava_lang_Runnable_;
		}

		static void n_SetOnStartRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnStartRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnStartRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setOnStartRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnStartRunnable", "(Ljava/lang/Runnable;)V", "GetSetOnStartRunnable_Ljava_lang_Runnable_Handler")]
		public virtual void SetOnStartRunnable (global::Java.Lang.IRunnable p0)
		{
			if (id_setOnStartRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setOnStartRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setOnStartRunnable", "(Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnStartRunnable_Ljava_lang_Runnable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnStartRunnable", "(Ljava/lang/Runnable;)V"), new JValue (p0));
		}

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRadius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
		public virtual void SetRadius (int p0)
		{
			if (id_setRadius_I == IntPtr.Zero)
				id_setRadius_I = JNIEnv.GetMethodID (class_ref, "setRadius", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRadius_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRadius", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setRobot_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
		static Delegate GetSetRobot_Lorbotix_robot_base_Robot_Handler ()
		{
			if (cb_setRobot_Lorbotix_robot_base_Robot_ == null)
				cb_setRobot_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRobot_Lorbotix_robot_base_Robot_);
			return cb_setRobot_Lorbotix_robot_base_Robot_;
		}

		static void n_SetRobot_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRobot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRobot_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setRobot' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register ("setRobot", "(Lorbotix/robot/base/Robot;)V", "GetSetRobot_Lorbotix_robot_base_Robot_Handler")]
		public virtual void SetRobot (global::Orbotix.Robot.Base.Robot p0)
		{
			if (id_setRobot_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_setRobot_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "setRobot", "(Lorbotix/robot/base/Robot;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRobot_Lorbotix_robot_base_Robot_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRobot", "(Lorbotix/robot/base/Robot;)V"), new JValue (p0));
		}

		static Delegate cb_setShowGlow_Z;
#pragma warning disable 0169
		static Delegate GetSetShowGlow_ZHandler ()
		{
			if (cb_setShowGlow_Z == null)
				cb_setShowGlow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowGlow_Z);
			return cb_setShowGlow_Z;
		}

		static void n_SetShowGlow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Calibration.CalibrationButtonView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationButtonView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowGlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowGlow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationButtonView']/method[@name='setShowGlow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowGlow", "(Z)V", "GetSetShowGlow_ZHandler")]
		public virtual void SetShowGlow (bool p0)
		{
			if (id_setShowGlow_Z == IntPtr.Zero)
				id_setShowGlow_Z = JNIEnv.GetMethodID (class_ref, "setShowGlow", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShowGlow_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowGlow", "(Z)V"), new JValue (p0));
		}

	}
}
