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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellido.Text;
            string nombres = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string especialidad = txtEspecialidad.Text;
            string gradoAcademico = txtGradoAcademico.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.Especialidad = especialidad;
            rector1.gradoAcademico = gradoAcademico;
            MessageBox.Show("Se han registrado correctamente los datos de rector 1");
        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Representar());
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int edad = rector1.Edad;
            string especialidad = rector1.Especialidad;
            string gradoacademico = rector1.gradoAcademico;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad" + edad + " Especialidad: " + especialidad  + "Grado de Instruccion: " + gradoacademico);
        }

        private void btnAdministar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Administrar());
        }

        private void btnReglamentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Reglamentar());
        }
    }
}
