using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Robot.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']"
	[global::Android.Runtime.Register ("orbotix/robot/base/OrbBasicControl", DoNotGenerateAcw=true)]
	public partial class OrbBasicControl : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='OrbBasicControl.EventListener']"
		[Register ("orbotix/robot/base/OrbBasicControl$EventListener", "", "Orbotix.Robot.Base.OrbBasicControl/IEventListenerInvoker")]
		public partial interface IEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='OrbBasicControl.EventListener']/method[@name='onEraseCompleted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onEraseCompleted", "(Z)V", "GetOnEraseCompleted_ZHandler:Orbotix.Robot.Base.OrbBasicControl/IEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnEraseCompleted (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='OrbBasicControl.EventListener']/method[@name='onErrorByteArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onErrorByteArray", "([B)V", "GetOnErrorByteArray_arrayBHandler:Orbotix.Robot.Base.OrbBasicControl/IEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnErrorByteArray (byte[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='OrbBasicControl.EventListener']/method[@name='onErrorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onErrorMessage", "(Ljava/lang/String;)V", "GetOnErrorMessage_Ljava_lang_String_Handler:Orbotix.Robot.Base.OrbBasicControl/IEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnErrorMessage (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='OrbBasicControl.EventListener']/method[@name='onLoadProgramComplete' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onLoadProgramComplete", "(Z)V", "GetOnLoadProgramComplete_ZHandler:Orbotix.Robot.Base.OrbBasicControl/IEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnLoadProgramComplete (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/interface[@name='OrbBasicControl.EventListener']/method[@name='onPrintMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onPrintMessage", "(Ljava/lang/String;)V", "GetOnPrintMessage_Ljava_lang_String_Handler:Orbotix.Robot.Base.OrbBasicControl/IEventListenerInvoker, F2S.Native.Robots.RobotLibrary")]
			void OnPrintMessage (string p0);

		}

		[global::Android.Runtime.Register ("orbotix/robot/base/OrbBasicControl$EventListener", DoNotGenerateAcw=true)]
		internal class IEventListenerInvoker : global::Java.Lang.Object, IEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("orbotix/robot/base/OrbBasicControl$EventListener");
			IntPtr class_ref;

			public static IEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "orbotix.robot.base.OrbBasicControl.EventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IEventListenerInvoker); }
			}

			static Delegate cb_onEraseCompleted_Z;
#pragma warning disable 0169
			static Delegate GetOnEraseCompleted_ZHandler ()
			{
				if (cb_onEraseCompleted_Z == null)
					cb_onEraseCompleted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnEraseCompleted_Z);
				return cb_onEraseCompleted_Z;
			}

			static void n_OnEraseCompleted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Orbotix.Robot.Base.OrbBasicControl.IEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnEraseCompleted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onEraseCompleted_Z;
			public void OnEraseCompleted (bool p0)
			{
				if (id_onEraseCompleted_Z == IntPtr.Zero)
					id_onEraseCompleted_Z = JNIEnv.GetMethodID (class_ref, "onEraseCompleted", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onEraseCompleted_Z, new JValue (p0));
			}

			static Delegate cb_onErrorByteArray_arrayB;
#pragma warning disable 0169
			static Delegate GetOnErrorByteArray_arrayBHandler ()
			{
				if (cb_onErrorByteArray_arrayB == null)
					cb_onErrorByteArray_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorByteArray_arrayB);
				return cb_onErrorByteArray_arrayB;
			}

			static void n_OnErrorByteArray_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.OrbBasicControl.IEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnErrorByteArray (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onErrorByteArray_arrayB;
			public void OnErrorByteArray (byte[] p0)
			{
				if (id_onErrorByteArray_arrayB == IntPtr.Zero)
					id_onErrorByteArray_arrayB = JNIEnv.GetMethodID (class_ref, "onErrorByteArray", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JNIEnv.CallVoidMethod (Handle, id_onErrorByteArray_arrayB, new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onErrorMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnErrorMessage_Ljava_lang_String_Handler ()
			{
				if (cb_onErrorMessage_Ljava_lang_String_ == null)
					cb_onErrorMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorMessage_Ljava_lang_String_);
				return cb_onErrorMessage_Ljava_lang_String_;
			}

			static void n_OnErrorMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.OrbBasicControl.IEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnErrorMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onErrorMessage_Ljava_lang_String_;
			public void OnErrorMessage (string p0)
			{
				if (id_onErrorMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_onErrorMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onErrorMessage", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_onErrorMessage_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onLoadProgramComplete_Z;
#pragma warning disable 0169
			static Delegate GetOnLoadProgramComplete_ZHandler ()
			{
				if (cb_onLoadProgramComplete_Z == null)
					cb_onLoadProgramComplete_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnLoadProgramComplete_Z);
				return cb_onLoadProgramComplete_Z;
			}

			static void n_OnLoadProgramComplete_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Orbotix.Robot.Base.OrbBasicControl.IEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadProgramComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLoadProgramComplete_Z;
			public void OnLoadProgramComplete (bool p0)
			{
				if (id_onLoadProgramComplete_Z == IntPtr.Zero)
					id_onLoadProgramComplete_Z = JNIEnv.GetMethodID (class_ref, "onLoadProgramComplete", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onLoadProgramComplete_Z, new JValue (p0));
			}

			static Delegate cb_onPrintMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnPrintMessage_Ljava_lang_String_Handler ()
			{
				if (cb_onPrintMessage_Ljava_lang_String_ == null)
					cb_onPrintMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrintMessage_Ljava_lang_String_);
				return cb_onPrintMessage_Ljava_lang_String_;
			}

			static void n_OnPrintMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Orbotix.Robot.Base.OrbBasicControl.IEventListener __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPrintMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPrintMessage_Ljava_lang_String_;
			public void OnPrintMessage (string p0)
			{
				if (id_onPrintMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_onPrintMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPrintMessage", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_onPrintMessage_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class EraseCompletedEventArgs : global::System.EventArgs {

			public EraseCompletedEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class ErrorByteArrayEventArgs : global::System.EventArgs {

			public ErrorByteArrayEventArgs (byte[] p0)
			{
				this.p0 = p0;
			}

			byte[] p0;
			public byte[] P0 {
				get { return p0; }
			}
		}

		public partial class ErrorMessageEventArgs : global::System.EventArgs {

			public ErrorMessageEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class LoadProgramCompleteEventArgs : global::System.EventArgs {

			public LoadProgramCompleteEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class PrintMessageEventArgs : global::System.EventArgs {

			public PrintMessageEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/orbotix/robot/base/OrbBasicControl_EventListenerImplementor")]
		internal sealed class IEventListenerImplementor : global::Java.Lang.Object, IEventListener {

			object sender;

			public IEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/orbotix/robot/base/OrbBasicControl_EventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EraseCompletedEventArgs> OnEraseCompletedHandler;
#pragma warning restore 0649

			public void OnEraseCompleted (bool p0)
			{
				var __h = OnEraseCompletedHandler;
				if (__h != null)
					__h (sender, new EraseCompletedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ErrorByteArrayEventArgs> OnErrorByteArrayHandler;
#pragma warning restore 0649

			public void OnErrorByteArray (byte[] p0)
			{
				var __h = OnErrorByteArrayHandler;
				if (__h != null)
					__h (sender, new ErrorByteArrayEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ErrorMessageEventArgs> OnErrorMessageHandler;
#pragma warning restore 0649

			public void OnErrorMessage (string p0)
			{
				var __h = OnErrorMessageHandler;
				if (__h != null)
					__h (sender, new ErrorMessageEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LoadProgramCompleteEventArgs> OnLoadProgramCompleteHandler;
#pragma warning restore 0649

			public void OnLoadProgramComplete (bool p0)
			{
				var __h = OnLoadProgramCompleteHandler;
				if (__h != null)
					__h (sender, new LoadProgramCompleteEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<PrintMessageEventArgs> OnPrintMessageHandler;
#pragma warning restore 0649

			public void OnPrintMessage (string p0)
			{
				var __h = OnPrintMessageHandler;
				if (__h != null)
					__h (sender, new PrintMessageEventArgs (p0));
			}

			internal static bool __IsEmpty (IEventListenerImplementor value)
			{
				return value.OnEraseCompletedHandler == null && value.OnErrorByteArrayHandler == null && value.OnErrorMessageHandler == null && value.OnLoadProgramCompleteHandler == null && value.OnPrintMessageHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/robot/base/OrbBasicControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrbBasicControl); }
		}

		protected OrbBasicControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorbotix_robot_base_Robot_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/constructor[@name='OrbBasicControl' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.Robot']]"
		[Register (".ctor", "(Lorbotix/robot/base/Robot;)V", "")]
		public OrbBasicControl (global::Orbotix.Robot.Base.Robot p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OrbBasicControl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorbotix/robot/base/Robot;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorbotix/robot/base/Robot;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorbotix_robot_base_Robot_ == IntPtr.Zero)
				id_ctor_Lorbotix_robot_base_Robot_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorbotix/robot/base/Robot;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorbotix_robot_base_Robot_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorbotix_robot_base_Robot_, new JValue (p0));
		}

		static Delegate cb_abortProgram;
#pragma warning disable 0169
		static Delegate GetAbortProgramHandler ()
		{
			if (cb_abortProgram == null)
				cb_abortProgram = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AbortProgram);
			return cb_abortProgram;
		}

		static void n_AbortProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbortProgram ();
		}
#pragma warning restore 0169

		static IntPtr id_abortProgram;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='abortProgram' and count(parameter)=0]"
		[Register ("abortProgram", "()V", "GetAbortProgramHandler")]
		public virtual void AbortProgram ()
		{
			if (id_abortProgram == IntPtr.Zero)
				id_abortProgram = JNIEnv.GetMethodID (class_ref, "abortProgram", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_abortProgram);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "abortProgram", "()V"));
		}

		static Delegate cb_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
#pragma warning disable 0169
		static Delegate GetAddEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_Handler ()
		{
			if (cb_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ == null)
				cb_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_);
			return cb_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
		}

		static void n_AddEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.OrbBasicControl.IEventListener p0 = (global::Orbotix.Robot.Base.OrbBasicControl.IEventListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='addEventListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.OrbBasicControl.EventListener']]"
		[Register ("addEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V", "GetAddEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_Handler")]
		public virtual void AddEventListener (global::Orbotix.Robot.Base.OrbBasicControl.IEventListener p0)
		{
			if (id_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ == IntPtr.Zero)
				id_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V"), new JValue (p0));
		}

		static Delegate cb_clearEventListeners;
#pragma warning disable 0169
		static Delegate GetClearEventListenersHandler ()
		{
			if (cb_clearEventListeners == null)
				cb_clearEventListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearEventListeners);
			return cb_clearEventListeners;
		}

		static void n_ClearEventListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearEventListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_clearEventListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='clearEventListeners' and count(parameter)=0]"
		[Register ("clearEventListeners", "()V", "GetClearEventListenersHandler")]
		public virtual void ClearEventListeners ()
		{
			if (id_clearEventListeners == IntPtr.Zero)
				id_clearEventListeners = JNIEnv.GetMethodID (class_ref, "clearEventListeners", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearEventListeners);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearEventListeners", "()V"));
		}

		static Delegate cb_eraseStorage;
#pragma warning disable 0169
		static Delegate GetEraseStorageHandler ()
		{
			if (cb_eraseStorage == null)
				cb_eraseStorage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EraseStorage);
			return cb_eraseStorage;
		}

		static void n_EraseStorage (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EraseStorage ();
		}
#pragma warning restore 0169

		static IntPtr id_eraseStorage;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='eraseStorage' and count(parameter)=0]"
		[Register ("eraseStorage", "()V", "GetEraseStorageHandler")]
		public virtual void EraseStorage ()
		{
			if (id_eraseStorage == IntPtr.Zero)
				id_eraseStorage = JNIEnv.GetMethodID (class_ref, "eraseStorage", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_eraseStorage);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "eraseStorage", "()V"));
		}

		static Delegate cb_executeProgram;
#pragma warning disable 0169
		static Delegate GetExecuteProgramHandler ()
		{
			if (cb_executeProgram == null)
				cb_executeProgram = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExecuteProgram);
			return cb_executeProgram;
		}

		static void n_ExecuteProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteProgram ();
		}
