using CentroMedico.Dominio;

namespace CentroMedico.Infraestructura.Estructuras.Nodos
{
    public class NodoAccion
    {
        public AccionRealizada Valor { get; set; }
        public NodoAccion Siguiente { get; set; }

        public NodoAccion(AccionRealizada valor, NodoAccion siguiente = null)
        {
            Valor = valor;
            Siguiente = siguiente;
        }
    }

}
