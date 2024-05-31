using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flotex.Models.Entity
{

    [Table("PedidoVenta")]
    public class PedidoVenta
    {
        
        [Column("Id")]
        public int Id { get; set; }

        [Column("Id_Pedido")]
        public int IdPedido { get; set; }




    }
}