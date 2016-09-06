using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ekstra_Opgave_3_Tolkebestilling
{
    class SQL
    {

        #region SQL Setup

        SqlConnection dbcon = new SqlConnection(@"Server = CV-PC-T-40\TEST; Database=Tolkebestilling; Integrated Security=SSPI; Trusted_Connection=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        #endregion

        string query;

        public SQL CheckDatabaseForUser()
        {
            using (dbcon)
            {
                cmd.CommandText = "StoredUsers";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = dbcon;
                dbcon.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                }
            }
            

            return null;
        }
    }
}
