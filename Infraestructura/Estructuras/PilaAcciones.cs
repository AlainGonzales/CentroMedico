using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras.Nodos;

namespace CentroMedico.Infraestructura.Estructuras
{
    public class PilaAcciones
    {
        private NodoAccion cima;

        public PilaAcciones()
        {
            cima = null;
        }

        public void Apilar(AccionRealizada accion)
        {
            NodoAccion nuevo = new NodoAccion(accion, cima);
            //nuevo.Siguiente = cima;
            cima = nuevo;
        }

        public AccionRealizada Desapilar()
        {
            if (EstaVacia()) return null;

            AccionRealizada accion = cima.Valor;
            cima = cima.Siguiente;
            return accion;
        }

        public AccionRealizada Tope()
        {
            return cima?.Valor;
        }

        public bool EstaVacia()
        {
            return cima == null;
        }

        public List<AccionRealizada> ObtenerTodas()
        {
            List<AccionRealizada> acciones = new List<AccionRealizada>();
            NodoAccion actual = cima;

            while (actual != null)
            {
                acciones.Add(actual.Valor);
                actual = actual.Siguiente;
            }

            return acciones;
        }

    }

}
