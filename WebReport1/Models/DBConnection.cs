﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace WebReport1.Models
{
    public class DBConnection
    {
        string strCon;
        public DBConnection()
        {

            strCon = ConfigurationManager.ConnectionStrings["aspnet_WebReport1_20200622011138ConnectionString"].ConnectionString;
        }
        public SqlConnection getConnection()
        {
            return new SqlConnection(strCon);
        }

    }
}