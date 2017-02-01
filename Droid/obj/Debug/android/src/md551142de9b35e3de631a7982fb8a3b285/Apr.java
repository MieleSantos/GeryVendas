package md551142de9b35e3de631a7982fb8a3b285;


public class Apr
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("GeryVendas.Droid.Apr, GeryVendas.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Apr.class, __md_methods);
	}


	public Apr () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Apr.class)
			mono.android.TypeManager.Activate ("GeryVendas.Droid.Apr, GeryVendas.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
