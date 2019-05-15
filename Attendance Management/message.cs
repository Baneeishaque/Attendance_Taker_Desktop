using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendance_Management
{
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter message tiltle");

            }
            else
            {
                if (msg.Text.Length == 0)
                {
                    MessageBox.Show("Enter Message body");
                }
                else
                {

                    DBhandler v = new DBhandler();
                    v.Ins_Up_Del("insert into messages(title,message) values('" + textBox1.Text.ToString() + "','" + msg.Text.ToString() + "')");
                    MessageBox.Show("Message insrted succesfully");
                }
            }
        }
    }
}
 