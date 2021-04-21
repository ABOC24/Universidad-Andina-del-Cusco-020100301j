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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        CapaNegocio.Laboratorio lab1 = new CapaNegocio.Laboratorio();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text;
            int foro = int.Parse(txtForo.Text);
            string tipo = txtTipo.Text;
            int cantidadAlumno = int.Parse(txtCantidadAlumno.Text);
            lab1.Elemento = elemento;
            lab1.Foro = foro;
            lab1.Tipo = tipo;
            lab1.CantidadAlumno = cantidadAlumno;
            MessageBox.Show("Se ha registrado correctamente los datos de el Laboratorio");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string elementos = lab1.Elemento;
            int foro = lab1.Foro;
            string tipo = lab1.Tipo;
            int cantidadAlumno = lab1.CantidadAlumno;
            MessageBox.Show("Elementos: " + elementos + "Foro: " + foro + "Tipo: " + tipo + "CantidadAlumnos" + cantidadAlumno);
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Investigar());
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Experimentar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Aprender());
        }
    }
}
