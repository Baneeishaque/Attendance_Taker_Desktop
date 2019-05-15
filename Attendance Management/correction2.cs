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
    public partial class correction2 : Form
    {
        DBhandler db = new DBhandler();
        private string p;
        private string p_2;
        private string p_3;
        private string p_4;
        string branch, semester, no, date;
        DataTable dt,d;

        public correction2()
        {
            InitializeComponent();
        }

        public correction2(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            branch = p;
            semester = p_2;
            no = p_3;
            date= p_4;
            d = db.GetTable("select *from " + branch.Substring(0, 6) + "s" + semester.Substring(8) + " where (reg='"+no+"')");
            dt = db.GetTable("select date,p1,p2,p3,p4,p5,reg from attendance where (branch='" +branch+ "' and date='" +date+ "' and semester='" +semester+ "' and reg='"+no+"')");

            dataGridView1.Rows.Add(dt.Rows[0]["reg"].ToString(), d.Rows[0]["name"].ToString(), dt.Rows[0]["date"].ToString(), dt.Rows[0]["p1"].ToString(), dt.Rows[0]["p2"].ToString(), dt.Rows[0]["p3"].ToString(), dt.Rows[0]["p4"].ToString(), dt.Rows[0]["p5"].ToString());
            textBox1.Text = dt.Rows[0]["p1"].ToString();
            textBox2.Text = dt.Rows[0]["p2"].ToString();
            textBox3.Text = dt.Rows[0]["p3"].ToString();
            textBox4.Text = dt.Rows[0]["p4"].ToString();
            textBox5.Text = dt.Rows[0]["p5"].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void correction2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("UPDATE    attendance SET              p1='" + textBox1.Text + "',p2='" + textBox2.Text + "', p3='" + textBox3.Text + "', p4='" + textBox4.Text + "', p5='" + textBox5.Text + "' WHERE     (semester = '" + semester + "') AND (branch = '" + branch + "') AND (reg = '" + no + "') AND (date ='"+date+"')");

            MessageBox.Show("succes");
        }
    }
}
