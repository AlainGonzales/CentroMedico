using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico
{
    public class Medico
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }

        public Medico(string dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Nombre} ({DNI})";
        }
    }
}
