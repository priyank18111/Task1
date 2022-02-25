using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Task1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        Button Registerbtn,loginbtn;
        ImageView fb, google;
        TextView forget,createact,registername;
        
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login_Screen);
            UIReference();
            UIClickEvents();

          
        }
        private void UIReference()
        {
            Registerbtn = FindViewById<Button>(Resource.Id.registerbutton);
            fb = FindViewById<ImageView>(Resource.Id.facebook);
            google = FindViewById<ImageView>(Resource.Id.google);
            forget = FindViewById<TextView>(Resource.Id.forget);
            createact = FindViewById<TextView>(Resource.Id.createaccounttext);
            loginbtn = FindViewById<Button>(Resource.Id.loginbutton);
            registername = FindViewById<TextView>(Resource.Id.name);
        }
        private void UIClickEvents()
        {
            Registerbtn.Click += Registerbtn_Click;
            fb.Click += Fb_Click;
            google.Click += Google_Click;
            forget.Click += Forget_Click;
            createact.Click += Createact_Click;
            loginbtn.Click += Loginbtn_Click;
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "successfully login", ToastLength.Short).Show();
        }

        private void Createact_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Register_activity));
        }

        private void Forget_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "new password created", ToastLength.Short).Show();
        }

        private void Google_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Google", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Facebook", ToastLength.Short).Show();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Register_activity));

        }

        
    }
}