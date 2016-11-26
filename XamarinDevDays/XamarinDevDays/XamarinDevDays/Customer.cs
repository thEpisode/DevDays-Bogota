using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDevDays
{
    public class Customer : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;
        private string _address;
        private string _city;
        private string _state;
        private string _zip;

        private string _result;
        
        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if(value != _firstname)
                {
                    _firstname = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("HasValidInput");
                }
            }
        }
        

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value != _lastname)
                {
                    _lastname = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("HasValidInput");
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value != _address)
                {
                    _address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (value != _city)
                {
                    _city = value;
                    OnPropertyChanged("City");
                }
            }
        }

        public string State
        {
            get { return _state; }
            set
            {
                if (value != _state)
                {
                    _state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        public string Zip
        {
            get { return _zip; }
            set
            {
                if (value != _zip)
                {
                    _zip = value;
                    OnPropertyChanged("Zip");
                }
            }
        }

        public string Result
        {
            get { return _result; }
            set
            {
                if (value != _result)
                {
                    _result = value;
                    OnPropertyChanged("Result");
                }
            }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
