package f2s.mvvmx.glass.compass.droid;


public class CompassService
	extends android.app.Service
	implements
		mono.android.IGCUserPeer,
		android.speech.tts.TextToSpeech.OnInitListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:()V:GetOnCreateHandler\n" +
			"n_onBind:(Landroid/content/Intent;)Landroid/os/IBinder;:GetOnBind_Landroid_content_Intent_Handler\n" +
			"n_onUnbind:(Landroid/content/Intent;)Z:GetOnUnbind_Landroid_content_Intent_Handler\n" +
			"n_onStartCommand:(Landroid/content/Intent;II)I:GetOnStartCommand_Landroid_content_Intent_IIHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onInit:(I)V:GetOnInit_IHandler:Android.Speech.Tts.TextToSpeech/IOnInitListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Glass.Compass.Droid.CompassService, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CompassService.class, __md_methods);
	}


	public CompassService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CompassService.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.Compass.Droid.CompassService, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate ()
	{
		n_onCreate ();
	}

	private native void n_onCreate ();


	public android.os.IBinder onBind (android.content.Intent p0)
	{
		return n_onBind (p0);
	}

	private native android.os.IBinder n_onBind (android.content.Intent p0);


	public boolean onUnbind (android.content.Intent p0)
	{
		return n_onUnbind (p0);
	}

	private native boolean n_onUnbind (android.content.Intent p0);


	public int onStartCommand (android.content.Intent p0, int p1, int p2)
	{
		return n_onStartCommand (p0, p1, p2);
	}

	private native int n_onStartCommand (android.content.Intent p0, int p1, int p2);


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onInit (int p0)
	{
		n_onInit (p0);
	}

	private native void n_onInit (int p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
