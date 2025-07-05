namespace CentroMedico
{
    public class ListaCircularMedicos
    {
        private NodoMedico _actual;

        public ListaCircularMedicos()
        {
            _actual = null;
        }

        public void Agregar(Medico medico)
        {
            NodoMedico nuevo = new NodoMedico(medico);

            if (_actual == null)
            {
                nuevo.Anterior = nuevo;
                nuevo.Siguiente = nuevo;
                _actual = nuevo;
            }
            else
            {
                NodoMedico ultimo = _actual.Anterior;

                nuevo.Siguiente = _actual;
                nuevo.Anterior = ultimo;

                ultimo.Siguiente = nuevo;
                _actual.Anterior = nuevo;
            }
        }

        public Medico ObtenerActual()
        {
            return _actual?.Valor;
        }

        public void Retroceder()
        {
            if (_actual != null)
            {
                _actual = _actual.Anterior;
            }
        }

        public void Avanzar()
        {
            if (_actual != null)
            {
                _actual = _actual.Siguiente;
            }
        }        

        public bool EstaVacia()
        {
            return _actual == null;
        }

        public List<Medico> ObtenerTodos()
        {
            List<Medico> lista = new List<Medico>();

            if (_actual == null) return lista;

            NodoMedico temp = _actual;
            do
            {
                lista.Add(temp.Valor);
                temp = temp.Siguiente;
            } while (temp != _actual);

            return lista;
        }
    }

}
