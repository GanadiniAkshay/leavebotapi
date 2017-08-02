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
        public object get(string companyGUID, string userGUID, DateTime year)
        {
            LeaveBiz leave = new LeaveBiz();
            DataTable data = leave.GetUserBalanceDetails_ByUserGUID(companyGUID, userGUID, year);

            List<DataRow> leavebalance = data.AsEnumerable().ToList();
            return new { leavebalance = leavebalance };
        }
        
    }
}
