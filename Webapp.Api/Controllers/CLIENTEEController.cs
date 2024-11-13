using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.SqlClient;
using Webapp.Api.Modelos;


namespace Webapp.Api.Controllers
{
    public class CLIENTEEController : ApiController
    {
        // GET: api/CLIENTEE
        public List<CLIENTE_ADO> Get()
        {
            CLIENTE_ADO ocliente = new CLIENTE_ADO();
            var dt = ocliente.TraerT();

            var ListaJsom = JsonConvert.SerializeObject(dt);
            var oList = JsonConvert.DeserializeObject<List<CLIENTE_ADO>>(ListaJsom).ToList();

            return oList;
        }


        // GET: api/CLIENTEE/5
          public CLIENTE_ADO Get(int id)
            {
            CLIENTE_ADO oCliente = new CLIENTE_ADO();

                oCliente.id_cliente = id;

                var dt = oCliente.TraerPorId();

                var ListaJsom = JsonConvert.SerializeObject(dt);
                var Obj = JsonConvert.DeserializeObject<List<CLIENTE_ADO>>(ListaJsom).ToList().FirstOrDefault();

                return Obj;


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
