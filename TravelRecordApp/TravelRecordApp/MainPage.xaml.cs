using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty= string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEntry = string.IsNullOrEmpty(passwordEntry.Text);

            if(isEmailEmpty || isPasswordEntry)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
            
        }
    }
}
