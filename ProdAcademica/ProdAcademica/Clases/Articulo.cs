using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_BDOOp1
{
    public class Articulo : ProduccionAcademica
    {
        public Articulo(string titulo) : base(titulo)
        {

        }
        public MedioDePublicacion publicadoen { get; set; }
       
        public Autor Autor { get; set; }
     

        public DateTime FechaAprobacion { get; set; }
  

        public short AñoPublicacion { get; set; }
       

        public String LugarExposion { get; set; }
      

        public DateTime FechaExposicion { get; set; }
       
        
    }


}