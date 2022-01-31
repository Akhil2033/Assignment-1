using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject1.Controllers
{
    public class HostController : ApiController
    {
        public String Get(double id)
        {
            double Cost = 5.50;
            double Tax = 0.715;
            double TotalCost = Cost + Tax;
            double TDC = 0.44;
            double total = TDC * id + TotalCost;

            return ("1 fortnights at $5.50/FN = $5.50 CAD "+ "HST 13 % = $0.72 CA Total= " + " " + total);

        }

    }
}
