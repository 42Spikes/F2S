using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Orbotix.Achievement {

	// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']"
	[global::Android.Runtime.Register ("orbotix/achievement/AchievementManager", DoNotGenerateAcw=true)]
	public partial class AchievementManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/field[@name='AchievementEarnedIntent']"
		[Register ("AchievementEarnedIntent")]
		public const string AchievementEarnedIntent = (string) "com.orbotix.robotlibrary.achievement.achievementmanager.achievementearnedintent";

		// Metadata.xml XPath field reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/field[@name='CollisionDetectedIntent']"
		[Register ("CollisionDetectedIntent")]
		public const string CollisionDetectedIntent = (string) "com.orbotix.robotlibrary.achievement.achievementmanager.collisiondetectedintent";
		// Metadata.xml XPath class reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager.ColorThread']"
		[global::Android.Runtime.Register ("orbotix/achievement/AchievementManager$ColorThread", DoNotGenerateAcw=true)]
		public partial class ColorThread : global::Java.Lang.Thread {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("orbotix/achievement/AchievementManager$ColorThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ColorThread); }
			}

			protected ColorThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_updateLastColor_IIIJ;
#pragma warning disable 0169
			static Delegate GetUpdateLastColor_IIIJHandler ()
			{
				if (cb_updateLastColor_IIIJ == null)
					cb_updateLastColor_IIIJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, long>) n_UpdateLastColor_IIIJ);
				return cb_updateLastColor_IIIJ;
			}

			static void n_UpdateLastColor_IIIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, long p3)
			{
				global::Orbotix.Achievement.AchievementManager.ColorThread __this = global::Java.Lang.Object.GetObject<global::Orbotix.Achievement.AchievementManager.ColorThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.UpdateLastColor (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_updateLastColor_IIIJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager.ColorThread']/method[@name='updateLastColor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register ("updateLastColor", "(IIIJ)V", "GetUpdateLastColor_IIIJHandler")]
			public virtual void UpdateLastColor (int p0, int p1, int p2, long p3)
			{
				if (id_updateLastColor_IIIJ == IntPtr.Zero)
					id_updateLastColor_IIIJ = JNIEnv.GetMethodID (class_ref, "updateLastColor", "(IIIJ)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateLastColor_IIIJ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastColor", "(IIIJ)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("orbotix/achievement/AchievementManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AchievementManager); }
		}

		protected AchievementManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/constructor[@name='AchievementManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AchievementManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AchievementManager)) {
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

		static IntPtr id_getAccumulatedDistanceSinceLastQuery;
		public static int AccumulatedDistanceSinceLastQuery {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getAccumulatedDistanceSinceLastQuery' and count(parameter)=0]"
			[Register ("getAccumulatedDistanceSinceLastQuery", "()I", "GetGetAccumulatedDistanceSinceLastQueryHandler")]
			get {
				if (id_getAccumulatedDistanceSinceLastQuery == IntPtr.Zero)
					id_getAccumulatedDistanceSinceLastQuery = JNIEnv.GetStaticMethodID (class_ref, "getAccumulatedDistanceSinceLastQuery", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getAccumulatedDistanceSinceLastQuery);
			}
		}

		static IntPtr id_getAppID;
		public static string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				if (id_getAppID == IntPtr.Zero)
					id_getAppID = JNIEnv.GetStaticMethodID (class_ref, "getAppID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAppSecret;
		public static string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler")]
			get {
				if (id_getAppSecret == IntPtr.Zero)
					id_getAppSecret = JNIEnv.GetStaticMethodID (class_ref, "getAppSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getColorChangesSinceLastQuery;
		public static int ColorChangesSinceLastQuery {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getColorChangesSinceLastQuery' and count(parameter)=0]"
			[Register ("getColorChangesSinceLastQuery", "()I", "GetGetColorChangesSinceLastQueryHandler")]
			get {
				if (id_getColorChangesSinceLastQuery == IntPtr.Zero)
					id_getColorChangesSinceLastQuery = JNIEnv.GetStaticMethodID (class_ref, "getColorChangesSinceLastQuery", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getColorChangesSinceLastQuery);
			}
		}

		static IntPtr id_getCurrentRobotAddress;
		public static string CurrentRobotAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getCurrentRobotAddress' and count(parameter)=0]"
			[Register ("getCurrentRobotAddress", "()Ljava/lang/String;", "GetGetCurrentRobotAddressHandler")]
			get {
				if (id_getCurrentRobotAddress == IntPtr.Zero)
					id_getCurrentRobotAddress = JNIEnv.GetStaticMethodID (class_ref, "getCurrentRobotAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentRobotAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getOAuth;
		public static string OAuth {
			// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getOAuth' and count(parameter)=0]"
			[Register ("getOAuth", "()Ljava/lang/String;", "GetGetOAuthHandler")]
			get {
				if (id_getOAuth == IntPtr.Zero)
					id_getOAuth = JNIEnv.GetStaticMethodID (class_ref, "getOAuth", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOAuth), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_achievementCollisionEnabled_ZLorbotix_sphero_Sphero_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='achievementCollisionEnabled' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='orbotix.sphero.Sphero']]"
		[Register ("achievementCollisionEnabled", "(ZLorbotix/sphero/Sphero;)V", "")]
		public static void AchievementCollisionEnabled (bool p0, global::Orbotix.Sphero.Sphero p1)
		{
			if (id_achievementCollisionEnabled_ZLorbotix_sphero_Sphero_ == IntPtr.Zero)
				id_achievementCollisionEnabled_ZLorbotix_sphero_Sphero_ = JNIEnv.GetStaticMethodID (class_ref, "achievementCollisionEnabled", "(ZLorbotix/sphero/Sphero;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_achievementCollisionEnabled_ZLorbotix_sphero_Sphero_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_boosted_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='boosted' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("boosted", "(F)V", "")]
		public static void Boosted (float p0)
		{
			if (id_boosted_F == IntPtr.Zero)
				id_boosted_F = JNIEnv.GetStaticMethodID (class_ref, "boosted", "(F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_boosted_F, new JValue (p0));
		}

		static IntPtr id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='collisionDetected' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.CollisionDetectedAsyncData']]"
		[Register ("collisionDetected", "(Lorbotix/robot/base/CollisionDetectedAsyncData;)V", "")]
		public static void CollisionDetected (global::Orbotix.Robot.Base.CollisionDetectedAsyncData p0)
		{
			if (id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ == IntPtr.Zero)
				id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_ = JNIEnv.GetStaticMethodID (class_ref, "collisionDetected", "(Lorbotix/robot/base/CollisionDetectedAsyncData;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_collisionDetected_Lorbotix_robot_base_CollisionDetectedAsyncData_, new JValue (p0));
		}

		static IntPtr id_doUpdateSpheroName;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='doUpdateSpheroName' and count(parameter)=0]"
		[Register ("doUpdateSpheroName", "()V", "")]
		public static void DoUpdateSpheroName ()
		{
			if (id_doUpdateSpheroName == IntPtr.Zero)
				id_doUpdateSpheroName = JNIEnv.GetStaticMethodID (class_ref, "doUpdateSpheroName", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_doUpdateSpheroName);
		}

		static IntPtr id_earnedAchievement_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='earnedAchievement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("earnedAchievement", "(Ljava/lang/String;)V", "")]
		public static void EarnedAchievement (string p0)
		{
			if (id_earnedAchievement_Ljava_lang_String_ == IntPtr.Zero)
				id_earnedAchievement_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "earnedAchievement", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_earnedAchievement_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_generateUUID;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='generateUUID' and count(parameter)=0]"
		[Register ("generateUUID", "()Ljava/lang/String;", "")]
		public static string GenerateUUID ()
		{
			if (id_generateUUID == IntPtr.Zero)
				id_generateUUID = JNIEnv.GetStaticMethodID (class_ref, "generateUUID", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateUUID), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getEventCount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='getEventCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEventCount", "(Ljava/lang/String;)I", "")]
		public static int GetEventCount (string p0)
		{
			if (id_getEventCount_Ljava_lang_String_ == IntPtr.Zero)
				id_getEventCount_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getEventCount", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getEventCount_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_gotNewSpheroName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='gotNewSpheroName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("gotNewSpheroName", "(Ljava/lang/String;)V", "")]
		public static void GotNewSpheroName (string p0)
		{
			if (id_gotNewSpheroName_Ljava_lang_String_ == IntPtr.Zero)
				id_gotNewSpheroName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "gotNewSpheroName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_gotNewSpheroName_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_gotRobotAddress_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='gotRobotAddress' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("gotRobotAddress", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void GotRobotAddress (string p0, string p1)
		{
			if (id_gotRobotAddress_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_gotRobotAddress_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "gotRobotAddress", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_gotRobotAddress_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_loadedToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='loadedToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadedToken", "(Ljava/lang/String;)V", "")]
		public static void LoadedToken (string p0)
		{
			if (id_loadedToken_Ljava_lang_String_ == IntPtr.Zero)
				id_loadedToken_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadedToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_loadedToken_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_logStatsForCommand_Lorbotix_robot_internal_DeviceCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='logStatsForCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.internal.DeviceCommand']]"
		[Register ("logStatsForCommand", "(Lorbotix/robot/internal/DeviceCommand;)V", "")]
		public static void LogStatsForCommand (global::Orbotix.Robot.Internal.DeviceCommand p0)
		{
			if (id_logStatsForCommand_Lorbotix_robot_internal_DeviceCommand_ == IntPtr.Zero)
				id_logStatsForCommand_Lorbotix_robot_internal_DeviceCommand_ = JNIEnv.GetStaticMethodID (class_ref, "logStatsForCommand", "(Lorbotix/robot/internal/DeviceCommand;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logStatsForCommand_Lorbotix_robot_internal_DeviceCommand_, new JValue (p0));
		}

		static IntPtr id_macroDetected;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='macroDetected' and count(parameter)=0]"
		[Register ("macroDetected", "()V", "")]
		public static void MacroDetected ()
		{
			if (id_macroDetected == IntPtr.Zero)
				id_macroDetected = JNIEnv.GetStaticMethodID (class_ref, "macroDetected", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_macroDetected);
		}

		static IntPtr id_makeWSCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='makeWSCall' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("makeWSCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void MakeWSCall (string p0, string p1, string p2, string p3, string p4)
		{
			if (id_makeWSCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeWSCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "makeWSCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_makeWSCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "")]
		public static void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetStaticMethodID (class_ref, "onStop", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onStop);
		}

		static IntPtr id_recordEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='recordEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("recordEvent", "(Ljava/lang/String;)V", "")]
		public static void RecordEvent (string p0)
		{
			if (id_recordEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_recordEvent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "recordEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_recordEvent_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_recordEvent_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='recordEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("recordEvent", "(Ljava/lang/String;I)V", "")]
		public static void RecordEvent (string p0, int p1)
		{
			if (id_recordEvent_Ljava_lang_String_I == IntPtr.Zero)
				id_recordEvent_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "recordEvent", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_recordEvent_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_registerRGBCommand_Lorbotix_robot_base_RGBLEDOutputCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='registerRGBCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RGBLEDOutputCommand']]"
		[Register ("registerRGBCommand", "(Lorbotix/robot/base/RGBLEDOutputCommand;)V", "")]
		public static void RegisterRGBCommand (global::Orbotix.Robot.Base.RGBLEDOutputCommand p0)
		{
			if (id_registerRGBCommand_Lorbotix_robot_base_RGBLEDOutputCommand_ == IntPtr.Zero)
				id_registerRGBCommand_Lorbotix_robot_base_RGBLEDOutputCommand_ = JNIEnv.GetStaticMethodID (class_ref, "registerRGBCommand", "(Lorbotix/robot/base/RGBLEDOutputCommand;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerRGBCommand_Lorbotix_robot_base_RGBLEDOutputCommand_, new JValue (p0));
		}

		static IntPtr id_registerRollCommand_Lorbotix_robot_base_RollCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='registerRollCommand' and count(parameter)=1 and parameter[1][@type='orbotix.robot.base.RollCommand']]"
		[Register ("registerRollCommand", "(Lorbotix/robot/base/RollCommand;)V", "")]
		public static void RegisterRollCommand (global::Orbotix.Robot.Base.RollCommand p0)
		{
			if (id_registerRollCommand_Lorbotix_robot_base_RollCommand_ == IntPtr.Zero)
				id_registerRollCommand_Lorbotix_robot_base_RollCommand_ = JNIEnv.GetStaticMethodID (class_ref, "registerRollCommand", "(Lorbotix/robot/base/RollCommand;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerRollCommand_Lorbotix_robot_base_RollCommand_, new JValue (p0));
		}

		static IntPtr id_setToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setToken", "(Ljava/lang/String;)V", "")]
		public static void SetToken (string p0)
		{
			if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
				id_setToken_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setToken_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setupApplication_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='setupApplication' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("setupApplication", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static void SetupApplication (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_setupApplication_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_setupApplication_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setupApplication", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setupApplication_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_wsCallLoaded_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='orbotix.achievement']/class[@name='AchievementManager']/method[@name='wsCallLoaded' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("wsCallLoaded", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public static void WsCallLoaded (string p0, string p1, string p2, string p3, int p4)
		{
			if (id_wsCallLoaded_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_wsCallLoaded_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "wsCallLoaded", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_wsCallLoaded_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
