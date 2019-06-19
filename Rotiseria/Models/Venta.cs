using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario{ get; set; }
        public DateTime Fecha { get; set; }
        public float SubTotal { get; set; }
    }
}