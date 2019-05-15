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
    public partial class svise1 : Form
    {
        DBhandler db = new DBhandler();

        public svise1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void svise1_Load(object sender, EventArgs e)
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sel = comboBox1.SelectedItem.ToString();
            sel = sel.Substring(0, 6);

            if (comboBox2.SelectedItem.ToString().Equals("semester1"))
            {
                DataTable s = db.GetTable("select subjects from " + sel + "1" + "");
                int h = sub.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        sub.Items.RemoveAt(0);


                    }
                }
                int g = s.Rows.Count;
                for (int y = 0; y < g; y++)
                {
                    sub.Items.Add(s.Rows[y]["subjects"].ToString());

                }

            }


            if (comboBox2.SelectedItem.ToString().Equals("semester2"))
            {
                DataTable s = db.GetTable("select subjects from " + sel + "2" + "");
                int h = sub.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        sub.Items.RemoveAt(0);


                    }
                }
                int g = s.Rows.Count;
                for (int y = 0; y < g; y++)
                {
                    sub.Items.Add(s.Rows[y]["subjects"].ToString());

                }

            }

            if (comboBox2.SelectedItem.ToString().Equals("semester3"))
            {
                DataTable s = db.GetTable("select subjects from " + sel + "3" + "");
                int h = sub.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        sub.Items.RemoveAt(0);


                    }
                }
                int g = s.Rows.Count;
                for (int y = 0; y < g; y++)
                {
                    sub.Items.Add(s.Rows[y]["subjects"].ToString());

                }

            }
            if (comboBox2.SelectedItem.ToString().Equals("semester4"))
            {
                DataTable s = db.GetTable("select subjects from " + sel + "4" + "");
                int h = sub.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        sub.Items.RemoveAt(0);


                    }
                }
                int g = s.Rows.Count;
                for (int y = 0; y < g; y++)
                {
                    sub.Items.Add(s.Rows[y]["subjects"].ToString());

                }

            }

            if (comboBox2.SelectedItem.ToString().Equals("semester5"))
            {
                DataTable s = db.GetTable("select subjects from " + sel + "5" + "");
                int h = sub.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        sub.Items.RemoveAt(0);


                    }
                }
                int g = s.Rows.Count;
                for (int y = 0; y < g; y++)
                {
                    sub.Items.Add(s.Rows[y]["subjects"].ToString());

                }

            }
            if (comboBox2.SelectedItem.ToString().Equals("semester6"))
            {
                DataTable s = db.GetTable("select subjects from " + sel + "6" + "");
                int h = sub.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        sub.Items.RemoveAt(0);


                    }
                }
                int g = s.Rows.Count;
                for (int y = 0; y < g; y++)
                {
                    sub.Items.Add(s.Rows[y]["subjects"].ToString());

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            svise ss = new svise(comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString(),sub.SelectedItem.ToString());
            ss.Show();
        }
    }
}
