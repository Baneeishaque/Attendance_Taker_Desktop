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
    public partial class change2 : Form
    {
        DBhandler db = new DBhandler();
        public change2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("UPDATE       auth SET                username = '" + user.Text + "', password = '" + pass.Text + "'");
            MessageBox.Show("Succesfull");
            this.Dispose();
        }
    }
}
