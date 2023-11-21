using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFI
{
    public partial class frmSociosBarrio_8_ : Form
    {
        public frmSociosBarrio_8_()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        private void frmSociosBarrio_8__Load(object sender, EventArgs e)
        {
            clsBarrio combo = new clsBarrio();
            combo.ComboBarrio(cmbBarrio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 barrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            clsSocio listar = new clsSocio();
            listar.ListarSociosActividad(dgvBarrio, barrio);
            listar.MayorDeudaBarrio(lblMayor2, barrio);
            listar.MenorDeudaBarrio(lblMenor2, barrio);
            listar.PromedioBarrio(lblPromedio2, barrio);
        }

        private void btnReporteBarrio_Click(object sender, EventArgs e)
        {
            Int32 barrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            clsSocio exp = new clsSocio();
            exp.ReporteBarrio(barrio);
            MessageBox.Show("Reporte generado con éxito");
        }

        private void btnImprimirBarrio_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio imp = new clsSocio();
            imp.Barrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            imp.ImprimirBarrio(e);
        }
    }
}
