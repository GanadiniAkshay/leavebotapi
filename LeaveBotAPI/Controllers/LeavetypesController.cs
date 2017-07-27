using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ELeaveLibrary;

namespace LeaveBotAPI.Controllers
{
    public class LeavetypesController : ApiController
    {
        public object get(string companyGUID, string userGUID, int year)
        {
            UserDAL user = new UserDAL();
            DataTable data = user.GenerateLeaveTypes_ByUserGUID(companyGUID, userGUID, year);

            List<DataRow> leavetypes = data.AsEnumerable().ToList();
            return new { types = leavetypes };
        }
    }
}
