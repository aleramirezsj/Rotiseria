using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Compra")]
        public int CompraId { get; set; }
        public virtual Compra Compra { get; set; }
        [Required]
        [Display(Name = "Producto")]
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
        [Required]
        public decimal PrecioCompra { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}