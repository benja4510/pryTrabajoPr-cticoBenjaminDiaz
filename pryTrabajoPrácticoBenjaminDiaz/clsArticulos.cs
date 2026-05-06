using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPrácticoBenjaminDiaz
{
    internal class clsArticulos
    {
        private string RutaArchivo = "Articulos.csv";

        public void Grabar(string codigo, string desc, string rubro, string costo, string stock)
        {
            StreamWriter sw = new StreamWriter(RutaArchivo, true);
            
            sw.WriteLine(codigo + ";" + desc + ";" + rubro + ";" + costo + ";" + stock);
            sw.Close();
        }

        public void Consultar(DataGridView Grilla, string rubroBuscado, Label lblCantidad, Label lblTotal)
        {
            int cantidad = 0;
            decimal totalGeneral = 0;

            Grilla.Rows.Clear();

            if (File.Exists(RutaArchivo))
            {
                StreamReader sr = new StreamReader(RutaArchivo);

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    if (!string.IsNullOrEmpty(linea))
                    {
                        string[] VecDatos = linea.Split(';');

                        if (VecDatos.Length >= 5)
                        {
                            if (VecDatos[2].Trim().ToUpper() == rubroBuscado.Trim().ToUpper())
                            {
                                decimal costo = Convert.ToDecimal(VecDatos[3]);
                                int stock = Convert.ToInt32(VecDatos[4]);
                                decimal valorFila = costo * stock;

                                Grilla.Rows.Add(VecDatos[0], VecDatos[1], costo, stock, valorFila);

                                
                                cantidad++;
                                totalGeneral += valorFila;
                            }
                        }
                    }
                }
                sr.Close();

                
                lblCantidad.Text = "Cantidad de Artículos: " + cantidad.ToString();
                lblTotal.Text = "Total Valor Stock: " + totalGeneral.ToString("C2");
            }
        }

        public void Exportar(string rubroBuscado)
        {
            string RutaExportar = "Consulta_" + rubroBuscado + ".csv";
            StreamWriter sw = new StreamWriter(RutaExportar, false);
            
            sw.WriteLine("sep=;");
            sw.WriteLine("Codigo;Descripcion;Rubro;Costo;Stock;Total");

            if (File.Exists(RutaArchivo))
            {
                StreamReader sr = new StreamReader(RutaArchivo);
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    if (!string.IsNullOrEmpty(linea))
                    {
                        string[] VecDatos = linea.Split(';');
                        if (VecDatos[2].Trim().ToUpper() == rubroBuscado.Trim().ToUpper())
                        {
                            decimal vTotal = Convert.ToDecimal(VecDatos[3]) * Convert.ToDecimal(VecDatos[4]);
                            sw.WriteLine(VecDatos[0] + ";" + VecDatos[1] + ";" + VecDatos[2] + ";" + VecDatos[3] + ";" + VecDatos[4] + ";" + vTotal);
                        }
                    }
                }
                sr.Close();
            }
            sw.Close();
            MessageBox.Show("Archivo '" + RutaExportar + "' generado con éxito.");
        }
    }

}

