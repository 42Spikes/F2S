package f2s.mvvmx.sphero.ui.droid.views;


public class MainSpheroView
	extends cirrious.mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Sphero.UI.Droid.Views.MainSpheroView, F2S.MvvmX.Sphero.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainSpheroView.class, __md_methods);
	}


	public MainSpheroView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainSpheroView.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Sphero.UI.Droid.Views.MainSpheroView, F2S.MvvmX.Sphero.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
