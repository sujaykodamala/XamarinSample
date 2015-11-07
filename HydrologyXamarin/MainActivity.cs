using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HydrologyXamarin.ORM;


namespace HydrologyXamarin
{
   [Activity(Label = "MainActivity",MainLauncher=true)]
    
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Android.Resource.Layout.

            // Get our button from the layout resource,
            // and attach an event to it
            //var Create = FindViewById<Button>(Resource.Id.Add);
           
            //Create.Click += OncreateClicked;
            //var table = FindViewById<Button>(Resource.Id.createTable);
            //table.Click += TableCreate;
            //var insert = FindViewById<Button>(Resource.Id.inserting);
            //insert.Click += insertclicked;
        }
        void insertclicked(object sender, EventArgs e)
        {
            StartActivity(typeof(Insert));
        }
     void OncreateClicked(object sender,EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.CreateDb();
            Toast.MakeText(this,result, ToastLength.Short).Show();
        }
     void TableCreate(object sender, EventArgs e)
   {
       DBRepository dbr = new DBRepository();
       var result = dbr.CreateTable();
       Toast.MakeText(this, result, ToastLength.Short).Show();
   }
    }
}

