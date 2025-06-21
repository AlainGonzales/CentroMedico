namespace CentroMedico
{
    public partial class frmHistorialPaciente : Form
    {
        private ListaDobleHistorial historial;

        public frmHistorialPaciente()
        {
            InitializeComponent();
        }

        public frmHistorialPaciente(ListaDobleHistorial historial)
        {
            InitializeComponent();
            this.historial = historial;
            this.Load += FrmHistorialPaciente_Load;
        }

        private void FrmHistorialPaciente_Load(object sender, EventArgs e)
        {
            if (historial.EstaVacia())
            {
                MessageBox.Show("No hay atenciones registradas aún.");
                this.Close();
                return;
            }

            historial.IrAlInicio();
            MostrarAtencion(historial.VerActual());
        }

        private void MostrarAtencion(AtencionMedica atencion)
        {
            if (atencion == null)
            {
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtSintomas.Text = "";

                txtDiagnostico.Text = "";
                lblPosicion.Text = "Sin registros";
                return;
            }

            lblMedico.Text = atencion.MedicoAtendido.Nombre;
            lblFecha.Text = atencion.FechaHora.ToString("dd/MM/yyyy HH:mm");

            txtDNI.Text = atencion.PacienteAtendido.DNI;
            txtNombre.Text = atencion.PacienteAtendido.Nombre;
            txtEdad.Text = atencion.PacienteAtendido.Edad;
            txtSintomas.Text = atencion.PacienteAtendido.Sintomas;

            txtDiagnostico.Text = atencion.Diagnostico;
            lblPosicion.Text = $"Atención {historial.PosicionActual()} de {historial.Contar()}";

            // (Opcional) Actualiza un contador si lo implementas después
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            AtencionMedica anterior = historial.Anterior();
            MostrarAtencion(anterior);
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            AtencionMedica siguiente = historial.Siguiente();
            MostrarAtencion(siguiente);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            AtencionMedica siguiente = historial.Siguiente();
            MostrarAtencion(siguiente);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            AtencionMedica anterior = historial.Anterior();
            MostrarAtencion(anterior);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar.");
                return;
            }

            AtencionMedica resultado = historial.BuscarPorDNI(dni);

            if (resultado != null)
            {
                MostrarAtencion(resultado);
            }
            else
            {
                MessageBox.Show("Paciente no encontrado en el historial.");
            }
        }
    }
}
