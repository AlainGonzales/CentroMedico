using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico
{
    public class AtencionMedica
    {
        public Paciente PacienteAtendido { get; set; }
        public Medico MedicoAtendido { get; set; }
        public DateTime FechaHora { get; set; }
        public string Diagnostico { get; set; }

        public AtencionMedica(Paciente paciente, Medico medico, string diagnostico)
        {
            PacienteAtendido = paciente;
            MedicoAtendido = medico;
            Diagnostico = diagnostico;
            FechaHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{FechaHora:dd/MM/yyyy HH:mm} - {PacienteAtendido.Nombre} atendido por {MedicoAtendido.Nombre}";
        }
    }
}
