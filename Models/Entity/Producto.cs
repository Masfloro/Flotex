using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flotex.Models.Entity
{
    public class Producto
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Categoria { get; set; }

        
        public String Estado{ get; set; }

        public Double Precio{ get; set; }

        public String Color{ get; set; }

        public Double Ancho{ get; set; }

        public Double Alto{ get; set; }

        public String Descripcion{ get; set; }


    }   
}