﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SqlConn
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "oop_practicalwork5";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
