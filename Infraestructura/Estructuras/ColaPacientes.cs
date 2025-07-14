using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras.Nodos;

namespace CentroMedico.Infraestructura.Estructuras
{
    public class ColaPacientes
    {
        private NodoColaPaciente frente;
        private NodoColaPaciente fin;

        public ColaPacientes()
        {
            frente = null;
            fin = null;
        }

        public void Encolar(Paciente nuevo)
        {
            NodoColaPaciente nodo = new NodoColaPaciente(nuevo);

            if (frente == null)
            {
                frente = nodo;
                fin = nodo;
            }
            else
            {
                fin.Siguiente = nodo;
                fin = nodo;
            }
        }

        public Paciente Desencolar()
        {
            if (frente == null)
                return null;

            Paciente paciente = frente.Valor;
            frente = frente.Siguiente;
            if (frente == null)
                fin = null;

            return paciente;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public int Contar()
        {
            int total = 0;
            NodoColaPaciente actual = frente;
            while (actual != null)
            {
                total++;
                actual = actual.Siguiente;
            }
            return total;
        }

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> lista = new List<Paciente>();
            NodoColaPaciente actual = frente;
            while (actual != null)
            {
                lista.Add(actual.Valor);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }

}
