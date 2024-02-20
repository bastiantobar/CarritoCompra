using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<ItemCarrito> Items { get; set; }
        public DateTime Fecha { get; set; }
    }
}