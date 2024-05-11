using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ClientApp.Services
{
    public class WS
    {
        private readonly string urlService;

        public WS()
        {
            urlService = ConfigurationManager.AppSettings["WS"];
            if (string.IsNullOrEmpty(urlService))
            {
                throw new ConfigurationErrorsException("Error");
            }
        }

        public string Encender()
        {
            WebServiceRef.LightControlSoapClient lightControlSoap = new WebServiceRef.LightControlSoapClient();
            return lightControlSoap.TurnOn();
        }

        public string Apagar()
        {
            WebServiceRef.LightControlSoapClient lightControlSoap = new WebServiceRef.LightControlSoapClient();
            return lightControlSoap.TurnOff();
        }
    }
}