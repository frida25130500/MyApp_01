using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace MyApp_01
{
    internal class Datos
    {
        SqlConnection conexion;
        string cadenaConexion = "Server=localhost,1433;Integrated Security =false"+
            "User=sa; password= L12345678.;initial catalog = Agenda";
        private void conexionOpen()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexionOpen();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());

            
            private void conexionClose()
        {
            try
            {
                conexionClose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
}
    }



