using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bd
{
    public class Revista : MedioDePublicacion
    {
        public Revista(string titulo) : base(titulo)
        {

        }
        public string ISSN { get; set; }
        

    }

}