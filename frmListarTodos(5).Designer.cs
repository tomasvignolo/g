namespace pryIEFI
{
    partial class frmListarTodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarTodos));
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor2 = new System.Windows.Forms.Label();
            this.lblMenor2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.imgDeuda = new System.Windows.Forms.PictureBox();
            this.imgImprimir = new System.Windows.Forms.PictureBox();
            this.imgReporte = new System.Windows.Forms.PictureBox();
            this.imgListar = new System.Windows.Forms.PictureBox();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(22, 23);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(339, 355);
            this.dgvSocios.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(67, 413);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 36);
            this.btnListar.TabIndex = 25;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(233, 412);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(96, 36);
            this.btnReporte.TabIndex = 26;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(398, 413);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 36);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(388, 77);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(117, 20);
            this.lblMayor.TabIndex = 28;
            this.lblMayor.Text = "Mayor deuda:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(388, 124);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(119, 20);
            this.lblMenor.TabIndex = 29;
            this.lblMenor.Text = "Menor deuda:";
            // 
            // lblMayor2
            // 
            this.lblMayor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor2.Location = new System.Drawing.Point(511, 80);
            this.lblMayor2.Name = "lblMayor2";
            this.lblMayor2.Size = new System.Drawing.Size(56, 18);
            this.lblMayor2.TabIndex = 30;
            // 
            // lblMenor2
            // 
            this.lblMenor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor2.Location = new System.Drawing.Point(513, 124);
            this.lblMenor2.Name = "lblMenor2";
            this.lblMenor2.Size = new System.Drawing.Size(54, 18);
            this.lblMenor2.TabIndex = 31;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(388, 167);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(89, 20);
            this.lblPromedio.TabIndex = 33;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio2.Location = new System.Drawing.Point(483, 170);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(84, 18);
            this.lblPromedio2.TabIndex = 34;
            // 
            // imgDeuda
            // 
            ///this.imgDeuda.Image = global::pryIEFI.Properties.Resources.deuda;
            this.imgDeuda.Location = new System.Drawing.Point(422, 232);
            this.imgDeuda.Name = "imgDeuda";
            this.imgDeuda.Size = new System.Drawing.Size(110, 89);
            this.imgDeuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDeuda.TabIndex = 32;
            this.imgDeuda.TabStop = false;
            // 
            // imgImprimir
            // 
            //this.imgImprimir.Image = global::pryIEFI.Properties.Resources.imprimir;
            this.imgImprimir.Location = new System.Drawing.Point(353, 412);
            this.imgImprimir.Name = "imgImprimir";
            this.imgImprimir.Size = new System.Drawing.Size(39, 37);
            this.imgImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImprimir.TabIndex = 24;
            this.imgImprimir.TabStop = false;
            // 
            // imgReporte
            // 
            //this.imgReporte.Image = global::pryIEFI.Properties.Resources.reporte;
            this.imgReporte.Location = new System.Drawing.Point(188, 413);
            this.imgReporte.Name = "imgReporte";
            this.imgReporte.Size = new System.Drawing.Size(39, 37);
            this.imgReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReporte.TabIndex = 23;
            this.imgReporte.TabStop = false;
            // 
            // imgListar
            // 
            //this.imgListar.Image = global::pryIEFI.Properties.Resources.listar;
            this.imgListar.Location = new System.Drawing.Point(22, 413);
            this.imgListar.Name = "imgListar";
            this.imgListar.Size = new System.Drawing.Size(39, 37);
            this.imgListar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgListar.TabIndex = 22;
            this.imgListar.TabStop = false;
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmListarTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 476);
            this.Controls.Add(this.lblPromedio2);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.imgDeuda);
            this.Controls.Add(this.lblMenor2);
            this.Controls.Add(this.lblMayor2);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.imgImprimir);
            this.Controls.Add(this.imgReporte);
            this.Controls.Add(this.imgListar);
            this.Controls.Add(this.dgvSocios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de todos los socios";
            this.Load += new System.EventHandler(this.frmListarTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.PictureBox imgListar;
        private System.Windows.Forms.PictureBox imgReporte;
        private System.Windows.Forms.PictureBox imgImprimir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor2;
        private System.Windows.Forms.Label lblMenor2;
        private System.Windows.Forms.PictureBox imgDeuda;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}