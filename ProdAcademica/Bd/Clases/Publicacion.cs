using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bd
{
    public class MedioDePublicacion
    {
        private string titulo;

        public MedioDePublicacion(string titulo)
        {
            this.titulo = titulo;
        }

        public string Nombre { set; get; }
    }
}