using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPrácticoBenjaminDiaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consultarArticukosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar frmConsulta = new frmConsultar();
            frmConsulta.ShowDialog();
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArtículo frmAgregar = new frmAgregarArtículo();
            frmAgregar.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();
            frmDatos.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
