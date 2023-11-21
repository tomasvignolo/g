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
    public partial class frmAgregar_2_ : Form
    {
        public frmAgregar_2_()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsSocio socio = new clsSocio();
            socio.DNI = Convert.ToInt32(txtIdSocio.Text);
            socio.nom = txtNombre.Text;
            socio.direc = txtDireccion.Text;
            socio.Barrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            socio.Actividad = Convert.ToInt32(cmbActividad.SelectedValue);
            socio.Deu = Convert.ToDecimal(txtDeuda.Text);
            socio.Agregar();
            MessageBox.Show("El cliente ha sido agregado correctamente");
        }

        private void frmAgregar_2__Load(object sender, EventArgs e)
        {
            clsActividad act = new clsActividad();
            act.ComboActividad(cmbActividad);
            clsBarrio barr = new clsBarrio();
            barr.ComboBarrio(cmbBarrio);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
