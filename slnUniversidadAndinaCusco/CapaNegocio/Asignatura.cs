using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        private string especialidad;
        private string idiomas;
        private int aula;
        private string profesor;

        public string Especialidad
        {
            get { return especialidad; } 
            set { especialidad = value; }
        }
        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }
        public int Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        public string Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        //Metodos u operaciones
        public string Aprender()
        {
            return "No se ha implementado el metodo Aprender";
        }
        public string Clasificar()
        {
            return "No se ha implementado el metodo Clasificar";
        }
        public string Conocer()
        {
            return "No se ha implementado el metodo Conocer";
        }
    }
}
