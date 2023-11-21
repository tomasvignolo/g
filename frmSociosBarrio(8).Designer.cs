namespace pryIEFI
{
    partial class frmSociosBarrio_8_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSociosBarrio_8_));
            this.lblMenor2 = new System.Windows.Forms.Label();
            this.lblMayor2 = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.btnImprimirBarrio = new System.Windows.Forms.Button();
            this.btnReporteBarrio = new System.Windows.Forms.Button();
            this.btnListarBarrio = new System.Windows.Forms.Button();
            this.dgvBarrio = new System.Windows.Forms.DataGridView();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.imgDeuda = new System.Windows.Forms.PictureBox();
            this.imgImprimirBarrio = new System.Windows.Forms.PictureBox();
            this.imgReporteBarrio = new System.Windows.Forms.PictureBox();
            this.imgListarBarrio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimirBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporteBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListarBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenor2
            // 
            this.lblMenor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor2.Location = new System.Drawing.Point(519, 309);
            this.lblMenor2.Name = "lblMenor2";
            this.lblMenor2.Size = new System.Drawing.Size(82, 18);
            this.lblMenor2.TabIndex = 63;
            // 
            // lblMayor2
            // 
            this.lblMayor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor2.Location = new System.Drawing.Point(519, 261);
            this.lblMayor2.Name = "lblMayor2";
            this.lblMayor2.Size = new System.Drawing.Size(82, 18);
            this.lblMayor2.TabIndex = 62;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(394, 306);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(119, 20);
            this.lblMenor.TabIndex = 61;
            this.lblMenor.Text = "Menor deuda:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(396, 258);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(117, 20);
            this.lblMayor.TabIndex = 60;
            this.lblMayor.Text = "Mayor deuda:";
            // 
            // btnImprimirBarrio
            // 
            this.btnImprimirBarrio.Location = new System.Drawing.Point(398, 444);
            this.btnImprimirBarrio.Name = "btnImprimirBarrio";
            this.btnImprimirBarrio.Size = new System.Drawing.Size(96, 36);
            this.btnImprimirBarrio.TabIndex = 59;
            this.btnImprimirBarrio.Text = "Imprimir";
            this.btnImprimirBarrio.UseVisualStyleBackColor = true;
            this.btnImprimirBarrio.Click += new System.EventHandler(this.btnImprimirBarrio_Click);
            // 
            // btnReporteBarrio
            // 
            this.btnReporteBarrio.Location = new System.Drawing.Point(233, 443);
            this.btnReporteBarrio.Name = "btnReporteBarrio";
            this.btnReporteBarrio.Size = new System.Drawing.Size(96, 36);
            this.btnReporteBarrio.TabIndex = 58;
            this.btnReporteBarrio.Text = "Generar reporte";
            this.btnReporteBarrio.UseVisualStyleBackColor = true;
            this.btnReporteBarrio.Click += new System.EventHandler(this.btnReporteBarrio_Click);
            // 
            // btnListarBarrio
            // 
            this.btnListarBarrio.Location = new System.Drawing.Point(67, 444);
            this.btnListarBarrio.Name = "btnListarBarrio";
            this.btnListarBarrio.Size = new System.Drawing.Size(96, 36);
            this.btnListarBarrio.TabIndex = 57;
            this.btnListarBarrio.Text = "Listar";
            this.btnListarBarrio.UseVisualStyleBackColor = true;
            this.btnListarBarrio.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBarrio
            // 
            this.dgvBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrio.Location = new System.Drawing.Point(22, 78);
            this.dgvBarrio.Name = "dgvBarrio";
            this.dgvBarrio.Size = new System.Drawing.Size(344, 346);
            this.dgvBarrio.TabIndex = 53;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(22, 39);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(344, 21);
            this.cmbBarrio.TabIndex = 52;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(101, 9);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(168, 18);
            this.lblBarrio.TabIndex = 51;
            this.lblBarrio.Text = "Seleccione su barrio:";
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio2.Location = new System.Drawing.Point(493, 353);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(108, 18);
            this.lblPromedio2.TabIndex = 66;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(398, 350);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(89, 20);
            this.lblPromedio.TabIndex = 65;
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
            //this.imgDeuda.Image = global::pryIEFI.Properties.Resources.deuda;
            this.imgDeuda.Location = new System.Drawing.Point(432, 99);
            this.imgDeuda.Name = "imgDeuda";
            this.imgDeuda.Size = new System.Drawing.Size(133, 117);
            this.imgDeuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDeuda.TabIndex = 64;
            this.imgDeuda.TabStop = false;
            // 
            // imgImprimirBarrio
            // 
            //this.imgImprimirBarrio.Image = global::pryIEFI.Properties.Resources.imprimir;
            this.imgImprimirBarrio.Location = new System.Drawing.Point(353, 443);
            this.imgImprimirBarrio.Name = "imgImprimirBarrio";
            this.imgImprimirBarrio.Size = new System.Drawing.Size(39, 37);
            this.imgImprimirBarrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImprimirBarrio.TabIndex = 56;
            this.imgImprimirBarrio.TabStop = false;
            // 
            // imgReporteBarrio
            // 
            //this.imgReporteBarrio.Image = global::pryIEFI.Properties.Resources.reporte;
            this.imgReporteBarrio.Location = new System.Drawing.Point(188, 444);
            this.imgReporteBarrio.Name = "imgReporteBarrio";
            this.imgReporteBarrio.Size = new System.Drawing.Size(39, 37);
            this.imgReporteBarrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReporteBarrio.TabIndex = 55;
            this.imgReporteBarrio.TabStop = false;
            // 
            // imgListarBarrio
            // 
            //this.imgListarBarrio.Image = global::pryIEFI.Properties.Resources.listar;
            this.imgListarBarrio.Location = new System.Drawing.Point(22, 444);
            this.imgListarBarrio.Name = "imgListarBarrio";
            this.imgListarBarrio.Size = new System.Drawing.Size(39, 37);
            this.imgListarBarrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgListarBarrio.TabIndex = 54;
            this.imgListarBarrio.TabStop = false;
            // 
            // frmSociosBarrio_8_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 493);
            this.Controls.Add(this.lblPromedio2);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.imgDeuda);
            this.Controls.Add(this.lblMenor2);
            this.Controls.Add(this.lblMayor2);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.btnImprimirBarrio);
            this.Controls.Add(this.btnReporteBarrio);
            this.Controls.Add(this.btnListarBarrio);
            this.Controls.Add(this.imgImprimirBarrio);
            this.Controls.Add(this.imgReporteBarrio);
            this.Controls.Add(this.imgListarBarrio);
            this.Controls.Add(this.dgvBarrio);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSociosBarrio_8_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios por barrio";
            this.Load += new System.EventHandler(this.frmSociosBarrio_8__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimirBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporteBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListarBarrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDeuda;
        private System.Windows.Forms.Label lblMenor2;
        private System.Windows.Forms.Label lblMayor2;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Button btnImprimirBarrio;
        private System.Windows.Forms.Button btnReporteBarrio;
        private System.Windows.Forms.Button btnListarBarrio;
        private System.Windows.Forms.PictureBox imgImprimirBarrio;
        private System.Windows.Forms.PictureBox imgReporteBarrio;
        private System.Windows.Forms.PictureBox imgListarBarrio;
        private System.Windows.Forms.DataGridView dgvBarrio;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}