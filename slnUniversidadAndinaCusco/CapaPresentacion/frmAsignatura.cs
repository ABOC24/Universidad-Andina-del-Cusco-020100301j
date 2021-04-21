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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();

        private void btnLeer_Click_1(object sender, EventArgs e)
        {
            string especialidad = txtEspecialidad.Text;
            string idiomas = txtIdiomas.Text;
            string profesor = txtProfesor.Text;
            int aula = int.Parse(txtAula.Text);
            asignatura1.Especialidad = especialidad;
            asignatura1.Idiomas = idiomas;
            asignatura1.Profesor = profesor;
            asignatura1.Aula = aula;
            MessageBox.Show("Se han registrado correctamente los datos de la Asignatura");
        }

        private void btnEscribir_Click_1(object sender, EventArgs e)
        {
            string especialidad = asignatura1.Especialidad;
            string idiomas = asignatura1.Idiomas;
            int aula = asignatura1.Aula;
            string profesor = asignatura1.Profesor;
            MessageBox.Show("Especialidad: " + especialidad + "  Idiomas: " + idiomas + "  Aula: " + aula + "  Profesor: " + profesor);
        }

        private void btnAprender_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprender());
        }

        private void btnClasificar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Clasificar());
        }

        private void btnConocer_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Conocer());
        }

    }
}
