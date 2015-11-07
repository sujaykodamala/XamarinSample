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
using Android;

namespace HydrologyXamarin
{
    [Activity(Label = "EntryPage")]
    public class EntryPage : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            //SetContentView(Resource.Layout.Insertion);
            //var insertWell = FindViewById<Button>(Resource.Id.AddWellInfo);
            //insertWell.Click += GoToReadingsPage;
        }
        private void GoToReadingsPage(object sender, EventArgs e)
        {
            StartActivity(typeof(WellReadingActivity));
        }
    }
}