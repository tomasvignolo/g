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
    public partial class frmListarTodos : Form
    {
        public frmListarTodos()
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
        private void button1_Click(object sender, EventArgs e)
        {
            clsSocio lista = new clsSocio();
            lista.ListarSocios(dgvSocios);
            lista.MayorDeudaTodos(lblMayor2);
            lista.MenorDeudaTodos(lblMenor2);
            lista.PromedioTodos(lblPromedio2);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsSocio exp = new clsSocio();
            exp.Reporte();
            MessageBox.Show("Reporte generado exitosamente");
        }

        private void frmListarTodos_Load(object sender, EventArgs e)
        {
            
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio imp = new clsSocio();
            imp.ImprimirTodosLosSocios(e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente");
        }
    }
}
