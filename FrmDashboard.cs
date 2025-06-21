namespace CentroMedico
{
    public partial class frmDashboard : Form
    {
        private ListaSimplePaciente pacientesRegistrados;

        private ColaPacientes colaEspera;

        private ListaDobleHistorial historialAtenciones;

        private ListaCircularMedicos medicosEnTurno;

        private PilaAcciones pilaAcciones;

        public frmDashboard()
        {
            InitializeComponent();

            // Inicializa cada estructura
            pacientesRegistrados = new ListaSimplePaciente();
            colaEspera = new ColaPacientes();
            historialAtenciones = new ListaDobleHistorial();
            medicosEnTurno = new ListaCircularMedicos();
            pilaAcciones = new PilaAcciones();

            // Opcional: precarga tus médicos en la lista circular
            medicosEnTurno.Agregar(new Medico("11111111", "Dr. Gregory House"));
            medicosEnTurno.Agregar(new Medico("22222222", "Dra. Lastimosa Curita"));
            medicosEnTurno.Agregar(new Medico("33333333", "Dr. Juanete Grande"));

            // Actualiza UI inicial
            RefrescarDashboard();
        }

        private void RefrescarDashboard()
        {
            lblDoctorTurno.Text = $"Médico en turno: {medicosEnTurno.ObtenerActual().Nombre}";

            lblPacientesEnCola.Text = $"Pacientes en cola: {colaEspera.Contar()}";

            lblUltimaAccion.Text = pilaAcciones.EstaVacia()
                ? "Última acción: —"
                : $"Última acción: {pilaAcciones.Tope()}";

            lvColaPacientes.Items.Clear();
            foreach (Paciente p in colaEspera.ObtenerTodos())
            {
                var item = new ListViewItem(new[] { p.DNI, p.Nombre, p.Edad.ToString(), p.Sintomas });
                lvColaPacientes.Items.Add(item);
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente form = new frmRegistroPaciente(pacientesRegistrados,colaEspera,pilaAcciones);
            form.ShowDialog();
            RefrescarDashboard();
        }

        private void btnAtenderPaciente_Click(object sender, EventArgs e)
        {
            frmAtencionPaciente form = new frmAtencionPaciente(
                                                                colaEspera,
                                                                medicosEnTurno,
                                                                historialAtenciones,
                                                                pilaAcciones
                                                            );

            form.ShowDialog();
            RefrescarDashboard();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialPaciente form = new frmHistorialPaciente(historialAtenciones);
            form.ShowDialog();
        }

        private void btnRotacion_Click(object sender, EventArgs e)
        {
            frmRotacionMedico ventana = new frmRotacionMedico();
            ventana.ShowDialog();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            frmDeshacerAccion ventana = new frmDeshacerAccion();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
