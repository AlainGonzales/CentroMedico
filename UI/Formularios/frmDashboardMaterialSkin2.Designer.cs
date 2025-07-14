namespace CentroMedico.UI.Formularios
{
    partial class frmDashboardMaterialSkin2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardMaterialSkin2));
            tabControlDashboard = new MaterialSkin.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            cardUltimasAcciones = new MaterialSkin.Controls.MaterialCard();
            lvwUltimasAcciones = new MaterialSkin.Controls.MaterialListView();
            columnHeader4 = new ColumnHeader();
            lblUltimasAcciones = new MaterialSkin.Controls.MaterialLabel();
            cardDoctoresDisponibles = new MaterialSkin.Controls.MaterialCard();
            lvwDoctoresDisponibles = new MaterialSkin.Controls.MaterialListView();
            columnHeader2 = new ColumnHeader();
            lblDoctoresEnTurno = new MaterialSkin.Controls.MaterialLabel();
            cardColaAtencion = new MaterialSkin.Controls.MaterialCard();
            lvwColaAtencion = new MaterialSkin.Controls.MaterialListView();
            columnHeader3 = new ColumnHeader();
            lblColaAtencion = new MaterialSkin.Controls.MaterialLabel();
            cardPacientesRegistrados = new MaterialSkin.Controls.MaterialCard();
            lvwPacientesRegistrados = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            lblPacientesRegistrados = new MaterialSkin.Controls.MaterialLabel();
            tabRegistrarPaciente = new TabPage();
            tabAtenderPaciente = new TabPage();
            tabHistorialAtencion = new TabPage();
            tabDeshacerAccion = new TabPage();
            tabSalir = new TabPage();
            imageList1 = new ImageList(components);
            tabControlDashboard.SuspendLayout();
            tabDashboard.SuspendLayout();
            cardUltimasAcciones.SuspendLayout();
            cardDoctoresDisponibles.SuspendLayout();
            cardColaAtencion.SuspendLayout();
            cardPacientesRegistrados.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(tabDashboard);
            tabControlDashboard.Controls.Add(tabRegistrarPaciente);
            tabControlDashboard.Controls.Add(tabAtenderPaciente);
            tabControlDashboard.Controls.Add(tabHistorialAtencion);
            tabControlDashboard.Controls.Add(tabDeshacerAccion);
            tabControlDashboard.Controls.Add(tabSalir);
            tabControlDashboard.Depth = 0;
            resources.ApplyResources(tabControlDashboard, "tabControlDashboard");
            tabControlDashboard.ImageList = imageList1;
            tabControlDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlDashboard.Multiline = true;
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(cardUltimasAcciones);
            tabDashboard.Controls.Add(cardDoctoresDisponibles);
            tabDashboard.Controls.Add(cardColaAtencion);
            tabDashboard.Controls.Add(cardPacientesRegistrados);
            resources.ApplyResources(tabDashboard, "tabDashboard");
            tabDashboard.Name = "tabDashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // cardUltimasAcciones
            // 
            cardUltimasAcciones.BackColor = Color.FromArgb(255, 255, 255);
            cardUltimasAcciones.Controls.Add(lvwUltimasAcciones);
            cardUltimasAcciones.Controls.Add(lblUltimasAcciones);
            cardUltimasAcciones.Depth = 0;
            cardUltimasAcciones.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(cardUltimasAcciones, "cardUltimasAcciones");
            cardUltimasAcciones.MouseState = MaterialSkin.MouseState.HOVER;
            cardUltimasAcciones.Name = "cardUltimasAcciones";
            // 
            // lvwUltimasAcciones
            // 
            lvwUltimasAcciones.AutoSizeTable = false;
            lvwUltimasAcciones.BackColor = Color.FromArgb(255, 255, 255);
            lvwUltimasAcciones.BorderStyle = BorderStyle.None;
            lvwUltimasAcciones.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            lvwUltimasAcciones.Depth = 0;
            lvwUltimasAcciones.FullRowSelect = true;
            resources.ApplyResources(lvwUltimasAcciones, "lvwUltimasAcciones");
            lvwUltimasAcciones.MouseLocation = new Point(-1, -1);
            lvwUltimasAcciones.MouseState = MaterialSkin.MouseState.OUT;
            lvwUltimasAcciones.Name = "lvwUltimasAcciones";
            lvwUltimasAcciones.OwnerDraw = true;
            lvwUltimasAcciones.UseCompatibleStateImageBehavior = false;
            lvwUltimasAcciones.View = View.Details;
            // 
            // columnHeader4
            // 
            resources.ApplyResources(columnHeader4, "columnHeader4");
            // 
            // lblUltimasAcciones
            // 
            lblUltimasAcciones.Depth = 0;
            resources.ApplyResources(lblUltimasAcciones, "lblUltimasAcciones");
            lblUltimasAcciones.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblUltimasAcciones.MouseState = MaterialSkin.MouseState.HOVER;
            lblUltimasAcciones.Name = "lblUltimasAcciones";
            // 
            // cardDoctoresDisponibles
            // 
            cardDoctoresDisponibles.BackColor = Color.FromArgb(255, 255, 255);
            cardDoctoresDisponibles.Controls.Add(lvwDoctoresDisponibles);
            cardDoctoresDisponibles.Controls.Add(lblDoctoresEnTurno);
            cardDoctoresDisponibles.Depth = 0;
            cardDoctoresDisponibles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(cardDoctoresDisponibles, "cardDoctoresDisponibles");
            cardDoctoresDisponibles.MouseState = MaterialSkin.MouseState.HOVER;
            cardDoctoresDisponibles.Name = "cardDoctoresDisponibles";
            // 
            // lvwDoctoresDisponibles
            // 
            lvwDoctoresDisponibles.AutoSizeTable = false;
            lvwDoctoresDisponibles.BackColor = Color.FromArgb(255, 255, 255);
            lvwDoctoresDisponibles.BorderStyle = BorderStyle.None;
            lvwDoctoresDisponibles.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            lvwDoctoresDisponibles.Depth = 0;
            lvwDoctoresDisponibles.FullRowSelect = true;
            resources.ApplyResources(lvwDoctoresDisponibles, "lvwDoctoresDisponibles");
            lvwDoctoresDisponibles.MouseLocation = new Point(-1, -1);
            lvwDoctoresDisponibles.MouseState = MaterialSkin.MouseState.OUT;
            lvwDoctoresDisponibles.Name = "lvwDoctoresDisponibles";
            lvwDoctoresDisponibles.OwnerDraw = true;
            lvwDoctoresDisponibles.UseCompatibleStateImageBehavior = false;
            lvwDoctoresDisponibles.View = View.Details;
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // lblDoctoresEnTurno
            // 
            lblDoctoresEnTurno.Depth = 0;
            resources.ApplyResources(lblDoctoresEnTurno, "lblDoctoresEnTurno");
            lblDoctoresEnTurno.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblDoctoresEnTurno.MouseState = MaterialSkin.MouseState.HOVER;
            lblDoctoresEnTurno.Name = "lblDoctoresEnTurno";
            // 
            // cardColaAtencion
            // 
            cardColaAtencion.BackColor = Color.FromArgb(255, 255, 255);
            cardColaAtencion.Controls.Add(lvwColaAtencion);
            cardColaAtencion.Controls.Add(lblColaAtencion);
            cardColaAtencion.Depth = 0;
            cardColaAtencion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(cardColaAtencion, "cardColaAtencion");
            cardColaAtencion.MouseState = MaterialSkin.MouseState.HOVER;
            cardColaAtencion.Name = "cardColaAtencion";
            // 
            // lvwColaAtencion
            // 
            lvwColaAtencion.AutoSizeTable = false;
            lvwColaAtencion.BackColor = Color.FromArgb(255, 255, 255);
            lvwColaAtencion.BorderStyle = BorderStyle.None;
            lvwColaAtencion.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            lvwColaAtencion.Depth = 0;
            lvwColaAtencion.FullRowSelect = true;
            resources.ApplyResources(lvwColaAtencion, "lvwColaAtencion");
            lvwColaAtencion.MouseLocation = new Point(-1, -1);
            lvwColaAtencion.MouseState = MaterialSkin.MouseState.OUT;
            lvwColaAtencion.Name = "lvwColaAtencion";
            lvwColaAtencion.OwnerDraw = true;
            lvwColaAtencion.UseCompatibleStateImageBehavior = false;
            lvwColaAtencion.View = View.Details;
            // 
            // columnHeader3
            // 
            resources.ApplyResources(columnHeader3, "columnHeader3");
            // 
            // lblColaAtencion
            // 
            lblColaAtencion.Depth = 0;
            resources.ApplyResources(lblColaAtencion, "lblColaAtencion");
            lblColaAtencion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblColaAtencion.MouseState = MaterialSkin.MouseState.HOVER;
            lblColaAtencion.Name = "lblColaAtencion";
            // 
            // cardPacientesRegistrados
            // 
            cardPacientesRegistrados.BackColor = Color.FromArgb(255, 255, 255);
            cardPacientesRegistrados.Controls.Add(lvwPacientesRegistrados);
            cardPacientesRegistrados.Controls.Add(lblPacientesRegistrados);
            cardPacientesRegistrados.Depth = 0;
            cardPacientesRegistrados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(cardPacientesRegistrados, "cardPacientesRegistrados");
            cardPacientesRegistrados.MouseState = MaterialSkin.MouseState.HOVER;
            cardPacientesRegistrados.Name = "cardPacientesRegistrados";
            // 
            // lvwPacientesRegistrados
            // 
            lvwPacientesRegistrados.AutoSizeTable = false;
            lvwPacientesRegistrados.BackColor = Color.FromArgb(255, 255, 255);
            lvwPacientesRegistrados.BorderStyle = BorderStyle.None;
            lvwPacientesRegistrados.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvwPacientesRegistrados.Depth = 0;
            lvwPacientesRegistrados.FullRowSelect = true;
            resources.ApplyResources(lvwPacientesRegistrados, "lvwPacientesRegistrados");
            lvwPacientesRegistrados.MouseLocation = new Point(-1, -1);
            lvwPacientesRegistrados.MouseState = MaterialSkin.MouseState.OUT;
            lvwPacientesRegistrados.Name = "lvwPacientesRegistrados";
            lvwPacientesRegistrados.OwnerDraw = true;
            lvwPacientesRegistrados.UseCompatibleStateImageBehavior = false;
            lvwPacientesRegistrados.View = View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // lblPacientesRegistrados
            // 
            lblPacientesRegistrados.Depth = 0;
            resources.ApplyResources(lblPacientesRegistrados, "lblPacientesRegistrados");
            lblPacientesRegistrados.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblPacientesRegistrados.MouseState = MaterialSkin.MouseState.HOVER;
            lblPacientesRegistrados.Name = "lblPacientesRegistrados";
            // 
            // tabRegistrarPaciente
            // 
            resources.ApplyResources(tabRegistrarPaciente, "tabRegistrarPaciente");
            tabRegistrarPaciente.Name = "tabRegistrarPaciente";
            tabRegistrarPaciente.UseVisualStyleBackColor = true;
            // 
            // tabAtenderPaciente
            // 
            resources.ApplyResources(tabAtenderPaciente, "tabAtenderPaciente");
            tabAtenderPaciente.Name = "tabAtenderPaciente";
            tabAtenderPaciente.UseVisualStyleBackColor = true;
            // 
            // tabHistorialAtencion
            // 
            resources.ApplyResources(tabHistorialAtencion, "tabHistorialAtencion");
            tabHistorialAtencion.Name = "tabHistorialAtencion";
            tabHistorialAtencion.UseVisualStyleBackColor = true;
            // 
            // tabDeshacerAccion
            // 
            resources.ApplyResources(tabDeshacerAccion, "tabDeshacerAccion");
            tabDeshacerAccion.Name = "tabDeshacerAccion";
            tabDeshacerAccion.UseVisualStyleBackColor = true;
            // 
            // tabSalir
            // 
            tabSalir.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(tabSalir, "tabSalir");
            tabSalir.Name = "tabSalir";
            tabSalir.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "historial.png");
            imageList1.Images.SetKeyName(1, "deshacer.png");
            imageList1.Images.SetKeyName(2, "salir.png");
            imageList1.Images.SetKeyName(3, "rotardoctor.png");
            imageList1.Images.SetKeyName(4, "colapaciente.png");
            imageList1.Images.SetKeyName(5, "listapaciente.png");
            imageList1.Images.SetKeyName(6, "doctor.png");
            imageList1.Images.SetKeyName(7, "prescripcion.png");
            imageList1.Images.SetKeyName(8, "atenderpaciente.png");
            imageList1.Images.SetKeyName(9, "registrarpaciente.png");
            imageList1.Images.SetKeyName(10, "dashboard_2.png");
            // 
            // frmDashboardMaterialSkin2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlDashboard);
            DrawerAutoHide = false;
            DrawerHighlightWithAccent = false;
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlDashboard;
            DrawerWidth = 220;
            Name = "frmDashboardMaterialSkin2";
            Sizable = false;
            tabControlDashboard.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            cardUltimasAcciones.ResumeLayout(false);
            cardDoctoresDisponibles.ResumeLayout(false);
            cardColaAtencion.ResumeLayout(false);
            cardPacientesRegistrados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlDashboard;
        private TabPage tabRegistrarPaciente;
        private TabPage tabAtenderPaciente;
        private TabPage tabHistorialAtencion;
        private ImageList imageList1;
        private TabPage tabDeshacerAccion;
        private TabPage tabSalir;
        private TabPage tabDashboard;
        private MaterialSkin.Controls.MaterialCard cardPacientesRegistrados;
        private MaterialSkin.Controls.MaterialLabel lblPacientesRegistrados;
        private MaterialSkin.Controls.MaterialListView lvwPacientesRegistrados;
        private ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialCard cardColaAtencion;
        private MaterialSkin.Controls.MaterialCard cardDoctoresDisponibles;
        private MaterialSkin.Controls.MaterialLabel lblDoctoresEnTurno;
        private MaterialSkin.Controls.MaterialCard cardUltimasAcciones;
        private MaterialSkin.Controls.MaterialLabel lblUltimasAcciones;
        private MaterialSkin.Controls.MaterialLabel lblColaAtencion;
        private MaterialSkin.Controls.MaterialListView lvwUltimasAcciones;
        private MaterialSkin.Controls.MaterialListView lvwDoctoresDisponibles;
        private ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialListView lvwColaAtencion;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}