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
            Button addstory = FindViewById<Button>(Resource.Id.button5);
            Button site = FindViewById<Button>(Resource.Id.button4);

            
            search.Click += delegate 
            {
                SetContentView(Resource.Layout.Search);
            };
            view.Click +=delegate 
            {
                SetContentView(Resource.Layout.ListView);
                                
            };
            addstory.Click += delegate 
            {
                SetContentView(Resource.Layout.AddStory);
            };
            
            random.Click += delegate 
            { 
                SetContentView(Resource.Layout.Read); 
            };
            // Sends the User to the Crickey Cottage Website
            site.Click += delegate 
            {
                SetContentView(Resource.Layout.Site);
                Android.Webkit.WebView.FindAddress("www.crickeycottage.com.au");
            }; 
        }      
    }
}

