using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapp.Api.Controllers
{
    public class ZapatillaController : ApiController
    {
        // GET: api/Zapatilla
        public List<ZAPATILLA> Get()
        {
            List<ZAPATILLA> oList = new List<ZAPATILLA>();

            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {

                oList = db.ZAPATILLA.ToList();
            }
            return oList;
        }

        // GET: api/Zapatilla/5
        public ZAPATILLA Get(int id)
        {

            ZAPATILLA oItem = new ZAPATILLA();

            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {

                oItem = db.ZAPATILLA.Find(id);
            }

            return oItem; 
        }

        // POST: api/Zapatilla
        public void Post([FromBody] ZAPATILLA value)
        {

            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                db.ZAPATILLA.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Zapatilla/5
        public void Put(int id, [FromBody] ZAPATILLA value)
        {

            using (DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                ZAPATILLA oItem = db.ZAPATILLA.Find(id);

                oItem.Marca = value.Marca;
                oItem.Modelo = value.Modelo;
                oItem.Talla = value.Talla;
                oItem.Color = value.Color;
                oItem.Precio = value.Precio;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

        }


        // DELETE: api/Zapatilla/5
        public void Delete(int id)
        {

            using ( DBAPIWEBEntities db = new DBAPIWEBEntities())
            {
                ZAPATILLA oItem = db.ZAPATILLA.Find(id);

                db.ZAPATILLA.Remove(oItem);
                db.SaveChanges();

            }
        }
    }
}
