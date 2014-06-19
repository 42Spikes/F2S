using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationView", DoNotGenerateAcw=true)]
	public partial class CalibrationView : global::Orbotix.View.Calibration.WidgetGraphicView, global::Orbotix.View.Calibration.IController {

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationView$CalibrationCircleLocation", DoNotGenerateAcw=true)]
		public sealed partial class CalibrationCircleLocation : global::Java.Lang.Enum {


			static IntPtr ABOVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/field[@name='ABOVE']"
			[Register ("ABOVE")]
			public static global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation Above {
				get {
					if (ABOVE_jfieldId == IntPtr.Zero)
						ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABOVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ABOVE_jfieldId == IntPtr.Zero)
						ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ABOVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BELOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/field[@name='BELOW']"
			[Register ("BELOW")]
			public static global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation Below {
				get {
					if (BELOW_jfieldId == IntPtr.Zero)
						BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BELOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BELOW_jfieldId == IntPtr.Zero)
						BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BELOW_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation Left {
				get {
					if (LEFT_jfieldId == IntPtr.Zero)
						LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LEFT_jfieldId == IntPtr.Zero)
						LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LEFT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public static global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation Right {
				get {
					if (RIGHT_jfieldId == IntPtr.Zero)
						RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RIGHT_jfieldId == IntPtr.Zero)
						RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RIGHT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationView$CalibrationCircleLocation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CalibrationCircleLocation); }
			}

			internal CalibrationCircleLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAngle;
			public float Angle {
				// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/method[@name='getAngle' and count(parameter)=0]"
				[Register ("getAngle", "()F", "GetGetAngleHandler")]
				get {
					if (id_getAngle == IntPtr.Zero)
						id_getAngle = JNIEnv.GetMethodID (class_ref, "getAngle", "()F");
					return JNIEnv.CallFloatMethod  (Handle, id_getAngle);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;", "")]
			public static global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation __ret = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.CalibrationCircleLocation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;", "")]
			public static global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;");
				return (global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.IntroAnimation']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationView$IntroAnimation", DoNotGenerateAcw=true)]
		public partial class IntroAnimation : global::Orbotix.View.Calibration.VectorAnimation {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationView$IntroAnimation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntroAnimation); }
			}

			protected IntroAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_calibration_CalibrationView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.IntroAnimation']/constructor[@name='CalibrationView.IntroAnimation' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationView']]"
			[Register (".ctor", "(Lorbotix/view/calibration/CalibrationView;)V", "")]
			public IntroAnimation (global::Orbotix.View.Calibration.CalibrationView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (IntroAnimation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorbotix_view_calibration_CalibrationView_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_calibration_CalibrationView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/calibration/CalibrationView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self));
			}

			static Delegate cb_initialize_I;
#pragma warning disable 0169
			static Delegate GetInitialize_IHandler ()
			{
				if (cb_initialize_I == null)
					cb_initialize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Initialize_I);
				return cb_initialize_I;
			}

			static void n_Initialize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Orbotix.View.Calibration.CalibrationView.IntroAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.IntroAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Initialize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_initialize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.IntroAnimation']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("initialize", "(I)V", "GetInitialize_IHandler")]
			public virtual void Initialize (int p0)
			{
				if (id_initialize_I == IntPtr.Zero)
					id_initialize_I = JNIEnv.GetMethodID (class_ref, "initialize", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initialize_I, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(I)V"), new JValue (p0));
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
				global::Orbotix.View.Calibration.CalibrationView.IntroAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.IntroAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowFrame (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_showFrame_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.IntroAnimation']/method[@name='showFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.OutroAnimation']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationView$OutroAnimation", DoNotGenerateAcw=true)]
		public partial class OutroAnimation : global::Orbotix.View.Calibration.VectorAnimation {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationView$OutroAnimation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OutroAnimation); }
			}

			protected OutroAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_calibration_CalibrationView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.OutroAnimation']/constructor[@name='CalibrationView.OutroAnimation' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationView']]"
			[Register (".ctor", "(Lorbotix/view/calibration/CalibrationView;)V", "")]
			public OutroAnimation (global::Orbotix.View.Calibration.CalibrationView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

				if (id_ctor_Lorbotix_view_calibration_CalibrationView_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_calibration_CalibrationView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/calibration/CalibrationView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self));
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
				global::Orbotix.View.Calibration.CalibrationView.OutroAnimation __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.OutroAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowFrame (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_showFrame_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.OutroAnimation']/method[@name='showFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.RotationGestureDetector']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationView$RotationGestureDetector", DoNotGenerateAcw=true)]
		public partial class RotationGestureDetector : global::Orbotix.View.Calibration.CalibrationGetureDetector {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationView$RotationGestureDetector", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RotationGestureDetector); }
			}

			protected RotationGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_calibration_CalibrationView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.RotationGestureDetector']/constructor[@name='CalibrationView.RotationGestureDetector' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationView']]"
			[Register (".ctor", "(Lorbotix/view/calibration/CalibrationView;)V", "")]
			public RotationGestureDetector (global::Orbotix.View.Calibration.CalibrationView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (RotationGestureDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorbotix_view_calibration_CalibrationView_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_calibration_CalibrationView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/calibration/CalibrationView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self));
			}

			static Delegate cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
			static Delegate GetOnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
			{
				if (cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
					cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_OnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_);
				return cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			}

			static void n_OnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRotation (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.RotationGestureDetector']/method[@name='onRotation' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='android.graphics.Point']]"
			[Register ("onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
			public virtual void OnRotation (double p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2, global::Android.Graphics.Point p3)
			{
				if (id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
			static Delegate GetOnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
			{
				if (cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
					cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_OnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_);
				return cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			}

			static void n_OnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRotationEnded (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.RotationGestureDetector']/method[@name='onRotationEnded' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='android.graphics.Point']]"
			[Register ("onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
			public virtual void OnRotationEnded (double p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2, global::Android.Graphics.Point p3)
			{
				if (id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
			static Delegate GetOnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
			{
				if (cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
					cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_);
				return cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			}

			static void n_OnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRotationStarted (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.RotationGestureDetector']/method[@name='onRotationStarted' and count(parameter)=3 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point']]"
			[Register ("onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
			public virtual void OnRotationStarted (global::Android.Graphics.Point p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2)
			{
				if (id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTouch_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_MotionEvent_;
			}

			static void n_OnTouch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.RotationGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTouch (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.RotationGestureDetector']/method[@name='onTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/MotionEvent;)V", "GetOnTouch_Landroid_view_MotionEvent_Handler")]
			public override void OnTouch (global::Android.Views.MotionEvent p0)
			{
				if (id_onTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/MotionEvent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTouch_Landroid_view_MotionEvent_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/MotionEvent;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']"
		[global::Android.Runtime.Register ("orbotix/view/calibration/CalibrationView$TouchGestureDetector", DoNotGenerateAcw=true)]
		public partial class TouchGestureDetector : global::Orbotix.View.Calibration.CalibrationGetureDetector {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationView$TouchGestureDetector", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TouchGestureDetector); }
			}

			protected TouchGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorbotix_view_calibration_CalibrationView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']/constructor[@name='CalibrationView.TouchGestureDetector' and count(parameter)=1 and parameter[1][@type='orbotix.view.calibration.CalibrationView']]"
			[Register (".ctor", "(Lorbotix/view/calibration/CalibrationView;)V", "")]
			public TouchGestureDetector (global::Orbotix.View.Calibration.CalibrationView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

				if (id_ctor_Lorbotix_view_calibration_CalibrationView_ == IntPtr.Zero)
					id_ctor_Lorbotix_view_calibration_CalibrationView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/view/calibration/CalibrationView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_view_calibration_CalibrationView_, new JValue (__self));
			}

			static Delegate cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
			static Delegate GetOnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
			{
				if (cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
					cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_OnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_);
				return cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			}

			static void n_OnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRotation (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']/method[@name='onRotation' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='android.graphics.Point']]"
			[Register ("onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
			public virtual void OnRotation (double p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2, global::Android.Graphics.Point p3)
			{
				if (id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
			static Delegate GetOnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
			{
				if (cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
					cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_OnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_);
				return cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			}

			static void n_OnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRotationEnded (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']/method[@name='onRotationEnded' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='android.graphics.Point']]"
			[Register ("onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
			public virtual void OnRotationEnded (double p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2, global::Android.Graphics.Point p3)
			{
				if (id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
			static Delegate GetOnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
			{
				if (cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
					cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_);
				return cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			}

			static void n_OnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRotationStarted (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']/method[@name='onRotationStarted' and count(parameter)=3 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point']]"
			[Register ("onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
			public virtual void OnRotationStarted (global::Android.Graphics.Point p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2)
			{
				if (id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTouch_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_MotionEvent_;
			}

			static void n_OnTouch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTouch (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']/method[@name='onTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/MotionEvent;)V", "GetOnTouch_Landroid_view_MotionEvent_Handler")]
			public override void OnTouch (global::Android.Views.MotionEvent p0)
			{
				if (id_onTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/MotionEvent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTouch_Landroid_view_MotionEvent_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/MotionEvent;)V"), new JValue (p0));
			}

			static Delegate cb_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetStartRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_Handler ()
			{
				if (cb_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_ == null)
					cb_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_);
				return cb_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_;
			}

			static void n_StartRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
			{
				global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.TouchGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation p1 = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p3 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.StartRotating (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView.TouchGestureDetector']/method[@name='startRotating' and count(parameter)=4 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='orbotix.view.calibration.CalibrationView.CalibrationCircleLocation'] and parameter[3][@type='int'] and parameter[4][@type='android.view.MotionEvent']]"
			[Register ("startRotating", "(Landroid/graphics/Point;Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;ILandroid/view/MotionEvent;)V", "GetStartRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_Handler")]
			public virtual void StartRotating (global::Android.Graphics.Point p0, global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation p1, int p2, global::Android.Views.MotionEvent p3)
			{
				if (id_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_ == IntPtr.Zero)
					id_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "startRotating", "(Landroid/graphics/Point;Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;ILandroid/view/MotionEvent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startRotating_Landroid_graphics_Point_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_ILandroid_view_MotionEvent_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRotating", "(Landroid/graphics/Point;Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;ILandroid/view/MotionEvent;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/CalibrationView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalibrationView); }
		}

		protected CalibrationView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/constructor[@name='CalibrationView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public CalibrationView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CalibrationView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/constructor[@name='CalibrationView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public CalibrationView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CalibrationView)) {
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCalibrating;
		}
#pragma warning restore 0169

		static IntPtr id_isCalibrating;
		public virtual bool IsCalibrating {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='isCalibrating' and count(parameter)=0]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='disable' and count(parameter)=0]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='enable' and count(parameter)=0]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InterpretMotionEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_interpretMotionEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='interpretMotionEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
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

		static Delegate cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetOnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Handler ()
		{
			if (cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_ == null)
				cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr>) n_OnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_);
			return cb_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_;
		}

		static void n_OnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRotation (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='onRotation' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotation_DLandroid_graphics_Point_Landroid_graphics_Point_Handler")]
		protected virtual void OnRotation (double p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2)
		{
			if (id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
				id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRotation_DLandroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotation", "(DLandroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetOnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Handler ()
		{
			if (cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_ == null)
				cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr>) n_OnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_);
			return cb_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_;
		}

		static void n_OnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRotationEnded (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='onRotationEnded' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_Handler")]
		protected virtual void OnRotationEnded (double p0, global::Android.Graphics.Point p1, global::Android.Graphics.Point p2)
		{
			if (id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
				id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRotationEnded_DLandroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationEnded", "(DLandroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetOnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
		{
			if (cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
				cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_);
			return cb_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_;
		}

		static void n_OnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRotationStarted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='onRotationStarted' and count(parameter)=2 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;)V", "GetOnRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
		protected virtual void OnRotationStarted (global::Android.Graphics.Point p0, global::Android.Graphics.Point p1)
		{
			if (id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
				id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRotationStarted_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRotationStarted", "(Landroid/graphics/Point;Landroid/graphics/Point;)V"), new JValue (p0), new JValue (p1));
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundColors (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundColors_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setBackgroundColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetCircleColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCircleColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setCircleColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
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

		static Delegate cb_setDot1Color_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetDot1Color_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_setDot1Color_arrayLjava_lang_Integer_ == null)
				cb_setDot1Color_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDot1Color_arrayLjava_lang_Integer_);
			return cb_setDot1Color_arrayLjava_lang_Integer_;
		}

		static void n_SetDot1Color_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetDot1Color (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDot1Color_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setDot1Color' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
		[Register ("setDot1Color", "([Ljava/lang/Integer;)V", "GetSetDot1Color_arrayLjava_lang_Integer_Handler")]
		public virtual void SetDot1Color (params global:: Java.Lang.Integer[] p0)
		{
			if (id_setDot1Color_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_setDot1Color_arrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setDot1Color", "([Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDot1Color_arrayLjava_lang_Integer_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDot1Color", "([Ljava/lang/Integer;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDot2Color_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetDot2Color_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_setDot2Color_arrayLjava_lang_Integer_ == null)
				cb_setDot2Color_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDot2Color_arrayLjava_lang_Integer_);
			return cb_setDot2Color_arrayLjava_lang_Integer_;
		}

		static void n_SetDot2Color_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetDot2Color (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDot2Color_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setDot2Color' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
		[Register ("setDot2Color", "([Ljava/lang/Integer;)V", "GetSetDot2Color_arrayLjava_lang_Integer_Handler")]
		public virtual void SetDot2Color (params global:: Java.Lang.Integer[] p0)
		{
			if (id_setDot2Color_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_setDot2Color_arrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setDot2Color", "([Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDot2Color_arrayLjava_lang_Integer_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDot2Color", "([Ljava/lang/Integer;)V"), new JValue (native_p0));
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetDotColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDotColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setDotColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDotSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDotSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setDotSize' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnEndRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnEndRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setOnEndRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRotationRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRotationRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setOnRotationRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnStartRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnStartRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setOnStartRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRobot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRobot_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setRobot' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
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

		static Delegate cb_setShowBothDots_Z;
#pragma warning disable 0169
		static Delegate GetSetShowBothDots_ZHandler ()
		{
			if (cb_setShowBothDots_Z == null)
				cb_setShowBothDots_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowBothDots_Z);
			return cb_setShowBothDots_Z;
		}

		static void n_SetShowBothDots_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBothDots (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowBothDots_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setShowBothDots' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowBothDots", "(Z)V", "GetSetShowBothDots_ZHandler")]
		public virtual void SetShowBothDots (bool p0)
		{
			if (id_setShowBothDots_Z == IntPtr.Zero)
				id_setShowBothDots_Z = JNIEnv.GetMethodID (class_ref, "setShowBothDots", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShowBothDots_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowBothDots", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setShowCircleGlow_Z;
#pragma warning disable 0169
		static Delegate GetSetShowCircleGlow_ZHandler ()
		{
			if (cb_setShowCircleGlow_Z == null)
				cb_setShowCircleGlow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowCircleGlow_Z);
			return cb_setShowCircleGlow_Z;
		}

		static void n_SetShowCircleGlow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowCircleGlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowCircleGlow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setShowCircleGlow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowCircleGlow", "(Z)V", "GetSetShowCircleGlow_ZHandler")]
		public virtual void SetShowCircleGlow (bool p0)
		{
			if (id_setShowCircleGlow_Z == IntPtr.Zero)
				id_setShowCircleGlow_Z = JNIEnv.GetMethodID (class_ref, "setShowCircleGlow", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShowCircleGlow_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowCircleGlow", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setShowDotGlow_Z;
#pragma warning disable 0169
		static Delegate GetSetShowDotGlow_ZHandler ()
		{
			if (cb_setShowDotGlow_Z == null)
				cb_setShowDotGlow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowDotGlow_Z);
			return cb_setShowDotGlow_Z;
		}

		static void n_SetShowDotGlow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowDotGlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowDotGlow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setShowDotGlow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowDotGlow", "(Z)V", "GetSetShowDotGlow_ZHandler")]
		public virtual void SetShowDotGlow (bool p0)
		{
			if (id_setShowDotGlow_Z == IntPtr.Zero)
				id_setShowDotGlow_Z = JNIEnv.GetMethodID (class_ref, "setShowDotGlow", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShowDotGlow_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowDotGlow", "(Z)V"), new JValue (p0));
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
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowGlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowGlow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='setShowGlow' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetStartSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_Handler ()
		{
			if (cb_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_ == null)
				cb_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_);
			return cb_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_;
		}

		static void n_StartSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Orbotix.View.Calibration.CalibrationView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation p0 = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p3 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.StartSingleTouchCalibration (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='CalibrationView']/method[@name='startSingleTouchCalibration' and count(parameter)=4 and parameter[1][@type='orbotix.view.calibration.CalibrationView.CalibrationCircleLocation'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='int'] and parameter[4][@type='android.view.MotionEvent']]"
		[Register ("startSingleTouchCalibration", "(Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;Landroid/graphics/Point;ILandroid/view/MotionEvent;)V", "GetStartSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_Handler")]
		public virtual void StartSingleTouchCalibration (global::Orbotix.View.Calibration.CalibrationView.CalibrationCircleLocation p0, global::Android.Graphics.Point p1, int p2, global::Android.Views.MotionEvent p3)
		{
			if (id_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_ == IntPtr.Zero)
				id_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "startSingleTouchCalibration", "(Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;Landroid/graphics/Point;ILandroid/view/MotionEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startSingleTouchCalibration_Lorbotix_view_calibration_CalibrationView_CalibrationCircleLocation_Landroid_graphics_Point_ILandroid_view_MotionEvent_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startSingleTouchCalibration", "(Lorbotix/view/calibration/CalibrationView$CalibrationCircleLocation;Landroid/graphics/Point;ILandroid/view/MotionEvent;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

	}
}
