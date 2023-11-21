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
    public partial class frmSociosActividad_7_ : Form
    {
        public frmSociosActividad_7_()
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

        private void frmSociosActividad_7__Load(object sender, EventArgs e)
        {
            clsActividad combo = new clsActividad();
            combo.ComboActividad(cmbActividad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 act = 0;
            act = Convert.ToInt32(cmbActividad.SelectedValue);
            clsSocio reporte = new clsSocio();
            reporte.ReporteSociosActividad(act);
            MessageBox.Show("Reporte generado exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 idAct = Convert.ToInt32(cmbActividad.SelectedValue);
            clsSocio listar = new clsSocio();
            listar.ListarSociosActividad(dgvActividad, idAct);
            listar.MayorDeudaActividad(lblMayor2, idAct);
            listar.MenorDeudaActividad(lblMenor2, idAct);
            listar.PromedioActividad(lblPromedio2, idAct);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio imp = new clsSocio();
            imp.Actividad = Convert.ToInt32(cmbActividad.SelectedValue);
            imp.ImprimirActividad(e);
        }
    }
}
