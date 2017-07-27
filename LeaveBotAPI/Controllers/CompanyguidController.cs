using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eStaffBizLayer;

namespace LeaveBotAPI.Controllers
{
    public class CompanyguidController : ApiController
    {
        public object get(string companyID)
        {
            eStaffBizLayer.BizMaster helper = new eStaffBizLayer.BizMaster();
            string companyGUID = helper.GetCompanyGUIDbyCompanyID(companyID);
            return new { companyGUID = companyGUID };
        }
    }
}
