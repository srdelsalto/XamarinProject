using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDemo
{
    public class Contacto
    {
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
