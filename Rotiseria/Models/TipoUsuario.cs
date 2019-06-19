using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Tipo_usuario")]
        public String Nombre { get; set; } 
    }
}