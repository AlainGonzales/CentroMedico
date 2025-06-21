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
            button1 = new Button();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            txtNuevoMedico = new TextBox();
            btnNuevoMedico = new Button();
            SuspendLayout();
            // 
            // txtNombreMedico
            // 
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
            // button1
            // 
            button1.Location = new Point(12, 38);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 25;
            button1.Text = "_siguiente Médico";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 27;
            label1.Text = "Lista de Médicos";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(12, 102);
            listView1.Name = "listView1";
            listView1.Size = new Size(256, 185);
            listView1.TabIndex = 28;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre Completo";
            columnHeader1.Width = 250;
            // 
            // txtNuevoMedico
            // 
            txtNuevoMedico.Location = new Point(12, 326);
            txtNuevoMedico.Name = "txtNuevoMedico";
            txtNuevoMedico.Size = new Size(256, 23);
            txtNuevoMedico.TabIndex = 29;
            // 
            // btnNuevoMedico
            // 
            btnNuevoMedico.Location = new Point(274, 325);
            btnNuevoMedico.Name = "btnNuevoMedico";
            btnNuevoMedico.Size = new Size(111, 23);
            btnNuevoMedico.TabIndex = 30;
            btnNuevoMedico.Text = "Nuevo Médico";
            btnNuevoMedico.UseVisualStyleBackColor = true;
            // 
            // frmRotacionMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 361);
            Controls.Add(btnNuevoMedico);
            Controls.Add(txtNuevoMedico);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtNombreMedico);
            Controls.Add(label2);
            Name = "frmRotacionMedico";
            Text = "Rotación Médico (Lista Circular)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreMedico;
        private Label label2;
        private Button button1;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private TextBox txtNuevoMedico;
        private Button btnNuevoMedico;
    }
}