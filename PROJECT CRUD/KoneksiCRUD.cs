using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PROJECT_CRUD
{
    internal class KoneksiCRUD
    {
        private static string getConnectionstring()
        {
            string host = " Host=localhost;";
            string port = " Port=5432;";
            string db = "Database=warung;";
            string user = "Username=postgres;";
            string pass = "Password=Paulus21.; ";
            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);


            return conString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionstring());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(NpgsqlCommand com)
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

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Perform Database CRUD Operation Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;



        }
    }
}
