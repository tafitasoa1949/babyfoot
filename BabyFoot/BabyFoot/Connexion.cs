using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BabyFoot
{
    internal class Connexion
    {
        public static string getConnexion()
        {
            string host = "HOST:localhost;";
            string port = "Port:5432;";
            string db = "Database=babyfoot;";
            string user = "Username=postgres;";
            string pass = "Password=admin";

            string conString = string.Format("{0},{1},{2},{3],{4}", host, port, db, user, pass);

            return conString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnexion());

        public static NpgsqlCommand cmd = default(NpgsqlCommand);

        public static string sql = string.Empty;

        public static DataTable executeCRUD(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error connexion :" + ex.Message);
                dt = null;
            }

            return dt;
        }
    }  
}
