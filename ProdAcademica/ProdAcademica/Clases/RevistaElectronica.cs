using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class RevistaElectronica : Revista
    {
        public RevistaElectronica(string titulo) : base(titulo)
        {
        }

        public int URL
        {
            get; set;
        }
    }

    public class RevistaImpresa : Revista
    {
        public RevistaImpresa(string titulo) : base(titulo)
        {
        }
    }
}