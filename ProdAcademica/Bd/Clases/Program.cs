

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd
{
    class Program
    {
        static void Main(string[] args)
        {
            Util db = new Util();
            // Tesis ProductoTesis = new Tesis("Mi mundo", new Estudiante("5108", "Miguel Mancera"), new Docente("Carmen salinas"));
          //  Util.MostrarTodosObjetos();
            // ProductoTesis.Asesor = (new Docente("Carmen Salinas"));

             Libro Plibro1 = new Libro("El mundo y sus demonios", new Autor("Carl sagan"), 1479);

          //  Estudiante es = new Estudiante("1025", "jose");

            // Console.WriteLine("Titulo tesis: " + ProductoTesis.Titulo);
            //   Console.WriteLine("Producto: " + ProductoTesis.Asesor.Nombre);

            Console.WriteLine("Titulo: " + Plibro1.Titulo);
            Console.WriteLine("Autor: " + Plibro1.Autor);
            Console.WriteLine("ISBN: " + Plibro1.ISBN);
            // Util.Guardar(Plibro);
            Util.Guardar(Plibro1);

            Util.MostrarTodosObjetos();

            /*   if (Util.BDDisponible())
               {
                   Util.Guardar(Plibro);
                   Util.MostrarTodosObjetos();
               }  */
            Console.ReadLine();

        }
    }
}
