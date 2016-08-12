using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Story_Reader
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button search = FindViewById<Button>(Resource.Id.button1);
            Button view = FindViewById<Button>(Resource.Id.button2);
            Button random = FindViewById<Button>(Resource.Id.button3);

            Button site = FindViewById<Button>(Resource.Id.button4);

            search.Click += delegate {SetContentView(Resource.Layout.Search);};
            view.Click +=delegate {SetContentView(Resource.Layout.ListView);};
            random.Click += delegate { SetContentView(Resource.Layout.Read); };
            site.Click += delegate { Android.Webkit.WebView.FindAddress("www.crickeycottage.com.au");}; 
        }      
    }
}

