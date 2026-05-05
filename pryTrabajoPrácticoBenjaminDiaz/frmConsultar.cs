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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            if (cboRubros.SelectedIndex != -1)
            {
                string rubro = cboRubros.SelectedItem.ToString();

                // Instanciamos la clase y llamamos al método
                clsArticulos objArticulo = new clsArticulos();
                objArticulo.ListarPorRubro(dgvConsulta, rubro, lblCantidad, lblTotal);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rubro primero.");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (cboRubros.SelectedIndex != -1)
            {
                string rubro = cboRubros.SelectedItem.ToString();

                clsArticulos objArticulo = new clsArticulos();
                objArticulo.Exportar(rubro);
            }
            else
            {
                MessageBox.Show("Seleccione un rubro para exportar los datos correspondientes.");
            }
        }
        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarExportacion(); 
        }

        
        private void RealizarExportacion()
        {
            if (cboRubros.SelectedIndex != -1)
            {
                clsArticulos objArticulo = new clsArticulos();
                objArticulo.Exportar(cboRubros.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un rubro.");
            }
        }

    } 
}

