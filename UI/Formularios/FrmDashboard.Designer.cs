using CentroMedico.Shared;

namespace CentroMedico
{
    partial class frmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnSalir = new Button();
            btnDeshacer = new Button();
            btnRotacion = new Button();
            btnHistorial = new Button();
            btnAtenderPaciente = new Button();
            btnRegistrarPaciente = new Button();
            pnlTopInfo = new Panel();
            lblUltimaAccion = new Label();
            lblPacientesEnCola = new Label();
            lblDoctorTurno = new Label();
            pnlContenido = new Panel();
            btnActualizarCola = new Button();
            lvColaPacientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlTopInfo.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(45, 45, 48);
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnDeshacer);
            pnlMenu.Controls.Add(btnRotacion);
            pnlMenu.Controls.Add(btnHistorial);
            pnlMenu.Controls.Add(btnAtenderPaciente);
            pnlMenu.Controls.Add(btnRegistrarPaciente);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 561);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(12, 439);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 52);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnDeshacer
            // 
            btnDeshacer.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeshacer.Location = new Point(12, 354);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(171, 60);
            btnDeshacer.TabIndex = 1;
            btnDeshacer.Text = "Deshacer Acción";
            btnDeshacer.UseVisualStyleBackColor = true;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnRotacion
            // 
            btnRotacion.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRotacion.Location = new Point(12, 271);
            btnRotacion.Name = "btnRotacion";
            btnRotacion.Size = new Size(171, 59);
            btnRotacion.TabIndex = 1;
            btnRotacion.Text = "Rotación Médicos";
            btnRotacion.UseVisualStyleBackColor = true;
            btnRotacion.Click += btnRotacion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(12, 195);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(171, 57);
            btnHistorial.TabIndex = 1;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnAtenderPaciente
            // 
            btnAtenderPaciente.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtenderPaciente.Location = new Point(12, 100);
            btnAtenderPaciente.Name = "btnAtenderPaciente";
            btnAtenderPaciente.Size = new Size(171, 64);
            btnAtenderPaciente.TabIndex = 1;
            btnAtenderPaciente.Text = "Atender Paciente";
            btnAtenderPaciente.UseVisualStyleBackColor = true;
            btnAtenderPaciente.Click += btnAtenderPaciente_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPaciente.Location = new Point(12, 12);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(171, 63);
            btnRegistrarPaciente.TabIndex = 1;
            btnRegistrarPaciente.Text = "Registrar Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // pnlTopInfo
            // 
            pnlTopInfo.BackColor = Color.WhiteSmoke;
            pnlTopInfo.Controls.Add(lblUltimaAccion);
            pnlTopInfo.Controls.Add(lblPacientesEnCola);
            pnlTopInfo.Controls.Add(lblDoctorTurno);
            pnlTopInfo.Dock = DockStyle.Top;
            pnlTopInfo.Location = new Point(253, 88);
            pnlTopInfo.Name = "pnlTopInfo";
            pnlTopInfo.Size = new Size(1424, 80);
            pnlTopInfo.TabIndex = 1;
            // 
            // lblUltimaAccion
            // 
            lblUltimaAccion.AutoSize = true;
            lblUltimaAccion.Location = new Point(15, 60);
            lblUltimaAccion.Name = "lblUltimaAccion";
            lblUltimaAccion.Size = new Size(101, 15);
            lblUltimaAccion.TabIndex = 2;
            lblUltimaAccion.Text = "Última acción: ---";
            // 
            // lblPacientesEnCola
            // 
            lblPacientesEnCola.AutoSize = true;
            lblPacientesEnCola.Location = new Point(15, 37);
            lblPacientesEnCola.Name = "lblPacientesEnCola";
            lblPacientesEnCola.Size = new Size(113, 15);
            lblPacientesEnCola.TabIndex = 1;
            lblPacientesEnCola.Text = "Pacientes en cola: N";
            // 
            // lblDoctorTurno
            // 
            lblDoctorTurno.AutoSize = true;
            lblDoctorTurno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctorTurno.Location = new Point(15, 4);
            lblDoctorTurno.Name = "lblDoctorTurno";
            lblDoctorTurno.Size = new Size(201, 25);
            lblDoctorTurno.TabIndex = 0;
            lblDoctorTurno.Text = "Médico en turno: Dr. X";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(btnActualizarCola);
            pnlContenido.Controls.Add(lvColaPacientes);
            pnlContenido.Controls.Add(label1);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(200, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(684, 481);
            pnlContenido.TabIndex = 2;
            // 
            // btnActualizarCola
            // 
            btnActualizarCola.Location = new Point(15, 443);
            btnActualizarCola.Name = "btnActualizarCola";
            btnActualizarCola.Size = new Size(143, 26);
            btnActualizarCola.TabIndex = 2;
            btnActualizarCola.Text = "Actualizar Cola";
            btnActualizarCola.UseVisualStyleBackColor = true;
            // 
            // lvColaPacientes
            // 
            lvColaPacientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvColaPacientes.FullRowSelect = true;
            lvColaPacientes.Location = new Point(15, 38);
            lvColaPacientes.Name = "lvColaPacientes";
            lvColaPacientes.Size = new Size(657, 399);
            lvColaPacientes.TabIndex = 1;
            lvColaPacientes.UseCompatibleStateImageBehavior = false;
            lvColaPacientes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 257;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Edad";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Síntoma";
            columnHeader4.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Listado de Pacientes en Cola";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTopInfo);
            Controls.Add(pnlMenu);
            Name = "frmDashboard";
            Text = "Sistema Médico Universitario";
            pnlMenu.ResumeLayout(false);
            pnlTopInfo.ResumeLayout(false);
            pnlTopInfo.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnRegistrarPaciente;
        private Button btnDeshacer;
        private Button btnRotacion;
        private Button btnHistorial;
        private Button btnAtenderPaciente;
        private Button btnSalir;
        private Panel pnlTopInfo;
        private Label lblUltimaAccion;
        private Label lblPacientesEnCola;
        private Label lblDoctorTurno;
        private Panel pnlContenido;
        private ListView lvColaPacientes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Button btnActualizarCola;
    }
}
