using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();

        private void btnLeer_Click_1(object sender, EventArgs e)
        {
            string apellidos = txtApellido.Text;
            string nombres = txtNombre.Text;
            string dni = txtDni.Text;
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Dni = dni;
            docente1.Profesion = profesion;
            MessageBox.Show("Se ha registrado correctamente los datos de Docente");
        }

        private void btnEscribir_Click_1(object sender, EventArgs e)
        {
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            string dni = docente1.Dni;
            string profesion = docente1.Profesion;
            MessageBox.Show(" Apellidos: " + apellidos + " Nombres:" + nombres + " Dni:" + dni + " Profesion:" + profesion);
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Trabajar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Enseñar());
        }
    }
}
