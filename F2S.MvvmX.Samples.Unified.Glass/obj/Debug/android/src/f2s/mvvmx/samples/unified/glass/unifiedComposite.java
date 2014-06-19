package f2s.mvvmx.samples.unified.glass;


public class unifiedComposite
	extends f2s.mvvmx.samples.unified.glass.framework.MvxServiceRunner_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:()V:GetOnCreateHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Samples.Unified.Glass.unifiedComposite, F2S.MvvmX.Samples.Unified.Glass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", unifiedComposite.class, __md_methods);
	}


	public unifiedComposite () throws java.lang.Throwable
	{
		super ();
		if (getClass () == unifiedComposite.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Samples.Unified.Glass.unifiedComposite, F2S.MvvmX.Samples.Unified.Glass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate ()
	{
		n_onCreate ();
	}

	private native void n_onCreate ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();

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
