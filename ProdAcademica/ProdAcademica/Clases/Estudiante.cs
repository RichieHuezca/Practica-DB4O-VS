using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{

    public class Estudiante : Autor
    {
        public Estudiante(string noControl,  string nombre) : base(nombre)
        {
            Nombre = nombre;
            NoControl = noControl;
        }

        public string NoControl { get; set; }
    }

    public class Estudiantes
    {
        private List<Estudiante> m_Estudiantes;

        public Estudiantes()
        {
            Util db = new Util();
            m_Estudiantes = new List<Estudiante>();

         //   m_Estudiantes.Add(new Estudiante("5247", "David"));
             m_Estudiantes.Add(new Estudiante("5248", "Oscar"));
            // m_Estudiantes.Add(new Estudiante(noControl, nombre);
           // m_Estudiantes.Add(new Estudiante(Util.Guardar());



        }

        public List<Estudiante> GetEstudiantes()
        {
            //Modificar para que muestre los de la BD
            
            Util.MostrarTodosObjetos();
            return (m_Estudiantes);
        }
    }
}
   