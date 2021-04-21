using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        private string curso;
        private int valor;

        public string Curso
        {
            get { return curso; } 
            set { curso = value; } 
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar ";
        }
        public string Aumentar()
        {
            return "No se ha implementado el metodo aumentar";
        }
        public string Disminuir()
        {
            return "No se ha implementado el método disminuir";
        }
    }
}
