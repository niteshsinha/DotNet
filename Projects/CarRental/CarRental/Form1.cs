using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CarRental
{
    public partial class Form1 : Form
    {
        CarRentalDLL.RentCar ob = new CarRentalDLL.RentCar();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = ob.getId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateClass vc = new ValidateClass();
            if (!vc.EmptyBox(textBox1))
            {
                MessageBox.Show("Enter name.");
                return;
            }
            else if (!vc.EmptyBox(textBox2))
            {
                MessageBox.Show("Enter Location.");
            }
            else
            {
                CarRentalDLL.RentCar obj = new CarRentalDLL.RentCar(textBox3.Text,
                                                             textBox1.Text,
                                                             comboBox1.SelectedItem.ToString(),
                                                             textBox2.Text,
                                                             dateTimePicker1.Value,
                                                             dateTimePicker2.Value);
               string c= obj.addData();
               textBox3.Text = obj.getId();
                MessageBox.Show(c);
              // List<CarRentalDLL.RentCar> li = new List<CarRentalDLL.RentCar>();
               // li.Add(new CarRentalDLL.RentCar(textBox3.Text,
                                                        //     textBox1.Text,
                                                          //   comboBox1.SelectedText,
                                                            // textBox2.Text,
                                                             //dateTimePicker1.Value,
                                                             //dateTimePicker2.Value));
                

            
               
               }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = ob.populateData();
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index;
            index = dataGridView1.CurrentCell.RowIndex;
            //MessageBox.Show(index.ToString());
            ob.delete(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = ob.populateData();
            dataGridView1.Refresh();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter Search Parameter" || textBox4.Text=="")
            {
                MessageBox.Show("Enter somthing to search.");
            }
            else
            {
                ArrayList arr=ob.search(textBox4.Text);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = arr;
                dataGridView1.Refresh();
            }
        }
    }
}
