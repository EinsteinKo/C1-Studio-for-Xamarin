﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using XAM = Xamarin.Forms;

using Xamarin.Forms.Platform.Android;

namespace C1Calendar101.Droid
{
    [Activity(Label = "C1Calendar101", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new C1Calendar101.App());
        }
    }
}

