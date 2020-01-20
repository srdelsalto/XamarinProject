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
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lblUser.TextColor = Constants.MainTextColor;
            lblPassword.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            txtUser.Completed += (sender, e) => txtPassword.Focus();
            txtPassword.Completed += (sender, e) => LoginProcedure(sender, e);
        }
        void SignInProcedure(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInPage());
        }

        void LoginProcedure(object sender, EventArgs e)
        {
            LoginController LoginCont = new LoginController();
            User EspeUser = new User(txtUser.Text, txtPassword.Text);

            if (LoginCont.CheckInformation(EspeUser))
            {
                DisplayAlert("Login", "Inicio de Sesión Correcto", "OK");
                Navigation.PushAsync(new MenuPage());
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