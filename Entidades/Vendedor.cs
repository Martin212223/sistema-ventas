using Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {

        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dNI) :base(nombre, apellido, email, telefono, direccion)
        {

            DNI = dNI;

        }

        public string DNI { get; set; }

    }
}
