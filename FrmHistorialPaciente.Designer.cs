namespace CentroMedico
{
    partial class frmHistorialPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBuscarDNI = new TextBox();
            btnBuscar = new Button();
            txtSintomas = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblMedico = new Label();
            lblFecha = new Label();
            lblPosicion = new Label();
            txtDiagnostico = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(12, 12);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(419, 23);
            txtBuscarDNI.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(437, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtSintomas
            // 
            txtSintomas.Enabled = false;
            txtSintomas.Location = new Point(118, 252);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(394, 80);
            txtSintomas.TabIndex = 24;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(118, 223);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(118, 194);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(394, 23);
            txtNombre.TabIndex = 22;
            // 
            // txtDNI
            // 
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(118, 165);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(117, 23);
            txtDNI.TabIndex = 21;
            // 
            // label4
            // 
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 20;
            label4.Text = "Síntomas:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 19;
            label3.Text = "Edad:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(12, 194);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 165);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 17;
            label1.Text = "DNI:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(12, 444);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(250, 40);
            btnAnterior.TabIndex = 25;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(262, 444);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(250, 40);
            btnSiguiente.TabIndex = 26;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblMedico
            // 
            lblMedico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMedico.Location = new Point(0, 65);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(524, 45);
            lblMedico.TabIndex = 27;
            lblMedico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI Semibold", 12F);
            lblFecha.Location = new Point(1, 110);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(524, 32);
            lblFecha.TabIndex = 28;
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPosicion
            // 
            lblPosicion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosicion.Location = new Point(0, 506);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(524, 32);
            lblPosicion.TabIndex = 29;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Enabled = false;
            txtDiagnostico.Location = new Point(118, 341);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(394, 80);
            txtDiagnostico.TabIndex = 31;
            // 
            // label5
            // 
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 30;
            label5.Text = "Diagnóstico:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmHistorialPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 587);
            Controls.Add(txtDiagnostico);
            Controls.Add(label5);
            Controls.Add(lblPosicion);
            Controls.Add(lblFecha);
            Controls.Add(lblMedico);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(txtSintomas);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarDNI);
            Name = "frmHistorialPaciente";
            Text = "Historial Paciente (Lista Doble)";
            Load += FrmHistorialPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarDNI;
        private Button btnBuscar;
        private TextBox txtSintomas;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblMedico;
        private Label lblFecha;
        private Label lblPosicion;
        private TextBox txtDiagnostico;
        private Label label5;
    }
}