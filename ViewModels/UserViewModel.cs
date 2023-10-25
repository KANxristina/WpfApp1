using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class UserViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<UserModel> userList;
        public ObservableCollection<UserModel> UserList {
            get { return userList; }
            set
            {
                userList = value;
                OnPropertyChanged("UserList");
            }
        }



        public void FindUsers()
        {
        ObservableCollection<UserModel> list = new ObservableCollection<UserModel>
            {
                new UserModel{ FirstName="Elena", LastName="Kanaki" }
            };
            UserList=list;

        }
        
       public void AddUser(string firstName, string lastName)
        {
            FindUsers();
            List<UserModel> list = new List<UserModel>
            {
                new UserModel{ FirstName=firstName, LastName=lastName }
            };
            foreach (var user in list)
            {

                UserList.Add(user);
            }
            
        }
        public void RemoveUser(string firstName, string lastName)
        {
            FindUsers();
            List<UserModel> list = new List<UserModel>
            {
                new UserModel{ FirstName=firstName, LastName=lastName }
            };
            foreach (var user in UserList)
            {
                if(UserList.Contains(user))
                UserList.Remove(user);
            }

        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
