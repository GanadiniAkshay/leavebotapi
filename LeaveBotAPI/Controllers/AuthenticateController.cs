using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apiv2.ELeave;
using LeaveBotAPI.Models;

namespace LeaveBotAPI.Controllers
{
    public class AuthenticateController : ApiController
    {
        public object Post(AuthenticationRequest request)
        {
            SessionHelper session = SessionHelper.getInstance();
            int user_id = session.findUser(request.Company_Id, request.Username, request.Password);
            return new { user_id = user_id };
        }
    }
}
