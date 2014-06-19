using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Macro {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']"
	[global::Android.Runtime.Register ("orbotix/macro/MacroObject", DoNotGenerateAcw=true)]
	public partial class MacroObject : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/field[@name='CALLBACK_EMIT_ID']"
		[Register ("CALLBACK_EMIT_ID")]
		public const int CallbackEmitId = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject.MacroObjectMode']"
		[global::Android.Runtime.Register ("orbotix/macro/MacroObject$MacroObjectMode", DoNotGenerateAcw=true)]
		public sealed partial class MacroObjectMode : global::Java.Lang.Enum {


			static IntPtr CachedStreaming_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject.MacroObjectMode']/field[@name='CachedStreaming']"
			[Register ("CachedStreaming")]
			public static global::Orbotix.Macro.MacroObject.MacroObjectMode CachedStreaming {
				get {
					if (CachedStreaming_jfieldId == IntPtr.Zero)
						CachedStreaming_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CachedStreaming", "Lorbotix/macro/MacroObject$MacroObjectMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CachedStreaming_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CachedStreaming_jfieldId == IntPtr.Zero)
						CachedStreaming_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CachedStreaming", "Lorbotix/macro/MacroObject$MacroObjectMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CachedStreaming_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr Chunky_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject.MacroObjectMode']/field[@name='Chunky']"
			[Register ("Chunky")]
			public static global::Orbotix.Macro.MacroObject.MacroObjectMode Chunky {
				get {
					if (Chunky_jfieldId == IntPtr.Zero)
						Chunky_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Chunky", "Lorbotix/macro/MacroObject$MacroObjectMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Chunky_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Chunky_jfieldId == IntPtr.Zero)
						Chunky_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Chunky", "Lorbotix/macro/MacroObject$MacroObjectMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Chunky_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr Normal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject.MacroObjectMode']/field[@name='Normal']"
			[Register ("Normal")]
			public static global::Orbotix.Macro.MacroObject.MacroObjectMode Normal {
				get {
					if (Normal_jfieldId == IntPtr.Zero)
						Normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Normal", "Lorbotix/macro/MacroObject$MacroObjectMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Normal_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Normal_jfieldId == IntPtr.Zero)
						Normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Normal", "Lorbotix/macro/MacroObject$MacroObjectMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Normal_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/macro/MacroObject$MacroObjectMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MacroObjectMode); }
			}

			internal MacroObjectMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject.MacroObjectMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorbotix/macro/MacroObject$MacroObjectMode;", "")]
			public static global::Orbotix.Macro.MacroObject.MacroObjectMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorbotix/macro/MacroObject$MacroObjectMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Orbotix.Macro.MacroObject.MacroObjectMode __ret = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject.MacroObjectMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorbotix/macro/MacroObject$MacroObjectMode;", "")]
			public static global::Orbotix.Macro.MacroObject.MacroObjectMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorbotix/macro/MacroObject$MacroObjectMode;");
				return (global::Orbotix.Macro.MacroObject.MacroObjectMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Orbotix.Macro.MacroObject.MacroObjectMode));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroObject.OnEmitCallback']"
		[Register ("orbotix/macro/MacroObject$OnEmitCallback", "", "Orbotix.Macro.MacroObject/IOnEmitCallbackInvoker")]
		public partial interface IOnEmitCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroObject.OnEmitCallback']/method[@name='onEmit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onEmit", "(I)V", "GetOnEmit_IHandler:Orbotix.Macro.MacroObject/IOnEmitCallbackInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnEmit (int p0);

		}

		[global::Android.Runtime.Register ("orbotix/macro/MacroObject$OnEmitCallback", DoNotGenerateAcw=true)]
		internal class IOnEmitCallbackInvoker : global::Java.Lang.Object, IOnEmitCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/macro/MacroObject$OnEmitCallback");
			IntPtr class_ref;

			public static IOnEmitCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnEmitCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.macro.MacroObject.OnEmitCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnEmitCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnEmitCallbackInvoker); }
			}

			static Delegate cb_onEmit_I;
