namespace pryIEFI
{
    partial class frmAgregar_2_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar_2_));
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtIdSocio = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.imgNuevos = new System.Windows.Forms.PictureBox();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNuevos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(58, 231);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(241, 20);
            this.txtDeuda.TabIndex = 25;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(13, 234);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 13);
            this.lblSaldo.TabIndex = 24;
            this.lblSaldo.Text = "Deuda";
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(70, 185);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(229, 21);
            this.cmbActividad.TabIndex = 23;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(13, 188);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 22;
            this.lblActividad.Text = "Actividad";
            // 
            // txtIdSocio
            // 
            this.txtIdSocio.Location = new System.Drawing.Point(48, 28);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.Size = new System.Drawing.Size(251, 20);
            this.txtIdSocio.TabIndex = 21;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(16, 31);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(26, 13);
            this.lblDocumento.TabIndex = 20;
            this.lblDocumento.Text = "DNI";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(74, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(225, 20);
            this.txtDireccion.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(18, 140);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 16;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Location = new System.Drawing.Point(16, 98);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(52, 13);
            this.lblDirección.TabIndex = 15;
            this.lblDirección.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre ";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cmbBarrio);
            this.grpDatos.Controls.Add(this.txtDeuda);
            this.grpDatos.Controls.Add(this.lblSaldo);
            this.grpDatos.Controls.Add(this.cmbActividad);
            this.grpDatos.Controls.Add(this.lblActividad);
            this.grpDatos.Controls.Add(this.txtIdSocio);
            this.grpDatos.Controls.Add(this.lblBarrio);
            this.grpDatos.Controls.Add(this.lblDocumento);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblDirección);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(12, 138);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(330, 276);
            this.grpDatos.TabIndex = 26;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Rellene con sus datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(145, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 27);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar..";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(58, 140);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(241, 21);
            this.cmbBarrio.TabIndex = 26;
            // 
            // imgAgregar
            // 
            //this.imgAgregar.Image = global::pryIEFI.Properties.Resources.agregar;
            this.imgAgregar.Location = new System.Drawing.Point(90, 437);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(49, 27);
            this.imgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAgregar.TabIndex = 43;
            this.imgAgregar.TabStop = false;
            // 
            // imgNuevos
            // 
            this.imgNuevos.Image = global::pryIEFI.Properties.Resources.nuevo_socio;
            this.imgNuevos.Location = new System.Drawing.Point(-5, -4);
            this.imgNuevos.Name = "imgNuevos";
            this.imgNuevos.Size = new System.Drawing.Size(365, 124);
            this.imgNuevos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNuevos.TabIndex = 0;
            this.imgNuevos.TabStop = false;
            this.imgNuevos.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAgregar_2_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 487);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.imgNuevos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar_2_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrese en la página";
            this.Load += new System.EventHandler(this.frmAgregar_2__Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNuevos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNuevos;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtIdSocio;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox imgAgregar;
        private System.Windows.Forms.ComboBox cmbBarrio;
    }
}