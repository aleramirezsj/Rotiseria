using Rotiseria.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rotiseria
{
    public partial class WebFormVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Probando Webforms";
            RotiseriaContext rotiseriaContext = new RotiseriaContext();

            ddlusuario.DataSource = rotiseriaContext.Usuarios.ToList();
            ddlusuario.DataTextField = "User";
            ddlusuario.DataValueField = "Id";
            ddlusuario.DataBind();
        }

        protected void txtNroVenta_TextChanged(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            RotiseriaContext rotiseriaContext = new RotiseriaContext();
            venta = rotiseriaContext.Ventas.Find(Convert.ToInt32(txtNroVenta.Text));
            txtFecha.Text = venta.Fecha.ToShortDateString();
            txtTotal.Text = venta.SubTotal.ToString();
            ddlusuario.SelectedValue = venta.UsuarioId.ToString();
        }


    }
}