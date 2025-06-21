namespace CentroMedico
{
    public class ListaSimplePaciente
    {
        private NodoPaciente _raiz;

        public ListaSimplePaciente()
        {
            this._raiz = null;
        }

        public NodoPaciente Inicio
        {
            get { return _raiz; }
            set { _raiz = value; }
        }

        public void AgregarAlFinal(Paciente nuevoPaciente)
        {
            NodoPaciente nuevoNodo = new NodoPaciente(nuevoPaciente);

            if (_raiz == null)
            {
                _raiz = nuevoNodo;
            }
            else
            {
                NodoPaciente actual = _raiz;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        public List<Paciente> ListarTodos()
        {
            List<Paciente> lista = new List<Paciente>();
            NodoPaciente actual = _raiz;
            while (actual != null)
            {
                lista.Add(actual.Valor);
                actual = actual.Siguiente;
            }
            return lista;
        }

        public void Listar(ListView listView)
        {
            listView.Items.Clear(); // Limpiar antes de agregar
            NodoPaciente actual = _raiz;

            while (actual != null)
            {
                Paciente reg = actual.Valor;

                ListViewItem item = new ListViewItem(reg.DNI.ToString());
                item.SubItems.Add(reg.Nombre);
                item.SubItems.Add(reg.Edad);
                item.SubItems.Add(reg.Sintomas);
                //item.SubItems.Add(reg.correo);

                listView.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

        public bool Vacia()
        {
            return this._raiz == null;
        }
    }

}
