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
    public partial class Staff : Form
    {
        DBhandler db = new DBhandler();

        String ide;
        Random rd = new Random();
        int i;
        public Staff()
        {

         
            InitializeComponent();
            i = rd.Next(1000, 2000);
            id.Text = i.ToString();
        }

        private void add_db_Click(object sender, EventArgs e)
        {
            int co = Subjects.Items.Count;

            if (co == 0)
            {
                MessageBox.Show("Minimum One Subject Is required");
            }

            else
            {

                switch (co)
                {
                    case 1: db.Ins_Up_Del("INSERT INTO staffs (ID, NAME, S1, S2, S3, S4, S5,PHONE,pass )VALUES        (" + i + ", '" + name.Text.ToString() + "', '" + Subjects.Items[0].ToString() + "', 'nil', 'nil', 'nil', 'nil', '" + phone.Text.ToString() + "','" + rd.Next(3000, 4000) + "')");
                        MessageBox.Show("Inserted");
                        break;
                    case 2:
                        db.Ins_Up_Del("INSERT INTO staffs (ID, NAME, S1, S2, S3, S4, S5,PHONE,pass )VALUES        (" + i + ", '" + name.Text.ToString() + "', '" + Subjects.Items[0].ToString() + "', '" + Subjects.Items[1].ToString() + "', 'nil', 'nil', 'nil', '" + phone.Text.ToString() + "','" + rd.Next(3000, 4000) + "')");
                        MessageBox.Show("Inserted");
                        break;
                    case 3:
                        db.Ins_Up_Del("INSERT INTO staffs (ID, NAME, S1, S2, S3, S4, S5,PHONE,pass )VALUES        (" + i + ", '" + name.Text.ToString() + "', '" + Subjects.Items[0].ToString() + "', '" + Subjects.Items[1].ToString() + "',  '" + Subjects.Items[2].ToString() + "', 'nil', 'nil', '" + phone.Text.ToString() + "','" + rd.Next(3000, 4000) + "')");
                        MessageBox.Show("Inserted");
                        break;
                    case 4:
                        db.Ins_Up_Del("INSERT INTO staffs (ID, NAME, S1, S2, S3, S4, S5,PHONE,pass )VALUES        (" + i + ", '" + name.Text.ToString() + "', '" + Subjects.Items[0].ToString() + "', '" + Subjects.Items[1].ToString() + "',  '" + Subjects.Items[2].ToString() + "', '" + Subjects.Items[3].ToString() + "', 'nil', '" + phone.Text.ToString() + "','" + rd.Next(3000, 4000) + "')");
                        MessageBox.Show("Inserted");
                        break;
                    case 5:
                        db.Ins_Up_Del("INSERT INTO staffs (ID, NAME, S1, S2, S3, S4, S5,PHONE,pass )VALUES        (" + i + ", '" + name.Text.ToString() + "', '" + Subjects.Items[0].ToString() + "', '" + Subjects.Items[1].ToString() + "',  '" + Subjects.Items[2].ToString() + "', '" + Subjects.Items[3].ToString() + "', '" + Subjects.Items[4].ToString() + "', '" + phone.Text.ToString() + "','" + rd.Next(3000, 4000) + "')");
                        MessageBox.Show("Inserted");
                        break;
                }
                 i = rd.Next(2000, 3000);
                 id.Text = i.ToString();
                 name.Text = null;
                 phone.Text = null;
                 


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMDBDataSet1.staffs' table. You can move, or remove it, as needed.
            
            DataTable dt = db.GetTable("select branch from branches");

            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox1.Items.Add(dt.Rows[y]["branch"].ToString());
               
            }

            DataTable s = db.GetTable("select semester from sem ");

            k = s.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                comboBox2.Items.Add(s.Rows[y]["semester"].ToString());
               
            }
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

        private void sub_add_Click(object sender, EventArgs e)
        {
            if (sub.SelectedItem == null)
            {
                MessageBox.Show("Select subject !");
            }
            else
            {

                if (Subjects.Items.Count == 5)
                    MessageBox.Show("Maximum");
                else
                {

                    if (Subjects.Items.Count == 0)
                    {
                        Subjects.Items.Add(sub.SelectedItem.ToString());
                        sub.SelectedItem = null;
                    }
                    else
                    {
                        int flag = 0;
                        int c = Subjects.Items.Count;

                        for (int i = 0; i < c; i++)
                        {
                            if (Subjects.Items[i].ToString() == sub.SelectedItem.ToString())
                            {
                                flag = 1;


                            }


                        }

                        if (flag == 0)
                        {
                            Subjects.Items.Add(sub.SelectedItem.ToString());

                            sub.SelectedItem = null;

                        }
                        else
                        {
                            MessageBox.Show(" already choosen");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (Subjects.SelectedItem == null)
             {
                MessageBox.Show("Select Subject!");
             }
            else
            {
                Subjects.Items.Remove(Subjects.SelectedItem);


            }




        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            ide = sid.Text.ToString();
            DataTable ff = db.GetTable("select NAME from staffs where ID ='"+ide+"'");
            int b = ff.Rows.Count;
            if (b > 0)
            {
                nme.Text = ff.Rows[0]["NAME"].ToString();
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("Delete from staffs where ID='"+ide+"'");
            MessageBox.Show("Deleted Succesfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = dataGridView1.Rows.Count;
            if (c > 1)
            {
                for (int j = 1; j < c; j++)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
            DataTable dt = db.GetTable("select id,name,phone,pass from staffs");

            int k = dt.Rows.Count;
            for (int y = 0; y < k; y++)
            {
                dataGridView1.Rows.Add(dt.Rows[y]["ID"].ToString(), dt.Rows[y]["NAME"].ToString(), dt.Rows[y]["PHONE"].ToString(), dt.Rows[y]["pass"].ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }


        
        }
        
    
}
