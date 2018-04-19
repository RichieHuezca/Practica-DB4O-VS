using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class Libro : ProduccionAcademica
    {
        private int v;

        public Libro(string titulo) : base(titulo)
        {

        }

        public Libro(string titulo, Autor autor, int v) : this(titulo)
        {
            this.Autor = autor;
            this.v = v;
        }

        public Autor Autor { get; set; }

        public int ISBN { get; set; }

    }
}