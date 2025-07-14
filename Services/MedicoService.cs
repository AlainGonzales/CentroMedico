using CentroMedico.Data;
using CentroMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.Services
{
    internal class MedicoService
    {
        private List<Medico> medicos;

        public MedicoService()
        {
            medicos = MockData.ObtenerMedicos();
        }
        public List<Medico> ObtenerMedicos()
        {
            return medicos;
        }
    }
}
