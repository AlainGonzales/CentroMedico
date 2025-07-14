using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroMedico
{
    public partial class frmRegistroPaciente : Form
    {
        private ListaSimplePaciente listaPacientes;
        private ColaPacientes cola;
        private PilaAcciones pila;

        private bool datosPrecargados = false;

        public frmRegistroPaciente()
        {
            InitializeComponent();
        }

        public frmRegistroPaciente(ListaSimplePaciente lista, ColaPacientes cola, PilaAcciones pila)
        {
            InitializeComponent();
            this.listaPacientes = lista;
            this.cola = cola;
            this.pila = pila;
            this.Load += frmRegistroPaciente_Load;

            //if (!datosPrecargados)
            //{

            //    Paciente p1 = new Paciente("12345678", "Ana Torres", "30", "Dolor de cabeza");
            //    Paciente p2 = new Paciente("87654321", "Luis Chávez", "45", "Dolor abdominal");
            //    Paciente p3 = new Paciente("11223344", "María Paredes", "25", "Fiebre alta");
            //    Paciente p4 = new Paciente("44332211", "Carlos Vela", "60", "Dolor en el pecho");

            //    listaPacientes.AgregarAlFinal(p1);
            //    listaPacientes.AgregarAlFinal(p2);
            //    listaPacientes.AgregarAlFinal(p3);
            //    listaPacientes.AgregarAlFinal(p4);

            //    cola.Encolar(p1);
            //    cola.Encolar(p2);
            //    cola.Encolar(p3);
            //    cola.Encolar(p4);

            //    pila.Apilar(new AccionRealizada("Precarga", "4 pacientes precargados"));

            //    datosPrecargados = true;
            //}
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtSintomas.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Edad inválida.");
                return;
            }

            Paciente nuevo = new Paciente(txtDNI.Text.Trim(), txtNombre.Text.Trim(), txtEdad.Text.Trim(), txtSintomas.Text.Trim());

            listaPacientes.AgregarAlFinal(nuevo);

            // Encolar en cola de atención
            cola.Encolar(nuevo);

            // Registrar acción en pila
            pila.Apilar(new AccionRealizada("Registro", $"Paciente {nuevo.Nombre} registrado y encolado."));

            MessageBox.Show("Paciente registrado con éxito.");
            this.Close(); 
        }

        private void MostrarPacientesRegistrados()
        {
            lvRegistrados.Items.Clear();

            foreach (Paciente p in listaPacientes.ListarTodos())
            {
                ListViewItem item = new ListViewItem(new[] {
                    p.DNI,
                    p.Nombre,
                    p.Edad,
                    p.Sintomas
                });

                lvRegistrados.Items.Add(item);
            }
        }

        private void frmRegistroPaciente_Load(object sender, EventArgs e)
        {
            MostrarPacientesRegistrados();
        }
    }
}
