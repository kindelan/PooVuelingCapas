using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.model;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoTxtDao : IAlumnoDao
    {

       

        private string path = (@"alumnos.txt");

        public Alumno Add(Alumno alumno)
        {
            if (File.Exists(path))
            {
                using (StreamWriter w = File.AppendText(path))
                {
                    w.WriteLine(alumno.ToString());
                }

               
            }
            else
            {
                FileStream fs = new FileStream(path,FileMode.Create,FileAccess.ReadWrite);

                using (StreamWriter w = new StreamWriter(fs))

                {

                    w.WriteLine(alumno.ToString());
                }

            
            }
            return alumno;
        }
    }
}
