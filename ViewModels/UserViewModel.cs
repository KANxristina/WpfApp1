using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class UserViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<UserModel> userList;
        public UserViewModel()
        {
            InitializeList();
            userList = UserList;
            //userList=new ObservableCollection<UserModel>();
            userList.CollectionChanged += UserList_CollectionChanged;
        }
        private void UserList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("UserList");
        }
        public ObservableCollection<UserModel> UserList {
            get  {return userList; }
            set
            {
                userList = value;
                OnPropertyChanged("UserList");
            }
        }


        public void InitializeList()
        {
            ObservableCollection<UserModel> list = new ObservableCollection<UserModel>
            {
                new UserModel{ FirstName="Elena", LastName="Kanaki" }
            };
            UserList = list;
        }
        public ObservableCollection<UserModel> FindUsers()
        {
            InitializeList();
            return UserList;

        }
        
       public ObservableCollection<UserModel> AddUser(string firstName, string lastName)
        {
            //FindUsers();
            List<UserModel> list = new List<UserModel>
            {
                new UserModel{ FirstName=firstName, LastName=lastName }
            };
            foreach (var user in list)
            {

                UserList.Add(user);
            }
            return UserList;
            
        }
        public ObservableCollection<UserModel> RemoveUser(string firstName, string lastName)
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
            return UserList;
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
