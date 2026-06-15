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
    public partial class frmAgregarArtículo : Form
    {
        public frmAgregarArtículo()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text.Trim() != "" && cmbRubros.SelectedIndex != -1 && txtCosto.Text.Trim() != "")
            {
         
                clsArticulos objArticulo = new clsArticulos();

               


                objArticulo.Grabar(txtDescripcion.Text, cmbRubros.Text, txtCosto.Text);
                

                txtDescripcion.Clear();
                txtCosto.Clear();
                cmbRubros.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de grabar.", "Atención");
            }
        }
        private void LimpiarControles()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtCosto.Text = "0";
            txtStock.Text = "0";
            cmbRubros.SelectedIndex = -1; 
            txtCodigo.Focus();           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            {
                
                this.Close();
            }
        }

        private void frmAgregarArtículo_Load(object sender, EventArgs e)
        {
            clsRubros objRubros = new clsRubros();

            
            objRubros.LlenarCombo(cmbRubros);

            if (cmbRubros.Items.Count > 0)
            {
                cmbRubros.SelectedIndex = 0;
            }
        }
    }
}
