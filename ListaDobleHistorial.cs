namespace CentroMedico
{
    public class ListaDobleHistorial
    {
        private NodoHistorial _primero;
        private NodoHistorial _ultimo;
        private NodoHistorial _actual;

        public ListaDobleHistorial()
        {
            _primero = null;
            _ultimo = null;
            _actual = null;
        }

        public void Agregar(AtencionMedica atencion)
        {
            NodoHistorial nuevo = new NodoHistorial(atencion);

            if (_primero == null)
            {
                _primero = _ultimo = _actual = nuevo;
            }
            else
            {
                _ultimo.Siguiente = nuevo;
                nuevo.Anterior = _ultimo;
                _ultimo = nuevo;
            }
        }

        public AtencionMedica VerActual()
        {
            return _actual?.Valor;
        }

        public AtencionMedica Siguiente()
        {
            if (_actual != null && _actual?.Siguiente != null)
            {
                _actual = _actual.Siguiente;
            }
            return _actual?.Valor;
        }

        public AtencionMedica Anterior()
        {
            if (_actual != null && _actual?.Anterior != null)
            {
                _actual = _actual.Anterior;
            }
            return _actual?.Valor;
        }

        public bool EstaVacia()
        {
            return _primero == null;
        }

        public int Contar()
        {
            int contador = 0;
            NodoHistorial actual = _primero;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        public int PosicionActual()
        {
            int posicion = 1;
            NodoHistorial temp = _primero;

            while (temp != null && temp != _actual)
            {
                posicion++;
                temp = temp.Siguiente;
            }

            return posicion;
        }

        public void IrAlInicio()
        {
            _actual = _primero;
        }
    }

}
