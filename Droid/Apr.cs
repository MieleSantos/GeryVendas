
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GeryVendas.Droid
{
	[Activity(Theme = "@style/meuTema.Theme", MainLauncher = true, NoHistory = true)]
	public class Apr : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			Thread.Sleep(4000);
			StartActivity(typeof(MainActivity));
		}
	}
}
