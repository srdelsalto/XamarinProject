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
        public IList<StudentModel> Students { get; private set; }
        public MenuPage()
        {
            InitializeComponent();
        }

        public MenuPage(StudentModel student)
        {
            Students = new List<StudentModel>();

            Students.Add(student);
            BindingContext = Students;

            InitializeComponent();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }

        void ExitProcedure()
        {

        }
    }
}