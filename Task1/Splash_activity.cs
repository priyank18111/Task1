using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [Activity(Label = "Splash_activity", MainLauncher = true, Theme = "@style/MyTheme.Splash", NoHistory = true)]
    public class Splash_activity : Activity
    {
        ImageView image;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Splashs);

        }  // Create your application here
       protected override async void OnResume()
        {

            base.OnResume();
            await SimulateStartup();

        }

        async Task SimulateStartup()
        {
            image = FindViewById<ImageView>(Resource.Id.imageView);
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.Fade);
            image.StartAnimation(animation);
            await Task.Delay(TimeSpan.FromSeconds(3));
            Intent intent = new Intent(Application.Context, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}