#pragma warning disable 0169
			static Delegate GetOnEmit_IHandler ()
			{
				if (cb_onEmit_I == null)
					cb_onEmit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnEmit_I);
				return cb_onEmit_I;
			}

			static void n_OnEmit_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Orbotix.Macro.MacroObject.IOnEmitCallback __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.IOnEmitCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnEmit (p0);
			}
#pragma warning restore 0169

			IntPtr id_onEmit_I;
			public void OnEmit (int p0)
			{
				if (id_onEmit_I == IntPtr.Zero)
					id_onEmit_I = JNIEnv.GetMethodID (class_ref, "onEmit", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_onEmit_I, new JValue (p0));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroObject.OnMacroUploadedListener']"
		[Register ("orbotix/macro/MacroObject$OnMacroUploadedListener", "", "Orbotix.Macro.MacroObject/IOnMacroUploadedListenerInvoker")]
		public partial interface IOnMacroUploadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/interface[@name='MacroObject.OnMacroUploadedListener']/method[@name='onMacroUploaded' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
			[Register ("onMacroUploaded", "(Lorbotix/robot/base/Robot;)V", "GetOnMacroUploaded_Lorbotix_robot_base_Robot_Handler:Orbotix.Macro.MacroObject/IOnMacroUploadedListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnMacroUploaded (global::Orbotix.Robot.Base.Robot p0);

		}

		[global::Android.Runtime.Register ("orbotix/macro/MacroObject$OnMacroUploadedListener", DoNotGenerateAcw=true)]
		internal class IOnMacroUploadedListenerInvoker : global::Java.Lang.Object, IOnMacroUploadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/macro/MacroObject$OnMacroUploadedListener");
			IntPtr class_ref;

			public static IOnMacroUploadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMacroUploadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.macro.MacroObject.OnMacroUploadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMacroUploadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMacroUploadedListenerInvoker); }
			}

			static Delegate cb_onMacroUploaded_Lorbotix_robot_base_Robot_;
#pragma warning disable 0169
			static Delegate GetOnMacroUploaded_Lorbotix_robot_base_Robot_Handler ()
			{
				if (cb_onMacroUploaded_Lorbotix_robot_base_Robot_ == null)
					cb_onMacroUploaded_Lorbotix_robot_base_Robot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMacroUploaded_Lorbotix_robot_base_Robot_);
				return cb_onMacroUploaded_Lorbotix_robot_base_Robot_;
			}

			static void n_OnMacroUploaded_Lorbotix_robot_base_Robot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMacroUploaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMacroUploaded_Lorbotix_robot_base_Robot_;
			public void OnMacroUploaded (global::Orbotix.Robot.Base.Robot p0)
			{
				if (id_onMacroUploaded_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
					id_onMacroUploaded_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "onMacroUploaded", "(Lorbotix/robot/base/Robot;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMacroUploaded_Lorbotix_robot_base_Robot_, new JValue (p0));
			}

		}

		public partial class MacroUploadedEventArgs : global::System.EventArgs {

			public MacroUploadedEventArgs (global::Orbotix.Robot.Base.Robot p0)
			{
				this.p0 = p0;
			}

			global::Orbotix.Robot.Base.Robot p0;
			public global::Orbotix.Robot.Base.Robot P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/macro/MacroObject_OnMacroUploadedListenerImplementor")]
		internal sealed class IOnMacroUploadedListenerImplementor : global::Java.Lang.Object, IOnMacroUploadedListener {

			object sender;

			public IOnMacroUploadedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/macro/MacroObject_OnMacroUploadedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MacroUploadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnMacroUploaded (global::Orbotix.Robot.Base.Robot p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MacroUploadedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMacroUploadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/macro/MacroObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MacroObject); }
		}

		protected MacroObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/constructor[@name='MacroObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MacroObject () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MacroObject)) {
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

		static IntPtr id_ctor_Lorbotix_macro_MacroObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/constructor[@name='MacroObject' and count(parameter)=1 and parameter[1][@type='orbotix.macro.MacroObject']]"
		[Register (".ctor", "(Lorbotix/macro/MacroObject;)V", "")]
		public MacroObject (global::Orbotix.Macro.MacroObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MacroObject)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/macro/MacroObject;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/macro/MacroObject;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_macro_MacroObject_ == IntPtr.Zero)
				id_ctor_Lorbotix_macro_MacroObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/macro/MacroObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_macro_MacroObject_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_macro_MacroObject_, new JValue (p0));
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/constructor[@name='MacroObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public MacroObject (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (MacroObject)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCommands;
#pragma warning disable 0169
		static Delegate GetGetCommandsHandler ()
		{
			if (cb_getCommands == null)
				cb_getCommands = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommands);
			return cb_getCommands;
		}

		static IntPtr n_GetCommands (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Orbotix.Macro.IMacroCommand>.ToLocalJniHandle (__this.Commands);
		}
