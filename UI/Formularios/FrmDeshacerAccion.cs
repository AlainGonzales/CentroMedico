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
    public partial class frmDeshacerAccion : Form
    {
        private PilaAcciones pila;

        public frmDeshacerAccion(PilaAcciones pila)
        {
            InitializeComponent();
            this.pila = pila;
        }
        

        private void RefrescarUI()
        {
            if (pila.EstaVacia())
            {
                txtUltimaAccion.Text = "Sin acciones registradas.";
                btnDeshacer.Enabled = false;
            }
            else
            {
                txtUltimaAccion.Text = pila.Tope().Descripcion;
                btnDeshacer.Enabled = true;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            var accion = pila.Desapilar();
            MessageBox.Show($"Se deshizo: {accion.Descripcion}", "Deshacer acción");
            RefrescarUI();
        }

        private void frmDeshacerAccion_Load_1(object sender, EventArgs e)
        {
            RefrescarUI();
        }
    }
}
