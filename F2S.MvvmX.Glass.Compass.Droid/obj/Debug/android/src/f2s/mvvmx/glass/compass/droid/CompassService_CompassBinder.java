package f2s.mvvmx.glass.compass.droid;


public class CompassService_CompassBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Glass.Compass.Droid.CompassService/CompassBinder, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CompassService_CompassBinder.class, __md_methods);
	}


	public CompassService_CompassBinder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CompassService_CompassBinder.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.Compass.Droid.CompassService/CompassBinder, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CompassService_CompassBinder (f2s.mvvmx.glass.compass.droid.CompassService p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CompassService_CompassBinder.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.Compass.Droid.CompassService/CompassBinder, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "F2S.MvvmX.Glass.Compass.Droid.CompassService, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
