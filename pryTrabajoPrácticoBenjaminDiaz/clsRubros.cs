using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

internal class clsRubros
{
    
    private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BD_TrabajoPractico.mdb;";

    public void LlenarCombo(ComboBox combo)
    {
        combo.Items.Clear();

        
        OleDbConnection conexion = new OleDbConnection(cadenaConexion);
        OleDbCommand comando = new OleDbCommand();

        comando.Connection = conexion;
        comando.CommandType = CommandType.Text;
        comando.CommandText = "SELECT Nombre_rubro FROM Rubros ORDER BY Nombre_rubro ASC";

        try
        {
            conexion.Open();

         
            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable tablaRubros = new DataTable();
            adaptador.Fill(tablaRubros);

            foreach (DataRow fila in tablaRubros.Rows)
            {
                combo.Items.Add(fila["Nombre_rubro"].ToString());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar rubros: " + ex.Message, "Error");
            combo.Items.Add("Sin Rubros");
        }
        finally
        {
            conexion.Close();
        }
    }
}