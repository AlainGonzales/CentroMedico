using CentroMedico.Dominio;

namespace CentroMedico.Infraestructura.Estructuras.Nodos
{
    public class NodoHistorial
    {
        public AtencionMedica Valor { get; set; }
        public NodoHistorial Siguiente { get; set; }
        public NodoHistorial Anterior { get; set; }

        public NodoHistorial(AtencionMedica atencion)
        {
            Valor = atencion;
            Siguiente = null;
            Anterior = null;
        }
    }
}
