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
    /// Interaction logic for FirstView.xaml
    /// </summary>
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
        }
       private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            FirstViewModel firstViewModel = new FirstViewModel();           
            firstViewModel.FindColor();
            label1.Content = firstViewModel.FirstModel.LabelText;
            var color=firstViewModel.FirstModel.Color;
            label1.Foreground = (Brush)new BrushConverter().ConvertFromString(color);
            txtIsTrue.Text = firstViewModel.FirstModel.IsTrue.ToString();
            txtText.Text= firstViewModel.FirstModel.Color;
        }
    }
}
