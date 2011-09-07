using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        dbClass db;

        public Form1()
        {
            InitializeComponent();
            db = new dbClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.usercheck(textBox1.Text, textBox2.Text))
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username-Password Combination.");
                    textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
