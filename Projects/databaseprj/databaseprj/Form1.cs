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
    public partial class Form1 : Form
    {
        BindingManagerBase bm;  
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataRow dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Integrated Security=SSPI;database=collabera;data source=TRAINING-4\\SQLEXPRESS");
            con.Open();

            da= new SqlDataAdapter("select * from customer", con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "customer");
            
            dt = ds.Tables["customer"];

            //textBox1.Text = ds.Tables["customer"].Rows[0][0].ToString();
           // textBox2.Text = ds.Tables["customer"].Rows[0][1].ToString();
           // textBox3.Text = ds.Tables["customer"].Rows[0][2].ToString();
           // textBox4.Text = ds.Tables["customer"].Rows[0][3].ToString();
           // textBox5.Text = ds.Tables["customer"].Rows[0][4].ToString();

            textBox1.DataBindings.Add("Text", dt, "custid");
            textBox2.DataBindings.Add("Text", dt, "custname");
            textBox3.DataBindings.Add("Text", dt, "age");
            textBox4.DataBindings.Add("Text", dt, "address");
            textBox5.DataBindings.Add("Text", dt, "phone");
            bm = BindingContext[dt];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bm.Position += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bm.Position -= 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            dr = dt.NewRow();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            dr[4] = textBox5.Text;
            dt.Rows.Add(dr);
            da.Update(dt);
            MessageBox.Show("Insert Success!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
         //   dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            dr[4] = textBox5.Text;
            da.Update(dt);
            MessageBox.Show("done");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            dr = dt.Rows.Find(textBox6.Text);
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString(); 
            textBox5.Text = dr[4].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(dt);
            MessageBox.Show("Delete Success");
        }
    }
}
