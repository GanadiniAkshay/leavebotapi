using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveBotAPI.Models
{
    public class AuthenticationRequest
    {
        public string Password { get; set; }
        public string Company_Id { get; set; }
        public string Username { get; set; }
    }
}