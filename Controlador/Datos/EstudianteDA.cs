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

        public void addEstudiante(Estudiante objEstudiante)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BaseDatos.getConexionSql();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_INS_ESTUDIANTE";

            SqlParameter parameter1 = new SqlParameter("CEDULA",objEstudiante.Cedula);
            cmd.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter("NOMBRES", objEstudiante.Nombres);
            cmd.Parameters.Add(parameter2);

            SqlParameter parameter3 = new SqlParameter("APELLIDOS", objEstudiante.Apellidos);
            cmd.Parameters.Add(parameter3);


            SqlParameter parameter4 = new SqlParameter("DIRECCION", objEstudiante.Direccion);
            cmd.Parameters.Add(parameter4);


            SqlParameter paramete5 = new SqlParameter("FECHA_NACIMIENTO", objEstudiante.Fecha_nacimieno);
            cmd.Parameters.Add(paramete5);


            SqlParameter paramete6 = new SqlParameter("CONTRASENA", objEstudiante.Contrasena);
            cmd.Parameters.Add(paramete6);

            cmd.ExecuteNonQuery();

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
