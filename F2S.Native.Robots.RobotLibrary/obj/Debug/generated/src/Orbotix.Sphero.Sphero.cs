using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Sphero {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']"
	[global::Android.Runtime.Register ("orbotix/sphero/Sphero", DoNotGenerateAcw=true)]
	public partial class Sphero : global::Orbotix.Robot.Base.Robot {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/sphero/Sphero", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Sphero); }
		}

		protected Sphero (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_bluetooth_BluetoothDevice_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/constructor[@name='Sphero' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;)V", "")]
		public Sphero (global::Android.Bluetooth.BluetoothDevice p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Sphero)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/bluetooth/BluetoothDevice;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/bluetooth/BluetoothDevice;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
				id_ctor_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothDevice;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_, new JValue (p0));
		}

		static Delegate cb_getCollisionControl;
#pragma warning disable 0169
		static Delegate GetGetCollisionControlHandler ()
		{
			if (cb_getCollisionControl == null)
				cb_getCollisionControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCollisionControl);
			return cb_getCollisionControl;
		}

		static IntPtr n_GetCollisionControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CollisionControl);
		}
#pragma warning restore 0169

		static IntPtr id_getCollisionControl;
		public virtual global::Orbotix.Sphero.CollisionControl CollisionControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='getCollisionControl' and count(parameter)=0]"
			[Register ("getCollisionControl", "()Lorbotix/sphero/CollisionControl;", "GetGetCollisionControlHandler")]
			get {
				if (id_getCollisionControl == IntPtr.Zero)
					id_getCollisionControl = JNIEnv.GetMethodID (class_ref, "getCollisionControl", "()Lorbotix/sphero/CollisionControl;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl> (JNIEnv.CallObjectMethod  (Handle, id_getCollisionControl), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.CollisionControl> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCollisionControl", "()Lorbotix/sphero/CollisionControl;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getConfiguration;
#pragma warning disable 0169
		static Delegate GetGetConfigurationHandler ()
		{
			if (cb_getConfiguration == null)
				cb_getConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfiguration);
			return cb_getConfiguration;
		}

		static IntPtr n_GetConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		static IntPtr id_getConfiguration;
		public virtual global::Orbotix.Sphero.ConfigurationControl Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Lorbotix/sphero/ConfigurationControl;", "GetGetConfigurationHandler")]
			get {
				if (id_getConfiguration == IntPtr.Zero)
					id_getConfiguration = JNIEnv.GetMethodID (class_ref, "getConfiguration", "()Lorbotix/sphero/ConfigurationControl;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (JNIEnv.CallObjectMethod  (Handle, id_getConfiguration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.ConfigurationControl> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfiguration", "()Lorbotix/sphero/ConfigurationControl;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOrbBasicControl;
#pragma warning disable 0169
		static Delegate GetGetOrbBasicControlHandler ()
		{
			if (cb_getOrbBasicControl == null)
				cb_getOrbBasicControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrbBasicControl);
			return cb_getOrbBasicControl;
		}

		static IntPtr n_GetOrbBasicControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrbBasicControl);
		}
#pragma warning restore 0169

		static IntPtr id_getOrbBasicControl;
		public virtual global::Orbotix.Robot.Base.OrbBasicControl OrbBasicControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='getOrbBasicControl' and count(parameter)=0]"
			[Register ("getOrbBasicControl", "()Lorbotix/robot/base/OrbBasicControl;", "GetGetOrbBasicControlHandler")]
			get {
				if (id_getOrbBasicControl == IntPtr.Zero)
					id_getOrbBasicControl = JNIEnv.GetMethodID (class_ref, "getOrbBasicControl", "()Lorbotix/robot/base/OrbBasicControl;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (JNIEnv.CallObjectMethod  (Handle, id_getOrbBasicControl), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Robot.Base.OrbBasicControl> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrbBasicControl", "()Lorbotix/robot/base/OrbBasicControl;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSensorControl;
#pragma warning disable 0169
		static Delegate GetGetSensorControlHandler ()
		{
			if (cb_getSensorControl == null)
				cb_getSensorControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSensorControl);
			return cb_getSensorControl;
		}

		static IntPtr n_GetSensorControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SensorControl);
		}
