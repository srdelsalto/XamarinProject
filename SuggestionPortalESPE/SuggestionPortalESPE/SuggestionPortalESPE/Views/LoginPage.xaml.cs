using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuggestionPortalESPE.Models;
using SuggestionPortalESPE.API;
using SuggestionPortalESPE.Controller;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuggestionPortalESPE.Views
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
            txtPassword.Completed += (sender, e) => SignInProcedure(sender, e);
        }
        void SignUpProcedure(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            LoginController cont = new LoginController();
            User stu = new User(txtUser.Text, txtPassword.Text);
            StudentModel estudiante = cont.CheckInformation(stu);

            if (estudiante!=null)
            {
                DisplayAlert("Login", "Inicio de Sesión Correcto", "OK");
                Navigation.PushAsync(new MenuPage());
            }
            else
            {
                DisplayAlert("Login", "Inicio de Sesión Incorrecto", "OK");
            }
            RestartData();
        }

        void RestartData()
        {
            txtPassword.Text = ""; txtUser.Text = "";
        }
    }
}