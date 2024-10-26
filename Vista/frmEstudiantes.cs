using Clase5.Controlador.Negocio;
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
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            EstudianteBL objControladorEstudiante = new EstudianteBL();
            grdEstudiantes.DataSource= objControladorEstudiante.GetEstudiantes();
        }
    }
}
