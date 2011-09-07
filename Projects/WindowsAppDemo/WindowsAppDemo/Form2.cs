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
    public partial class Form2 : Form
    {
        ValidationClass vc = new ValidationClass();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!vc.EmptyBox(textBox1))
                errorProvider1.SetError(textBox1, "Enter the first name");
            else if(!vc.EmptyBox(textBox2))
                errorProvider2.SetError(textBox2, "Enter the last name");
        }
    }
}
