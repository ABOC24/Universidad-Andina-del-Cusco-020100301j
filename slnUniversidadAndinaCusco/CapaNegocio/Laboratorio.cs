using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        private string elemento;
        private int foro;
        private string tipo;
        private int cantidadAlumno;

        public string Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
        public int Foro
        {
            get { return foro; }
            set { foro = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int CantidadAlumno
        {
            get { return this.cantidadAlumno; }
            set { this.cantidadAlumno = value; }
        }

        //Metodos u operaciones
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string Experimentar()
        {
            return "No se ha implementado el metodo Experimentar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }

    }
}
