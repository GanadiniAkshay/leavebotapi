using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eStaffBizLayer;

namespace LeaveBotAPI.Controllers
{
    public class UserguidController : ApiController
    {
        public object get(string userID, string companyGUID)
        {
            eStaffBizLayer.BizMaster helper = new eStaffBizLayer.BizMaster();
            string userGUID = helper.GetUserGUIDbyUserID(userID, companyGUID);
            return new { userGUID = userGUID };
        }
    }
}
