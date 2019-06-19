using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Usuario")]
        public String User { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        public String Password { get; set; }

        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }


    }
}