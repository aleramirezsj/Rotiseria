using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required]
        public String RazonSocial { get; set; }
        public String Direccion { get; set; }
        public String Celular { get; set; }
        public String Telefono { get; set; }
        public String Observaciones { get; set; }

    }
}