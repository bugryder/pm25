using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM25.Models
{

    public class SiteModel
    {
        public string SiteName { get; set; }
        public string SiteEngName { get; set; }
        public string AreaName { get; set; }
        public string County { get; set; }
        public string Township { get; set; }
        public string SiteAddress { get; set; }
        public string TWD97Lon { get; set; }
        public string TWD97Lat { get; set; }
        public string SiteType { get; set; }
        public string PM25 { get; set; }
        public string PM25icon { get; set; }
    }



  
}