using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuggestionESPE.Models;
using SuggestionESPE.Event;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuggestionESPE.Interfaces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public IList<Student> Students { get; private set; }
        public MenuPage()
        {
            InitializeComponent();
            Init();

            Student UStudent = new Student();
            UStudent.fillData();

            Students = new List<Student>();

            Students.Add(UStudent);

            BindingContext = UStudent;

        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }
    }
}