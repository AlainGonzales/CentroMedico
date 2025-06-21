using CentroMedico;

namespace CentroMedico
{
    public class NodoPaciente
    {
        private Paciente _valor;
        private NodoPaciente _siguiente;

        public Paciente Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public NodoPaciente Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public NodoPaciente()
        {
            _valor = null;
            _siguiente = null;
        }

        public NodoPaciente(Paciente nuevo_paciente)
        {
            _valor = nuevo_paciente;
            _siguiente = null;
        }

        public NodoPaciente(Paciente nuevo_paciente, NodoPaciente nuevo_siguiente)
        {
            _valor = nuevo_paciente;
            _siguiente = nuevo_siguiente;
        }
    }
}
