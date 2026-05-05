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
                clsArticulos objArticulo = new clsArticulos();

                // Pasamos todo: la grilla, el texto del combo y los dos labels de abajo
                objArticulo.Consultar(dgvConsulta, cboRubros.Text, lblCantidad, lblTotal);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rubro.");
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

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            // Creamos el objeto para usar la clase rubros
            clsRubros objRubros = new clsRubros();
            
           

            // Opcional: para que no empiece vacío el combo
            if (cboRubros.Items.Count > 0)
            {
                cboRubros.SelectedIndex = 0;
            }
        }

    }
    
}

