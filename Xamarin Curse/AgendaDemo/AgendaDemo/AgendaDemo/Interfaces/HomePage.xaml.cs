using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaDemo.Interfaces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            btnVerContactos.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Clases.PaginaListaContactos());
            };
        }
    }
}