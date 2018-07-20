using MvvmCross.Core.ViewModels;
using RestaurantBilling.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBilling.Core
{
    /// <summary>
    /// This class is used to customize how the application starts
    /// and which view is loaded on start.
    /// </summary>
    class CustomAppStart : MvxNavigatingObject, IMvxAppStart
    {
        /// <summary>
        /// Hint can take command-line startup parameters, and then pass them to the called view models.
        /// </summary>
        /// <param name="hint"></param>
        public void Start(object hint = null)
        {
            // ShowViewModel is a core navigation mechanism in MvvmCross.
            // for now, just start the regular MainMenuViewModel view.
            ShowViewModel<MainMenuViewModel>();
        }
    }
}
