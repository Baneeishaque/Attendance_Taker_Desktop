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
    public partial class viewbranch : Form
    {

        DBhandler db = new DBhandler();
        public viewbranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void viewbranch_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetTable("select branch,hod from branches");

            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                dataGridView1.Rows.Add(dt.Rows[y]["branch"].ToString(), dt.Rows[y]["hod"].ToString()); 
            }
        }
    }
}
