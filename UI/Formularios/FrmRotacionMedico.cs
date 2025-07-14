using CentroMedico.Models;
using CentroMedico.Services;
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
    public partial class frmRotacionMedico : Form
    {
        private ListaCircularMedicos medicos;
        private PilaAcciones pila;

        private MedicoService medicoService;

        public frmRotacionMedico(ListaCircularMedicos medicos, PilaAcciones pila)
        {
            InitializeComponent();
            this.medicos = medicos;
            this.pila = pila;
        }

        private void LlenarLista()
        {
            lvMedicos.Items.Clear();

            Medico medicoActual = medicos.ObtenerActual();

            foreach (var medico in medicos.ObtenerTodos())
            {
                var item = new ListViewItem(new[] { medico.DNI, medico.Nombre,  medico.ObtenerTextoEspecialidad(medico.Especialidad) });

                if (medico.DNI == medicoActual.DNI)
                {
                    item.BackColor = Color.LightBlue;  // Puedes usar LightSkyBlue, LightYellow, etc.
                    item.Font = new Font(item.Font, FontStyle.Bold);
                }

                lvMedicos.Items.Add(item);
            }
        }

        private void frmRotacionMedico_Load(object sender, EventArgs e)
        {
            MostrarMedico();
            LlenarLista();
        }

        private void MostrarMedico()
        {
            var medico = medicos.ObtenerActual();
            txtNombreMedico.Text = medico.Nombre;
            txtDNIMedico.Text = medico.DNI;
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            medicos.Avanzar();
            pila.Apilar(new AccionRealizada("Rotación", $"Nuevo médico en turno: {medicos.ObtenerActual().Nombre}"));
            MostrarMedico();
            LlenarLista();
        }

        private void btnAnteriorMedico_Click(object sender, EventArgs e)
        {
            medicos.Retroceder();
            pila.Apilar(new AccionRealizada("Rotación Hacia Atrás", $"Se rotó al médico anterior: {medicos.ObtenerActual().Nombre}"));
            MostrarMedico();
            LlenarLista();
        }
    }
}
