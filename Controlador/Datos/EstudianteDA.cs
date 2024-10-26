using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase5.Modelo;

namespace Clase5.Controlador.Datos
{
    public class EstudianteDA
    {
        public List<Estudiante> getEstudiantes()
        {
            List<Estudiante> respuesta = new List<Estudiante>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BaseDatos.getConexionSql();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONS_ESTUDIANTES";

            SqlDataAdapter adapatador = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapatador.Fill(ds);

            respuesta = fillEstudiantes(ds.Tables[0]);
            return respuesta;
        }

        private List<Estudiante> fillEstudiantes(DataTable dt)
        {
            List<Estudiante> respuesta = new List<Estudiante>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Estudiante objEstudiante = new Estudiante(
                    dt.Rows[i]["CEDULA"].ToString(),
                    dt.Rows[i]["NOMBRES"].ToString(),
                    dt.Rows[i]["APELLIDOS"].ToString(),
                    dt.Rows[i]["DIRECCION"].ToString(),
                    DateTime.Parse(dt.Rows[i]["FECHA_NACIMIENTO"].ToString()),
                    dt.Rows[i]["CONTRASENA"].ToString(),
                    dt.Rows[i]["ESTADO"].ToString()
                    );

                respuesta.Add(objEstudiante);
            }

            return respuesta;
        }
    }
}
