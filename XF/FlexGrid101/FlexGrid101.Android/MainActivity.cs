﻿using Android.App;
using Android.OS;
using Android.Content.PM;

namespace FlexGrid101.Android
{
    [Activity(Label = "FlexGrid101", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new FlexGrid101.App());
        }
    }
}

