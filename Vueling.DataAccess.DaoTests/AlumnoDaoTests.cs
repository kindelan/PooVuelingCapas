using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vueling.Common.Logic.model;

namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class AlumnoDaoTests
    {
        private string path = (@"alumnos.txt");
        private IAlumnoDao alumnodao;


        [TestInitialize]
        public void testInit()
        {
            alumnodao = new AlumnoTxtDao();

            if (File.Exists(path)) { File.Delete(path); }
        }

        [DataRow(1, "dd", "dd", "dd", "10-03-1988")]
        [DataTestMethod]
        public void AddTest(int idAlumno, string name, string apellidos, string dni, string fechadenacimiento)
        {
            var fechaNac = Convert.ToDateTime(fechadenacimiento);
            Alumno alumno = new Alumno(name, apellidos, idAlumno, fechaNac, dni);
            alumno.Guid = System.Guid.NewGuid().ToString();
            alumno.calculoEdad();
            alumno.horaRegistro();
            alumnodao.Add(alumno);
            Console.WriteLine(alumno.FechadeCreacion);

            Alumno alumnotest = LeerAlumnoTxt();
            Console.WriteLine(alumno);
            Console.WriteLine(alumnotest);

            Assert.IsTrue(alumno.Equals(alumnotest));
        }

        [TestCleanup]
        public void testClean()
        {
            //
        }

        private Alumno LeerAlumnoTxt()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sw = new StreamReader(fs))
            {
                String text = sw.ReadToEnd();
                string[] fields = text.Split(';');
                var nombre = fields[0];
                var apellidos = fields[1];
                var id = Convert.ToInt32(fields[2]);
                var fechadenacimiento = Convert.ToDateTime(fields[3]);
                var dni = fields[4];
                var edad = Convert.ToInt32(fields[5]);          
                var fechadecreacion = Convert.ToDateTime(fields[6]);
                Console.WriteLine(fechadecreacion);
                var Guid = fields[7];
                return new Alumno(nombre, apellidos, id, fechadenacimiento, dni, edad, fechadecreacion, Guid);
            }
        }
    }
}