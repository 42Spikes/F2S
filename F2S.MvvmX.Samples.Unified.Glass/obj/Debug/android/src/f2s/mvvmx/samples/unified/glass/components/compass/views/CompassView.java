package f2s.mvvmx.samples.unified.glass.components.compass.views;


public class CompassView
	extends f2s.mvvmx.samples.unified.glass.framework.MvxLiveCardView
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Views.CompassView, F2S.MvvmX.Samples.Unified.Glass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CompassView.class, __md_methods);
	}


	public CompassView (android.content.Context p0, java.lang.String p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == CompassView.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Views.CompassView, F2S.MvvmX.Samples.Unified.Glass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
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
