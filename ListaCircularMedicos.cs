namespace CentroMedico
{
    public class ListaCircularMedicos
    {
        private NodoMedico actual;

        public ListaCircularMedicos()
        {
            actual = null;
        }

        public void Agregar(Medico medico)
        {
            NodoMedico nuevo = new NodoMedico(medico);

            if (actual == null)
            {
                nuevo.Siguiente = nuevo;
                actual = nuevo;
            }
            else
            {
                NodoMedico temp = actual;
                while (temp.Siguiente != actual)
                {
                    temp = temp.Siguiente;
                }

                temp.Siguiente = nuevo;
                nuevo.Siguiente = actual;
            }
        }

        public Medico ObtenerActual()
        {
            return actual?.Valor;
        }

        public void Avanzar()
        {
            if (actual != null)
            {
                actual = actual.Siguiente;
            }
        }

        public bool EstaVacia()
        {
            return actual == null;
        }
    }

}
