using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuggestionPortalESPE.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuggestionPortalESPE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        StudentModel Student = new StudentModel();
        public MenuPage()
        {
            InitializeComponent();
            Init();
        }

        public MenuPage(StudentModel student)
        {
            InitializeComponent();
            Student = student;
            Init();
        }

        void Init()
        {
            
            BackgroundColor = Constants.BackgroundColor;
            this.NameLabel.Text = Student.CompleteName;
            this.CILabel.Text = Student.CI;
            this.IdEspeLabel.Text = Student.Id_Espe;
            this.UserNameLabel.Text = Student.User_Name;
        }
    }
}