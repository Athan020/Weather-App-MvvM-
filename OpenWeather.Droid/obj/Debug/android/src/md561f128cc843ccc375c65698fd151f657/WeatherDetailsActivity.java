package md561f128cc843ccc375c65698fd151f657;


public class WeatherDetailsActivity
	extends md561f128cc843ccc375c65698fd151f657.BaseActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OpenWeather.Droid.Views.activities.WeatherDetailsActivity, OpenWeather.Droid", WeatherDetailsActivity.class, __md_methods);
	}


	public WeatherDetailsActivity ()
	{
		super ();
		if (getClass () == WeatherDetailsActivity.class)
			mono.android.TypeManager.Activate ("OpenWeather.Droid.Views.activities.WeatherDetailsActivity, OpenWeather.Droid", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
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
