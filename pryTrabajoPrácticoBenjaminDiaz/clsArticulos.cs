using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

internal class clsArticulos
{
    private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BD_TrabajoPractico.mdb;";

    public void Grabar(string desc, string rubro, string costo)
    {
        OleDbConnection conexion = new OleDbConnection(cadenaConexion);
        OleDbCommand comando = new OleDbCommand();

        comando.Connection = conexion;
        comando.CommandType = CommandType.Text;

        comando.CommandText = "INSERT INTO Articulos (Nombre_articulo, Precio, IdRubro) " +
                              "VALUES (@desc, @precio, (SELECT TOP 1 IdRubro FROM Rubros WHERE Nombre_rubro = @rubro))";

        comando.Parameters.AddWithValue("@desc", desc);
        comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(costo));
        comando.Parameters.AddWithValue("@rubro", rubro);

        try
        {
            conexion.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Artículo cargado con éxito en la Base de Datos.", "Éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al grabar el artículo: " + ex.Message, "Error");
        }
        finally
        {
            conexion.Close();
        }
    }

    public void Consultar(DataGridView Grilla, string rubroBuscado, Label lblCantidad, Label lblTotal)
    {
        int cantidad = 0;
        decimal totalGeneral = 0;

        Grilla.Rows.Clear();

        OleDbConnection conexion = new OleDbConnection(cadenaConexion);
        OleDbCommand comando = new OleDbCommand();

        comando.Connection = conexion;
        comando.CommandType = CommandType.Text;

       
        comando.CommandText = "SELECT A.IdArticulo, A.Nombre_articulo, A.Precio, A.IdRubro " +
                              "FROM Articulos A " +
                              "INNER JOIN Rubros R ON A.IdRubro = R.IdRubro " +
                              "WHERE R.Nombre_rubro = @rubro";

        comando.Parameters.AddWithValue("@rubro", rubroBuscado);

        try
        {
            conexion.Open();
            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable tablaArticulos = new DataTable();
            adaptador.Fill(tablaArticulos);

            foreach (DataRow fila in tablaArticulos.Rows)
            {
                decimal costo = Convert.ToDecimal(fila["Precio"]);
                int stock = 1; 
                decimal valorFila = costo * stock;

                
                Grilla.Rows.Add(fila["IdArticulo"], fila["Nombre_articulo"], costo, stock, valorFila);

                cantidad++;
                totalGeneral += valorFila;
            }

            lblCantidad.Text = "Cantidad de Artículos: " + cantidad.ToString();
            lblTotal.Text = "Total Valor Stock: " + totalGeneral.ToString("C2");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al consultar datos: " + ex.Message, "Error");
        }
        finally
        {
            conexion.Close();
        }
    }


    public void Exportar(string rubroBuscado, string rutaDestino)
    {
        try
        {
            StreamWriter sw = new StreamWriter(rutaDestino, false);
            sw.WriteLine("sep=;");
            sw.WriteLine("Codigo;Descripcion;Precio;Total");

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            string sql = "SELECT A.IdArticulo, A.Nombre_articulo, A.Precio " +
                         "FROM Articulos A " +
                         "INNER JOIN Rubros R ON A.IdRubro = R.IdRubro " +
                         "WHERE R.Nombre_rubro = @rubro";

            OleDbCommand comando = new OleDbCommand(sql, conexion);
            comando.Parameters.AddWithValue("@rubro", rubroBuscado);

            conexion.Open();
            OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            foreach (DataRow fila in dt.Rows)
            {
                sw.WriteLine(fila["IdArticulo"] + ";" + fila["Nombre_articulo"] + ";" + fila["Precio"] + ";" + fila["Precio"]);
            }

            sw.Close();
            conexion.Close();
            MessageBox.Show("Archivo exportado correctamente.", "Éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al exportar: " + ex.Message);
        }
    }
}