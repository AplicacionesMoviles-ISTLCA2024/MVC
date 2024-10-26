using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.Controlador.Datos
{
    public static class BaseDatos
    {
        private static string cadenaConexionWindows = "Persist Security Info=False;Trusted_Connection=True;database=ACADEMICO_ISTLC;server=LT-EMANOSALVAS\\SQLEXPRESS";
        private static string cadenaConexionSa = "Persist Security Info=False;User ID=sa;Password=Representaciones.2024;Initial Catalog=ACADEMICO_ISTLC;Server=LT-EMANOSALVAS\\SQLEXPRESS";

        private static SqlConnection conexion;

        public static SqlConnection getConexionSql()
        {
            conexion = new SqlConnection(cadenaConexionSa);
            conexion.Open();
            return conexion;
        }

    }
}
