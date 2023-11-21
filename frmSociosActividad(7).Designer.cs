namespace pryIEFI
{
    partial class frmSociosActividad_7_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSociosActividad_7_));
            this.lblActividad = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.dgvActividad = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnListarActividad = new System.Windows.Forms.Button();
            this.lblMenor2 = new System.Windows.Forms.Label();
            this.lblMayor2 = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.imgDeuda = new System.Windows.Forms.PictureBox();
            this.imgImprimirActividad = new System.Windows.Forms.PictureBox();
            this.imgReporteActividad = new System.Windows.Forms.PictureBox();
            this.imgListarActividad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimirActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporteActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListarActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(96, 15);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(160, 18);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Indique su actividad:";
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(12, 51);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(342, 21);
            this.cmbActividad.TabIndex = 1;
            // 
            // dgvActividad
            // 
            this.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividad.Location = new System.Drawing.Point(12, 90);
            this.dgvActividad.Name = "dgvActividad";
            this.dgvActividad.Size = new System.Drawing.Size(342, 346);
            this.dgvActividad.TabIndex = 34;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(388, 456);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 36);
            this.btnImprimir.TabIndex = 45;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(223, 455);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(96, 36);
            this.btnReporte.TabIndex = 44;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListarActividad
            // 
            this.btnListarActividad.Location = new System.Drawing.Point(57, 456);
            this.btnListarActividad.Name = "btnListarActividad";
            this.btnListarActividad.Size = new System.Drawing.Size(96, 36);
            this.btnListarActividad.TabIndex = 43;
            this.btnListarActividad.Text = "Listar";
            this.btnListarActividad.UseVisualStyleBackColor = true;
            this.btnListarActividad.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMenor2
            // 
            this.lblMenor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor2.Location = new System.Drawing.Point(501, 295);
            this.lblMenor2.Name = "lblMenor2";
            this.lblMenor2.Size = new System.Drawing.Size(71, 18);
            this.lblMenor2.TabIndex = 49;
            // 
            // lblMayor2
            // 
            this.lblMayor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor2.Location = new System.Drawing.Point(501, 252);
            this.lblMayor2.Name = "lblMayor2";
            this.lblMayor2.Size = new System.Drawing.Size(71, 18);
            this.lblMayor2.TabIndex = 48;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(376, 293);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(119, 20);
            this.lblMenor.TabIndex = 47;
            this.lblMenor.Text = "Menor deuda:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(378, 252);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(117, 20);
            this.lblMayor.TabIndex = 46;
            this.lblMayor.Text = "Mayor deuda:";
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio2.Location = new System.Drawing.Point(479, 338);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(93, 18);
            this.lblPromedio2.TabIndex = 52;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(384, 335);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(89, 20);
            this.lblPromedio.TabIndex = 51;
            this.lblPromedio.Text = "Promedio:";
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // imgDeuda
            // 
            this.imgDeuda.Image = global::pryIEFI.Properties.Resources.deuda;
            this.imgDeuda.Location = new System.Drawing.Point(418, 90);
            this.imgDeuda.Name = "imgDeuda";
            this.imgDeuda.Size = new System.Drawing.Size(129, 111);
            this.imgDeuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDeuda.TabIndex = 50;
            this.imgDeuda.TabStop = false;
            // 
            // imgImprimirActividad
            // 
            this.imgImprimirActividad.Image = global::pryIEFI.Properties.Resources.imprimir;
            this.imgImprimirActividad.Location = new System.Drawing.Point(343, 455);
            this.imgImprimirActividad.Name = "imgImprimirActividad";
            this.imgImprimirActividad.Size = new System.Drawing.Size(39, 37);
            this.imgImprimirActividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImprimirActividad.TabIndex = 42;
            this.imgImprimirActividad.TabStop = false;
            // 
            // imgReporteActividad
            // 
            //this.imgReporteActividad.Image = global::pryIEFI.Properties.Resources.reporte;
            this.imgReporteActividad.Location = new System.Drawing.Point(178, 456);
            this.imgReporteActividad.Name = "imgReporteActividad";
            this.imgReporteActividad.Size = new System.Drawing.Size(39, 37);
            this.imgReporteActividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReporteActividad.TabIndex = 41;
            this.imgReporteActividad.TabStop = false;
            // 
            // imgListarActividad
            // 
            //this.imgListarActividad.Image = global::pryIEFI.Properties.Resources.listar;
            this.imgListarActividad.Location = new System.Drawing.Point(15, 461);
            this.imgListarActividad.Name = "imgListarActividad";
            this.imgListarActividad.Size = new System.Drawing.Size(39, 37);
            this.imgListarActividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgListarActividad.TabIndex = 40;
            this.imgListarActividad.TabStop = false;
            // 
            // frmSociosActividad_7_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 510);
            this.Controls.Add(this.lblPromedio2);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.imgDeuda);
            this.Controls.Add(this.lblMenor2);
            this.Controls.Add(this.lblMayor2);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnListarActividad);
            this.Controls.Add(this.imgImprimirActividad);
            this.Controls.Add(this.imgReporteActividad);
            this.Controls.Add(this.imgListarActividad);
            this.Controls.Add(this.dgvActividad);
            this.Controls.Add(this.cmbActividad);
            this.Controls.Add(this.lblActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSociosActividad_7_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios por actividad";
            this.Load += new System.EventHandler(this.frmSociosActividad_7__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimirActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporteActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListarActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.DataGridView dgvActividad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnListarActividad;
        private System.Windows.Forms.PictureBox imgImprimirActividad;
        private System.Windows.Forms.PictureBox imgReporteActividad;
        private System.Windows.Forms.PictureBox imgListarActividad;
        private System.Windows.Forms.PictureBox imgDeuda;
        private System.Windows.Forms.Label lblMenor2;
        private System.Windows.Forms.Label lblMayor2;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}