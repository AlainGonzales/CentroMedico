using CentroMedico.Dominio;

namespace CentroMedico.Infraestructura.Estructuras.Nodos
{
    public class NodoColaPaciente
    {
        public Paciente Valor { get; set; }
        public NodoColaPaciente Siguiente { get; set; }

        public NodoColaPaciente(Paciente paciente)
        {
            Valor = paciente;
            Siguiente = null;
        }
    }
}
