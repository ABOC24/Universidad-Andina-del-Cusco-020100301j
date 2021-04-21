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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefe1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellido.Text;
            string nombres = txtNombre.Text;
            string dni = txtDni.Text;
            jefe1.Apellidos = apellidos;
            jefe1.Nombres = nombres;
            jefe1.Dni = dni;
            MessageBox.Show("Se ha registrado correctamente los datos del Jefe de Practica");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefe1.Apellidos;
            string nombres = jefe1.Nombres;
            string dni = jefe1.Dni;
            MessageBox.Show(" Apellidos: " + apellidos + " Nombres:" + nombres + " Dni:" + dni);
        }

        private void btnBrindarAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.BrindarAyuda());
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Supervisar());
        }

        private void btnControla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Controlar());
        }
    }
}
