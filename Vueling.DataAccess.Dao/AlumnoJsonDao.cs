using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.model;
using Newtonsoft.Json;
using System.IO;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoJsonDao : IAlumnoDao
    {
        private string path = (@"alumnos.json");

        public Alumno Add(Alumno alumno)
        {
            if (File.Exists(path))
            {
                string outputJSON = JsonConvert.SerializeObject(alumno);

                using (StreamWriter w = File.AppendText(path))
                {
                    w.WriteLine(outputJSON);
                }



            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

                string outputJSON = JsonConvert.SerializeObject(alumno);
                using (StreamWriter w = new StreamWriter(fs))

                {

                    w.WriteLine(outputJSON);
                }


            }
            return alumno;
        }

    }

}
