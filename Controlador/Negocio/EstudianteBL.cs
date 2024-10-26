using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase5.Controlador.Datos;
using Clase5.Modelo;

namespace Clase5.Controlador.Negocio
{
    public class EstudianteBL
    {
        public List<Estudiante> GetEstudiantes()
        {
            EstudianteDA objEstudianteBaseDatos = new EstudianteDA();
            return objEstudianteBaseDatos.getEstudiantes();
        }

        public void addEstudiante(Estudiante objEstudiante)
        {
            EstudianteDA objEstudianteBaseDatos = new EstudianteDA();
            objEstudianteBaseDatos.addEstudiante(objEstudiante);
        }


    }
}
