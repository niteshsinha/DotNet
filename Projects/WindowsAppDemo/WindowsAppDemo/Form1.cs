using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsAppDemo
{
    public partial class Form1 : Form
    {
        ValidationClass vc = new ValidationClass();
        static int check = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!vc.EmptyBox(textBox1))
                MessageBox.Show("Please enter Username.");
            else if (!vc.EmptyBox(textBox2))
                MessageBox.Show("Please enter Password.");
            else if (textBox1.Text == "admin" && textBox2.Text == "india*123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong combination. Reenter.");

            if (check == 3)
            {
                MessageBox.Show("You have exceeded the maximum number of attempts.");
                this.Close();
            }
            else
                check++;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
