using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras;
using CentroMedico.Services;
using MaterialSkin.Controls;

namespace CentroMedico.UI.Formularios
{
    public partial class frmDashboardMaterialSkin2 : MaterialForm
    {
        private ListaSimplePaciente pacientesRegistrados;
        private ColaPacientes colaEspera;
        private ListaDobleHistorial historialAtenciones;
        private ListaCircularMedicos medicosEnTurno;
        private PilaAcciones pilaAcciones;
        private bool datosPrecargados = false;
        private MedicoService medicoService;
        private List<Medico> listaMedicos;

        public frmDashboardMaterialSkin2()
        {
            InitializeComponent();

            pacientesRegistrados = new ListaSimplePaciente();
            colaEspera = new ColaPacientes();
            historialAtenciones = new ListaDobleHistorial();
            medicosEnTurno = new ListaCircularMedicos();
            pilaAcciones = new PilaAcciones();

            //medicosEnTurno.Agregar(new Medico("11111111", "Dr. Gregory House", ""));
            //medicosEnTurno.Agregar(new Medico("22222222", "Dra. Lastimosa Curita",""));
            //medicosEnTurno.Agregar(new Medico("33333333", "Dr. Juanete Grande",""));

            PrecargarMedicos();
            AgregarTurnosMedicos();

            if (!datosPrecargados)
            {
                PrecargarPacientes();
                datosPrecargados = true;
            }

            RefrescarDashboardMaterialSkin();
        }

        public void PrecargarMedicos()
        {
            medicoService = new MedicoService();
            listaMedicos = medicoService.ObtenerMedicos();
        }

        public void AgregarTurnosMedicos()
        {
            foreach (Medico medico in listaMedicos)
            {
                medicosEnTurno.Agregar(medico);
            }
        }

        private void PrecargarPacientes()
        {
            Paciente p1 = new Paciente("12345678", "Ana Torres", "28", "Dolor de cabeza");
            Paciente p2 = new Paciente("87654321", "Luis Chávez", "34", "Fiebre y escalofríos");
            Paciente p3 = new Paciente("11223344", "María Paredes", "45", "Dolor abdominal");
            Paciente p4 = new Paciente("44332211", "Carlos Vela", "60", "Presión alta");

            pacientesRegistrados.AgregarAlFinal(p1);
            pacientesRegistrados.AgregarAlFinal(p2);
            pacientesRegistrados.AgregarAlFinal(p3);
            pacientesRegistrados.AgregarAlFinal(p4);

            colaEspera.Encolar(p1);
            colaEspera.Encolar(p2);
            colaEspera.Encolar(p3);
            colaEspera.Encolar(p4);

            pilaAcciones.Apilar(new AccionRealizada("Precarga", "Se registraron 4 pacientes por defecto"));
        }

        private void RefrescarDashboardMaterialSkin()
        {
            // === PACIENTES REGISTRADOS ===
            lvwPacientesRegistrados.Items.Clear();
            foreach (Paciente p in pacientesRegistrados.ObtenerTodos())
            {
                var item = new ListViewItem(new[] { $"{p.DNI} - {p.Nombre}" });
                lvwPacientesRegistrados.Items.Add(item);
            }
            lblPacientesRegistrados.Text = $"{pacientesRegistrados.Contar()} Pacientes registrados";

            // === COLA DE ATENCIÓN ===
            lvwColaAtencion.Items.Clear();
            foreach (Paciente p in colaEspera.ObtenerTodos())
            {
                var item = new ListViewItem(new[] { $"{p.DNI} - {p.Nombre}" });
                lvwColaAtencion.Items.Add(item);
            }
            lblColaAtencion.Text = $"{colaEspera.Contar()} Pacientes en cola";

            // === DOCTORES DISPONIBLES ===
            lvwDoctoresDisponibles.Items.Clear();
            foreach (Medico m in medicosEnTurno.ObtenerTodos())
            {
                var item = new ListViewItem(new[] { $"{m.DNI} - {m.Nombre}" });
                lvwDoctoresDisponibles.Items.Add(item);
            }
            lblDoctoresEnTurno.Text = $"Médico en turno: {medicosEnTurno.ObtenerActual().Nombre}";

            // === ÚLTIMAS ACCIONES ===
            lvwUltimasAcciones.Items.Clear();
            foreach (var accion in pilaAcciones.ObtenerTodas())
            {
                var item = new ListViewItem(new[] { accion.Descripcion });
                lvwUltimasAcciones.Items.Add(item);
            }
            lblUltimasAcciones.Text = pilaAcciones.EstaVacia()
                ? "Última acción: —"
                : $"Última acción: {pilaAcciones.Tope().Descripcion}";
        }


    }
}
