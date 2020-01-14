using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuggestionESPE.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SuggestionESPE.Controllers;

namespace SuggestionESPE.Interfaces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private const string PageTitle = "Login";

        public LoginPage()
        {
            InitializeComponent();
            Title = PageTitle;
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            LoginController LoginCont = new LoginController();
            User EspeUser = new User(txtUser.Text, txtPassword.Text);

            if (LoginCont.CheckInformation(EspeUser))
            {
                DisplayAlert("-"+EspeUser.UserName+"-", "Inicio de Sesión Correcto", "OK");
            }
            else
            {
                DisplayAlert("Login", "Inicio de Sesión Incorrecto", "OK");
                RestartData();
            }
            EspeUser = null;
        }

        void RestartData()
        {
            txtPassword.Text = ""; txtUser.Text = "";
        }
    }
}