using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemo2.Models
{
    public class Exchange
    {
        public List<Security> Securities { get; set; }

        public DateTime Date { get; set; }
    }
}