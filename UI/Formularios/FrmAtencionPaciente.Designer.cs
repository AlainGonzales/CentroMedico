namespace CentroMedico
{
    partial class frmAtencionPaciente
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
            txtSintomas = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtDiagnostico = new TextBox();
            btnAtender = new Button();
            lblMedicoInfo = new Label();
            SuspendLayout();
            // 
            // txtSintomas
            // 
            txtSintomas.Enabled = false;
            txtSintomas.Location = new Point(118, 148);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(394, 80);
            txtSintomas.TabIndex = 16;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(118, 119);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(118, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(394, 23);
            txtNombre.TabIndex = 14;
            // 
            // txtDNI
            // 
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(118, 61);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(117, 23);
            txtDNI.TabIndex = 13;
            // 
            // label4
            // 
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 12;
            label4.Text = "Síntomas:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 11;
            label3.Text = "Edad:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "DNI:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 17;
            label5.Text = "Diagnóstico:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(118, 251);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(394, 80);
            txtDiagnostico.TabIndex = 18;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(118, 352);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(394, 40);
            btnAtender.TabIndex = 19;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lblMedicoInfo
            // 
            lblMedicoInfo.Dock = DockStyle.Top;
            lblMedicoInfo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicoInfo.Location = new Point(0, 0);
            lblMedicoInfo.Name = "lblMedicoInfo";
            lblMedicoInfo.Size = new Size(524, 45);
            lblMedicoInfo.TabIndex = 21;
            lblMedicoInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAtencionPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(lblMedicoInfo);
            Controls.Add(btnAtender);
            Controls.Add(txtDiagnostico);
            Controls.Add(label5);
            Controls.Add(txtSintomas);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAtencionPaciente";
            Text = "Atender Paciente (Desencola y Guarda en Lista Doble)";
            Load += frmAtencionPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSintomas;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtDiagnostico;
        private Button btnAtender;
        private Label lblMedicoInfo;
    }
}