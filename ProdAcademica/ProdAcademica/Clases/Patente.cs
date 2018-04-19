using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class Patente : ProduccionAcademica
    {
        public string NoRegistro { get; set; }
        public Patente(string titulo) : base(titulo)
        {

        }
    }
}