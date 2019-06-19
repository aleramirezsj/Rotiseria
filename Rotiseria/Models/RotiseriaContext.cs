using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class RotiseriaContext: DbContext

    {
        public RotiseriaContext() : base(“RotiseriaContext”) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }

        public System.Data.Entity.DbSet<Rotiseria.Models.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<Rotiseria.Models.Producto> Productoes { get; set; }

        public System.Data.Entity.DbSet<Rotiseria.Models.Proveedor> Proveedors { get; set; }

        public System.Data.Entity.DbSet<Rotiseria.Models.Venta> Ventas { get; set; }
    }
}