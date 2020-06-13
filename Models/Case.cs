using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Case
    {
        public string 確定病名 { get; set; } //確定病名: 嚴重特殊傳染性肺炎
        public string 研判年份 { get; set; }
        public string 研判週別 { get; set; }
        public string 縣市 { get; set; }
        public string 性別 { get; set; }
        public string 是否為境外移入 { get; set; }
        public string 年齡層 { get; set; }
        public string 確定病例數 { get; set; }
    }

    
}