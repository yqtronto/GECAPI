namespace GECAPI
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SubMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.smAgregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.smModificarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.smEliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.smAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuContenido = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.SubMenuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.ssEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArchivo,
            this.MenuCursos,
            this.MenuAlumnos,
            this.MenuReportes,
            this.MenuAyuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MenuArchivo
            // 
            this.MenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuImprimir,
            this.toolStripSeparator5,
            this.SubMenuSalir});
            this.MenuArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuArchivo.Name = "MenuArchivo";
            this.MenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.MenuArchivo.Text = "&Archivo";
            // 
            // SubMenuImprimir
            // 
            this.SubMenuImprimir.Enabled = false;
            this.SubMenuImprimir.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuImprimir.Image")));
            this.SubMenuImprimir.ImageTransparentColor = System.Drawing.Color.Black;
            this.SubMenuImprimir.Name = "SubMenuImprimir";
            this.SubMenuImprimir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.SubMenuImprimir.Size = new System.Drawing.Size(161, 22);
            this.SubMenuImprimir.Text = "&Impirmir";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // SubMenuSalir
            // 
            this.SubMenuSalir.Name = "SubMenuSalir";
            this.SubMenuSalir.Size = new System.Drawing.Size(161, 22);
            this.SubMenuSalir.Text = "&Salir";
            this.SubMenuSalir.Click += new System.EventHandler(this.SubMenuSalir_Click);
            // 
            // MenuCursos
            // 
            this.MenuCursos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCursos,
            this.SubMenuPeriodos});
            this.MenuCursos.Name = "MenuCursos";
            this.MenuCursos.Size = new System.Drawing.Size(55, 20);
            this.MenuCursos.Text = "&Cursos";
            // 
            // SubMenuCursos
            // 
            this.SubMenuCursos.Name = "SubMenuCursos";
            this.SubMenuCursos.Size = new System.Drawing.Size(168, 22);
            this.SubMenuCursos.Text = "Cursos Actuales";
            this.SubMenuCursos.Click += new System.EventHandler(this.SubMenuCursos_Click);
            // 
            // SubMenuPeriodos
            // 
            this.SubMenuPeriodos.Name = "SubMenuPeriodos";
            this.SubMenuPeriodos.Size = new System.Drawing.Size(168, 22);
            this.SubMenuPeriodos.Text = "Períodos Actuales";
            // 
            // MenuAlumnos
            // 
            this.MenuAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smAgregarAlumno,
            this.smModificarAlumno,
            this.smEliminarAlumno,
            this.toolStripSeparator1,
            this.smAsistencia});
            this.MenuAlumnos.Name = "MenuAlumnos";
            this.MenuAlumnos.Size = new System.Drawing.Size(67, 20);
            this.MenuAlumnos.Text = "A&lumnos";
            // 
            // smAgregarAlumno
            // 
            this.smAgregarAlumno.Name = "smAgregarAlumno";
            this.smAgregarAlumno.Size = new System.Drawing.Size(171, 22);
            this.smAgregarAlumno.Text = "&Agregar Alumno";
            // 
            // smModificarAlumno
            // 
            this.smModificarAlumno.Name = "smModificarAlumno";
            this.smModificarAlumno.Size = new System.Drawing.Size(171, 22);
            this.smModificarAlumno.Text = "&Modificar Alumno";
            // 
            // smEliminarAlumno
            // 
            this.smEliminarAlumno.Name = "smEliminarAlumno";
            this.smEliminarAlumno.Size = new System.Drawing.Size(171, 22);
            this.smEliminarAlumno.Text = "&Eliminar Aumno";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // smAsistencia
            // 
            this.smAsistencia.Name = "smAsistencia";
            this.smAsistencia.Size = new System.Drawing.Size(171, 22);
            this.smAsistencia.Text = "Asistencia";
            // 
            // MenuReportes
            // 
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(65, 20);
            this.MenuReportes.Text = "&Reportes";
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuContenido,
            this.toolStripSeparator8,
            this.SubMenuAcerca});
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.Size = new System.Drawing.Size(53, 20);
            this.MenuAyuda.Text = "A&yuda";
            // 
            // SubMenuContenido
            // 
            this.SubMenuContenido.Enabled = false;
            this.SubMenuContenido.Name = "SubMenuContenido";
            this.SubMenuContenido.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.SubMenuContenido.Size = new System.Drawing.Size(176, 22);
            this.SubMenuContenido.Text = "&Contenido";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // SubMenuAcerca
            // 
            this.SubMenuAcerca.Enabled = false;
            this.SubMenuAcerca.Name = "SubMenuAcerca";
            this.SubMenuAcerca.Size = new System.Drawing.Size(176, 22);
            this.SubMenuAcerca.Text = "&Acerca de GECAPI";
            // 
            // ssEstado
            // 
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.ssEstado.Location = new System.Drawing.Point(0, 539);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(784, 22);
            this.ssEstado.TabIndex = 2;
            this.ssEstado.Text = "Estado";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Control de Asistencia de Psicoterapia Integrativa";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem SubMenuAcerca;
        private System.Windows.Forms.ToolStripMenuItem MenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem SubMenuImprimir;
        private System.Windows.Forms.ToolStripMenuItem SubMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuCursos;
        private System.Windows.Forms.ToolStripMenuItem MenuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem MenuReportes;
        private System.Windows.Forms.ToolStripMenuItem MenuAyuda;
        private System.Windows.Forms.ToolStripMenuItem SubMenuContenido;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCursos;
        private System.Windows.Forms.ToolStripMenuItem SubMenuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem smAgregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem smModificarAlumno;
        private System.Windows.Forms.ToolStripMenuItem smEliminarAlumno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem smAsistencia;
    }
}



