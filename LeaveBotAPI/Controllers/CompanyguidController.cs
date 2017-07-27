using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apiv2.ELeave.Dao;

namespace LeaveBotAPI.Controllers
{
    public class CompanyguidController : ApiController
    {
        public object get(string userGUID)
        {
            LeaveDaoHelper leaveHelper = LeaveDaoHelper.getInstance();
            string companyGUID = leaveHelper.GetCompanyGUIDByUserID(userGUID);
            return new { companyGUID = companyGUID };
        }
    }
}