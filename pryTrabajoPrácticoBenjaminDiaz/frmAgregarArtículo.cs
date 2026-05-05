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
            {
                // 1. Validar que no haya campos vacíos (mínima validación estética)
                if (txtCodigo.Text != "" && txtDescripcion.Text != "" && cmbRubros.SelectedIndex != -1)
                {
                    // 2. Instanciar la clase
                    clsArticulos objArticulo = new clsArticulos();

                    // 3. Llamar al método grabar (el que creamos anteriormente)
                    // Pasamos los textos de los controles como parámetros
                    objArticulo.Grabar(
                        txtCodigo.Text,
                        txtDescripcion.Text,
                        cmbRubros.Text,
                        txtCosto.Text,
                        txtStock.Text
                    );

                    // 4. Feedback al usuario y limpieza
                    MessageBox.Show("Artículo cargado exitosamente en CyberStock", "Éxito");
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Atención");
                }
            }
        }
        private void LimpiarControles()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtCosto.Text = "0";
            txtStock.Text = "0";
            cmbRubros.SelectedIndex = -1; // Deselecciona el combo
            txtCodigo.Focus();           // Deja el cursor listo para el siguiente código
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            {
                // Cierra el formulario actual
                this.Close();
            }
        }
    }
}
