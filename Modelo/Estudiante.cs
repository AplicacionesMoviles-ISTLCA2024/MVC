using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.Modelo
{
    public class Estudiante
    {
        string cedula;
        string nombres;
        string apellidos;
        string direccion;
        DateTime fecha_nacimieno;
        string contrasena;
        string estado;

        public Estudiante(string cedula, string nombres, string apellidos, string direccion, DateTime fecha_nacimieno, string contrasena, string estado)
        {
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Fecha_nacimieno = fecha_nacimieno;
            this.Contrasena = contrasena;
            this.Estado = estado;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_nacimieno { get => fecha_nacimieno; set => fecha_nacimieno = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
