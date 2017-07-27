using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveBotAPI.Models
{
    public class LeaveApplyRequest
    {
        public string userGUID { get; set; }
        public string companyGUID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public double leaveday { get; set; }
        public int leaveType { get; set; }
        public string remarks { get; set; }
        public string cclist { get; set; }
        public string aoguid { get; set; }
        public string roguid { get; set; }
    }
}