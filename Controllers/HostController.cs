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
            double Cost = 5.50;// cost per fort night before taxes
            double Tax = 0.715; // 13% tax on cost per fort night
            double TotalCost = Cost + Tax; // Cost including taxes
            double TDC = 0.44; // cost per day including taxes
            double total = TDC * id + TotalCost; // cost for extra days beyond a fort night

            return ("1 fortnights at $5.50/FN = $5.50 CAD \n HST 13 % = $0.72 CA Total= $ \n" + total+"CAD");

        }

    }
}
