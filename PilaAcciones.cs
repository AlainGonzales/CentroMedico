namespace CentroMedico
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
    }

}
