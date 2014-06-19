package f2s.mvvmx.glass.livecardapidemo.droid.util;


public class RenderingCallbackWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.glass.timeline.DirectRenderingCallback,
		android.view.SurfaceHolder.Callback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_renderingPaused:(Landroid/view/SurfaceHolder;Z)V:GetRenderingPaused_Landroid_view_SurfaceHolder_ZHandler:Android.Glass.Timeline.IDirectRenderingCallbackInvoker, GoogleGlassBindings\n" +
			"n_surfaceChanged:(Landroid/view/SurfaceHolder;III)V:GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler:Android.Views.ISurfaceHolderCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_surfaceCreated:(Landroid/view/SurfaceHolder;)V:GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler:Android.Views.ISurfaceHolderCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_surfaceDestroyed:(Landroid/view/SurfaceHolder;)V:GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler:Android.Views.ISurfaceHolderCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util.RenderingCallbackWrapper, F2S.MvvmX.Glass.LiveCardApiDemo.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RenderingCallbackWrapper.class, __md_methods);
	}


	public RenderingCallbackWrapper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RenderingCallbackWrapper.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util.RenderingCallbackWrapper, F2S.MvvmX.Glass.LiveCardApiDemo.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void renderingPaused (android.view.SurfaceHolder p0, boolean p1)
	{
		n_renderingPaused (p0, p1);
	}

	private native void n_renderingPaused (android.view.SurfaceHolder p0, boolean p1);


	public void surfaceChanged (android.view.SurfaceHolder p0, int p1, int p2, int p3)
	{
		n_surfaceChanged (p0, p1, p2, p3);
	}

	private native void n_surfaceChanged (android.view.SurfaceHolder p0, int p1, int p2, int p3);


	public void surfaceCreated (android.view.SurfaceHolder p0)
	{
		n_surfaceCreated (p0);
	}

	private native void n_surfaceCreated (android.view.SurfaceHolder p0);


	public void surfaceDestroyed (android.view.SurfaceHolder p0)
	{
		n_surfaceDestroyed (p0);
	}

	private native void n_surfaceDestroyed (android.view.SurfaceHolder p0);

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
