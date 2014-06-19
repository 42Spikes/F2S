package f2s.mvvmx.glass.livecardapidemo.droid;


public class myrunner
	extends f2s.mvvmx.glass.livecardapidemo.droid.framework.ServiceRunner_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Glass.LiveCardApiDemo.Droid.myrunner, F2S.MvvmX.Glass.LiveCardApiDemo.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", myrunner.class, __md_methods);
	}


	public myrunner () throws java.lang.Throwable
	{
		super ();
		if (getClass () == myrunner.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.LiveCardApiDemo.Droid.myrunner, F2S.MvvmX.Glass.LiveCardApiDemo.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
