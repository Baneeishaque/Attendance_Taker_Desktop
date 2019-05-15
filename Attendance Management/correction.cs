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
    public partial class correction : Form
    {
        DBhandler db = new DBhandler();
        public correction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void correction_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetTable("select branch from branches");

            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox1.Items.Add(dt.Rows[y]["branch"].ToString());

            }

            DataTable s = db.GetTable("select semester from sem where state = '1' ");

            k = s.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox2.Items.Add(s.Rows[y]["semester"].ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correction2 cr2 = new correction2(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), textBox1.Text, textBox2.Text);
            cr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
