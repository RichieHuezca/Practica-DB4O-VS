using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bd
{
    public class MemoriaCongreso : MedioDePublicacion
    {
        public MemoriaCongreso(string titulo) : base(titulo)
        {
        }

        public int ISBN
        {
            get; set;
        }
    }
}