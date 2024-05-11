using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LightsPlease
{
    /// <summary>
    /// Descripción breve de LightControl
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class LightControl : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string TurnOn()
        {
            try
            {
                string query = @"INSERT INTO UserAction (userId, deviceId, actionType) VALUES 
                                (1, 2, 'Encendio luz');";

                DataAccess.BD.DataManager dataManager = new DataAccess.BD.DataManager();
                dataManager.execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }

            return "Encendido";
        }


        [WebMethod]
        public string TurnOff()
        {
            try
            {
                string query = @"INSERT INTO UserAction (userId, deviceId, actionType) VALUES 
                                (1, 2, 'Apago luz');";
                DataAccess.BD.DataManager dataManager = new DataAccess.BD.DataManager();
                dataManager.execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }

            return "Apagado";
        }


    }
}
