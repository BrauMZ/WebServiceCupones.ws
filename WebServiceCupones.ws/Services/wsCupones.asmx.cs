using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceCupones.ws.Services
{
    /// <summary>
    /// Descripción breve de wsCupones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCupones : System.Web.Services.WebService
    {

        [WebMethod]
        public string stConsumirCuponKrispy(string sCupon)
        {
            try
            {
                WebServiceData.Logic.Class.clsCupones obclsCupones = new WebServiceData.Logic.Class.clsCupones();

               
                return obclsCupones.UpdateCupon(sCupon);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
