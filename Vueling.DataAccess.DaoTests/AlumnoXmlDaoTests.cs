using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vueling.Common.Logic.model;
using System.Xml.Serialization;
using System.Xml;

namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class AlumnoXmlDaoTests
    {

        private string path = (@"alumnos.xml");
        private IAlumnoDao alumnoxmldao;

        [TestInitialize]
        public void testInit()
        {
            alumnoxmldao = new AlumnoXmlDao();

            if (File.Exists(path)) { File.Delete(path); }
        }

        [DataRow(1, "dd", "dd", "dd", "10-03-1888")]


        [DataTestMethod]
        public void AddTest(int idAlumno, string name, string apellidos, string dni, string fechadenacimiento)
        {
            var fechaNac = Convert.ToDateTime(fechadenacimiento);
            Alumno alumno = new Alumno(name, apellidos, idAlumno, fechaNac, dni);
            alumno.Guid = System.Guid.NewGuid().ToString();
            alumno.calculoEdad();
            alumno.horaRegistro();

            // Realizamos la llamada metodo para añadir elemento
            alumnoxmldao.Add(alumno);

            // Leemos fichero pruebas Xml
            Alumno alumnotest = LeerAlumnoXml();

            Console.WriteLine(alumno);
            Console.WriteLine(alumnotest);

            Assert.IsTrue(alumno.Equals(alumnotest));
        }


        [TestCleanup]
        public void testClean()
        {
            //
        }

        public Alumno LeerAlumnoXml()
        {
            if (File.Exists(path))
            {
                List<Alumno> alumnos;
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                using (StreamReader r = new StreamReader(path))
                {
                    String xml = r.ReadToEnd();
                    StringReader stringReader = new StringReader(xml);
                    alumnos = (List<Alumno>)xSeriz.Deserialize(stringReader);
                }
                return alumnos[0];
            }
            else
            {
                return new Alumno();
            }
        }
    }
}