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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarNuevosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar_2_ agregar = new frmAgregar_2_();
            agregar.ShowDialog();
        }

        private void buscarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar_3_ buscar = new frmBuscar_3_();
            buscar.ShowDialog();    
        }

        private void consultaDeUnSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar consultar = new frmConsultar();
            consultar.ShowDialog();
        }

        private void listadoDeTodosLosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTodos todos = new frmListarTodos();
            todos.ShowDialog();
        }

        private void listadoDeSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosDeudores deudores = new frmSociosDeudores();
            deudores.ShowDialog();
        }

        private void listadoDeSociosDeUnaActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosActividad_7_ act = new frmSociosActividad_7_();
            act.ShowDialog();
        }

        private void listadoDeSociosDeUnBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosBarrio_8_ barrio = new frmSociosBarrio_8_();
            barrio.ShowDialog();
        }

        private void acercaDelDesarrolladorDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesarrolador tomi = new frmDesarrolador();
            tomi.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
