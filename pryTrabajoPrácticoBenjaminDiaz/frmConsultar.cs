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

                
                objArticulo.Consultar(dgvConsulta, cboRubros.Text, lblCantidad, lblTotal);
            }
            else
            {
                MessageBox.Show("Por Favor elija un rubro.");
            }
        }
        

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (cboRubros.SelectedIndex != -1)
            {
                string rubro = cboRubros.SelectedItem.ToString();

          
                SaveFileDialog selectorArchivo = new SaveFileDialog();
                selectorArchivo.Filter = "Archivos CSV (*.csv)|*.csv";
                selectorArchivo.FileName = "Reporte_" + rubro + ".csv";

 
                if (selectorArchivo.ShowDialog() == DialogResult.OK)
                {
                    string ruta = selectorArchivo.FileName;

                    clsArticulos objArticulo = new clsArticulos();
       
                    objArticulo.Exportar(rubro, ruta);
                }
            }
            else
            {
                MessageBox.Show("Elija un rubro para exportar los datos.");
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
                string rubro = cboRubros.SelectedItem.ToString();

                SaveFileDialog selectorArchivo = new SaveFileDialog();
                selectorArchivo.Filter = "Archivos CSV (*.csv)|*.csv";
                selectorArchivo.FileName = "Reporte_" + rubro + ".csv";

                if (selectorArchivo.ShowDialog() == DialogResult.OK)
                {
                    string ruta = selectorArchivo.FileName;

                    clsArticulos objArticulo = new clsArticulos();
                    objArticulo.Exportar(rubro, ruta);
                }
            }
            else
            {
                MessageBox.Show("Elija un rubro para exportar los datos.");
            }
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            clsRubros objRubros = new clsRubros();

            objRubros.LlenarCombo(cboRubros);

            if (cboRubros.Items.Count > 0)
            {
                cboRubros.SelectedIndex = 0;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            if (dgvConsulta.Rows.Count > 0)
            {
       
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos en la grilla para imprimir.", "Atención");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
            Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fuenteSubtitulo = new Font("Arial", 12, FontStyle.Bold);
            Font fuenteTexto = new Font("Arial", 10, FontStyle.Regular);

           
            int x = 100;
            int y = 100;

           
            e.Graphics.DrawString("CYBERSTOCK - REPORTE DE ARTÍCULOS", fuenteTitulo, Brushes.Black, x, y);
            y += 40;
            e.Graphics.DrawString("Rubro seleccionado: " + cboRubros.Text, fuenteSubtitulo, Brushes.Black, x, y);
            y += 40;


            e.Graphics.DrawString("Código", fuenteSubtitulo, Brushes.Black, x, y);
            e.Graphics.DrawString("Descripción", fuenteSubtitulo, Brushes.Black, x + 100, y);
            e.Graphics.DrawString("Precio", fuenteSubtitulo, Brushes.Black, x + 350, y);
            e.Graphics.DrawString("Stock", fuenteSubtitulo, Brushes.Black, x + 450, y);
            e.Graphics.DrawString("Total", fuenteSubtitulo, Brushes.Black, x + 550, y);
            y += 30;


            e.Graphics.DrawLine(Pens.Black, x, y, x + 600, y);
            y += 10;


            foreach (DataGridViewRow fila in dgvConsulta.Rows)
            {
        
                if (fila.Cells[0].Value == null) continue;

                string codigo = fila.Cells[0].Value.ToString();
                string descripcion = fila.Cells[1].Value.ToString();
                string precio = fila.Cells[2].Value.ToString();
                string stock = fila.Cells[3].Value.ToString();
                string total = fila.Cells[4].Value.ToString();

                e.Graphics.DrawString(codigo, fuenteTexto, Brushes.Black, x, y);
                e.Graphics.DrawString(descripcion, fuenteTexto, Brushes.Black, x + 100, y);
                e.Graphics.DrawString("$" + precio, fuenteTexto, Brushes.Black, x + 350, y);
                e.Graphics.DrawString(stock, fuenteTexto, Brushes.Black, x + 450, y);
                e.Graphics.DrawString("$" + total, fuenteTexto, Brushes.Black, x + 550, y);

                y += 25; 
            }

            y += 20;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 600, y);
            y += 15;

            
            e.Graphics.DrawString(lblCantidad.Text, fuenteSubtitulo, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString(lblTotal.Text, fuenteSubtitulo, Brushes.Black, x, y);
        }
    }
    
 }
    


