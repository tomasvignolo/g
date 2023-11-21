namespace pryIEFI
{
    partial class frmSociosDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSociosDeudores));
            this.btnReporteDeudores = new System.Windows.Forms.Button();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.lblDeudores = new System.Windows.Forms.Label();
            this.imgReporteDeudores = new System.Windows.Forms.PictureBox();
            this.imgListarDeudores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporteDeudores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListarDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporteDeudores
            // 
            this.btnReporteDeudores.Location = new System.Drawing.Point(247, 432);
            this.btnReporteDeudores.Name = "btnReporteDeudores";
            this.btnReporteDeudores.Size = new System.Drawing.Size(96, 36);
            this.btnReporteDeudores.TabIndex = 38;
            this.btnReporteDeudores.Text = "Generar reporte";
            this.btnReporteDeudores.UseVisualStyleBackColor = true;
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(81, 433);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(96, 36);
            this.btnListarDeudores.TabIndex = 37;
            this.btnListarDeudores.Text = "Listar";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            this.btnListarDeudores.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Location = new System.Drawing.Point(21, 55);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.Size = new System.Drawing.Size(344, 355);
            this.dgvDeudores.TabIndex = 33;
            // 
            // lblDeudores
            // 
            this.lblDeudores.AutoSize = true;
            this.lblDeudores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudores.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudores.Location = new System.Drawing.Point(45, 16);
            this.lblDeudores.Name = "lblDeudores";
            this.lblDeudores.Size = new System.Drawing.Size(287, 21);
            this.lblDeudores.TabIndex = 45;
            this.lblDeudores.Text = "Socios con una deuda mayor a 0";
            this.lblDeudores.Click += new System.EventHandler(this.label5_Click);
            // 
            // imgReporteDeudores
            // 
            //this.imgReporteDeudores.Image = global::pryIEFI.Properties.Resources.reporte;
            this.imgReporteDeudores.Location = new System.Drawing.Point(202, 433);
            this.imgReporteDeudores.Name = "imgReporteDeudores";
            this.imgReporteDeudores.Size = new System.Drawing.Size(39, 37);
            this.imgReporteDeudores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReporteDeudores.TabIndex = 35;
            this.imgReporteDeudores.TabStop = false;
            // 
            // imgListarDeudores
            // 
            //this.imgListarDeudores.Image = global::pryIEFI.Properties.Resources.listar;
            this.imgListarDeudores.Location = new System.Drawing.Point(36, 433);
            this.imgListarDeudores.Name = "imgListarDeudores";
            this.imgListarDeudores.Size = new System.Drawing.Size(39, 37);
            this.imgListarDeudores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgListarDeudores.TabIndex = 34;
            this.imgListarDeudores.TabStop = false;
            // 
            // frmSociosDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 485);
            this.Controls.Add(this.lblDeudores);
            this.Controls.Add(this.btnReporteDeudores);
            this.Controls.Add(this.btnListarDeudores);
            this.Controls.Add(this.imgReporteDeudores);
            this.Controls.Add(this.imgListarDeudores);
            this.Controls.Add(this.dgvDeudores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSociosDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios deudores";
            this.Load += new System.EventHandler(this.frmSociosDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporteDeudores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListarDeudores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReporteDeudores;
        private System.Windows.Forms.Button btnListarDeudores;
        private System.Windows.Forms.PictureBox imgReporteDeudores;
        private System.Windows.Forms.PictureBox imgListarDeudores;
        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.Label lblDeudores;
    }
}