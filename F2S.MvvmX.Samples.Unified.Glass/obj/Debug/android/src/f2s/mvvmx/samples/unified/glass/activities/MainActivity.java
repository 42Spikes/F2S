package f2s.mvvmx.samples.unified.glass.activities;


public class MainActivity
	extends f2s.tinymvx.glass.MvxActivityView_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Samples.Unified.Glass.Activities.MainActivity, F2S.MvvmX.Samples.Unified.Glass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Samples.Unified.Glass.Activities.MainActivity, F2S.MvvmX.Samples.Unified.Glass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
