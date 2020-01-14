using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AgendaDemo
{
    public class GeneradorContactos
    {
        private static List<String> ListaNombres = new List<String>()
        {
            "Juan", "Pablo","Gustavo","Manuela"
        };

        private static List<String> ListaApellidos = new List<string>()
        {
            "Pérez","Zuñiga","Polo","Gonzales"
        };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for (int i = 0; i < 10; i++)
            {
                var nombre = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var apellidos = ListaApellidos[random.Next(ListaApellidos.Count - 1)];
                var calle = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var contacto = new Contacto()
                {
                    Nombre = nombre + " " + apellidos,
                    Telefono = GenerarTelefono(),
                    Direccion = "Avenida " + calle + ", Número " + random.Next(1, 1000)
                };
                contactos.Add(contacto);
            }
            return contactos;
        }

        private static String GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100, 999));
            telefono.Append(")");
            telefono.Append(random.Next(100000, 999999));

            return telefono.ToString();
        }
    }
}
