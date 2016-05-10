using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using PM25.Models;
using System.Configuration;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Threading;
using System.IO;

namespace PM25
{
    public class PM25Hub : Hub
    {

        public void GetAllData()
        {

            while (true)
            {



                //真的遠端讀取
                var webClient = new WebClient();
                var Pm25Uri = ConfigurationManager.AppSettings["PM25_OpenData_Url"];
                var SiteUri = ConfigurationManager.AppSettings["Site_OpenData_Url"];
                webClient.Encoding = Encoding.UTF8;
                var Pm25Data = webClient.DownloadString(Pm25Uri);
                var SiteData = string.Empty;
                try
                {
                    SiteData = webClient.DownloadString(SiteUri);
                }
                catch
                {
                    SiteData = File.ReadAllText(HttpContext.Current.Server.MapPath("/scripts/SiteData.json"));
                }

              
                var Pm25DataList = JsonConvert.DeserializeObject<List<PM25Model>>(Pm25Data);
                var SiteDataList = JsonConvert.DeserializeObject<List<SiteModel>>(SiteData);



                foreach (SiteModel item in SiteDataList)
                {
                    var p = Pm25DataList.Where(x => x.SiteName == item.SiteName).FirstOrDefault();
                    if (p == null)
                    {
                        item.PM25 = "0";
                    }
                    else
                    {
                        item.PM25 = string.IsNullOrWhiteSpace(p.PM25) ? "0" : p.PM25;
                    }

                    if( Convert.ToDecimal( item.PM25) <= 35 )
                    {
                        item.PM25icon = "happy.png";
                    }
                    else if( Convert.ToDecimal( item.PM25) <= 70 )
                    {
                        item.PM25icon = "sad.png";
                    }
                    else 
                    {
                        item.PM25icon = "cry.png";
                    }
                }


                Clients.All.GetPM25Json(SiteDataList);

                Thread.Sleep(1000 * 60 * 10);
            }




        }

    }






}