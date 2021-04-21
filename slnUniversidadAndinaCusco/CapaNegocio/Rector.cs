using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        private string apellidos;
        private string nombres;
        private int edad;
        private string especialidad;
        private string universidad;
        private string gradoacademico;
        //Propiedades
        public string Apellidos
        {
            get { return apellidos; } 
            set { apellidos = value; } 
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        
        public string gradoAcademico
        {
            get { return gradoacademico; }
            set { gradoacademico = value; }
        }

        //Metodos u operaciones
        public string Representar()
        {
            return "No se ha implementado el metodo representar";
        }
        public string Administrar()
        {
            return "No se ha implementado el método administrar";
        }
        public string Reglamentar()
        {
            return "No se ha implementado el metodo reglamentar";
        }
    }
}
