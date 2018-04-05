using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.model;
using Vueling.DataAccess.Dao;

namespace Vueling.Busisness.Logic
{
    public class AlumnoBl : IAlumnobL
    {
        private IAlumnoDao alumnodao;

        public Alumno Add(Alumno alumno, string format)
        {
            Alumno al;
            alumno.calculoEdad();
            alumno.horaRegistro();

            switch (format)
            {
                case "txt":
                    alumnodao = new AlumnoTxtDao();
                    al = alumnodao.Add(alumno);
                    break;
                case "json":
                    alumnodao = new AlumnoJsonDao();
                    al = alumnodao.Add(alumno);
                    break;
                case "xml":
                    alumnodao = new AlumnoXmlDao();
                    al = alumnodao.Add(alumno);
                    break;
                default:
                    alumnodao = new AlumnoTxtDao();
                    al = alumnodao.Add(alumno);
                    break;
            }

            return al;
        }

    }
}
