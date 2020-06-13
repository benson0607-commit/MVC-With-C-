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
        public string getJson()
        {
            // 地區年齡性別統計表-嚴重特殊傳染性肺炎(以週為單位)-依個案研判日統計 https://data.cdc.gov.tw/dataset/aagsdctable-weekly-19cov
            string res = Utils.Utils.GetJsonContent("https://od.cdc.gov.tw/eic/Weekly_Confirmation_Age_County_Gender_19CoV.json");
            System.Diagnostics.Debug.WriteLine(res);
            return res;
        }

        public IEnumerable<Models.Case> getCases() {
            
            return JsonConvert.DeserializeObject<IEnumerable<Models.Case>>(getJson());
        }
    }
}