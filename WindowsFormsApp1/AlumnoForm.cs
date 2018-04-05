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
            alumnoBl = new IAlumnobL;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void boxdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadAlumnoData();
        Alumno.IdAlumno = convert.ToInt32()

    }
}
