using Clase5.Controlador.Negocio;
using Clase5.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5.Vista
{
    public partial class frmEstudianteModal : Form
    {
        public string tipo = "";

        public frmEstudianteModal()
        {
            InitializeComponent();
        }


        private void frmEstudianteModal_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                grabarEstudiante();
            }
        }

        private bool validaciones()
        {
            return true;
        }

        private void grabarEstudiante()
        {
            Estudiante objEstudiante = new Estudiante(
                txtCedula.Text,
                txtNombres.Text,
                txtApellidos.Text,
                txtDireccion.Text,
                dtpFecha.Value,
                txtContrasena.Text,
                ddlEstado.Text.Substring(0,1)
                );
            EstudianteBL objEstudianteControlador = new EstudianteBL();
            if (tipo == "N")
            {
                objEstudianteControlador.addEstudiante(objEstudiante);
                MessageBox.Show("Estudiante Ingresado con Éxito!");
            }
            {

            }
           
            this.Dispose();
        }
    }
}
