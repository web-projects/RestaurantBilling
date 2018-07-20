using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RestaurantBilling.Core.ViewModels
{
    class MainMenuViewModel : MvxViewModel
    {
        /// <summary>
        /// Provides command-based navigation to a Bill views through
        /// the use of the BillViewModel.  In this example, we supply
        /// the view model with a default bill sub-total of 40, which
        /// is picked up by the overriden Init method.
        /// </summary>
        public ICommand NavigateCreateBill
        {
            get
            {
                // Navigation Note:
                // Must add following value to Assembly.cs for any Windows projects
                // [assembly: InternalsVisibleTo("Cirrious.MvvmCross")]
                return new MvxCommand(() =>
                    ShowViewModel<BillViewModel>(new { subTotal = 40 }));
            }
        }
    }
}