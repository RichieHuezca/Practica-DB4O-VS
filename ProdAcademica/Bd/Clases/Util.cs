
using System;
using System.IO;
using Db4objects.Db4o;
using Db4objects.Db4o.Ext;

namespace Bd
{
    public class Util
    {
        /* public readonly static string YapFileName = Path.Combine(  
                               Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),   
                               "formula1.yap");  
        */
        
        private static IObjectContainer db;

        public readonly static string NombreArchivo = "C://Db4o//UTIM_PAcademica.dboo";
        public readonly static int ServerPort = 0xdb40;		
		public readonly static string ServerUser = "user";		
		public readonly static string ServerPassword = "password";

		public static void ListResult(IObjectSet result)
		{
			Console.WriteLine(result.Count);
			foreach (object item in result)
			{
				Console.WriteLine(item);
			}
		}

		public static void ListRefreshedResult(IObjectContainer container, IObjectSet items, int depth)
		{
			Console.WriteLine(items.Count);
			foreach (object item in items)
			{	
				container.Ext().Refresh(item, depth);
				Console.WriteLine(item);
			}
		}
		
		
        public static void RetrieveAll(IObjectContainer db) 
		{
			IObjectSet result = db.QueryByExample(typeof(Object));
			ListResult(result);
		}
		
		public static void DeleteAll(IObjectContainer db) 
		{
			IObjectSet result = db.QueryByExample(typeof(Object));
			foreach (object item in result)
			{
				db.Delete(item);
			}
		}
        
        public static Boolean Guardar(Object oNuevo)
        {            
            try
            {
                db = Db4oFactory.OpenFile(NombreArchivo);
                db.Store(oNuevo);
                db.Close();                
            }
            catch (Db4oException e)
            {
                Console.WriteLine("Se produjo el siguiente error" + e.Message);
                return false;
            }           

            return true;
        }

        public static Boolean BDDisponible()
        {
            try
            {
                db = Db4oFactory.OpenFile(NombreArchivo);
                db.Close();
            }
            catch (Db4oException e)
            {
                Console.WriteLine("Se produjo el siguiente error" + e.Message);
               return false;
            }
            return true;
        }

        public static void MostrarTodosObjetos()
        {

            try
            {
                db = Db4oFactory.OpenFile(NombreArchivo);
                RetrieveAll(db);
                db.Close();
            }
            catch (Db4oException e)
            {
                Console.WriteLine("Se produjo el siguiente error" + e.Message);               
            }        
            
        }

    }
}
