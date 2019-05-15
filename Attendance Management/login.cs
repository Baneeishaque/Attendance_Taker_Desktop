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
    public partial class login : Form
    {
        DBhandler db = new DBhandler();
        Form1 h = new Form1();

     
        
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable d = db.GetTable("SELECT        username,password FROM            auth");
            String u = d.Rows[0]["username"].ToString();
            String p = d.Rows[0]["password"].ToString();


            if (user.Text.ToString().Equals(u) && (pass.Text.ToString().Equals(p)))
            {
               
                h.ShowDialog();

                login n = new login();
                n.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Text = null;
            pass.Text = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
