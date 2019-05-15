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
    public partial class branch : Form
    {
        String bn,cut;
        DBhandler db = new DBhandler();
        public branch()
        {
            InitializeComponent();
            sem.Enabled = false;
           
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
             int count = listBox7.Items.Count;
            int flag = 0;
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox7.Items[i].ToString()==s6.Text.ToString())
                    {

                        flag = 1;
                    }

                }
            }
                if (flag == 0)
                {
                    listBox7.Items.Add(s6.Text.ToString());
                }
                else
                {

                    MessageBox.Show("Already Added");

                }
            
        }
    
        

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox7.Items.Count; j++)
            {
                db.Ins_Up_Del("insert into " + cut + "6" + " values('" + listBox7.Items[j].ToString() + "')");
            }
            notice.Items.Add("Semester 6 subjects added ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bname.Text.Length > 6)
            {
                 bn = bname.Text.ToString();

                String ho = hod.Text.ToString();
                cut = bn.Substring(0, 6);
                String temp = cut;
                db.Ins_Up_Del("INSERT INTO branches (branch, hod) VALUES ('" + bn + "','" + ho + "')");
                notice.Items.Add("New Branch Added");

                db.Ins_Up_Del("create table " + cut + "1" + " (subjects varchar(50))");
                db.Ins_Up_Del("create table " + cut + "2" + " (subjects varchar(50))");
                db.Ins_Up_Del("create table " + cut + "3" + " (subjects varchar(50))");
                db.Ins_Up_Del("create table " + cut + "4" + " (subjects varchar(50))");
                db.Ins_Up_Del("create table " + cut + "5" + " (subjects varchar(50))");
                db.Ins_Up_Del("create table " + cut + "6" + " (subjects varchar(50))");
                db.Ins_Up_Del("create table " + cut + "s1" + " (reg varchar(50),name varchar(50),dob varchar(50))");
                db.Ins_Up_Del("create table " + cut + "s2" + " (reg varchar(50),name varchar(50),dob varchar(50))");
                db.Ins_Up_Del("create table " + cut + "s3" + " (reg varchar(50),name varchar(50),dob varchar(50))");
                db.Ins_Up_Del("create table " + cut + "s4" + " (reg varchar(50),name varchar(50),dob varchar(50))");
                db.Ins_Up_Del("create table " + cut + "s5" + " (reg varchar(50),name varchar(50),dob varchar(50))");
                db.Ins_Up_Del("create table " + cut + "s6" + " (reg varchar(50),name varchar(50),dob varchar(50))");
                    db.Ins_Up_Del("create table " + cut + "t1" + " (day varchar(50),p1 varchar(50),f1 varchar(50),p2 varchar(50),f2 varchar(50),p3 varchar(50),f3 varchar(50),p4 varchar(50),f4 varchar(50),p5 varchar(50),f5 varchar(50))");
                    db.Ins_Up_Del("Insert into "+cut+"t1"+"(day)values('Monday')");
                    db.Ins_Up_Del("Insert into " + cut + "t1" + "(day)values('Tuesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t1" + "(day)values('Wednesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t1" + "(day)values('Thursday')");
                    db.Ins_Up_Del("Insert into " + cut + "t1" + "(day)values('Friday')");
                    db.Ins_Up_Del("Insert into " + cut + "t1" + "(day)values('Saturday')");
                    db.Ins_Up_Del("create table " + cut + "t2" + " (day varchar(50),p1 varchar(50),f1 varchar(50),p2 varchar(50),f2 varchar(50),p3 varchar(50),f3 varchar(50),p4 varchar(50),f4 varchar(50),p5 varchar(50),f5 varchar(50))");
                    db.Ins_Up_Del("Insert into " + cut + "t2" + "(day)values('Monday')");
                    db.Ins_Up_Del("Insert into " + cut + "t2" + "(day)values('Tuesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t2" + "(day)values('Wednesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t2" + "(day)values('Thursday')");
                    db.Ins_Up_Del("Insert into " + cut + "t2" + "(day)values('Friday')");
                    db.Ins_Up_Del("Insert into " + cut + "t2" + "(day)values('Saturday')");
                    db.Ins_Up_Del("create table " + cut + "t3" + " (day varchar(50),p1 varchar(50),f1 varchar(50),p2 varchar(50),f2 varchar(50),p3 varchar(50),f3 varchar(50),p4 varchar(50),f4 varchar(50),p5 varchar(50),f5 varchar(50))");
                    db.Ins_Up_Del("Insert into " + cut + "t3" + "(day)values('Monday')");
                    db.Ins_Up_Del("Insert into " + cut + "t3" + "(day)values('Tuesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t3" + "(day)values('Wednesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t3" + "(day)values('Thursday')");
                    db.Ins_Up_Del("Insert into " + cut + "t3" + "(day)values('Friday')");
                    db.Ins_Up_Del("Insert into " + cut + "t3" + "(day)values('Saturday')");
                    db.Ins_Up_Del("create table " + cut + "t4" + " (day varchar(50),p1 varchar(50),f1 varchar(50),p2 varchar(50),f2 varchar(50),p3 varchar(50),f3 varchar(50),p4 varchar(50),f4 varchar(50),p5 varchar(50),f5 varchar(50))");
                    db.Ins_Up_Del("Insert into " + cut + "t4" + "(day)values('Monday')");
                    db.Ins_Up_Del("Insert into " + cut + "t4" + "(day)values('Tuesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t4" + "(day)values('Wednesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t4" + "(day)values('Thursday')");
                    db.Ins_Up_Del("Insert into " + cut + "t4" + "(day)values('Friday')");
                    db.Ins_Up_Del("Insert into " + cut + "t4" + "(day)values('Saturday')");
                    db.Ins_Up_Del("create table " + cut + "t5" + " (day varchar(50),p1 varchar(50),f1 varchar(50),p2 varchar(50),f2 varchar(50),p3 varchar(50),f3 varchar(50),p4 varchar(50),f4 varchar(50),p5 varchar(50),f5 varchar(50))");
                    db.Ins_Up_Del("Insert into " + cut + "t5" + "(day)values('Monday')");
                    db.Ins_Up_Del("Insert into " + cut + "t5" + "(day)values('Tuesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t5" + "(day)values('Wednesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t5" + "(day)values('Thursday')");
                    db.Ins_Up_Del("Insert into " + cut + "t5" + "(day)values('Friday')");
                    db.Ins_Up_Del("Insert into " + cut + "t5" + "(day)values('Saturday')");
                    db.Ins_Up_Del("create table " + cut + "t6" + " (day varchar(50),p1 varchar(50),f1 varchar(50),p2 varchar(50),f2 varchar(50),p3 varchar(50),f3 varchar(50),p4 varchar(50),f4 varchar(50),p5 varchar(50),f5 varchar(50))");
                    db.Ins_Up_Del("Insert into " + cut + "t6" + "(day)values('Monday')");
                    db.Ins_Up_Del("Insert into " + cut + "t6" + "(day)values('Tuesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t6" + "(day)values('Wednesday')");
                    db.Ins_Up_Del("Insert into " + cut + "t6" + "(day)values('Thursday')");
                    db.Ins_Up_Del("Insert into " + cut + "t6" + "(day)values('Friday')");
                    db.Ins_Up_Del("Insert into " + cut + "t6" + "(day)values('Saturday')");






                sem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter Full branch Name !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = listBox2.Items.Count;
            int flag = 0;
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox2.Items[i].ToString()==s.Text.ToString())
                    {

                        flag = 1;
                    }

                }
            }
                if (flag == 0)
                {
                    listBox2.Items.Add(s.Text.ToString());
                }
                else
                {

                    MessageBox.Show("Already Added");

                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
             int count = listBox3.Items.Count;
            int flag = 0;
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox3.Items[i].ToString()==s2.Text.ToString())
                    {

                        flag = 1;
                    }

                }
            }
                if (flag == 0)
                {
                    listBox3.Items.Add(s2.Text.ToString());
                }
                else
                {

                    MessageBox.Show("Already Added");

                }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
             int count = listBox4.Items.Count;
            int flag = 0;
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox4.Items[i].ToString()==s3.Text.ToString())
                    {

                        flag = 1;
                    }

                }
            }
                if (flag == 0)
                {
                    listBox4.Items.Add(s3.Text.ToString());
                }
                else
                {

                    MessageBox.Show("Already Added");

                }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
             int count = listBox5.Items.Count;
            int flag = 0;
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox5.Items[i].ToString()==s4.Text.ToString())
                    {

                        flag = 1;
                    }

                }
            }
                if (flag == 0)
                {
                    listBox5.Items.Add(s4.Text.ToString());
                }
                else
                {

                    MessageBox.Show("Already Added");

                }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
             int count = listBox6.Items.Count;
            int flag = 0;
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox6.Items[i].ToString()==s5.Text.ToString())
                    {

                        flag = 1;
                    }

                }
            }
                if (flag == 0)
                {
                    listBox6.Items.Add(s5.Text.ToString());
                }
                else
                {

                    MessageBox.Show("Already Added");

                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox2.Items.Count; j++)
            {
                db.Ins_Up_Del("insert into " + cut + "1" + " values('" + listBox2.Items[j].ToString() + "')");
            }
            notice.Items.Add("Semester 1 subjects added ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox3.Items.Count; j++)
            {
                db.Ins_Up_Del("insert into " + cut + "2" + " values('" + listBox3.Items[j].ToString() + "')");
            }
            notice.Items.Add("Semester 2 subjects added ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox4.Items.Count; j++)
            {
                db.Ins_Up_Del("insert into " + cut + "3" + " values('" + listBox4.Items[j].ToString() + "')");
            }
            notice.Items.Add("Semester 3 subjects added ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox5.Items.Count; j++)
            {
                db.Ins_Up_Del("insert into " + cut + "4" + " values('" + listBox5.Items[j].ToString() + "')");
            }
            notice.Items.Add("Semester 4 subjects added ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox6.Items.Count; j++)
            {
                db.Ins_Up_Del("insert into " + cut + "5" + " values('" + listBox6.Items[j].ToString() + "')");
            }
            notice.Items.Add("Semester 5 subjects added ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String br = comboBox1.SelectedItem.ToString();
            String b=br.Substring(0,6);
            db.Ins_Up_Del("delete  from branches where branch='" + br + "'");

                db.Ins_Up_Del("DROP TABLE " + b + "1" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "2" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "3" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "4" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "5" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "6" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "s1" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "s2" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "s3" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "s4" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "s5" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "s6" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "t1" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "t2" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "t3" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "t4" + "");
                db.Ins_Up_Del("DROP TABLE " + b + "t5" + "");
                MessageBox.Show("Deleted Succesfully");
            
        }

        private void branch_Load(object sender, EventArgs e)
        {
            DataTable b = db.GetTable("Select branch from branches");
            int k = b.Rows.Count;
            for(int y=0;y<k;y++)
            {
                comboBox1.Items.Add(b.Rows[y]["branch"].ToString());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        }
    
        
    
       
    
        
 

