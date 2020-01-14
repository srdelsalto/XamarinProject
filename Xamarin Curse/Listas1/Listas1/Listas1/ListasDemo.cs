using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Diagnostics;

namespace Listas1
{
    public class ListasDemo : ContentPage
    {
        public ListasDemo()
        {
            var nombres = new[]
            {
                "Héctor",
                "Cristina",
                "Regina",
                "Juan",
                "Ronaldo",
                "Santiago",
                "Miguel",
                "Cristiano",
                "César" 
            };

            var miListView = new ListView();
            miListView.ItemsSource = from nombre in nombres 
                                     where nombre.StartsWith("C") 
                                     select nombre;
            miListView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Debug.WriteLine("Selected: " + e.SelectedItem);
                    await DisplayAlert("Mensaje", "Usted ha seleccionado a: " + e.SelectedItem, "Correcto");
                    miListView.SelectedItem = null;
                }
            };
            Content = miListView;
        }
    }
}