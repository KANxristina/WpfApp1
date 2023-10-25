using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        private UserViewModel userViewModel;
        public UserView()
        {
            InitializeComponent();
             userViewModel = new UserViewModel();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.AddUser(txtFirstName.Text, txtLastName.Text);
            
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.RemoveUser(txtFirstName.Text, txtLastName.Text);
        }
     
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            
            cbUsers.GetBindingExpression(ComboBox.ItemsSourceProperty).UpdateTarget();
           var x= userViewModel.UserList;
        }
    }
}
