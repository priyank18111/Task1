using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    [Activity(Label = "Register_activity")]
    public class Register_activity : Activity
    {
        Button homebtn;
        ImageView fb, google;
        TextInputLayout name, email, username, password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register_screen);
            UIReferences();
            UIClickEvents();
        }
        private void UIReferences()
        {
            homebtn = FindViewById<Button>(Resource.Id.registerbutton);
            fb = FindViewById<ImageView>(Resource.Id.facebook);
            google = FindViewById<ImageView>(Resource.Id.google);
            name = FindViewById<TextInputLayout>(Resource.Id.entername);
            email = FindViewById<TextInputLayout>(Resource.Id.emailcontainer);
            username = FindViewById<TextInputLayout>(Resource.Id.username);
            password = FindViewById<TextInputLayout>(Resource.Id.passwordcontainer);

        }
        private void UIClickEvents()
        {
            homebtn.Click += Homebtn_Click;
            fb.Click += Fb_Click;
            
            google.Click += Google_Click;
        }

     

        private void Google_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Google", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "facebook", ToastLength.Short).Show();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
            Toast.MakeText(this, "Register Successfully", ToastLength.Short).Show();
        }

        
    }
}