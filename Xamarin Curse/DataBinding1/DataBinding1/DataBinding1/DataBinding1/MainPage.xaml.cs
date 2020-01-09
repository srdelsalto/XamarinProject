using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Empleado NuevoEmpleado { get; set; }
        public MainPage()
        {
            NuevoEmpleado = new Empleado();
            NuevoEmpleado.NombreCompleto = "Santiago Del Salto";
            NuevoEmpleado.Email = "santyrdse@gmail.com";
            BindingContext = NuevoEmpleado;

            InitializeComponent();
        }
    }
}
