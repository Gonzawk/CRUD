using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapp.Api.Modelos;
using System.Data.SqlClient;

namespace Webapp.Api.Controllers
{
    public class CLIENTEEController : ApiController
    {
        // GET: api/CLIENTEE
        public List<CLIENTE> Get()
        {
            CLIENTE ocliente = new CLIENTE();
            var dt = ocliente.TraerT();

            var ListaJsom = JsonConvert.SerializeObject(dt);
            var oList = JsonConvert.DeserializeObject<List<CLIENTE>>(ListaJsom).ToList();

            return oList;
        }


        // GET: api/CLIENTEE/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CLIENTEE
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CLIENTEE/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CLIENTEE/5
        public void Delete(int id)
        {
        }
    }
}
