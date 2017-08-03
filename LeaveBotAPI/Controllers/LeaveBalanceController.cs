using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ELeaveLibrary;
using System.Data;

namespace LeaveBotAPI.Controllers
{
    public class LeaveBalanceController : ApiController
    {
        public object get(string companyGUID, string userGUID, string year)
        {
            DateTime dt_year = DateTime.Now;//new DateTime(Convert.ToInt32(year), 1, 1);
            LeaveBiz leave = new LeaveBiz();
            DataTable data = leave.GetUserBalanceDetails_ByUserGUID(companyGUID, userGUID, dt_year);

            List<DataRow> leavebalance = data.AsEnumerable().ToList();
            return new { leavebalance = leavebalance };
        }
        
    }
}
