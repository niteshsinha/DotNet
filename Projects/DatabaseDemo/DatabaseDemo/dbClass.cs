using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DatabaseDemo
{
    public class dbClass
    {
        SqlConnection con;
        BindingManagerBase bm;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataRow dr;
        string sql;
       
        public dbClass()
        {
            con = new SqlConnection("Integrated Security=SSPI;database=testdb;data source=TRAINING-4\\SQLEXPRESS");
            con.Open();
        }
        public bool usercheck(string uname, string pass)
        {
            sql = "SELECT * FROM users WHERE username='" + uname + "' AND password='" + pass + "'";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "users");
            dt = ds.Tables["users"];
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}