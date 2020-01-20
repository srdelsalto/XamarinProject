﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuggestionESPE.Event;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Views.InputMethods;
using Plugin.CurrentActivity;

namespace SuggestionESPE.Droid
{
    public class AndroidForceKeyboardDismissalService : ForceDismissKeyboard
    {
        public void DismissKeyboard()
        {
            InputMethodManager imm = InputMethodManager.FromContext(CrossCurrentActivity.Current.Activity.ApplicationContext);

            imm.HideSoftInputFromWindow(
                CrossCurrentActivity.Current.Activity.Window.DecorView.WindowToken, HideSoftInputFlags.NotAlways);
        }
    }
}