#pragma warning restore 0169

		static IntPtr id_getCommands;
		public virtual global::System.Collections.Generic.IList<global::Orbotix.Macro.IMacroCommand> Commands {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='getCommands' and count(parameter)=0]"
			[Register ("getCommands", "()Ljava/util/ArrayList;", "GetGetCommandsHandler")]
			get {
				if (id_getCommands == IntPtr.Zero)
					id_getCommands = JNIEnv.GetMethodID (class_ref, "getCommands", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Orbotix.Macro.IMacroCommand>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCommands), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Orbotix.Macro.IMacroCommand>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommands", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		static Delegate cb_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lorbotix_macro_MacroObject_MacroObjectMode_Handler ()
		{
			if (cb_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_ == null)
				cb_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lorbotix_macro_MacroObject_MacroObjectMode_);
			return cb_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_;
		}

		static void n_SetMode_Lorbotix_macro_MacroObject_MacroObjectMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.MacroObject.MacroObjectMode p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMode;
		static IntPtr id_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_;
		public virtual global::Orbotix.Macro.MacroObject.MacroObjectMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lorbotix/macro/MacroObject$MacroObjectMode;", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lorbotix/macro/MacroObject$MacroObjectMode;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (JNIEnv.CallObjectMethod  (Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.MacroObjectMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMode", "()Lorbotix/macro/MacroObject$MacroObjectMode;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='orbotix.macro.MacroObject.MacroObjectMode']]"
			[Register ("setMode", "(Lorbotix/macro/MacroObject$MacroObjectMode;)V", "GetSetMode_Lorbotix_macro_MacroObject_MacroObjectMode_Handler")]
			set {
				if (id_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_ == IntPtr.Zero)
					id_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lorbotix/macro/MacroObject$MacroObjectMode;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMode_Lorbotix_macro_MacroObject_MacroObjectMode_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Lorbotix/macro/MacroObject$MacroObjectMode;)V"), new JValue (value));
			}
		}

		static Delegate cb_addCommand_ILorbotix_macro_MacroCommand_;
