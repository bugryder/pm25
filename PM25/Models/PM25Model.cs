using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM25.Models
{

        public class PM25Model
        {
            public string CO { get; set; }
            public string County { get; set; }
            public string FPMI { get; set; }
            public string MajorPollutant { get; set; }
            public string NO { get; set; }
            public string NO2 { get; set; }
            public string NOx { get; set; }
            public string O3 { get; set; }
            public string PM10 { get; set; }
            [JsonProperty("PM2.5")]
            public string PM25 { get; set; }
            public string PSI { get; set; }
            public string PublishTime { get; set; }
            public string SiteName { get; set; }
            public string SO2 { get; set; }
            public string Status { get; set; }
            public string WindDirec { get; set; }
            public string WindSpeed { get; set; }
        }

  
}