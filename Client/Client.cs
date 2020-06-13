using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Collections;

namespace WebApplication2.Client
{
    public class Client
    {
        public IEnumerable<Models.Case> download() {
            string content = Utils.Utils.GetJsonContent("https://od.cdc.gov.tw/eic/Weekly_Confirmation_Age_County_Gender_19CoV.json");
            Console.WriteLine(content);
            return JsonConvert.DeserializeObject<IEnumerable<Models.Case>>(content);
        }


    }
}