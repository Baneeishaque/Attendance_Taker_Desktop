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
    public partial class Viewtime : Form
    {
        DBhandler db = new DBhandler();
        public Viewtime()
        {
            InitializeComponent();
        }

        private void Viewtime_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            String br = comboBox1.SelectedItem.ToString();
            String cv = br.Substring(0, 6);
            String sem = comboBox2.SelectedItem.ToString();
            if (sem.Equals("semester1"))
            {
                int c = list.Rows.Count;
                if (c > 1)
                {
                    for (int j = 1; j < c; j++)
                    {
                        list.Rows.RemoveAt(0);
                    }
                }

                DataTable dt = db.GetTable("select day,p1,p2,p3,p4,p5 from " + cv + "t1" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["day"].ToString(), dt.Rows[y]["p1"].ToString(), dt.Rows[y]["p2"].ToString(), dt.Rows[y]["p3"].ToString(), dt.Rows[y]["p4"].ToString(), dt.Rows[y]["p5"].ToString());

                }




            }
            if (sem.Equals("semester2"))
            {
                int c = list.Rows.Count;
                if (c > 1)
                {
                    for (int j = 1; j < c; j++)
                    {
                        list.Rows.RemoveAt(0);
                    }
                }
                DataTable dt = db.GetTable("select day,p1,p2,p3,p4,p5 from " + cv + "t2" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["day"].ToString(), dt.Rows[y]["p1"].ToString(), dt.Rows[y]["p2"].ToString(), dt.Rows[y]["p3"].ToString(), dt.Rows[y]["p4"].ToString(), dt.Rows[y]["p5"].ToString());

                }




            }
            if (sem.Equals("semester3"))
            {
                int c = list.Rows.Count;
                if (c > 1)
                {
                    for (int j = 1; j < c; j++)
                    {
                        list.Rows.RemoveAt(0);
                    }
                }
                DataTable dt = db.GetTable("select day,p1,p2,p3,p4,p5 from " + cv + "t3" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["day"].ToString(), dt.Rows[y]["p1"].ToString(), dt.Rows[y]["p2"].ToString(), dt.Rows[y]["p3"].ToString(), dt.Rows[y]["p4"].ToString(), dt.Rows[y]["p5"].ToString());

                }



            }
            if (sem.Equals("semester4"))
            {
                int c = list.Rows.Count;
                if (c > 1)
                {
                    for (int j = 1; j < c; j++)
                    {
                        list.Rows.RemoveAt(0);
                    }
                }
                DataTable dt = db.GetTable("select day,p1,p2,p3,p4,p5 from " + cv + "t4" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["day"].ToString(), dt.Rows[y]["p1"].ToString(), dt.Rows[y]["p2"].ToString(), dt.Rows[y]["p3"].ToString(), dt.Rows[y]["p4"].ToString(), dt.Rows[y]["p5"].ToString());

                }



            }
            if (sem.Equals("semester5"))
            {
                int c = list.Rows.Count;
                if (c > 1)
                {
                    for (int j = 1; j < c; j++)
                    {
                        list.Rows.RemoveAt(0);
                    }
                }
                DataTable dt = db.GetTable("select day,p1,p2,p3,p4,p5 from " + cv + "t5" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["day"].ToString(), dt.Rows[y]["p1"].ToString(), dt.Rows[y]["p2"].ToString(), dt.Rows[y]["p3"].ToString(), dt.Rows[y]["p4"].ToString(), dt.Rows[y]["p5"].ToString());

                }




            }
            if (sem.Equals("semester6"))
            {
                int c = list.Rows.Count;
                if (c > 1)
                {
                    for (int j = 1; j < c; j++)
                    {
                        list.Rows.RemoveAt(0);
                    }
                }
                DataTable dt = db.GetTable("select day,p1,p2,p3,p4,p5 from " + cv + "t6" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["day"].ToString(), dt.Rows[y]["p1"].ToString(), dt.Rows[y]["p2"].ToString(), dt.Rows[y]["p3"].ToString(), dt.Rows[y]["p4"].ToString(), dt.Rows[y]["p5"].ToString());

                }


            }
        }
    }
}
