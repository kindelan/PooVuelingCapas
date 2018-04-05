using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Common.Logic.model;
using Vueling.Busisness.Logic;

namespace WindowsFormsApp1
{
    public partial class AlumnoForm : Form

        
    {

        private Alumno alumno;
        private IAlumnobL alumnoBl;

       

        public AlumnoForm()
        {
            InitializeComponent();
            alumno = new Alumno ();
            alumnoBl = new AlumnoBl();
        }

        private void LoaddatosForm(string format)
        {
            alumno.IdAlumno = Convert.ToInt32(boxdni.Text);
            alumno.Nombre = boxnombre.Text;
            alumno.Apellidos = boxapellido.Text;
            alumno.Dni = boxdni.Text;
            alumno.FechadeNacimiento = Convert.ToDateTime(boxfecha.Text);
            alumnoBl.Add(alumno, format);
        }

        private void buttontxt_Click(object sender, EventArgs e)
        {
            LoaddatosForm("txt");
        }

        private void buttonjson_Click(object sender, EventArgs e)
        {
            LoaddatosForm("json");
          
        }

        private void buttonxml_Click(object sender, EventArgs e)
        {
            LoaddatosForm("xml");

        }
    }
}
