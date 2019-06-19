using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public Decimal PrecioCosto { get; set; }
        [Required]
        public Double PrecioVenta { get; set; }
        public int Imagen { get; set; }

        public int CategoriaProductoId { get; set; }
        public virtual Categoria CategoriaProducto { get; set; }
    }
}