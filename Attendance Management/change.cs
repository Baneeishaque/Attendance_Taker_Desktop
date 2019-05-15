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
   
    public partial class change : Form
    {
        DBhandler db = new DBhandler();
        public change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable d = db.GetTable("SELECT        username,password FROM            auth");
            String u = d.Rows[0]["username"].ToString();
            String p = d.Rows[0]["password"].ToString();


            if (user.Text.ToString().Equals(u) && (pass.Text.ToString().Equals(p)))
            {
                change2 ch = new change2();
                ch.ShowDialog();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Invalid Username Or Password");
            }
        }
    }
}
