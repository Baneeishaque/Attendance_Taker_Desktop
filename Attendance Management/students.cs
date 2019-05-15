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
    public partial class students : Form
    {
        DBhandler db = new DBhandler();
        public students()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void students_Load(object sender, EventArgs e)
        {
           
            DataTable dt = db.GetTable("select branch from branches");
           
            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox1.Items.Add(dt.Rows[y]["branch"].ToString());
                comboBox4.Items.Add(dt.Rows[y]["branch"].ToString());
                comboBox6.Items.Add(dt.Rows[y]["branch"].ToString());
            }

            DataTable s = db.GetTable("select semester from sem where state = '1'");

            k =s.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox2.Items.Add(s.Rows[y]["semester"].ToString());
                comboBox3.Items.Add(s.Rows[y]["semester"].ToString());
                comboBox5.Items.Add(s.Rows[y]["semester"].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String br = comboBox1.SelectedItem.ToString();
            String cv = br.Substring(0, 6);
            String sem = comboBox2.SelectedItem.ToString();
            if (sem.Equals("semester1"))
            {
              

                db.Ins_Up_Del("INSERT INTO "+cv+"s1"+" (reg,name,dob )VALUES        ('" + rno.Text.ToString() + "', '" + name.Text + "', '" + dob.Text + "')");

                MessageBox.Show("Inserted");

            }
            if (sem.Equals("semester2"))
            {


                db.Ins_Up_Del("INSERT INTO " + cv + "s2" + " (reg,name,dob )VALUES        ('" + rno.Text.ToString() + "', '" + name.Text + "', '" + dob.Text + "')");

                MessageBox.Show("Inserted");

            }
            if (sem.Equals("semester3"))
            {


                db.Ins_Up_Del("INSERT INTO " + cv + "s3" + " (reg,name,dob )VALUES        ('" + rno.Text.ToString() + "', '" + name.Text + "', '" + dob.Text + "')");

                MessageBox.Show("Inserted");

            }
            if (sem.Equals("semester4"))
            {


                db.Ins_Up_Del("INSERT INTO " + cv + "s4" + " (reg,name,dob )VALUES        ('" + rno.Text.ToString() + "', '" + name.Text + "', '" + dob.Text + "')");

                MessageBox.Show("Inserted");

            }
            if (sem.Equals("semester5"))
            {


                db.Ins_Up_Del("INSERT INTO " + cv + "s5" + " (reg,name,dob )VALUES        ('" + rno.Text.ToString() + "', '" + name.Text + "', '" + dob.Text + "')");

                MessageBox.Show("Inserted");

            }
            if (sem.Equals("semester6"))
            {


                db.Ins_Up_Del("INSERT INTO " + cv + "s6" + " (reg,name,dob )VALUES        ('" + rno.Text.ToString() + "', '" + name.Text + "', '" + dob.Text + "')");

                MessageBox.Show("Inserted");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String aa = comboBox4.SelectedItem.ToString();
            String bb = aa.Substring(0, 6);
            String sms = comboBox3.SelectedItem.ToString();
            String g = drno.Text;

            if (sms.Equals("semester1"))
            {


                db.Ins_Up_Del("delete from "+bb+"s1"+" where reg ='"+g+"'");

                MessageBox.Show("Deleted " + g);

            }
            if (sms.Equals("semester2"))
            {


                db.Ins_Up_Del("delete from " + bb + "s2" + " where reg ='" + g + "'");

                MessageBox.Show("Deleted " + g);

            }
            if (sms.Equals("semester3"))
            {


                db.Ins_Up_Del("delete from " + bb + "s3" + " where reg ='" + g + "'");

                MessageBox.Show("Deleted " + g);

            }
            if (sms.Equals("semester4"))
            {


                db.Ins_Up_Del("delete from " + bb + "s4" + " where reg ='" + g + "'");

                MessageBox.Show("Deleted " + g);

            }
            if (sms.Equals("semester5"))
            {


                db.Ins_Up_Del("delete from " + bb + "s5" + " where reg ='" + g + "'");

                MessageBox.Show("Deleted " + g);

            }
            if (sms.Equals("semester6"))
            {


                db.Ins_Up_Del("delete from " + bb + "s6" + " where reg ='" + g + "'");

                MessageBox.Show("Deleted " + g);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String br = comboBox6.SelectedItem.ToString();
            String cv = br.Substring(0, 6);
            String sem = comboBox5.SelectedItem.ToString();
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

                DataTable dt = db.GetTable("select reg,name from "+cv+"s1"+"");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["reg"].ToString(), dt.Rows[y]["name"].ToString());

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
                DataTable dt = db.GetTable("select reg,name from " + cv + "s2" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["reg"].ToString(), dt.Rows[y]["name"].ToString());

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

                DataTable dt = db.GetTable("select reg,name from " + cv + "s3" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["reg"].ToString(), dt.Rows[y]["name"].ToString());

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

                DataTable dt = db.GetTable("select reg,name from " + cv + "s4" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["reg"].ToString(), dt.Rows[y]["name"].ToString());

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
                DataTable dt = db.GetTable("select reg,name from " + cv + "s5" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["reg"].ToString(), dt.Rows[y]["name"].ToString());

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
                DataTable dt = db.GetTable("select reg,name from " + cv + "s6" + "");

                int k = dt.Rows.Count;
                for (int y = 0; y < k; y++)
                {
                    list.Rows.Add(dt.Rows[y]["reg"].ToString(), dt.Rows[y]["name"].ToString());

                }
                

            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        
    }
}
