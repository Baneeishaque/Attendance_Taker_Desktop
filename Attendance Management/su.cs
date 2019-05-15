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
    public partial class su : Form
    {
        DBhandler db = new DBhandler();
        int i;
        Random rd = new Random();
        public su()
        {
            InitializeComponent();
        }

        private void su_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetTable("select branch from branches");

            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox1.Items.Add(dt.Rows[y]["branch"].ToString());

            }

            DataTable s = db.GetTable("select semester from sem where state = '1'");

            k = s.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox2.Items.Add(s.Rows[y]["semester"].ToString());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String txt = textBox1.Text.ToString();
            DataTable f = db.GetTable("select name,phone from staffs where(ID='" + txt + "')");
            SET.Text = f.Rows[0]["NAME"].ToString();
            mob.Text = f.Rows[0]["phone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i = rd.Next(9999, 11111);
            
            db.Ins_Up_Del("insert into sub(branch,semester,period,id,otp,reason)values('"+comboBox1.SelectedItem.ToString().Substring(0,6)+"','"+comboBox2.SelectedItem.ToString().Substring(8,1)+"','"+textBox2.Text+"','"+textBox1.Text+"','"+i.ToString()+"','"+rsn.Text+"')");
            MessageBox.Show("Substituted Succesfully");
            MessageBox.Show("OTP   :" + i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
