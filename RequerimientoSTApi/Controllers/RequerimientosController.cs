using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RequerimientoSTApi.Models;

namespace RequerimientoSTApi.Controllers
{
    public class RequerimientosController : ApiController
    {

        [Route("api/Requerimientos/ObtenerRequerimientos")]
        [HttpGet]
        public List<uspObtenerRequerimientos_Result> ObtenerVariablesWinCC()
        {
            try
            {

                List<uspObtenerRequerimientos_Result> requerimientoList = new List<uspObtenerRequerimientos_Result>();

                using (var DB = new PruebaTecnicaJulianArangoEntities())
                {
                    requerimientoList = DB.uspObtenerRequerimientos().ToList();



                    return (requerimientoList);
                }


            }

            catch (Exception ex)
            {
                return null;
                //return (ex.ToString());

            }



        }


    }
}
