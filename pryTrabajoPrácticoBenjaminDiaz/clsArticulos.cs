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
        // El archivo debe estar en la carpeta bin/Debug
        private string RutaArchivo = "Articulos.csv";

        public void ListarPorRubro(DataGridView Grilla, string rubroBuscado, Label lblCant, Label lblTot)
        {
            int cantidad = 0;
            decimal totalGeneral = 0;

            Grilla.Rows.Clear();

            // Validación simple de existencia
            if (File.Exists(RutaArchivo))
            {
                StreamReader sr = new StreamReader(RutaArchivo);

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] VecDatos = linea.Split(',');

                    // Comparamos el rubro (suponiendo que está en la posición 3)
                    if (VecDatos[3] == rubroBuscado)
                    {
                        decimal costo = Convert.ToDecimal(VecDatos[4]);
                        int stock = Convert.ToInt32(VecDatos[5]);
                        decimal valorFila = costo * stock;

                        Grilla.Rows.Add(VecDatos[0], VecDatos[1], costo, stock, valorFila);

                        cantidad++;
                        totalGeneral += valorFila;
                    }
                }
                sr.Close();

                // Actualización de etiquetas
                lblCant.Text = "Cantidad de Artículos: " + cantidad.ToString("00");
                lblTot.Text = "Total Valor Stock: " + totalGeneral.ToString("C2");
            }
            else
            {
                MessageBox.Show("Archivo no encontrado.");
            }
        }

        public void Exportar(string rubroBuscado)
        {
            string RutaExportar = "Consulta_" + rubroBuscado + ".csv";

            // Creamos el archivo de destino (false para sobreescribir)
            StreamWriter sw = new StreamWriter(RutaExportar, false);
            sw.WriteLine("Codigo,Descripcion,Costo,Stock,ValorTotal");

            // Abrimos el origen para leer
            StreamReader sr = new StreamReader(RutaArchivo);

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] VecDatos = linea.Split(',');

                if (VecDatos[3] == rubroBuscado)
                {
                    decimal costo = Convert.ToDecimal(VecDatos[4]);
                    int stock = Convert.ToInt32(VecDatos[5]);
                    decimal valorFila = costo * stock;

                    sw.WriteLine(VecDatos[0] + "," + VecDatos[1] + "," + costo + "," + stock + "," + valorFila);
                }
            }

            sr.Close();
            sw.Close();

            MessageBox.Show("Archivo '" + RutaExportar + "' generado con éxito.");
        }
        public void Grabar(string codigo, string desc, string rubro, string costo, string stock)
        {
            // Abrimos en modo 'true' para agregar al final (Append)
            StreamWriter sw = new StreamWriter(RutaArchivo, true);

            // Escribimos la línea con el mismo formato que veníamos leyendo
            sw.WriteLine(codigo + "," + desc + "," + rubro + "," + costo + "," + stock);

            sw.Close();
        }
    }
}

