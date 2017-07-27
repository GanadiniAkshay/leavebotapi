using LeaveBotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ELeaveLibrary;

namespace LeaveBotAPI.Controllers
{
    public class LeaveController : ApiController
    {
        public object post(LeaveApplyRequest request)
        {
            TransactionDAL transaction = new TransactionDAL();
            DateTime fromDate = Convert.ToDateTime(request.FromDate);
            DateTime toDate = Convert.ToDateTime(request.ToDate);
            int result = transaction.DoApplyLeave(request.userGUID, request.companyGUID, fromDate, toDate, request.FromTime, request.ToTime, request.leaveday, request.leaveType, request.remarks, request.cclist, request.aoguid, request.roguid, request.userGUID, DateTime.Now);
            return new { res = result };
        }
    }
}