#pragma warning restore 0169

		static IntPtr id_getSensorControl;
		public virtual global::Orbotix.Sphero.SensorControl SensorControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='getSensorControl' and count(parameter)=0]"
			[Register ("getSensorControl", "()Lorbotix/sphero/SensorControl;", "GetGetSensorControlHandler")]
			get {
				if (id_getSensorControl == IntPtr.Zero)
					id_getSensorControl = JNIEnv.GetMethodID (class_ref, "getSensorControl", "()Lorbotix/sphero/SensorControl;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (JNIEnv.CallObjectMethod  (Handle, id_getSensorControl), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.SensorControl> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSensorControl", "()Lorbotix/sphero/SensorControl;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual global::Orbotix.Sphero.RobotVersion Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Lorbotix/sphero/RobotVersion;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Lorbotix/sphero/RobotVersion;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.RobotVersion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Lorbotix/sphero/RobotVersion;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disconnect);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
		}

		static Delegate cb_drive_FF;
#pragma warning disable 0169
		static Delegate GetDrive_FFHandler ()
		{
			if (cb_drive_FF == null)
				cb_drive_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_Drive_FF);
			return cb_drive_FF;
		}

		static void n_Drive_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Drive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_drive_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='drive' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("drive", "(FF)V", "GetDrive_FFHandler")]
		public virtual void Drive (float p0, float p1)
		{
			if (id_drive_FF == IntPtr.Zero)
				id_drive_FF = JNIEnv.GetMethodID (class_ref, "drive", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drive_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drive", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_enableStabilization_Z;
#pragma warning disable 0169
		static Delegate GetEnableStabilization_ZHandler ()
		{
			if (cb_enableStabilization_Z == null)
				cb_enableStabilization_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableStabilization_Z);
			return cb_enableStabilization_Z;
		}

		static void n_EnableStabilization_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableStabilization (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableStabilization_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='enableStabilization' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableStabilization", "(Z)V", "GetEnableStabilization_ZHandler")]
		public virtual void EnableStabilization (bool p0)
		{
			if (id_enableStabilization_Z == IntPtr.Zero)
				id_enableStabilization_Z = JNIEnv.GetMethodID (class_ref, "enableStabilization", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableStabilization_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableStabilization", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_evaluateReadyState;
#pragma warning disable 0169
		static Delegate GetEvaluateReadyStateHandler ()
		{
			if (cb_evaluateReadyState == null)
				cb_evaluateReadyState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EvaluateReadyState);
			return cb_evaluateReadyState;
		}

		static void n_EvaluateReadyState (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EvaluateReadyState ();
		}
#pragma warning restore 0169

		static IntPtr id_evaluateReadyState;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='evaluateReadyState' and count(parameter)=0]"
		[Register ("evaluateReadyState", "()V", "GetEvaluateReadyStateHandler")]
		protected virtual void EvaluateReadyState ()
		{
			if (id_evaluateReadyState == IntPtr.Zero)
				id_evaluateReadyState = JNIEnv.GetMethodID (class_ref, "evaluateReadyState", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_evaluateReadyState);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "evaluateReadyState", "()V"));
		}

		static Delegate cb_executeMacro_Lorbotix_macro_MacroObject_;
#pragma warning disable 0169
		static Delegate GetExecuteMacro_Lorbotix_macro_MacroObject_Handler ()
		{
			if (cb_executeMacro_Lorbotix_macro_MacroObject_ == null)
				cb_executeMacro_Lorbotix_macro_MacroObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExecuteMacro_Lorbotix_macro_MacroObject_);
			return cb_executeMacro_Lorbotix_macro_MacroObject_;
		}

		static void n_ExecuteMacro_Lorbotix_macro_MacroObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Orbotix.Macro.MacroObject p0 = global::Java.Lang.Object.GetObject<global::Orbotix.Macro.MacroObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteMacro (p0);
		}
