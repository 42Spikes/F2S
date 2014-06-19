using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/GlowingDot", DoNotGenerateAcw=true)]
	public partial class GlowingDot : global::Java.Lang.Object, global::Orbotix.View.Calibration.IWidgetGraphicPart {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/GlowingDot", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlowingDot); }
		}

		protected GlowingDot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/constructor[@name='GlowingDot' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GlowingDot (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GlowingDot)) {
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

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		static IntPtr id_setSize_I;
		public virtual int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
			set {
				if (id_setSize_I == IntPtr.Zero)
					id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSize_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static IntPtr n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Draw (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public virtual global::Android.Graphics.Rect Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;");

			global::Android.Graphics.Rect __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_draw_Landroid_graphics_Canvas_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)Landroid/graphics/Rect;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public virtual void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hide);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hide", "()V"));
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
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetColor (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
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

		static Delegate cb_setPosition_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Landroid_graphics_Point_Handler ()
		{
			if (cb_setPosition_Landroid_graphics_Point_ == null)
				cb_setPosition_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Landroid_graphics_Point_);
			return cb_setPosition_Landroid_graphics_Point_;
		}

		static void n_SetPosition_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setPosition", "(Landroid/graphics/Point;)V", "GetSetPosition_Landroid_graphics_Point_Handler")]
		public virtual void SetPosition (global::Android.Graphics.Point p0)
		{
			if (id_setPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_setPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Landroid/graphics/Point;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPosition_Landroid_graphics_Point_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Landroid/graphics/Point;)V"), new JValue (p0));
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
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowGlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowGlow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='setShowGlow' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.View.Calibration.GlowingDot __this = global::Java.Lang.Object.GetObject<global::Orbotix.View.Calibration.GlowingDot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='GlowingDot']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_show);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
		}

	}
}
