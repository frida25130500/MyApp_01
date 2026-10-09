using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp_01
{
    internal class Datos
    {
        SqlConnection conexion;
        string cadenaConexion = "Server=localhost,1433;Integrated Security=false;" +
     "User=sa;password=L12345678.;initial catalog=Agenda";
    
        private void conexionOpen()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        private void conexionClose()
        {
            try { conexion.Close(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public bool Insertar(string nombre, string paterno, string materno,
            string telefono, string correo)
        {
            try
            {
                conexionOpen();
                string comando = "Insert Into Datos(Nombre,Paterno,Materno,Telefono," +
                    "Correo)Values('" + nombre + "','" + paterno +
                    "','" + materno + "','" + telefono + "','" + correo + "')";
                SqlCommand sqlCommand = new SqlCommand(comando, conexion);
                sqlCommand.ExecuteNonQuery();
                conexionClose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
                return false;
            }
        }
        public DataSet Informacion(string comando)
        {
            DataSet ds= new DataSet();
            try
            {
                conexionOpen();
                SqlDataAdapter da = new SqlDataAdapter(comando, conexion);
                da.Fill(ds);
                conexion.Close();
                return ds;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.ToString());
                return null;
            }

        }
    }
}




