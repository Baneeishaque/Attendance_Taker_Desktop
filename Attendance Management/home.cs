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
    public partial class Form1 : Form
    {
        DBhandler db = new DBhandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            branch br = new branch();
            br.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students s = new students();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sem3 sm = new Sem3();
            sm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            su s = new su();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.ShowDialog();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable d = db.GetTable("SELECT        username,password FROM            auth");
            String u = d.Rows[0]["username"].ToString();
            String p = d.Rows[0]["password"].ToString();
            if (user.Text != null && pass.Text != null)
            {

                if (user.Text.ToString().Equals(u) && (pass.Text.ToString().Equals(p)))
                {
                    panel3.Visible = false;

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password");
                }
            }
            else
            {
                MessageBox.Show("Required Fields");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            message ms = new message();
            ms.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table t = new table();
            t.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            change c = new change();
            c.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Viewtime v = new Viewtime();
            v.ShowDialog();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            viewbranch vb = new viewbranch();
            vb.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            viewmsg msg = new viewmsg();
            msg.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            correction cr = new correction();
            cr.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            svise1 s = new svise1();
            s.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("delete from sub");
        }
    }
}
