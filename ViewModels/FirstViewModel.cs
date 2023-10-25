using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class FirstViewModel
    {
        public FirstModel FirstModel;
        private bool RandomBoolean()
        {
            Random random = new Random();
            bool randomBool = random.Next(2)==1;
           // FirstModel.IsTrue= randomBool;
            return randomBool;
        }
        public void FindColor()
        {
            FirstModel = new FirstModel();
           bool x= RandomBoolean();
            if (x == true)
            {
                FirstModel.IsTrue = true;
                FirstModel.Color = ConsoleColor.Green.ToString();
                FirstModel.LabelText = "connected";
            }
            else
            {
                FirstModel.IsTrue = false;
                FirstModel.Color = ConsoleColor.Red.ToString();
                FirstModel.LabelText = "disconnected";
                
            }
        }
        

        
        
    }

}
