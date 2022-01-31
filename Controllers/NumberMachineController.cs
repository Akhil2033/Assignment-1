using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return ((7 * (id)) + 9 - (id / 4));
        }
    }
}
