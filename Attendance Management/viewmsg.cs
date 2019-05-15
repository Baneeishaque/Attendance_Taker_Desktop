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
    public partial class viewmsg : Form
    {
        DBhandler db = new DBhandler();
        public viewmsg()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewmsg_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetTable("select title,message from messages");

            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                dataGridView1.Rows.Add(dt.Rows[y]["title"].ToString(), dt.Rows[y]["message"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
