﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Servicios
{
    public class ConexionBD
    {
        string server = "bzfkzsmkcdxslgo5fohv-mysql.services.clever-cloud.com";
        string database = "bzfkzsmkcdxslgo5fohv";
        string username = "uf0betb0sqlmsqbd";
        string password = "bnFWrCsdN7EPRyEkPzYG";

        public ConexionBD()
        {
        }

        public string GetConnector()
        {
            string connectionString = $"Server={this.server}; database={this.database}; UID={this.username}; password={this.password};";

            return connectionString;
        }
    }
}
