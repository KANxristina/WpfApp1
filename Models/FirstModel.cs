using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class FirstModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private bool isTrue;
        private string color;
        private string labelText;
        public bool IsTrue
        {
            get { return isTrue; }
            set
            {
                isTrue = value;
               
            }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;

                OnPropertyRaised("LabelText");
            }
        }
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

    }
}
