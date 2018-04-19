using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class MemoriaEstadia : ProduccionAcademica
    {
        private const string Nivel = "TSU";

        public MemoriaEstadia(string titulo) : base(titulo)
        {

        }
        public Estudiante Estudiante
        {
            get; set;
        }
    }
}