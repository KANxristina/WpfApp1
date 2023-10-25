using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class UserModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string firstName;
        private string lastName;
        
        public string FirstName
        {
            get { return firstName; }
            set
            { 
                firstName = value;
                OnPropertyRaised("FirstName");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                OnPropertyRaised("LastName");
            }
          
        }

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
