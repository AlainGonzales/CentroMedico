namespace CentroMedico
{
    public partial class frmAtencionPaciente : Form
    {
        private ColaPacientes cola;
        private ListaCircularMedicos medicos;
        private ListaDobleHistorial historial;
        private PilaAcciones pila;

        private Paciente pacienteActual;
        private Medico medicoActual;

        public frmAtencionPaciente()
        {
            InitializeComponent();
        }

        public frmAtencionPaciente(ColaPacientes cola, ListaCircularMedicos medicos,
                              ListaDobleHistorial historial, PilaAcciones pila)
        {
            InitializeComponent();

            this.cola = cola;
            this.medicos = medicos;
            this.historial = historial;
            this.pila = pila;
        }
        
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Ingrese un diagnóstico.");
                return;
            }

            AtencionMedica atencion = new AtencionMedica(
                pacienteActual,
                medicoActual,
                txtDiagnostico.Text.Trim()
            );

            // Guardar en historial (lista doble)
            historial.Agregar(atencion);

            // Apilar acción
            pila.Apilar(new AccionRealizada("Atención", $"Se atendió a {pacienteActual.Nombre} con {medicoActual.Nombre}"));

            // Rota médico
            medicos.Avanzar();

            MessageBox.Show("Paciente atendido correctamente.");
            //MessageBox.Show("Total atendidos: " + historial.Contar());

            this.Close();
        }

        private void frmAtencionPaciente_Load(object sender, EventArgs e)
        {
            if (cola.EstaVacia())
            {
                MessageBox.Show("No hay pacientes en la cola.");
                this.Close();
                return;
            }

            if (medicos.EstaVacia())
            {
                MessageBox.Show("No hay médicos registrados.");
                this.Close();
                return;
            }

            pacienteActual = cola.Desencolar();
            medicoActual = medicos.ObtenerActual();

            //lblPacienteInfo.Text = $"Paciente: {pacienteActual.Nombre} ({pacienteActual.DNI})";
            txtDNI.Text = pacienteActual.DNI;
            txtNombre.Text = pacienteActual.Nombre;
            txtEdad.Text = pacienteActual.Edad;
            txtSintomas.Text = pacienteActual.Sintomas;

            lblMedicoInfo.Text = $"Médico: {medicoActual.Nombre}";
        }
    }
}
