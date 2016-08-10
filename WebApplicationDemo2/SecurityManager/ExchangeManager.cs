using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApplicationDemo2.Models;

namespace WebApplicationDemo2.SecurityManager
{
    public class ExchangeManager
    {
        private string connStr = "https://www.quandl.com/api/v3/datasets.csv?database_code={EXCHANGE}&per_page=100&sort_by=id&page={PAGEID}&api_key=XUVXyoyJLzkrsKzMYstv";

        private string exchangeConnStr{ get; set; }

        private string ExchangeStr { get; set; }

        public ExchangeManager(string exchange)
        {
            this.ExchangeStr = exchange;
            this.exchangeConnStr = this.connStr.Replace("{EXCHANGE}", exchange);
        }

        public Exchange GetExhangeDetails(DateTime businessDate)
        {
            for(int page=0;page<55;page++){
                using (var client = new WebClient())
                {
                    client.DownloadFile(exchangeConnStr, @"c:\temp\"+ this.ExchangeStr +"_"+ page +".csv");
                }
            }



            return new Exchange()
            {
                
            };
        }

        private void downloadSecurities()
    }
}