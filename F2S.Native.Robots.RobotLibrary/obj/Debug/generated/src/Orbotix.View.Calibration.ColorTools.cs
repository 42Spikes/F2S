using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.View.Calibration {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']"
	[global::Android.Runtime.Register ("orbotix/view/calibration/ColorTools", DoNotGenerateAcw=true)]
	public partial class ColorTools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/view/calibration/ColorTools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorTools); }
		}

		protected ColorTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/constructor[@name='ColorTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ColorTools () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ColorTools)) {
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

		static IntPtr id_ClippedColorPart_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='ClippedColorPart' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ClippedColorPart", "(I)I", "")]
		public static int ClippedColorPart (int p0)
		{
			if (id_ClippedColorPart_I == IntPtr.Zero)
				id_ClippedColorPart_I = JNIEnv.GetStaticMethodID (class_ref, "ClippedColorPart", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_ClippedColorPart_I, new JValue (p0));
		}

		static IntPtr id_ColorSum_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='ColorSum' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ColorSum", "(II)I", "")]
		public static int ColorSum (int p0, int p1)
		{
			if (id_ColorSum_II == IntPtr.Zero)
				id_ColorSum_II = JNIEnv.GetStaticMethodID (class_ref, "ColorSum", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_ColorSum_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ColorSum_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='ColorSum' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("ColorSum", "(IIZ)I", "")]
		public static int ColorSum (int p0, int p1, bool p2)
		{
			if (id_ColorSum_IIZ == IntPtr.Zero)
				id_ColorSum_IIZ = JNIEnv.GetStaticMethodID (class_ref, "ColorSum", "(IIZ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_ColorSum_IIZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_average_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='average' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("average", "(II)I", "")]
		public static int Average (int p0, int p1)
		{
			if (id_average_II == IntPtr.Zero)
				id_average_II = JNIEnv.GetStaticMethodID (class_ref, "average", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_average_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getArgb_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='getArgb' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getArgb", "(I)[I", "")]
		public static int[] GetArgb (int p0)
		{
			if (id_getArgb_I == IntPtr.Zero)
				id_getArgb_I = JNIEnv.GetStaticMethodID (class_ref, "getArgb", "(I)[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getArgb_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static IntPtr id_getColorFromArgb_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='getColorFromArgb' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getColorFromArgb", "([I)I", "")]
		public static int GetColorFromArgb (int[] p0)
		{
			if (id_getColorFromArgb_arrayI == IntPtr.Zero)
				id_getColorFromArgb_arrayI = JNIEnv.GetStaticMethodID (class_ref, "getColorFromArgb", "([I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getColorFromArgb_arrayI, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_getContrastFilter_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='getContrastFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getContrastFilter", "(F)Landroid/graphics/ColorMatrixColorFilter;", "")]
		public static global::Android.Graphics.ColorMatrixColorFilter GetContrastFilter (float p0)
		{
			if (id_getContrastFilter_F == IntPtr.Zero)
				id_getContrastFilter_F = JNIEnv.GetStaticMethodID (class_ref, "getContrastFilter", "(F)Landroid/graphics/ColorMatrixColorFilter;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorMatrixColorFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContrastFilter_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getScaleContrastFilter_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='getScaleContrastFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getScaleContrastFilter", "(F)Landroid/graphics/ColorMatrixColorFilter;", "")]
		public static global::Android.Graphics.ColorMatrixColorFilter GetScaleContrastFilter (float p0)
		{
			if (id_getScaleContrastFilter_F == IntPtr.Zero)
				id_getScaleContrastFilter_F = JNIEnv.GetStaticMethodID (class_ref, "getScaleContrastFilter", "(F)Landroid/graphics/ColorMatrixColorFilter;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorMatrixColorFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScaleContrastFilter_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getTranslationColorFilter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.view.calibration']/class[@name='ColorTools']/method[@name='getTranslationColorFilter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTranslationColorFilter", "(I)Landroid/graphics/ColorMatrixColorFilter;", "")]
		public static global::Android.Graphics.ColorMatrixColorFilter GetTranslationColorFilter (int p0)
		{
			if (id_getTranslationColorFilter_I == IntPtr.Zero)
				id_getTranslationColorFilter_I = JNIEnv.GetStaticMethodID (class_ref, "getTranslationColorFilter", "(I)Landroid/graphics/ColorMatrixColorFilter;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorMatrixColorFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTranslationColorFilter_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
