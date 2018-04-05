using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.model;

namespace Vueling.Busisness.Logic
{
    public interface IAlumnobL
    {
        Alumno Add(Alumno alumno, string format);
    }

}
