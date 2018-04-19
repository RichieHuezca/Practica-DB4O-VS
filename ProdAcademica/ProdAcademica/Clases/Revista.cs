using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class Revista : MedioDePublicacion
    {
        public Revista(string titulo) : base(titulo)
        {

        }
        public string ISSN { get; set; }
        

    }

}