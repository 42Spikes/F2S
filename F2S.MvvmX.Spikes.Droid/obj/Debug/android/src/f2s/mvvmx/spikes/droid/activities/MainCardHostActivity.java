package f2s.mvvmx.spikes.droid.activities;


public class MainCardHostActivity
	extends cirrious.mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Spikes.Droid.Activities.MainCardHostActivity, F2S.MvvmX.Spikes.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainCardHostActivity.class, __md_methods);
	}


	public MainCardHostActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainCardHostActivity.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Spikes.Droid.Activities.MainCardHostActivity, F2S.MvvmX.Spikes.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
