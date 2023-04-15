using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskyBusiness.Scripts
{
    public class DBConnect
    {
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "business";
        private static string Password = "159753";
        private static string Port = "5432";

        public NpgsqlDataReader connection(string query)
        {
            string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);


            NpgsqlConnection conn = new NpgsqlConnection(connString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return dr;
            }
            dr.Close();
            return dr;

        }
    }
}
