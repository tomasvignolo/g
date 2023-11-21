namespace pryIEFI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msSistema = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeUnaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeUnBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // msSistema
            // 
            this.msSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.socioToolStripMenuItem});
            this.msSistema.Location = new System.Drawing.Point(0, 0);
            this.msSistema.Name = "msSistema";
            this.msSistema.Size = new System.Drawing.Size(253, 24);
            this.msSistema.TabIndex = 0;
            this.msSistema.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDelDesarrolladorDelSistemaToolStripMenuItem
            // 
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Name = "acercaDelDesarrolladorDelSistemaToolStripMenuItem";
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Text = "Acerca del desarrollador del sistema...";
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelDesarrolladorDelSistemaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosSociosToolStripMenuItem,
            this.buscarSocioToolStripMenuItem,
            this.consultaDeUnSocioToolStripMenuItem,
            this.listadoDeTodosLosSociosToolStripMenuItem,
            this.listadoDeSociosDeudoresToolStripMenuItem,
            this.listadoDeSociosDeUnaActividadToolStripMenuItem,
            this.listadoDeSociosDeUnBarrioToolStripMenuItem});
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.socioToolStripMenuItem.Text = "Socio";
            // 
            // agregarNuevosSociosToolStripMenuItem
            // 
            this.agregarNuevosSociosToolStripMenuItem.Name = "agregarNuevosSociosToolStripMenuItem";
            this.agregarNuevosSociosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.agregarNuevosSociosToolStripMenuItem.Text = "Agregar nuevos socios...";
            this.agregarNuevosSociosToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosSociosToolStripMenuItem_Click);
            // 
            // buscarSocioToolStripMenuItem
            // 
            this.buscarSocioToolStripMenuItem.Name = "buscarSocioToolStripMenuItem";
            this.buscarSocioToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.buscarSocioToolStripMenuItem.Text = "Buscar socio...";
            this.buscarSocioToolStripMenuItem.Click += new System.EventHandler(this.buscarSocioToolStripMenuItem_Click);
            // 
            // consultaDeUnSocioToolStripMenuItem
            // 
            this.consultaDeUnSocioToolStripMenuItem.Name = "consultaDeUnSocioToolStripMenuItem";
            this.consultaDeUnSocioToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.consultaDeUnSocioToolStripMenuItem.Text = "Consulta de un socio...";
            this.consultaDeUnSocioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnSocioToolStripMenuItem_Click);
            // 
            // listadoDeTodosLosSociosToolStripMenuItem
            // 
            this.listadoDeTodosLosSociosToolStripMenuItem.Name = "listadoDeTodosLosSociosToolStripMenuItem";
            this.listadoDeTodosLosSociosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeTodosLosSociosToolStripMenuItem.Text = "Listado de todos los socios...";
            this.listadoDeTodosLosSociosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosSociosToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeudoresToolStripMenuItem
            // 
            this.listadoDeSociosDeudoresToolStripMenuItem.Name = "listadoDeSociosDeudoresToolStripMenuItem";
            this.listadoDeSociosDeudoresToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeSociosDeudoresToolStripMenuItem.Text = "Listado de socios deudores...";
            this.listadoDeSociosDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeudoresToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeUnaActividadToolStripMenuItem
            // 
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Name = "listadoDeSociosDeUnaActividadToolStripMenuItem";
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Text = "Listado de socios de una actividad...";
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeUnaActividadToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeUnBarrioToolStripMenuItem
            // 
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Name = "listadoDeSociosDeUnBarrioToolStripMenuItem";
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Text = "Listado de socios de un barrio...";
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeUnBarrioToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(253, 29);
            this.Controls.Add(this.msSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msSistema;
            this.Name = "frmPrincipal";
            this.Text = "Sistema gestión socios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msSistema.ResumeLayout(false);
            this.msSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msSistema;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelDesarrolladorDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeUnaActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeUnBarrioToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

