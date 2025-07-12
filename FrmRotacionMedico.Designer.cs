namespace CentroMedico
{
    partial class frmRotacionMedico
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
            txtNombreMedico = new TextBox();
            label2 = new Label();
            btnSiguienteMedico = new Button();
            label1 = new Label();
            lvMedicos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtDNIMedico = new TextBox();
            label3 = new Label();
            btnAnteriorMedico = new Button();
            SuspendLayout();
            // 
            // txtNombreMedico
            // 
            txtNombreMedico.Enabled = false;
            txtNombreMedico.Location = new Point(72, 9);
            txtNombreMedico.Name = "txtNombreMedico";
            txtNombreMedico.Size = new Size(313, 23);
            txtNombreMedico.TabIndex = 24;
            // 
            // label2
            // 
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 23;
            label2.Text = "Médico:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSiguienteMedico
            // 
            btnSiguienteMedico.Location = new Point(240, 90);
            btnSiguienteMedico.Name = "btnSiguienteMedico";
            btnSiguienteMedico.Size = new Size(145, 23);
            btnSiguienteMedico.TabIndex = 25;
            btnSiguienteMedico.Text = "Siguiente Médico -->";
            btnSiguienteMedico.UseVisualStyleBackColor = true;
            btnSiguienteMedico.Click += btnRotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 181);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 27;
            label1.Text = "Lista de Médicos";
            // 
            // lvMedicos
            // 
            lvMedicos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvMedicos.FullRowSelect = true;
            lvMedicos.Location = new Point(12, 214);
            lvMedicos.Name = "lvMedicos";
            lvMedicos.Size = new Size(373, 213);
            lvMedicos.TabIndex = 28;
            lvMedicos.UseCompatibleStateImageBehavior = false;
            lvMedicos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MEDICO";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ESPECIALIDAD";
            columnHeader3.Width = 150;
            // 
            // txtDNIMedico
            // 
            txtDNIMedico.Enabled = false;
            txtDNIMedico.Location = new Point(72, 38);
            txtDNIMedico.Name = "txtDNIMedico";
            txtDNIMedico.Size = new Size(313, 23);
            txtDNIMedico.TabIndex = 32;
            // 
            // label3
            // 
            label3.Location = new Point(12, 38);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 31;
            label3.Text = "DNI:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAnteriorMedico
            // 
            btnAnteriorMedico.Location = new Point(12, 90);
            btnAnteriorMedico.Name = "btnAnteriorMedico";
            btnAnteriorMedico.Size = new Size(153, 23);
            btnAnteriorMedico.TabIndex = 33;
            btnAnteriorMedico.Text = "<-- Anterior Médico";
            btnAnteriorMedico.UseVisualStyleBackColor = true;
            btnAnteriorMedico.Click += btnAnteriorMedico_Click;
            // 
            // frmRotacionMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 439);
            Controls.Add(btnAnteriorMedico);
            Controls.Add(txtDNIMedico);
            Controls.Add(label3);
            Controls.Add(lvMedicos);
            Controls.Add(label1);
            Controls.Add(btnSiguienteMedico);
            Controls.Add(txtNombreMedico);
            Controls.Add(label2);
            Name = "frmRotacionMedico";
            Text = "Rotación Médico (Lista Circular)";
            Load += frmRotacionMedico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreMedico;
        private Label label2;
        private Button btnAnteriorMedico;
        private Label label1;
        private ListView lvMedicos;
        private ColumnHeader columnHeader1;
        private Button btnSiguienteMedico;
        private TextBox txtDNIMedico;
        private Label label3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}