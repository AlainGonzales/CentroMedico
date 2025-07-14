using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public enum Especialidad
    {
        MedicinaGeneral,
        Pediatria,
        Cardiologia,
        Dermatologia,
        Traumatologia,
        Endocrinologia,
        Nutricion,
        Oncologia,
        Neurologia
    }
    public class Medico
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public Especialidad Especialidad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({DNI})";
        }

        public string ObtenerTextoEspecialidad(Especialidad especialidad)
        {
            return especialidad switch
            {
                Especialidad.MedicinaGeneral => "Medicina General",
                Especialidad.Pediatria => "Pediatría",
                Especialidad.Cardiologia => "Cardiología",
                Especialidad.Dermatologia => "Dermatología",
                Especialidad.Traumatologia => "Traumatología",
                Especialidad.Endocrinologia => "Endocrinología",
                Especialidad.Nutricion => "Nutrición",
                Especialidad.Oncologia => "Oncología",
                Especialidad.Neurologia => "Neurología",
                _ => especialidad.ToString()
            };
        }
    }
}
