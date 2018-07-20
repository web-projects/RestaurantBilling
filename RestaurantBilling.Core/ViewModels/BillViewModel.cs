using MvvmCross.Core.ViewModels;
using RestaurantBilling.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RestaurantBilling.Core.ViewModels
{
    /// <summary>
    /// All view models should inherit from MvxViewModel in MVVMCross
    /// </summary>
    public class BillViewModel : MvxViewModel
    {
        readonly IBillCalculator _calculation;
        private string _customerEmail;
        double _subTotal;
        int _gratuity;
        double _tip;
        double _total;

        /// <summary>
        /// Used to implement button commanding for navigation.
        /// </summary>
        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        public string CustomerEmail
        {
            get { return _customerEmail; }
            set
            {
                _customerEmail = value;

                // This notifies the framework when a change occurs.
                // It is required for any data bound properties that are updated.
                RaisePropertyChanged(() => CustomerEmail);
            }
        }

        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        public int Gratuity
        {
            get { return _gratuity; }
            set
            {
                _gratuity = value;
                RaisePropertyChanged(() => Gratuity);
                Recalculate();
            }
        }

        public double Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        public double Total
        {
            get { return _total; }
            set
            {
                _total = value;
                RaisePropertyChanged(() => Total);
            }
        }

        /// <summary>
        /// Use constructor injection to supply _calculation with the implementation.
        /// </summary>
        public BillViewModel(IBillCalculator calculation)
        {
            _calculation = calculation;
        }

        /// <summary>
        /// Demonstrates the ability to pass parameters to MvvmCross view models.
        /// </summary>
        /// <param name="subTotal">The bill sub-total.</param>
        public void Init(int subTotal)
        {
            SubTotal = subTotal;
        }

        /// <summary>
        /// Override the start method to perform view model initialization.
        /// </summary>
        public override void Start()
        {
            _gratuity = 10;
            Recalculate();
            base.Start();
        }

        /// <summary>
        /// Use the bill calculator to calculate the tip and total.
        /// </summary>
        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Gratuity);
            Total = _calculation.BillTotal(SubTotal, Gratuity);
        }
    }
}