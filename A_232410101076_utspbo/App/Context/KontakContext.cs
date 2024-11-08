using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_232410101076_utspbo.App.Core;
using Npgsql;
using A_232410101076_utspbo.App.Models;

namespace A_232410101076_utspbo.App.Context
{
    internal class KontakContext : dataWrapper
    {
        private static string table = "Kontak";

        public static DataTable All()
        {
            string query = @"SELECT idKontak, Nama, Email, NoHP FROM Kontak";
            DataTable dataKontak = queryExecutor(query);
            return dataKontak;
        }

        public static DataTable getKontakById(int id)
        {
            string query = @"SELECT idKontak, Nama, Email, NoHP FROM Kontak WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id}
            };
            DataTable dataKontak = queryExecutor(query);
            return dataKontak;
        }

        public static void TambahKontak(M_Kontak kontakBaru)
        {
            string query = $"INSERT INTO {table} (Nama, Email, NoHP) VALUES(@Nama, @Email, @NoHP)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Nama", kontakBaru.Nama),
                new NpgsqlParameter("@Email", kontakBaru.Email),
                new NpgsqlParameter("@NoHP", kontakBaru.NoHP)
            };

            commandExecutor(query, parameters);
        }
    }
}
