using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='WidgetGraphicView']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/WidgetGraphicView", DoNotGenerateAcw=true)]
	public partial class WidgetGraphicView : global::Android.Views.View, global::Orbotix.View.Calibration.IWidgetGraphic {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/WidgetGraphicView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WidgetGraphicView); }
		}

		protected WidgetGraphicView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='WidgetGraphicView']/constructor[@name='WidgetGraphicView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public WidgetGraphicView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WidgetGraphicView)) {
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

		static Delegate cb_hideAllWidgetsParts;
#pragma warning disable 0169
		static Delegate GetHideAllWidgetsPartsHandler ()
		{
			if (cb_hideAllWidgetsParts == null)
				cb_hideAllWidgetsParts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideAllWidgetsParts);
			return cb_hideAllWidgetsParts;
		}

		static void n_HideAllWidgetsParts (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.WidgetGraphicView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.WidgetGraphicView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideAllWidgetsParts ();
		}
#pragma warning restore 0169

		static IntPtr id_hideAllWidgetsParts;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='WidgetGraphicView']/method[@name='hideAllWidgetsParts' and count(parameter)=0]"
		[Register ("hideAllWidgetsParts", "()V", "GetHideAllWidgetsPartsHandler")]
		public virtual void HideAllWidgetsParts ()
		{
			if (id_hideAllWidgetsParts == IntPtr.Zero)
				id_hideAllWidgetsParts = JNIEnv.GetMethodID (class_ref, "hideAllWidgetsParts", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hideAllWidgetsParts);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideAllWidgetsParts", "()V"));
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_ == null)
				cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraw_Landroid_graphics_Canvas_);
			return cb_onDraw_Landroid_graphics_Canvas_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.WidgetGraphicView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.WidgetGraphicView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='WidgetGraphicView']/method[@name='onDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public virtual void OnDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_onDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;)V"), new JValue (p0));
		}

		static Delegate cb_showAllWidgetParts;
#pragma warning disable 0169
		static Delegate GetShowAllWidgetPartsHandler ()
		{
			if (cb_showAllWidgetParts == null)
				cb_showAllWidgetParts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowAllWidgetParts);
			return cb_showAllWidgetParts;
		}

		static void n_ShowAllWidgetParts (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.WidgetGraphicView __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.WidgetGraphicView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAllWidgetParts ();
		}
#pragma warning restore 0169

		static IntPtr id_showAllWidgetParts;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='WidgetGraphicView']/method[@name='showAllWidgetParts' and count(parameter)=0]"
		[Register ("showAllWidgetParts", "()V", "GetShowAllWidgetPartsHandler")]
		public virtual void ShowAllWidgetParts ()
		{
			if (id_showAllWidgetParts == IntPtr.Zero)
				id_showAllWidgetParts = JNIEnv.GetMethodID (class_ref, "showAllWidgetParts", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showAllWidgetParts);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAllWidgetParts", "()V"));
		}

	}
}
