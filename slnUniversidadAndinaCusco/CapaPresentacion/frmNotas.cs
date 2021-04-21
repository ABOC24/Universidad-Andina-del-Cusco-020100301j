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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        CapaNegocio.Notas nota1 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string curso = txtCurso.Text;
            int valor = int.Parse(txtValor.Text);
            nota1.Curso = curso;
            nota1.Valor = valor;
            MessageBox.Show("Se han registrado correctamente los datos de Notas1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string curso = nota1.Curso;
            int valor = nota1.Valor;
            MessageBox.Show("Curso: " + curso + "  Valor: " + valor);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Desaprobar());
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Aumentar());
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Disminuir());
        }
    }
}
