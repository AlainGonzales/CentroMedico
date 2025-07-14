using CentroMedico.Data;
using CentroMedico.Dominio;

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
