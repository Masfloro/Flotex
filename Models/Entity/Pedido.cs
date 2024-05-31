using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flotex.Models.Entity
{
    [Table("Pedido")]
    public class Pedido
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Productos")]
        public List<Producto> Productos { get; set; }


    }
}