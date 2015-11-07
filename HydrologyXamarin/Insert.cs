using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HydrologyXamarin.ORM;
using Android.Locations;

namespace HydrologyXamarin
{
    [Activity(Label = "Insert")]
    public class Insert : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
           // SetContentView(Resource.Layout.wellReadingLayout);

            
        }
        private void addClick(Object sender, EventArgs e)
        {
            //EditText edit = FindViewById<EditText>(Resource.Id.editText1);
            //DBRepository dbr = new DBRepository();
            ////string result = dbr.insertRecord(edit.Text);
            //Toast.MakeText(this, result, ToastLength.Short).Show();
        }
    }
}