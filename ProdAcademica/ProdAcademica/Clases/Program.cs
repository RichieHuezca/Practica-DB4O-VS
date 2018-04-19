using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA_BDOOp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Util db = new Util();
           // Tesis ProductoTesis = new Tesis("Mi mundo", new Estudiante("5108", "Miguel Mancera"), new Docente("Carmen salinas"));
            Util.MostrarTodosObjetos();
           // ProductoTesis.Asesor = (new Docente("Carmen Salinas"));

           // Libro Plibro = new Libro("El mundo y sus demonios", new Autor("Carl sagan"),  1479);

            Estudiante es = new Estudiante("1025","jose");

           // Console.WriteLine("Titulo tesis: " + ProductoTesis.Titulo);
               //   Console.WriteLine("Producto: " + ProductoTesis.Asesor.Nombre);

             Console.WriteLine("ncontrol: " + es.NoControl);
            Console.WriteLine("nombre: " + es.Nombre);
            // Util.Guardar(Plibro);
           Util.Guardar(es);

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
