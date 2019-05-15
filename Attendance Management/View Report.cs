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
    public partial class View_Report : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt, d,dattendence;
        private string p;
        private string p_2;
        String branch, semester;
        int totalp;
        public View_Report()
        {
            
        }

        public View_Report(string p, string p_2)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            branch = p;
            semester = p_2;
            //MessageBox.Show(p);
            //MessageBox.Show(p_2);
            d = db.GetTable("select distinct date from attendance where branch='"+branch+"' and semester='"+semester+"'");
            //MessageBox.Show("select distinct date from attendance where branch='" + branch + "' and semester='" + semester + "'");
            //MessageBox.Show("Total count of days" + d.Rows.Count.ToString());
            totalp = 5 * d.Rows.Count;
           // MessageBox.Show("Total periods: " + totalp);
            //MessageBox.Show("Students Report...");
            dt=db.GetTable ("select *from "+branch.Substring(0,6)+"s"+semester.Substring(8)+"");
            for (int j = 0; j < dt.Rows.Count; j++)
            {
//MessageBox.Show(dt.Rows[j]["reg"].ToString());
                //MessageBox.Show(dt.Rows[j]["name"].ToString());
               
                int acount = 0;
               

                
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    dattendence = db.GetTable("select p1,p2,p3,p4,p5 from attendance where reg='" + dt.Rows[j]["reg"].ToString() + "' and branch='"+branch+"' and semester='"+semester+"' and date='" + d.Rows[i]["date"].ToString() + "' ");
                    String a="select p1,p2,p3,p4,p5 from attendance where reg='" + dt.Rows[j]["reg"].ToString() + "' and branch='"+branch+"' and semester='"+semester+"' and date='" + d.Rows[i]["date"].ToString() + "'" ;
                    MessageBox.Show(a);
                    if (dattendence.Rows[0]["p1"].ToString().Equals("1"))
                    {
                        acount++;
                    }
                    if (dattendence.Rows[0]["p2"].ToString().Equals("1"))
                    {
                        acount++;
                    }
                    if (dattendence.Rows[0]["p3"].ToString().Equals("1"))
                    {
                        acount++;
                    }
                    if (dattendence.Rows[0]["p4"].ToString().Equals("1"))
                    {
                        acount++;
                    } if (dattendence.Rows[0]["p5"].ToString().Equals("1"))
                    {
                        acount++;
                    }
                    
                }
               

               // MessageBox.Show("Total present of "+dt.Rows[j]["name"].ToString() +": " + acount);
                
                dataGridView1.Rows.Add(dt.Rows[j]["reg"].ToString(), dt.Rows[j]["name"].ToString(), d.Rows.Count.ToString(), totalp.ToString(), acount.ToString(),((float)acount /totalp )*100+" %");
                     
                //MessageBox.Show("% is" + (((float)acount /totalp )*100).ToString() + "%");
               //, d.Rows.Count.ToString(), totalp.ToString(), acount.ToString());
            }
            
        }
        

        private void View_Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
         
    }
}
