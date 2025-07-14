using CentroMedico.Models;

namespace CentroMedico
using CentroMedico.Dominio;

namespace CentroMedico.Infraestructura.Estructuras.Nodos
{
    public class NodoMedico
    {
        public Medico Valor { get; set; }
        public NodoMedico Anterior { get; set; }
        public NodoMedico Siguiente { get; set; }

        public NodoMedico(Medico medico)
        {
            Valor = medico;
            Anterior = null;
            Siguiente = null;
        }
    }

}
