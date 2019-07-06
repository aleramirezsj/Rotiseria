using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Éste campo es obligatorio")]
        [Display(Name = "Venta")]
        public int VentaId { get; set; }
        public virtual Venta Venta { get; set; }
        [Required(ErrorMessage = "Éste campo es obligatorio")]
        [Display(Name = "Venta")]
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
        [Required(ErrorMessage = "Éste campo es obligatorio")]
        [Display(Name = "Precio venta")]
        public decimal PrecioVenta { get; set; }
        [Required(ErrorMessage = "Éste campo es obligatorio")]
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}