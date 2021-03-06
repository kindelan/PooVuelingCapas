﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.model
{
    public class Alumno : VuelingObject
    {
        //Atributos (atributos privados)
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public int IdAlumno { set; get; }
        public DateTime FechadeNacimiento { set; get; }
        public string Dni { set; get; }
        public int Edad { set; get; }
        public DateTime FechadeCreacion { set; get; }
        public string Guid { set; get; }

        public Alumno()
        {
        }

        public Alumno(string nombre, string apellidos, int idAlumno, DateTime fechadeNacimiento, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            IdAlumno = idAlumno;
            FechadeNacimiento = fechadeNacimiento;
            Dni = dni;
        }

        public Alumno(string nombre, string apellidos, int idAlumno, DateTime fechadeNacimiento, string dni, int edad, DateTime fechadeCreacion, string guid) : this(nombre, apellidos, idAlumno, fechadeNacimiento, dni)
        {
            Edad = edad;
            FechadeCreacion = fechadeCreacion;
            Guid = guid;
        }

        public void calculoEdad()
        {
            Edad = DateTime.Now.Year - FechadeNacimiento.Year;
        }

        public void horaRegistro()
        {
            FechadeCreacion = DateTime.Now;
        }

        public void SetGuid()
        {
            Guid = System.Guid.NewGuid().ToString();
        }


        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};", Nombre, Apellidos, IdAlumno, FechadeNacimiento, Dni, Edad, FechadeCreacion, Guid);
        }

        public override bool Equals(object obj)
        {
            var alumno = obj as Alumno;
            return alumno != null &&
                   Nombre == alumno.Nombre &&
                   Apellidos == alumno.Apellidos &&
                   IdAlumno == alumno.IdAlumno &&
                   FechadeNacimiento == alumno.FechadeNacimiento &&
                   Dni == alumno.Dni &&
                   Edad == alumno.Edad &&
                   FechadeCreacion.Date == alumno.FechadeCreacion.Date &&
                   Guid == alumno.Guid;
        }

        public override int GetHashCode()
        {
            var hashCode = 1122968978;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + IdAlumno.GetHashCode();
            hashCode = hashCode * -1521134295 + FechadeNacimiento.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + Edad.GetHashCode();

            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Guid);
            return hashCode;
        }
    }
}
