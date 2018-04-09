using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vueling.Common.Logic.model;
using Newtonsoft.Json;



namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class AlumnoJsonDaoTests
    {
        private string path = (@"alumnos.json");
        private IAlumnoDao alumnojsondao;


        [TestInitialize]
        public void testInit()
        {
            alumnojsondao = new AlumnoJsonDao();

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
            alumnojsondao.Add(alumno);

            // Leemos fichero pruebas JSON
            Alumno alumnotest = LeerAlumnoJson();

            Console.WriteLine(alumno);
            Console.WriteLine(alumnotest);

            Assert.IsTrue(alumno.Equals(alumnotest));
        }


        [TestCleanup]
        public void testClean()
        {
            //
        }

        private Alumno LeerAlumnoJson()
        {
            //String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //var fullPath = path + "\\" + "alumnos.json";


            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sw = new StreamReader(fs))
            {

                String json = sw.ReadToEnd();
                return JsonConvert.DeserializeObject<Alumno>(json);
            }
        }
    }
}
    