#pragma warning restore 0169

		static IntPtr id_executeProgram;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='executeProgram' and count(parameter)=0]"
		[Register ("executeProgram", "()V", "GetExecuteProgramHandler")]
		public virtual void ExecuteProgram ()
		{
			if (id_executeProgram == IntPtr.Zero)
				id_executeProgram = JNIEnv.GetMethodID (class_ref, "executeProgram", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_executeProgram);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeProgram", "()V"));
		}

		static Delegate cb_loadProgram;
#pragma warning disable 0169
		static Delegate GetLoadProgramHandler ()
		{
			if (cb_loadProgram == null)
				cb_loadProgram = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadProgram);
			return cb_loadProgram;
		}

		static void n_LoadProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadProgram ();
		}
#pragma warning restore 0169

		static IntPtr id_loadProgram;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='loadProgram' and count(parameter)=0]"
		[Register ("loadProgram", "()V", "GetLoadProgramHandler")]
		public virtual void LoadProgram ()
		{
			if (id_loadProgram == IntPtr.Zero)
				id_loadProgram = JNIEnv.GetMethodID (class_ref, "loadProgram", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadProgram);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadProgram", "()V"));
		}

		static Delegate cb_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_Handler ()
		{
			if (cb_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ == null)
				cb_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_);
			return cb_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
		}

		static void n_RemoveEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.OrbBasicControl.IEventListener p0 = (global::Orbotix.Robot.Base.OrbBasicControl.IEventListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.OrbBasicControl.EventListener']]"
		[Register ("removeEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V", "GetRemoveEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_Handler")]
		public virtual void RemoveEventListener (global::Orbotix.Robot.Base.OrbBasicControl.IEventListener p0)
		{
			if (id_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ == IntPtr.Zero)
				id_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ = JNIEnv.GetMethodID (class_ref, "removeEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
#pragma warning disable 0169
		static Delegate GetSetOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_Handler ()
		{
			if (cb_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ == null)
				cb_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_);
			return cb_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
		}

		static void n_SetOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Robot.Base.OrbBasicControl.IEventListener p0 = (global::Orbotix.Robot.Base.OrbBasicControl.IEventListener)global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrbBasicControlEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='setOrbBasicControlEventListener' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.OrbBasicControl.EventListener']]"
		[Register ("setOrbBasicControlEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V", "GetSetOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_Handler")]
		public virtual void SetOrbBasicControlEventListener (global::Orbotix.Robot.Base.OrbBasicControl.IEventListener p0)
		{
			if (id_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ == IntPtr.Zero)
				id_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_ = JNIEnv.GetMethodID (class_ref, "setOrbBasicControlEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOrbBasicControlEventListener_Lorbotix_robot_base_OrbBasicControl_EventListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrbBasicControlEventListener", "(Lorbotix/robot/base/OrbBasicControl$EventListener;)V"), new JValue (p0));
		}

		static Delegate cb_setProgram_arrayB;
#pragma warning disable 0169
		static Delegate GetSetProgram_arrayBHandler ()
		{
			if (cb_setProgram_arrayB == null)
				cb_setProgram_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProgram_arrayB);
			return cb_setProgram_arrayB;
		}

		static void n_SetProgram_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Robot.Base.OrbBasicControl __this = global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetProgram (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setProgram_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.robot.base']/class[@name='OrbBasicControl']/method[@name='setProgram' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setProgram", "([B)V", "GetSetProgram_arrayBHandler")]
		public virtual void SetProgram (byte[] p0)
		{
			if (id_setProgram_arrayB == IntPtr.Zero)
				id_setProgram_arrayB = JNIEnv.GetMethodID (class_ref, "setProgram", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setProgram_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProgram", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Orbotix.Robot.Base.OrbBasicControl.IEventListener"
		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.EraseCompletedEventArgs> EraseCompleted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						__CreateIEventListenerImplementor,
						AddEventListener,
						__h => __h.OnEraseCompletedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						RemoveEventListener,
						__h => __h.OnEraseCompletedHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.ErrorByteArrayEventArgs> ErrorByteArray {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						__CreateIEventListenerImplementor,
						AddEventListener,
						__h => __h.OnErrorByteArrayHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						RemoveEventListener,
						__h => __h.OnErrorByteArrayHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.ErrorMessageEventArgs> ErrorMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						__CreateIEventListenerImplementor,
						AddEventListener,
						__h => __h.OnErrorMessageHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						RemoveEventListener,
						__h => __h.OnErrorMessageHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.LoadProgramCompleteEventArgs> LoadProgramComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						__CreateIEventListenerImplementor,
						AddEventListener,
						__h => __h.OnLoadProgramCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						RemoveEventListener,
						__h => __h.OnLoadProgramCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.PrintMessageEventArgs> PrintMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						__CreateIEventListenerImplementor,
						AddEventListener,
						__h => __h.OnPrintMessageHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_AddEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						RemoveEventListener,
						__h => __h.OnPrintMessageHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.EraseCompletedEventArgs> EraseCompleted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						__CreateIEventListenerImplementor,
						SetOrbBasicControlEventListener,
						__h => __h.OnEraseCompletedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						__v => SetOrbBasicControlEventListener (null),
						__h => __h.OnEraseCompletedHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.ErrorByteArrayEventArgs> ErrorByteArray {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						__CreateIEventListenerImplementor,
						SetOrbBasicControlEventListener,
						__h => __h.OnErrorByteArrayHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						__v => SetOrbBasicControlEventListener (null),
						__h => __h.OnErrorByteArrayHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.ErrorMessageEventArgs> ErrorMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						__CreateIEventListenerImplementor,
						SetOrbBasicControlEventListener,
						__h => __h.OnErrorMessageHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						__v => SetOrbBasicControlEventListener (null),
						__h => __h.OnErrorMessageHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.LoadProgramCompleteEventArgs> LoadProgramComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						__CreateIEventListenerImplementor,
						SetOrbBasicControlEventListener,
						__h => __h.OnLoadProgramCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						__v => SetOrbBasicControlEventListener (null),
						__h => __h.OnLoadProgramCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Orbotix.Robot.Base.OrbBasicControl.PrintMessageEventArgs> PrintMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						__CreateIEventListenerImplementor,
						SetOrbBasicControlEventListener,
						__h => __h.OnPrintMessageHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Orbotix.Robot.Base.OrbBasicControl.IEventListener, global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor>(
						ref weak_implementor_SetOrbBasicControlEventListener,
						global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor.__IsEmpty,
						__v => SetOrbBasicControlEventListener (null),
						__h => __h.OnPrintMessageHandler -= value);
			}
		}

		WeakReference weak_implementor_AddEventListener;
		WeakReference weak_implementor_SetOrbBasicControlEventListener;

		global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor __CreateIEventListenerImplementor ()
		{
			return new global::Orbotix.Robot.Base.OrbBasicControl.IEventListenerImplementor (this);
		}
#endregion
	}
}
