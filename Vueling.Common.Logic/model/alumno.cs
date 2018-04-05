using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.model
{
     public class Alumno : VuelingObject
    {
        //Atributos (atributos privados)
        private string Nombre;
        private int IdAlumno;

      

        //propiedades (propiedades publicas y mayuscula)

        public int IdAlumnos { get => IdAlumnos; set => IdAlumnos = value; }

        public string GetNombre()
        {
            return GetNombre();
        }

        public void SetNombre(string value)
        {
            SetNombre(value);
        }
    }
}
