using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ELeaveLibrary;

namespace LeaveBotAPI.Controllers
{
    public class UseraoroController : ApiController
    {
        public object get(string userGUID)
        {
            LeaveBiz helper = new LeaveBiz();
            Employee emp = helper.GetEmployee_ROAO(userGUID);

            string Aoname = emp.AOFullName;
            string Roname = emp.ROFullName;
            string Aoguid = emp.AOGUID;
            string Roguid = emp.ROGUID;

            return new { Aoname = Aoname, Roname = Roname, Aoguid = Aoguid, Roguid = Roguid };
        }
    }
}
