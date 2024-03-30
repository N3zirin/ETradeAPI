using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString //static property
        {
            get
            {
                ConfigurationManager configurationManager = new();
                //asagidaki iki setir Mic.Extensions.Config.Json ile gelir. Niye, dbstrng i burda islede bilek deye
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETradeAPI.API"));//appsettings.json un yolu/yeri
                configurationManager.AddJsonFile("appsettings.json");//neyi elave edek, hansi json file i onu gosterir

                return configurationManager.GetConnectionString("ETradeAPIConStr");
            }

        }
    }
}