#pragma warning restore 0169

		static IntPtr id_executeMacro_Lorbotix_macro_MacroObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='executeMacro' and count(parameter)=1 and parameter[1][@type='orbotix.macro.MacroObject']]"
		[Register ("executeMacro", "(Lorbotix/macro/MacroObject;)V", "GetExecuteMacro_Lorbotix_macro_MacroObject_Handler")]
		public virtual void ExecuteMacro (global::Orbotix.Macro.MacroObject p0)
		{
			if (id_executeMacro_Lorbotix_macro_MacroObject_ == IntPtr.Zero)
				id_executeMacro_Lorbotix_macro_MacroObject_ = JNIEnv.GetMethodID (class_ref, "executeMacro", "(Lorbotix/macro/MacroObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_executeMacro_Lorbotix_macro_MacroObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeMacro", "(Lorbotix/macro/MacroObject;)V"), new JValue (p0));
		}

		static Delegate cb_rotate_F;
#pragma warning disable 0169
		static Delegate GetRotate_FHandler ()
		{
			if (cb_rotate_F == null)
				cb_rotate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_Rotate_F);
			return cb_rotate_F;
		}

		static void n_Rotate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rotate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rotate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)V", "GetRotate_FHandler")]
		public virtual void Rotate (float p0)
		{
			if (id_rotate_F == IntPtr.Zero)
				id_rotate_F = JNIEnv.GetMethodID (class_ref, "rotate", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rotate_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotate", "(F)V"), new JValue (p0));
		}

		static Delegate cb_sendRawByteCommand_arrayB;
#pragma warning disable 0169
		static Delegate GetSendRawByteCommand_arrayBHandler ()
		{
			if (cb_sendRawByteCommand_arrayB == null)
				cb_sendRawByteCommand_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendRawByteCommand_arrayB);
			return cb_sendRawByteCommand_arrayB;
		}

		static void n_SendRawByteCommand_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SendRawByteCommand (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendRawByteCommand_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='sendRawByteCommand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendRawByteCommand", "([B)V", "GetSendRawByteCommand_arrayBHandler")]
		public virtual void SendRawByteCommand (byte[] p0)
		{
			if (id_sendRawByteCommand_arrayB == IntPtr.Zero)
				id_sendRawByteCommand_arrayB = JNIEnv.GetMethodID (class_ref, "sendRawByteCommand", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendRawByteCommand_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRawByteCommand", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setBackLEDBrightness_F;
#pragma warning disable 0169
		static Delegate GetSetBackLEDBrightness_FHandler ()
		{
			if (cb_setBackLEDBrightness_F == null)
				cb_setBackLEDBrightness_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBackLEDBrightness_F);
			return cb_setBackLEDBrightness_F;
		}

		static void n_SetBackLEDBrightness_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackLEDBrightness (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackLEDBrightness_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='setBackLEDBrightness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBackLEDBrightness", "(F)V", "GetSetBackLEDBrightness_FHandler")]
		public virtual void SetBackLEDBrightness (float p0)
		{
			if (id_setBackLEDBrightness_F == IntPtr.Zero)
				id_setBackLEDBrightness_F = JNIEnv.GetMethodID (class_ref, "setBackLEDBrightness", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBackLEDBrightness_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackLEDBrightness", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setColor_III;
#pragma warning disable 0169
		static Delegate GetSetColor_IIIHandler ()
		{
			if (cb_setColor_III == null)
				cb_setColor_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetColor_III);
			return cb_setColor_III;
		}

		static void n_SetColor_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='setColor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setColor", "(III)V", "GetSetColor_IIIHandler")]
		public virtual void SetColor (int p0, int p1, int p2)
		{
			if (id_setColor_III == IntPtr.Zero)
				id_setColor_III = JNIEnv.GetMethodID (class_ref, "setColor", "(III)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setColor_III, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(III)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_setRotationRate_F;
#pragma warning disable 0169
		static Delegate GetSetRotationRate_FHandler ()
		{
			if (cb_setRotationRate_F == null)
				cb_setRotationRate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotationRate_F);
			return cb_setRotationRate_F;
		}

		static void n_SetRotationRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationRate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='setRotationRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotationRate", "(F)V", "GetSetRotationRate_FHandler")]
		public virtual void SetRotationRate (float p0)
		{
			if (id_setRotationRate_F == IntPtr.Zero)
				id_setRotationRate_F = JNIEnv.GetMethodID (class_ref, "setRotationRate", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRotationRate_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationRate", "(F)V"), new JValue (p0));
		}

		static Delegate cb_sleep_I;
#pragma warning disable 0169
		static Delegate GetSleep_IHandler ()
		{
			if (cb_sleep_I == null)
				cb_sleep_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Sleep_I);
			return cb_sleep_I;
		}

		static void n_Sleep_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sleep (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sleep_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sleep", "(I)V", "GetSleep_IHandler")]
		public virtual void Sleep (int p0)
		{
			if (id_sleep_I == IntPtr.Zero)
				id_sleep_I = JNIEnv.GetMethodID (class_ref, "sleep", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sleep_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sleep", "(I)V"), new JValue (p0));
		}

		static Delegate cb_sleepAndWakeWithMacro_II;
#pragma warning disable 0169
		static Delegate GetSleepAndWakeWithMacro_IIHandler ()
		{
			if (cb_sleepAndWakeWithMacro_II == null)
				cb_sleepAndWakeWithMacro_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SleepAndWakeWithMacro_II);
			return cb_sleepAndWakeWithMacro_II;
		}

		static void n_SleepAndWakeWithMacro_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepAndWakeWithMacro (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sleepAndWakeWithMacro_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='sleepAndWakeWithMacro' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("sleepAndWakeWithMacro", "(II)V", "GetSleepAndWakeWithMacro_IIHandler")]
		public virtual void SleepAndWakeWithMacro (int p0, int p1)
		{
			if (id_sleepAndWakeWithMacro_II == IntPtr.Zero)
				id_sleepAndWakeWithMacro_II = JNIEnv.GetMethodID (class_ref, "sleepAndWakeWithMacro", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sleepAndWakeWithMacro_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sleepAndWakeWithMacro", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_startCalibration;
#pragma warning disable 0169
		static Delegate GetStartCalibrationHandler ()
		{
			if (cb_startCalibration == null)
				cb_startCalibration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartCalibration);
			return cb_startCalibration;
		}

		static void n_StartCalibration (IntPtr jnienv, IntPtr native__this)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCalibration ();
		}
#pragma warning restore 0169

		static IntPtr id_startCalibration;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='startCalibration' and count(parameter)=0]"
		[Register ("startCalibration", "()V", "GetStartCalibrationHandler")]
		public virtual void StartCalibration ()
		{
			if (id_startCalibration == IntPtr.Zero)
				id_startCalibration = JNIEnv.GetMethodID (class_ref, "startCalibration", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startCalibration);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startCalibration", "()V"));
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
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='stop' and count(parameter)=0]"
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

		static Delegate cb_stopCalibration_Z;
#pragma warning disable 0169
		static Delegate GetStopCalibration_ZHandler ()
		{
			if (cb_stopCalibration_Z == null)
				cb_stopCalibration_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StopCalibration_Z);
			return cb_stopCalibration_Z;
		}

		static void n_StopCalibration_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Orbotix.Sphero.Sphero __this = global::Java.Lang.Object.GetObject<global::Orbotix.Sphero.Sphero> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCalibration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stopCalibration_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.sphero']/class[@name='Sphero']/method[@name='stopCalibration' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stopCalibration", "(Z)V", "GetStopCalibration_ZHandler")]
		public virtual void StopCalibration (bool p0)
		{
			if (id_stopCalibration_Z == IntPtr.Zero)
				id_stopCalibration_Z = JNIEnv.GetMethodID (class_ref, "stopCalibration", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopCalibration_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopCalibration", "(Z)V"), new JValue (p0));
		}

	}
}
