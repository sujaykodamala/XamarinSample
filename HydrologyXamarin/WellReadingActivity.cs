using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HydrologyXamarin;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Locations;

namespace HydrologyXamarin
{
    [Activity(Label = "WellReading")]
    public class WellReadingActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.WellL
            //// Create your application here
            //LocationManager  locMgr;
            //locMgr = GetSystemService(Context.LocationService) as LocationManager;
            
        }
        public  void onButtonClick(Location location)
        {
            //EditText Lat = FindViewById<EditText> (Resource.Id.
            //EditText Long = FindViewById<EditText> (Resource.Id.EditLong);
            //Lat.Text = location.Latitude.ToString ();
            //Long.Text = location.Longitude.ToString ();
            //EditText Address = FindViewById<EditText>(Resource.Id.EditAddress);
            
				
        }
    }
}