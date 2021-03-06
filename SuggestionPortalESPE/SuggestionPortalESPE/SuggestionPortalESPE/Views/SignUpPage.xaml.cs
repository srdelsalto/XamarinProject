﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuggestionPortalESPE.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SuggestionPortalESPE.Event;

namespace SuggestionPortalESPE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lblCI.TextColor = Constants.MainTextColor;
            lblIdEspe.TextColor = Constants.MainTextColor;
            lblName.TextColor = lblLastName.TextColor = Constants.MainTextColor;
            lblUserEspe.TextColor = Constants.MainTextColor;
            lblPasswordEspe.TextColor = Constants.MainTextColor;

            SignUpIcon.HeightRequest = Constants.LoginIconHeight;

            txtIdEspe.Completed += (sender, e) => txtCI.Focus();
            txtCI.Completed += (sender, e) => txtName.Focus();
            txtName.Completed += (s, e) => txtLastName.Focus();
            txtLastName.Completed += (sender, e) => txtUserEspe.Focus();
            //txtPassEspe.Completed += (sender, e) => DismissKeyboard(sender, e);
        }

        private void DismissKeyboard(object sender, EventArgs e)
        {
            int timerCount = 1;

            Device.StartTimer(TimeSpan.FromSeconds(1),
            () =>
            {
                if (timerCount == 0)
                {

                    DependencyService.Get<ForceDismissKeyboard>().DismissKeyboard();
                    return false;
                }

                timerCount--;

                return true;
            });
        }
    }
}