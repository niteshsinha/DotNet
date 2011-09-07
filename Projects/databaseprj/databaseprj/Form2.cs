using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseprj
{
    public partial class Form2 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;database=collabera;data source=TRAINING-4\\SQLEXPRESS");
            con.Open();

            da = new SqlDataAdapter("select * from customer", con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "customer");

            dt = ds.Tables["customer"];

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customer";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            MessageBox.Show("done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.WriteXml("c:\\cust.xml");
            MessageBox.Show("done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.WriteXml("c:\\customer.xml",XmlWriteMode.DiffGram);
            MessageBox.Show("done");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "age > 30";
            dataGridView2.DataSource = dv;
        }
    }
}
