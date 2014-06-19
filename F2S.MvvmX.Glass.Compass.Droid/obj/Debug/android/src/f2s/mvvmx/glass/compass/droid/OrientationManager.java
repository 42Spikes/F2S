package f2s.mvvmx.glass.compass.droid;


public class OrientationManager
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.hardware.SensorEventListener,
		android.location.LocationListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAccuracyChanged:(Landroid/hardware/Sensor;I)V:GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler:Android.Hardware.ISensorEventListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onSensorChanged:(Landroid/hardware/SensorEvent;)V:GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler:Android.Hardware.ISensorEventListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onLocationChanged:(Landroid/location/Location;)V:GetOnLocationChanged_Landroid_location_Location_Handler:Android.Locations.ILocationListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onProviderDisabled:(Ljava/lang/String;)V:GetOnProviderDisabled_Ljava_lang_String_Handler:Android.Locations.ILocationListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onProviderEnabled:(Ljava/lang/String;)V:GetOnProviderEnabled_Ljava_lang_String_Handler:Android.Locations.ILocationListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onStatusChanged:(Ljava/lang/String;ILandroid/os/Bundle;)V:GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler:Android.Locations.ILocationListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("F2S.MvvmX.Glass.Compass.Droid.OrientationManager, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OrientationManager.class, __md_methods);
	}


	public OrientationManager () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OrientationManager.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.Compass.Droid.OrientationManager, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public OrientationManager (android.hardware.SensorManager p0, android.location.LocationManager p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == OrientationManager.class)
			mono.android.TypeManager.Activate ("F2S.MvvmX.Glass.Compass.Droid.OrientationManager, F2S.MvvmX.Glass.Compass.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Hardware.SensorManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Locations.LocationManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public void onAccuracyChanged (android.hardware.Sensor p0, int p1)
	{
		n_onAccuracyChanged (p0, p1);
	}

	private native void n_onAccuracyChanged (android.hardware.Sensor p0, int p1);


	public void onSensorChanged (android.hardware.SensorEvent p0)
	{
		n_onSensorChanged (p0);
	}

	private native void n_onSensorChanged (android.hardware.SensorEvent p0);


	public void onLocationChanged (android.location.Location p0)
	{
		n_onLocationChanged (p0);
	}

	private native void n_onLocationChanged (android.location.Location p0);


	public void onProviderDisabled (java.lang.String p0)
	{
		n_onProviderDisabled (p0);
	}

	private native void n_onProviderDisabled (java.lang.String p0);


	public void onProviderEnabled (java.lang.String p0)
	{
		n_onProviderEnabled (p0);
	}

	private native void n_onProviderEnabled (java.lang.String p0);


	public void onStatusChanged (java.lang.String p0, int p1, android.os.Bundle p2)
	{
		n_onStatusChanged (p0, p1, p2);
	}

	private native void n_onStatusChanged (java.lang.String p0, int p1, android.os.Bundle p2);

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
