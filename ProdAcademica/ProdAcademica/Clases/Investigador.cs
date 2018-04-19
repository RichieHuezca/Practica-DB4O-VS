using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class Docente : Autor
    {
        public string NoEmpleado { set; get; }

        public Docente (string nombre)
            :base ( nombre)
        {
            Nombre = nombre;
        }
    }
}