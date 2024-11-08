using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_232410101076_utspbo.App.Core;
using A_232410101076_utspbo.App.Models;
using Npgsql;

namespace A_232410101076_utspbo.App.Context
{
    internal class AdminContext : dataWrapper
    {
        private static string table = "Admin";

        public static DataTable All()
        {
            string query = @"SELECT FROM * Admin";
            DataTable dataAdmin = queryExecutor(query);
            return dataAdmin;
        }

        public static void TambahAdmin(M_AkunAdmin akunAdmin)
        {
            string query = $"INSERT INTO {table} (username, password) VALUES(@username, password)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Nama", akunAdmin.username),
                new NpgsqlParameter("@Email", akunAdmin.password)
            };

            commandExecutor(query, parameters);
        }
    }
}