#pragma warning disable 0169
		static Delegate GetAddCommand_ILorbotix_macro_MacroCommand_Handler ()
		{
			if (cb_addCommand_ILorbotix_macro_MacroCommand_ == null)
				cb_addCommand_ILorbotix_macro_MacroCommand_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddCommand_ILorbotix_macro_MacroCommand_);
			return cb_addCommand_ILorbotix_macro_MacroCommand_;
		}

		static void n_AddCommand_ILorbotix_macro_MacroCommand_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.IMacroCommand p1 = (global::Orbotix.Macro.IMacroCommand)global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addCommand_ILorbotix_macro_MacroCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='addCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='orbotix.macro.MacroCommand']]"
		[Register ("addCommand", "(ILorbotix/macro/MacroCommand;)V", "GetAddCommand_ILorbotix_macro_MacroCommand_Handler")]
		public virtual void AddCommand (int p0, global::Orbotix.Macro.IMacroCommand p1)
		{
			if (id_addCommand_ILorbotix_macro_MacroCommand_ == IntPtr.Zero)
				id_addCommand_ILorbotix_macro_MacroCommand_ = JNIEnv.GetMethodID (class_ref, "addCommand", "(ILorbotix/macro/MacroCommand;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addCommand_ILorbotix_macro_MacroCommand_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCommand", "(ILorbotix/macro/MacroCommand;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addCommand_Lorbotix_macro_MacroCommand_;
#pragma warning disable 0169
		static Delegate GetAddCommand_Lorbotix_macro_MacroCommand_Handler ()
		{
			if (cb_addCommand_Lorbotix_macro_MacroCommand_ == null)
				cb_addCommand_Lorbotix_macro_MacroCommand_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCommand_Lorbotix_macro_MacroCommand_);
			return cb_addCommand_Lorbotix_macro_MacroCommand_;
		}

		static void n_AddCommand_Lorbotix_macro_MacroCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.IMacroCommand p0 = (global::Orbotix.Macro.IMacroCommand)global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCommand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCommand_Lorbotix_macro_MacroCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='addCommand' and count(parameter)=1 and parameter[1][@type='orbotix.macro.MacroCommand']]"
		[Register ("addCommand", "(Lorbotix/macro/MacroCommand;)V", "GetAddCommand_Lorbotix_macro_MacroCommand_Handler")]
		public virtual void AddCommand (global::Orbotix.Macro.IMacroCommand p0)
		{
			if (id_addCommand_Lorbotix_macro_MacroCommand_ == IntPtr.Zero)
				id_addCommand_Lorbotix_macro_MacroCommand_ = JNIEnv.GetMethodID (class_ref, "addCommand", "(Lorbotix/macro/MacroCommand;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addCommand_Lorbotix_macro_MacroCommand_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCommand", "(Lorbotix/macro/MacroCommand;)V"), new JValue (p0));
		}

		static Delegate cb_generateMacroData;
#pragma warning disable 0169
		static Delegate GetGenerateMacroDataHandler ()
		{
			if (cb_generateMacroData == null)
				cb_generateMacroData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateMacroData);
			return cb_generateMacroData;
		}

		static IntPtr n_GenerateMacroData (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GenerateMacroData ());
		}
#pragma warning restore 0169

		static IntPtr id_generateMacroData;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='generateMacroData' and count(parameter)=0]"
		[Register ("generateMacroData", "()[B", "GetGenerateMacroDataHandler")]
		public virtual byte[] GenerateMacroData ()
		{
			if (id_generateMacroData == IntPtr.Zero)
				id_generateMacroData = JNIEnv.GetMethodID (class_ref, "generateMacroData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_generateMacroData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateMacroData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBytes);
			return cb_getBytes;
		}

		static IntPtr n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "GetGetBytesHandler")]
		public virtual byte[] GetBytes ()
		{
			if (id_getBytes == IntPtr.Zero)
				id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_moveCommand_II;
#pragma warning disable 0169
		static Delegate GetMoveCommand_IIHandler ()
		{
			if (cb_moveCommand_II == null)
				cb_moveCommand_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_MoveCommand_II);
			return cb_moveCommand_II;
		}

		static void n_MoveCommand_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveCommand_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='moveCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("moveCommand", "(II)V", "GetMoveCommand_IIHandler")]
		public virtual void MoveCommand (int p0, int p1)
		{
			if (id_moveCommand_II == IntPtr.Zero)
				id_moveCommand_II = JNIEnv.GetMethodID (class_ref, "moveCommand", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveCommand_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveCommand", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_playMacro;
#pragma warning disable 0169
		static Delegate GetPlayMacroHandler ()
		{
			if (cb_playMacro == null)
				cb_playMacro = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PlayMacro);
			return cb_playMacro;
		}

		static void n_PlayMacro (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayMacro ();
		}
#pragma warning restore 0169

		static IntPtr id_playMacro;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='playMacro' and count(parameter)=0]"
		[Register ("playMacro", "()V", "GetPlayMacroHandler")]
		public virtual void PlayMacro ()
		{
			if (id_playMacro == IntPtr.Zero)
				id_playMacro = JNIEnv.GetMethodID (class_ref, "playMacro", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_playMacro);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playMacro", "()V"));
		}

		static Delegate cb_removeCommand_I;
