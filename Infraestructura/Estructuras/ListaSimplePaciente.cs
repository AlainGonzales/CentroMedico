using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras.Nodos;

namespace CentroMedico.Infraestructura.Estructuras
{
    public class ListaSimplePaciente
    {
        private NodoPaciente _raiz;

        public ListaSimplePaciente()
        {
            _raiz = null;
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
            return _raiz == null;
        }

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> pacientes = new List<Paciente>();
            NodoPaciente actual = _raiz;

            while (actual != null)
            {
                pacientes.Add(actual.Valor);
                actual = actual.Siguiente;
            }

            return pacientes;
        }

        public int Contar()
        {
            int contador = 0;
            NodoPaciente actual = _raiz;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }


    }

}
