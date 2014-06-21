package f2s.glass.apidemo.theming;


public class ThemingActivity
	extends f2s.glass.apidemo.CardScrollerActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("F2S.Glass.ApiDemo.Theming.ThemingActivity, F2S.Glass.ApiDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ThemingActivity.class, __md_methods);
	}


	public ThemingActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ThemingActivity.class)
			mono.android.TypeManager.Activate ("F2S.Glass.ApiDemo.Theming.ThemingActivity, F2S.Glass.ApiDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
