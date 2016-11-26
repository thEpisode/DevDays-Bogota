using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinDevDays.ViewModels
{
    public class MainPageViewModel : Customer
    {
        public ICommand ShowNameCommand { get; private set; }
        public ICommand ResetFieldsCommand { get; private set; }

        public bool HasValidInput { get { return !String.IsNullOrWhiteSpace(FirstName) && !String.IsNullOrWhiteSpace(LastName); } }

        public MainPageViewModel()
        {
            ShowNameCommand = new Command(() =>
            {
                Result = "Submited Data Succesfuly";
            });

            ResetFieldsCommand = new Command(() =>
            {
                FirstName = null;
                LastName = null;
                Address = null;
                City = null;
                State = null;
                Zip = null;
            });
        }
    }
}
