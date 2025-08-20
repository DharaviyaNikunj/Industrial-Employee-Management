using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class Connection
    {
        
        SqlCommand CMD;
        static string cnn = "Data Source=DharaviyaNikunj;Initial Catalog=employ_information;Integrated Security=True";
        static SqlConnection CONN = new SqlConnection(cnn);
        SqlDataAdapter DA;
        DataTable DT;


        // This funtion for Registration
        public void Register(string Qry)
        {
            
            CMD = new SqlCommand(Qry, CONN);
            CONN.Open();
            CMD.ExecuteNonQuery();
            CONN.Close();
        }

        // This function is for Login of user
        public int Login(string Qry)
        {
            CMD = new SqlCommand(Qry, CONN);
            DA = new SqlDataAdapter(CMD);
            DT = new DataTable();
            DA.Fill(DT);
            CONN.Open();
            CMD.ExecuteNonQuery();
            CONN.Close();
            int l = DT.Rows.Count;
            if (DT.Rows.Count > 0)
            {
                return l;
            }
            return 0;
        }
        public int Designation(string QRY)
        {
            return 0;
 
        }
    }
}
