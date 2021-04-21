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
    public partial class frmPpp : Form
    {
        public frmPpp()
        {
            InitializeComponent();
        }

        CapaNegocio.Ppp practicante1 = new CapaNegocio.Ppp();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellido.Text;
            string nombres = txtNombre.Text;
            string dni = txtDni.Text;
            string profesion = txtProfesion.Text;
            string ocupacion = txtOcupacion.Text;
            practicante1.Apellidos = apellidos;
            practicante1.Nombres = nombres;
            practicante1.Dni = dni;
            practicante1.Profesion = profesion;
            practicante1.Ocupacion = ocupacion;
            MessageBox.Show("Se ha registrado correctamente los datos del Practicante");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = practicante1.Apellidos;
            string nombres = practicante1.Nombres;
            string dni = practicante1.Dni;
            string profesion = practicante1.Profesion;
            string ocupacion = practicante1.Ocupacion;
            MessageBox.Show("Apellidos: " + apellidos + "   Nombres: " + nombres + "   Edad: " + dni + "   Profesion: " + profesion + "   Ocupacion: " + ocupacion);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicante1.Aprender());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicante1.Trabajar());
        }

        private void btnAquirirExperiencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicante1.AAdquirirExpreciencia());
        }
    }
}
