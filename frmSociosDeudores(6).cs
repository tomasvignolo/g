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
    public partial class frmSociosDeudores : Form
    {
        public frmSociosDeudores()
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
            lista.ListarSociosDeudores(dgvDeudores);
            lista.MayorDeudaDeudores(lblMayor2);
            lista.MenorDeudaDeudores(lblMenor2);
            lista.PromedioDeudores(lblPromedio2);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSociosDeudores_Load(object sender, EventArgs e)
        {

        }
    }
}
