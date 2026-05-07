using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPrácticoBenjaminDiaz
{
    internal class clsRubros
    {

        private string RutaArchivo = "Rubros.csv";

        public void LlenarCombo(ComboBox combo)
        {

            combo.Items.Clear();

            if (File.Exists(RutaArchivo))
            {
                StreamReader sr = new StreamReader(RutaArchivo);

                while (!sr.EndOfStream)
                {
                    string rubro = sr.ReadLine();
                    if (!string.IsNullOrEmpty(rubro))
                    {
                        combo.Items.Add(rubro);
                    }
                }

                sr.Close();
            }
            else
            {

                combo.Items.Add("Sin Rubros");
            }
        }
    }
}
