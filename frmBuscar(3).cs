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
    public partial class frmBuscar_3_ : Form
    {
        public frmBuscar_3_()
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

        private void frmBuscar_3__Load(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            txtNombre.Text = "";
            lblNombre.Text = "";
            lblDireccion.Text = "";
            txtBarrio.Text = "";
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            txtNombre.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtActividad.ReadOnly = false;
            txtDeuda.ReadOnly = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtDni.ReadOnly = true;
            btnGuardar.Enabled = true;
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtDni.Text);
            clsSocio socio = new clsSocio();
            socio.Eliminar(id);
            MessageBox.Show("El dato ha sido eliminado con éxito");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsSocio clsSocios = new clsSocio();
            clsSocios.nom = txtNombre.Text;
            clsSocios.direc = txtDireccion.Text;
            clsSocios.Barrio = Convert.ToInt32(txtBarrio.Text);
            clsSocios.Actividad = Convert.ToInt32(txtActividad.Text);
            clsSocios.Deu = Convert.ToDecimal(txtDeuda.Text);
            clsSocios.Modificar(Convert.ToInt32(txtDni.Text));
            MessageBox.Show("El socio ha sido guardado con éxito");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("No existe este socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Int32 IdSocio = Convert.ToInt32(txtDni.Text);
                clsSocio x = new clsSocio();
                x.Buscar(IdSocio);
                if (x.DNI != 0)
                {
                    txtNombre.Text = x.nom;
                    txtDireccion.Text = x.direc.ToString();
                    txtBarrio.Text = x.Barrio.ToString();
                    txtActividad.Text = x.Actividad.ToString();
                    txtDeuda.Text = x.Deu.ToString();
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Este socio no se encuentra registrado");
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }

        }
    }
}
