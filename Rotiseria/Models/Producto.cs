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
        [Display(Name = "Producto")]
        public String Nombre { get; set; }
        [Required]
        [Range(0,10000,ErrorMessage ="No puede ingresar valores superiores a 10.000")]
        public int Cantidad { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal PrecioCosto { get; set; }
        [Required]
        public Double PrecioVenta { get; set; }
        public int Imagen { get; set; }
        [Display(Name = "Categoría")]
        public int CategoriaProductoId { get; set; }
        public virtual Categoria CategoriaProducto { get; set; }
    }
}