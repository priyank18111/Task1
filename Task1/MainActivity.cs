using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Text.RegularExpressions;

namespace Task1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false,NoHistory =true)]
    public class MainActivity : AppCompatActivity
    {
        Button Registerbtn,loginbtn;
        ImageView fb, google;
        TextView forget,createact,login;
        EditText usernametext, passwordtext;
        private Regex username = new Regex("^[a-z-A-Z]*$");
       


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
            login = FindViewById<TextView>(Resource.Id.name);
            usernametext = FindViewById<EditText>(Resource.Id.usernamelogintext);
            passwordtext = FindViewById<EditText>(Resource.Id.passwordlogintext);
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


        private bool usernameok()
        {
            if (usernametext.Text.Length == 0)
            {

                usernametext.Error = "Enter Username";
                return false;

            }
            else if (!isValidateUsername(usernametext.Text))

            {
                usernametext.Error = "Numbers are not allowed";
                return false;
            }
            return true;

        }
        private bool isValidateUsername(string text)
        {
            if (string.IsNullOrEmpty(text))

                return false;


            return username.IsMatch(text);

        }
        private bool passwordok()
        {
            var length1 = passwordtext.Length();
            if (passwordtext.Text.Length < 8)
            {
                Toast.MakeText(this, "password of user is empty or less than 8", ToastLength.Long).Show();
                passwordtext.Error = "password of the user is should not be less than 8";
                return false;
            }
            else
                return true;
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (!usernameok() &&  !passwordok())
            {
                Toast.MakeText(this, "please enter valid details", ToastLength.Long).Show();
                return;
            }

            if (usernameok() && passwordok())
            {
                Toast.MakeText(this, "user successfully logged in", ToastLength.Long).Show();


            }
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