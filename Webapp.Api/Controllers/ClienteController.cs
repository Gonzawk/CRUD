using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapp.Api.Controllers
{
    public class ClienteController : ApiController
    {
        // GET: api/Cliente
        public List<CLIENTE> Get()
        {
            List<CLIENTE> oList = new List<CLIENTE>();

            using(DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                oList = db.CLIENTE.ToList();

            }

            return oList;
        }

        // GET: api/Cliente/5
        public CLIENTE Get(int id)
        {
            CLIENTE oItem = new CLIENTE();

            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                oItem = db.CLIENTE.Find(id);

            }
            return oItem;
        }

        // POST: api/Cliente
        public void Post([FromBody] CLIENTE value)
        {

            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                db.CLIENTE.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]CLIENTE value)
        {
            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                CLIENTE oItem = db.CLIENTE.Find(id);

                oItem.Nombre = value.Nombre;
                oItem.Apellido = value.Apellido;
                oItem.Email = value.Email;
                oItem.Telefono = value.Telefono;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {

            using( DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                CLIENTE oItem = db.CLIENTE.Find(id);

                db.CLIENTE.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
