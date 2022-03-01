using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
    [Activity(Label = "Register_activity", NoHistory = true)]
    public class Register_activity : Activity
    {
        Button Registerbutton;
        ImageView fb, google;
        EditText nametext, emailtext, usernametext, passwordtext;
        TextView homebtn;
        private Regex username = new Regex("^[a-z-A-Z]*$");
        private Regex name = new Regex("^[a-z-A-Z- ]*$");

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register_screen);
            UIReferences();
            UIClickEvents();

        }
        private void UIReferences()
        {
            homebtn = FindViewById<TextView>(Resource.Id.Loginbtn);
            fb = FindViewById<ImageView>(Resource.Id.facebook);
            google = FindViewById<ImageView>(Resource.Id.google);
            nametext = FindViewById<EditText>(Resource.Id.nameEdittext);
            emailtext = FindViewById<EditText>(Resource.Id.emailEdittext);
            usernametext = FindViewById<EditText>(Resource.Id.usernameEdittext);
            Registerbutton = FindViewById<Button>(Resource.Id.registerbutton);
            passwordtext = FindViewById<EditText>(Resource.Id.passwordEdittext);
           
          

        }
        private void UIClickEvents()
        {
            homebtn.Click += Login_Click;

            fb.Click += Fb_Click;
            Registerbutton.Click += Registerbutton_Click;
            google.Click += Google_Click;
        }

        private void Registerbutton_Click(object sender, System.EventArgs e)
        {
            if (!usernameok() && !emailok() && !nameok() && !passwordok())
            {
                Toast.MakeText(this, "please enter valid details", ToastLength.Long).Show();
                return;
            }

            if (usernameok() && emailok() && nameok() && passwordok())
            {
                Toast.MakeText(this, "user successfully logged in", ToastLength.Long).Show();
                StartActivity(typeof(MainActivity));

            }
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

        private bool emailok()
        {
            bool isEmail = Regex.IsMatch(emailtext.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (emailtext.Text.Trim().Equals(""))
            {
                Toast.MakeText(this, "email of user is empty", ToastLength.Long).Show();
                emailtext.Error = "email of the user is not inserted";
                return false;
            }
            if (!isEmail)
            {
                Toast.MakeText(this, "Invalid Email", ToastLength.Long).Show();
                emailtext.Error = "Invalid email address";
                return false;
            }


            return true;
        }

        private bool nameok()
        {
            if (nametext.Text.Length == 0)
            {

                nametext.Error = "Enter Username";
                return false;

            }
            else if (!isValidatename(nametext.Text))

            {
                nametext.Error = "Numbers are not allowed";
                return false;
            }
            return true;

        }

        private bool isValidatename(string text)
        {
            if (string.IsNullOrEmpty(text))

                return false;


            return name.IsMatch(text);

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
        private void Login_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        private void Google_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Google", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "facebook", ToastLength.Short).Show();
        }

       

        
    }
}