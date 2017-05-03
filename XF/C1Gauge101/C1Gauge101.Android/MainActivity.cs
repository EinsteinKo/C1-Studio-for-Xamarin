﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using XAM = Xamarin.Forms;

using Xamarin.Forms.Platform.Android;

namespace GaugeDemo.Droid
{
    [Activity(Label = "C1Gauge101", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::C1.Xamarin.Forms.Gauge.Platform.Android.C1GaugeRenderer.Init();

            LoadApplication(new C1Gauge101.App());
        }
    }
}

