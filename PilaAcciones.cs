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
            NodoAccion nuevo = new NodoAccion(accion);
            nuevo.Siguiente = cima;
            cima = nuevo;
        }

        public AccionRealizada Desapilar()
        {
            if (cima == null)
                return null;

            AccionRealizada temp = cima.Valor;
            cima = cima.Siguiente;
            return temp;
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
