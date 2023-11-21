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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
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

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            clsSocio cbo = new clsSocio();
            cbo.LlenarComboNombres(cmbNombres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbNombres.Text == "")
            {
                MessageBox.Show("Seleccione un nombre de socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Nombre = (cmbNombres.Text);
                clsSocio x = new clsSocio();
                x.Consultar(Nombre);

                if (x.DNI != 0)
                {
                   txtDni.Text = x.DNI.ToString();
                   txtDireccion.Text = x.direc.ToString();
                   txtBarrio.Text = x.Barrio.ToString();
                   txtActividad.Text = x.Actividad.ToString();
                   txtDeuda.Text = x.Deu.ToString();
                   txtDni.ReadOnly = true;
                   txtDireccion.ReadOnly = true;
                   txtBarrio.ReadOnly = true;
                   txtActividad.ReadOnly = true;
                   txtDeuda.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Socio no encontrado");
                }
            }
        }

        private void cmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNombres_Click(object sender, EventArgs e)
        {

        }
    }
}
