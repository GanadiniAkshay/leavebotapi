using LeaveBotAPI.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeaveBotAPI.Controllers
{
    public class UserguidController : ApiController
    {
        public object get(string userID, string companyID)
        {
            string userguid = "";

            Database database = DatabaseFactory.CreateDatabase("LeaveDBConnectionString");
            string str = "chatbot_FinduserGUID";
            DbCommand storedProcCommand = database.GetStoredProcCommand(str);
            database.AddInParameter(storedProcCommand, "@userid", DbType.String, (object)userID);
            database.AddInParameter(storedProcCommand, "@companyid", DbType.String, (object)companyID);

            try
            {
                IDataReader dataReader = database.ExecuteReader(storedProcCommand);
                if (dataReader.Read())
                {
                    userguid = (string)Convert.ToString(dataReader[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new { userguid = userguid };
        }
    }
}
