namespace CentroMedico
{
    partial class frmDeshacerAccion
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
            txtUltimaAccion = new TextBox();
            label2 = new Label();
            btnDeshacer = new Button();
            SuspendLayout();
            // 
            // txtUltimaAccion
            // 
            txtUltimaAccion.Location = new Point(118, 9);
            txtUltimaAccion.Name = "txtUltimaAccion";
            txtUltimaAccion.Size = new Size(294, 23);
            txtUltimaAccion.TabIndex = 16;
            // 
            // label2
            // 
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 15;
            label2.Text = "Última Acción:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDeshacer
            // 
            btnDeshacer.Location = new Point(12, 55);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(100, 23);
            btnDeshacer.TabIndex = 17;
            btnDeshacer.Text = "DesHacer";
            btnDeshacer.UseVisualStyleBackColor = true;
            // 
            // frmDeshacerAccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 101);
            Controls.Add(btnDeshacer);
            Controls.Add(txtUltimaAccion);
            Controls.Add(label2);
            Name = "frmDeshacerAccion";
            Text = "Deshacer Acción (Pila)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUltimaAccion;
        private Label label2;
        private Button btnDeshacer;
    }
}