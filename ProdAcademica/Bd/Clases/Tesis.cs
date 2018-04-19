using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bd
{
    public class Tesis : ProduccionAcademica
    {
        private const string Nivel = "ING";

        public Tesis(string titulo, Estudiante estudiante, Docente asesor) : base(titulo)
        {
            Estudiante = estudiante;
            Asesor = asesor;
        }
        public Estudiante Estudiante
        {
            get; set;
        }

        public Docente Asesor
        {
            get; set;
           
        }
    }


}