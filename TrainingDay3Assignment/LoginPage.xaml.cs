using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingDay3Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(uName.Text == "admin" && pass.Text == "admin")
            {
                DisplayAlert("Login Success", "Success", "OK");
                uName.Text = null; pass.Text = null;


            }
            else 
            {
                DisplayAlert("Login Failed", "Login Failed! Try again.", "OK");

                uName.Text = null; pass.Text = null;


            }
        }
    }
}