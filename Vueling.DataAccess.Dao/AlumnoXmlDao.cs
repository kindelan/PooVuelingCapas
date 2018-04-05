using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vueling.Common.Logic.model;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoXmlDao : IAlumnoDao
    {
        private string path = (@"alumnos.xml");

        public Alumno Add(Alumno alumno)
        {
            if (File.Exists(path))
            {
                List<Alumno> alumnos = new List<Alumno>();
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                using (StreamReader r = new StreamReader(path))
                {
                    String xml = r.ReadToEnd();
                    StringReader stringReader = new StringReader(xml);
                    alumnos = (List<Alumno>)xSeriz.Deserialize(stringReader);
                    alumnos.Add(alumno);
                }

                using (FileStream fs1 = new FileStream(path, FileMode.Open))
                    xSeriz.Serialize(fs1, alumnos);

            }
            else
            {
                List<Alumno> alumnos = new List<Alumno>();
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                alumnos.Add(alumno);

                using (FileStream fs1 = new FileStream(path, FileMode.Create))
                    xSeriz.Serialize(fs1, alumnos);
            }
            return alumno;
        }

    }
}
