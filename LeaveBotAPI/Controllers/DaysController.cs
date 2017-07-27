using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ELeaveLibrary;
using LeaveBotAPI.Models;

namespace LeaveBotAPI.Controllers
{
    public class DaysController : ApiController
    {
        public object get(string FromDate, string ToDate, string FromTime, string ToTime, string userGUID, string companyGUID)
        {
            LeaveBiz leave = new LeaveBiz();
            DateTime fromDate = Convert.ToDateTime(FromDate);
            DateTime toDate = Convert.ToDateTime(ToDate);
            double days = leave.Employee_GetLeaveDay(fromDate, toDate, FromTime, ToTime, userGUID, companyGUID);
            return new { days = days };
        }
    }
}