#pragma warning disable 0169
		static Delegate GetRemoveCommand_IHandler ()
		{
			if (cb_removeCommand_I == null)
				cb_removeCommand_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveCommand_I);
			return cb_removeCommand_I;
		}

		static void n_RemoveCommand_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCommand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCommand_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='removeCommand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeCommand", "(I)V", "GetRemoveCommand_IHandler")]
		public virtual void RemoveCommand (int p0)
		{
			if (id_removeCommand_I == IntPtr.Zero)
				id_removeCommand_I = JNIEnv.GetMethodID (class_ref, "removeCommand", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeCommand_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCommand", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setCommand_ILorbotix_macro_MacroCommand_;
#pragma warning disable 0169
		static Delegate GetSetCommand_ILorbotix_macro_MacroCommand_Handler ()
		{
			if (cb_setCommand_ILorbotix_macro_MacroCommand_ == null)
				cb_setCommand_ILorbotix_macro_MacroCommand_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetCommand_ILorbotix_macro_MacroCommand_);
			return cb_setCommand_ILorbotix_macro_MacroCommand_;
		}

		static IntPtr n_SetCommand_ILorbotix_macro_MacroCommand_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.IMacroCommand p1 = (global::Orbotix.Macro.IMacroCommand)global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCommand (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCommand_ILorbotix_macro_MacroCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='orbotix.macro.MacroCommand']]"
		[Register ("setCommand", "(ILorbotix/macro/MacroCommand;)Lorbotix/macro/MacroCommand;", "GetSetCommand_ILorbotix_macro_MacroCommand_Handler")]
		public virtual global::Orbotix.Macro.IMacroCommand SetCommand (int p0, global::Orbotix.Macro.IMacroCommand p1)
		{
			if (id_setCommand_ILorbotix_macro_MacroCommand_ == IntPtr.Zero)
				id_setCommand_ILorbotix_macro_MacroCommand_ = JNIEnv.GetMethodID (class_ref, "setCommand", "(ILorbotix/macro/MacroCommand;)Lorbotix/macro/MacroCommand;");

			global::Orbotix.Macro.IMacroCommand __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (JNIEnv.CallObjectMethod  (Handle, id_setCommand_ILorbotix_macro_MacroCommand_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.IMacroCommand> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommand", "(ILorbotix/macro/MacroCommand;)Lorbotix/macro/MacroCommand;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOnEmitCallback_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetOnEmitCallback_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setOnEmitCallback_Ljava_lang_Runnable_ == null)
				cb_setOnEmitCallback_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnEmitCallback_Ljava_lang_Runnable_);
			return cb_setOnEmitCallback_Ljava_lang_Runnable_;
		}

		static void n_SetOnEmitCallback_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnEmitCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnEmitCallback_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setOnEmitCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnEmitCallback", "(Ljava/lang/Runnable;)V", "GetSetOnEmitCallback_Ljava_lang_Runnable_Handler")]
		public virtual void SetOnEmitCallback (global::Java.Lang.IRunnable p0)
		{
			if (id_setOnEmitCallback_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setOnEmitCallback_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setOnEmitCallback", "(Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnEmitCallback_Ljava_lang_Runnable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnEmitCallback", "(Ljava/lang/Runnable;)V"), new JValue (p0));
		}

		static Delegate cb_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_Handler ()
		{
			if (cb_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_ == null)
				cb_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_);
			return cb_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_;
		}

		static void n_SetOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.MacroObject.IOnEmitCallback p0 = (global::Orbotix.Macro.MacroObject.IOnEmitCallback)global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.IOnEmitCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnEmitCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setOnEmitCallback' and count(parameter)=1 and parameter[1][@type='orbotix.macro.MacroObject.OnEmitCallback']]"
		[Register ("setOnEmitCallback", "(Lorbotix/macro/MacroObject$OnEmitCallback;)V", "GetSetOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_Handler")]
		public virtual void SetOnEmitCallback (global::Orbotix.Macro.MacroObject.IOnEmitCallback p0)
		{
			if (id_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_ == IntPtr.Zero)
				id_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_ = JNIEnv.GetMethodID (class_ref, "setOnEmitCallback", "(Lorbotix/macro/MacroObject$OnEmitCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnEmitCallback_Lorbotix_macro_MacroObject_OnEmitCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnEmitCallback", "(Lorbotix/macro/MacroObject$OnEmitCallback;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_Handler ()
		{
			if (cb_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_ == null)
				cb_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_);
			return cb_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_;
		}

		static void n_SetOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener p0 = (global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener)global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMacroUploadedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setOnMacroUploadedListener' and count(parameter)=1 and parameter[1][@type='orbotix.macro.MacroObject.OnMacroUploadedListener']]"
		[Register ("setOnMacroUploadedListener", "(Lorbotix/macro/MacroObject$OnMacroUploadedListener;)V", "GetSetOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_Handler")]
		public virtual void SetOnMacroUploadedListener (global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener p0)
		{
			if (id_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_ == IntPtr.Zero)
				id_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_ = JNIEnv.GetMethodID (class_ref, "setOnMacroUploadedListener", "(Lorbotix/macro/MacroObject$OnMacroUploadedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMacroUploadedListener_Lorbotix_macro_MacroObject_OnMacroUploadedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMacroUploadedListener", "(Lorbotix/macro/MacroObject$OnMacroUploadedListener;)V"), new JValue (p0));
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
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.Robot p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.Robot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRobot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRobot_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setRobot' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
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

		static Delegate cb_setRunAfterLoading_Z;
#pragma warning disable 0169
		static Delegate GetSetRunAfterLoading_ZHandler ()
		{
			if (cb_setRunAfterLoading_Z == null)
				cb_setRunAfterLoading_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRunAfterLoading_Z);
			return cb_setRunAfterLoading_Z;
		}

		static void n_SetRunAfterLoading_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRunAfterLoading (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRunAfterLoading_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='setRunAfterLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRunAfterLoading", "(Z)V", "GetSetRunAfterLoading_ZHandler")]
		public virtual void SetRunAfterLoading (bool p0)
		{
			if (id_setRunAfterLoading_Z == IntPtr.Zero)
				id_setRunAfterLoading_Z = JNIEnv.GetMethodID (class_ref, "setRunAfterLoading", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRunAfterLoading_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRunAfterLoading", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_size);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
		}

		static Delegate cb_stopMacro;
#pragma warning disable 0169
		static Delegate GetStopMacroHandler ()
		{
			if (cb_stopMacro == null)
				cb_stopMacro = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopMacro);
			return cb_stopMacro;
		}

		static void n_StopMacro (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Macro.MacroObject __this = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMacro ();
		}
#pragma warning restore 0169

		static IntPtr id_stopMacro;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.macro']/class[@name='MacroObject']/method[@name='stopMacro' and count(parameter)=0]"
		[Register ("stopMacro", "()V", "GetStopMacroHandler")]
		public virtual void StopMacro ()
		{
			if (id_stopMacro == IntPtr.Zero)
				id_stopMacro = JNIEnv.GetMethodID (class_ref, "stopMacro", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopMacro);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopMacro", "()V"));
		}

#region "Event implementation for Orbotix.Macro.MacroObject.IOnMacroUploadedListener"
		public event EventHandler<global::Orbotix.Macro.MacroObject.MacroUploadedEventArgs> MacroUploaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener, global::Orbotix.Macro.MacroObject.IOnMacroUploadedListenerImplementor>(
						ref weak_implementor_SetOnMacroUploadedListener,
						__CreateIOnMacroUploadedListenerImplementor,
						SetOnMacroUploadedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Macro.MacroObject.IOnMacroUploadedListener, global::Orbotix.Macro.MacroObject.IOnMacroUploadedListenerImplementor>(
						ref weak_implementor_SetOnMacroUploadedListener,
						global::Orbotix.Macro.MacroObject.IOnMacroUploadedListenerImplementor.__IsEmpty,
						__v => SetOnMacroUploadedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMacroUploadedListener;

		global::Orbotix.Macro.MacroObject.IOnMacroUploadedListenerImplementor __CreateIOnMacroUploadedListenerImplementor ()
		{
			return new global::Orbotix.Macro.MacroObject.IOnMacroUploadedListenerImplementor (this);
		}
#endregion
	}
}
