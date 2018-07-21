using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace RestaurantBilling.UI.Droid
{
    /// <summary>
    /// MvvmCross Mods:
    /// - Uses MvxSplashScreenActivity which will start the MvvmCross framework
    /// - After init, will then use IMvxAppStart interface.
    /// </summary>
    [Activity(Label = "My App", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity() : base(Resource.Layout.View_SplashScreen)
        {

        }
    }
}