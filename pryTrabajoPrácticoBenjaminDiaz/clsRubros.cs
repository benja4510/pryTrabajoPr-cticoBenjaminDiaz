using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    // Suponiendo que el archivo de rubros solo tiene el nombre
                    combo.Items.Add(linea);
                }
                sr.Close();
            }
            if (combo.Items.Count > 0) combo.SelectedIndex = 0;
        }
    }
}
}
