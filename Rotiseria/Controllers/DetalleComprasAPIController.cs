using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Rotiseria.Models;

namespace Rotiseria.Controllers
{
    public class DetalleComprasAPIController : ApiController
    {
        private RotiseriaContext db = new RotiseriaContext();

        // GET: api/DetalleComprasAPI
        public IQueryable<DetalleCompra> GetDetalleCompras()
        {
            return db.DetalleCompras;
        }

        // GET: api/DetalleComprasAPI/5
        [ResponseType(typeof(DetalleCompra))]
        public IHttpActionResult GetDetalleCompra(int id)
        {
            DetalleCompra detalleCompra = db.DetalleCompras.Find(id);
            if (detalleCompra == null)
            {
                return NotFound();
            }

            return Ok(detalleCompra);
        }

        // PUT: api/DetalleComprasAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDetalleCompra(int id, DetalleCompra detalleCompra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detalleCompra.Id)
            {
                return BadRequest();
            }

            db.Entry(detalleCompra).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleCompraExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DetalleComprasAPI
        [ResponseType(typeof(DetalleCompra))]
        public IHttpActionResult PostDetalleCompra(DetalleCompra detalleCompra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DetalleCompras.Add(detalleCompra);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = detalleCompra.Id }, detalleCompra);
        }

        // DELETE: api/DetalleComprasAPI/5
        [ResponseType(typeof(DetalleCompra))]
        public IHttpActionResult DeleteDetalleCompra(int id)
        {
            DetalleCompra detalleCompra = db.DetalleCompras.Find(id);
            if (detalleCompra == null)
            {
                return NotFound();
            }

            db.DetalleCompras.Remove(detalleCompra);
            db.SaveChanges();

            return Ok(detalleCompra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DetalleCompraExists(int id)
        {
            return db.DetalleCompras.Count(e => e.Id == id) > 0;
        }
    }
}