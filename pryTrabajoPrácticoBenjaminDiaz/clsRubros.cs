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
        private string RutaRubros = "Rubros.csv";

        public void LlenarCombo(ComboBox combo)
        {
            combo.Items.Clear();
            if (File.Exists(RutaRubros))
            {
                StreamReader sr = new StreamReader(RutaRubros);
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    
                    combo.Items.Add(linea);
                }
                sr.Close();
            }
            if (combo.Items.Count > 0) combo.SelectedIndex = 0;
        }
    }
}

