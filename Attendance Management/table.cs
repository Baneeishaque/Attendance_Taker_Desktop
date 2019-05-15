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
    public partial class table : Form
    {
        DBhandler db = new DBhandler();
        public table()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
             DataTable dt = db.GetTable("SELECT        NAME FROM            staffs WHERE        (S1 = '" + comboBox6.SelectedItem.ToString() + "') OR (S2 = '" + comboBox6.SelectedItem.ToString() + "') OR (S3 = '" + comboBox6.SelectedItem.ToString() + "') OR (S4 = '" + comboBox6.SelectedItem.ToString() + "') OR (S5 = '" + comboBox6.SelectedItem.ToString() + "')");
            int c = dt.Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("No faculyt..Pls Add....");
            }
            else
            {
                int h = f3.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        f3.Items.RemoveAt(0);

                    }
                }
                for (int j = 0; j < c; j++)
                {
                    f3.Items.Add(dt.Rows[j]["NAME"].ToString());

                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void table_Load(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String br = comboBox1.SelectedItem.ToString();
            String cv = br.Substring(0, 6);
            String sem = comboBox2.SelectedItem.ToString();
            if (sem.Equals("semester1"))
            {

                int h = comboBox8.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        comboBox8.Items.RemoveAt(0);
                         comboBox7.Items.RemoveAt(0);
                         comboBox6.Items.RemoveAt(0);
                         comboBox5.Items.RemoveAt(0);
                         comboBox4.Items.RemoveAt(0);

                    }
                }

                DataTable dt = db.GetTable("select subjects  from "+cv+"1"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    comboBox8.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox7.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox6.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox5.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox4.Items.Add(dt.Rows[y]["subjects"].ToString());

                }





            }
            if (sem.Equals("semester2"))
            {


               

                int h = comboBox7.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        comboBox8.Items.RemoveAt(0);
                         comboBox7.Items.RemoveAt(0);
                         comboBox6.Items.RemoveAt(0);
                         comboBox5.Items.RemoveAt(0);
                         comboBox4.Items.RemoveAt(0);

                    }
                }

                DataTable dt = db.GetTable("select subjects  from "+cv+"2"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    comboBox8.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox7.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox6.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox5.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox4.Items.Add(dt.Rows[y]["subjects"].ToString());

                }



            }
            if (sem.Equals("semester3"))
            {


                

                int h = comboBox6.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        comboBox8.Items.RemoveAt(0);
                         comboBox7.Items.RemoveAt(0);
                         comboBox6.Items.RemoveAt(0);
                         comboBox5.Items.RemoveAt(0);
                         comboBox4.Items.RemoveAt(0);

                    }
                }

                DataTable dt = db.GetTable("select subjects  from "+cv+"3"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    comboBox8.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox7.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox6.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox5.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox4.Items.Add(dt.Rows[y]["subjects"].ToString());

                }
            }
            if (sem.Equals("semester4"))
            {


                

                int h = comboBox5.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        comboBox8.Items.RemoveAt(0);
                         comboBox7.Items.RemoveAt(0);
                         comboBox6.Items.RemoveAt(0);
                         comboBox5.Items.RemoveAt(0);
                         comboBox4.Items.RemoveAt(0);

                    }
                }

                DataTable dt = db.GetTable("select subjects  from "+cv+"4"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    comboBox8.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox7.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox6.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox5.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox4.Items.Add(dt.Rows[y]["subjects"].ToString());

                }


            }
            if (sem.Equals("semester5"))
            {


            

                int h = comboBox8.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        comboBox8.Items.RemoveAt(0);
                         comboBox7.Items.RemoveAt(0);
                         comboBox6.Items.RemoveAt(0);
                         comboBox5.Items.RemoveAt(0);
                         comboBox4.Items.RemoveAt(0);


                    }
                }

                DataTable dt = db.GetTable("select subjects  from "+cv+"5"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    comboBox8.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox7.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox6.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox5.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox4.Items.Add(dt.Rows[y]["subjects"].ToString());

                }



            }
            if (sem.Equals("semester6"))
            {


             

                int h = comboBox8.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        comboBox8.Items.RemoveAt(0);
                         comboBox7.Items.RemoveAt(0);
                         comboBox6.Items.RemoveAt(0);
                         comboBox5.Items.RemoveAt(0);
                         comboBox4.Items.RemoveAt(0);


                    }
                }

                DataTable dt = db.GetTable("select subjects  from "+cv+"6"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    comboBox8.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox7.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox6.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox5.Items.Add(dt.Rows[y]["subjects"].ToString());
                    comboBox4.Items.Add(dt.Rows[y]["subjects"].ToString());

                }


            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = db.GetTable("SELECT        NAME FROM            staffs WHERE        (S1 = '" + comboBox8.SelectedItem.ToString() + "') OR (S2 = '" + comboBox8.SelectedItem.ToString() + "') OR (S3 = '" + comboBox8.SelectedItem.ToString() + "') OR (S4 = '" + comboBox8.SelectedItem.ToString() + "') OR (S5 = '" + comboBox8.SelectedItem.ToString() + "')");
            int c = dt.Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("No faculyt..Pls Add....");
            }
            else
            {
                int h = f1.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        f1.Items.RemoveAt(0);

                    }
                }
                for (int j = 0; j < c; j++)
                {
                    f1.Items.Add(dt.Rows[j]["NAME"].ToString());

                }

            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
             DataTable dt = db.GetTable("SELECT        NAME FROM            staffs WHERE        (S1 = '" + comboBox7.SelectedItem.ToString() + "') OR (S2 = '" + comboBox7.SelectedItem.ToString() + "') OR (S3 = '" + comboBox7.SelectedItem.ToString() + "') OR (S4 = '" + comboBox7.SelectedItem.ToString() + "') OR (S5 = '" + comboBox7.SelectedItem.ToString() + "')");
            int c = dt.Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("No faculyt..Pls Add....");
            }
            else
            {
                int h = f2.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        f2.Items.RemoveAt(0);

                    }
                }
                for (int j = 0; j < c; j++)
                {
                    f2.Items.Add(dt.Rows[j]["NAME"].ToString());

                }

            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
             DataTable dt = db.GetTable("SELECT        NAME FROM            staffs WHERE        (S1 = '" + comboBox5.SelectedItem.ToString() + "') OR (S2 = '" + comboBox5.SelectedItem.ToString() + "') OR (S3 = '" + comboBox5.SelectedItem.ToString() + "') OR (S4 = '" + comboBox5.SelectedItem.ToString() + "') OR (S5 = '" + comboBox5.SelectedItem.ToString() + "')");
            int c = dt.Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("No faculyt..Pls Add....");
            }
            else
            {
                int h = f4.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        f4.Items.RemoveAt(0);

                    }
                }
                for (int j = 0; j < c; j++)
                {
                    f4.Items.Add(dt.Rows[j]["NAME"].ToString());

                }

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
             DataTable dt = db.GetTable("SELECT        NAME FROM            staffs WHERE        (S1 = '" + comboBox4.SelectedItem.ToString() + "') OR (S2 = '" + comboBox4.SelectedItem.ToString() + "') OR (S3 = '" + comboBox4.SelectedItem.ToString() + "') OR (S4 = '" + comboBox4.SelectedItem.ToString() + "') OR (S5 = '" + comboBox4.SelectedItem.ToString() + "')");
            int c = dt.Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("No faculyt..Pls Add....");
            }
            else
            {
                int h = f5.Items.Count;
                if (h > 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        f5.Items.RemoveAt(0);

                    }
                }
                for (int j = 0; j < c; j++)
                {
                    f5.Items.Add(dt.Rows[j]["NAME"].ToString());

                }

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String br = comboBox1.SelectedItem.ToString();
            String cv = br.Substring(0, 6);
            
            if (comboBox2.SelectedItem.ToString().Equals("semester1"))
            {


                db.Ins_Up_Del("UPDATE       " + cv + "t1" + " SET                p1 = '" + comboBox8.SelectedItem.ToString() + "', f1 = '" + f1.SelectedItem.ToString() + "', p2 = '" + comboBox7.SelectedItem.ToString() + "', f2 = '" + f2.SelectedItem.ToString() + "', p3 = '" + comboBox6.SelectedItem.ToString() + "', f3 = '" + f3.SelectedItem.ToString() + "', p4 = '" + comboBox5.SelectedItem.ToString() + "', f4 = '" + f4.SelectedItem.ToString() + "', p5 = '" + comboBox4.SelectedItem.ToString() + "', f5 = '" + f5.SelectedItem.ToString() + "' WHERE    (day = '" + comboBox3.SelectedItem.ToString() + "')");
            }
            if (comboBox2.SelectedItem.ToString().Equals("semester2"))
            {


                db.Ins_Up_Del("UPDATE       " + cv + "t2" + " SET                p1 = '" + comboBox8.SelectedItem.ToString() + "', f1 = '" + f1.SelectedItem.ToString() + "', p2 = '" + comboBox7.SelectedItem.ToString() + "', f2 = '" + f2.SelectedItem.ToString() + "', p3 = '" + comboBox6.SelectedItem.ToString() + "', f3 = '" + f3.SelectedItem.ToString() + "', p4 = '" + comboBox5.SelectedItem.ToString() + "', f4 = '" + f4.SelectedItem.ToString() + "', p5 = '" + comboBox4.SelectedItem.ToString() + "', f5 = '" + f5.SelectedItem.ToString() + "' WHERE    (day = '" + comboBox3.SelectedItem.ToString() + "')");



            }
            if (comboBox2.SelectedItem.ToString().Equals("semester3"))
            {


                db.Ins_Up_Del("UPDATE       " + cv + "t3" + " SET                p1 = '" + comboBox8.SelectedItem.ToString() + "', f1 = '" + f1.SelectedItem.ToString() + "', p2 = '" + comboBox7.SelectedItem.ToString() + "', f2 = '" + f2.SelectedItem.ToString() + "', p3 = '" + comboBox6.SelectedItem.ToString() + "', f3 = '" + f3.SelectedItem.ToString() + "', p4 = '" + comboBox5.SelectedItem.ToString() + "', f4 = '" + f4.SelectedItem.ToString() + "', p5 = '" + comboBox4.SelectedItem.ToString() + "', f5 = '" + f5.SelectedItem.ToString() + "' WHERE    (day = '" + comboBox3.SelectedItem.ToString() + "')");



            }
            if (comboBox2.SelectedItem.ToString().Equals("semester4"))
            {


                db.Ins_Up_Del("UPDATE       " + cv + "t4" + " SET                p1 = '" + comboBox8.SelectedItem.ToString() + "', f1 = '" + f1.SelectedItem.ToString() + "', p2 = '" + comboBox7.SelectedItem.ToString() + "', f2 = '" + f2.SelectedItem.ToString() + "', p3 = '" + comboBox6.SelectedItem.ToString() + "', f3 = '" + f3.SelectedItem.ToString() + "', p4 = '" + comboBox5.SelectedItem.ToString() + "', f4 = '" + f4.SelectedItem.ToString() + "', p5 = '" + comboBox4.SelectedItem.ToString() + "', f5 = '" + f5.SelectedItem.ToString() + "' WHERE    (day = '" + comboBox3.SelectedItem.ToString() + "')");



            }
            if (comboBox2.SelectedItem.ToString().Equals("semester5"))
            {


                db.Ins_Up_Del("UPDATE       " + cv + "t5" + " SET                p1 = '" + comboBox8.SelectedItem.ToString() + "', f1 = '" + f1.SelectedItem.ToString() + "', p2 = '" + comboBox7.SelectedItem.ToString() + "', f2 = '" + f2.SelectedItem.ToString() + "', p3 = '" + comboBox6.SelectedItem.ToString() + "', f3 = '" + f3.SelectedItem.ToString() + "', p4 = '" + comboBox5.SelectedItem.ToString() + "', f4 = '" + f4.SelectedItem.ToString() + "', p5 = '" + comboBox4.SelectedItem.ToString() + "', f5 = '" + f5.SelectedItem.ToString() + "' WHERE    (day = '" + comboBox3.SelectedItem.ToString() + "')");



            }
            if (comboBox2.SelectedItem.ToString().Equals("semester6"))
            {

                db.Ins_Up_Del("UPDATE       " + cv + "t6" + " SET                p1 = '" + comboBox8.SelectedItem.ToString() + "', f1 = '" + f1.SelectedItem.ToString() + "', p2 = '" + comboBox7.SelectedItem.ToString() + "', f2 = '" + f2.SelectedItem.ToString() + "', p3 = '" + comboBox6.SelectedItem.ToString() + "', f3 = '" + f3.SelectedItem.ToString() + "', p4 = '" + comboBox5.SelectedItem.ToString() + "', f4 = '" + f4.SelectedItem.ToString() + "', p5 = '" + comboBox4.SelectedItem.ToString() + "', f5 = '" + f5.SelectedItem.ToString() + "' WHERE    (day = '" + comboBox3.SelectedItem.ToString() + "')");
               



            }
            
        }
    }
}
