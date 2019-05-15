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
    public partial class svise : Form
    {
        
        DBhandler db = new DBhandler();
        DataTable dt, d, dattendence, ds;
     
        String branch, semester,subject;
        private string p;
        private string p_2;
        private string p_3;
      
        public svise()
        {
           
        }

        public svise(string p, string p_2, string p_3)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            branch= p;
            semester= p_2;
            subject = p_3;
        }

        private void svise_Load(object sender, EventArgs e)
        {
            



            d = db.GetTable("select * from " + branch.Substring(0, 6) + "s" + semester.Substring(8) + "");
            ds = db.GetTable("select *from " + branch.Substring(0, 6) + "s" + semester.Substring(8) + "");
            for (int i = 0; i < d.Rows.Count; i++)
            {
                int subcount = 0, stucount = 0;
               // MessageBox.Show(d.Rows[i]["reg"].ToString());

                dt = db.GetTable("select * from " + branch.Substring(0, 6) + "t" + semester.Substring(8) + " where day='Monday'");

                if (dt.Rows[0]["p1"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Monday p1");

                    dattendence = db.GetTable("select p1 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Monday' ");

                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        //MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Monday p1" + " " + j);
                        subcount++;
                        if (dattendence.Rows[j]["p1"].ToString().Equals("1"))
                        {

                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }

                }
                if (dt.Rows[0]["p2"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Monday p2");

                    dattendence = db.GetTable("select p2 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Monday' ");

                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Monday p2 " + j);
                        if (dattendence.Rows[j]["p2"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }

                }
                if (dt.Rows[0]["p3"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Monday p3");

                    dattendence = db.GetTable("select p3 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Monday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Monday p3 " + j);
                        if (dattendence.Rows[j]["p3"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }

                }
                if (dt.Rows[0]["p4"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Monday p4");

                    dattendence = db.GetTable("select p4 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Monday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Monday p4 " + j);
                        if (dattendence.Rows[j]["p4"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }

                }
                if (dt.Rows[0]["p5"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Monday p5");

                    dattendence = db.GetTable("select p5 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Monday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Monday p5 " + j);
                        if (dattendence.Rows[j]["p5"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }

                }




                dt = db.GetTable("select * from " + branch.Substring(0, 6) + "t" + semester.Substring(8) + " where day='Tuesday'");

                if (dt.Rows[0]["p1"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Tuesday p1");

                    dattendence = db.GetTable("select p1 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Tuesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                       // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Tuesday p1" + " " + j);
                        subcount++;
                        if (dattendence.Rows[j]["p1"].ToString().Equals("1"))
                        {

                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p2"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p2"].ToString() + "  Tuesday p2");

                    dattendence = db.GetTable("select p2 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Tuesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Tuesday p2 " + j);
                        if (dattendence.Rows[j]["p2"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p3"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p3"].ToString() + "  Tuesday p3");

                    dattendence = db.GetTable("select p3 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Tuesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Tuesday p3 " + j);
                        if (dattendence.Rows[j]["p3"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p4"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p4"].ToString() + "  Tuesday p4");

                    dattendence = db.GetTable("select p4 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Tuesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Tuesday p4 " + j);
                        if (dattendence.Rows[j]["p4"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p5"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p5"].ToString() + "  Tuesday p5");

                    dattendence = db.GetTable("select p5 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Tuesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Tuesday p5 " + j);
                        if (dattendence.Rows[j]["p5"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }


                dt = db.GetTable("select * from " + branch.Substring(0, 6) + "t" + semester.Substring(8) + " where day='Wednesday'");

                if (dt.Rows[0]["p1"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Wednesday p1");

                    dattendence = db.GetTable("select p1 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Wednesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                       // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Wednesday p1" + " " + j);
                        subcount++;
                        if (dattendence.Rows[j]["p1"].ToString().Equals("1"))
                        {

                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p2"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Wednesday p2");

                    dattendence = db.GetTable("select p2 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Wednesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Wednesday p2 " + j);
                        if (dattendence.Rows[j]["p2"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p3"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Wednesday p3");

                    dattendence = db.GetTable("select p3 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Wednesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Wednesday p3 " + j);
                        if (dattendence.Rows[j]["p3"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p4"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Wednesday p4");

                    dattendence = db.GetTable("select p4 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Wednesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Wednesday p4 " + j);
                        if (dattendence.Rows[j]["p4"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p5"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Wednesday p5");

                    dattendence = db.GetTable("select p5 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Wednesday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Wednesday p5 " + j);
                        if (dattendence.Rows[j]["p5"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }


                dt = db.GetTable("select * from " + branch.Substring(0, 6) + "t" + semester.Substring(8) + " where day='Thursday'");

                if (dt.Rows[0]["p1"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Thursday p1");

                    dattendence = db.GetTable("select p1 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Thursday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                       // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Thursday p1" + " " + j);
                        subcount++;
                        if (dattendence.Rows[j]["p1"].ToString().Equals("1"))
                        {

                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p2"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Thursday p2");

                    dattendence = db.GetTable("select p2 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Thursday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Thursday p2 " + j);
                        if (dattendence.Rows[j]["p2"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p3"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Thursday p3");

                    dattendence = db.GetTable("select p3 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Thursday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Thursday p3 " + j);
                        if (dattendence.Rows[j]["p3"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p4"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Thursday p4");

                    dattendence = db.GetTable("select p4 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Thursday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Thursday p4 " + j);
                        if (dattendence.Rows[j]["p4"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p5"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Thursday p5");

                    dattendence = db.GetTable("select p5 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Thursday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Thursday p5 " + j);
                        if (dattendence.Rows[j]["p5"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }


                dt = db.GetTable("select * from " + branch.Substring(0, 6) + "t" + semester.Substring(8) + " where day='Friday'");

                if (dt.Rows[0]["p1"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Friday p1");

                    dattendence = db.GetTable("select p1 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Friday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        //MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Friday p1" + " " + j);
                        subcount++;
                        if (dattendence.Rows[j]["p1"].ToString().Equals("1"))
                        {

                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p2"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Friday p2");

                    dattendence = db.GetTable("select p2 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Friday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Friday p2 " + j);
                        if (dattendence.Rows[j]["p2"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p3"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Friday p3");

                    dattendence = db.GetTable("select p3 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Friday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Friday p3 " + j);
                        if (dattendence.Rows[j]["p3"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p4"].ToString().Equals("" + subject + ""))
                {
                   // MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Friday p4");

                    dattendence = db.GetTable("select p4 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Friday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Friday p4 " + j);
                        if (dattendence.Rows[j]["p4"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p5"].ToString().Equals("" + subject + ""))
                {
                    //essageBox.Show(dt.Rows[0]["p5"].ToString() + " Friday p5");

                    dattendence = db.GetTable("select p5 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Friday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Friday p5 " + j);
                        if (dattendence.Rows[j]["p5"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }



                dt = db.GetTable("select * from " + branch.Substring(0, 6) + "t" + semester.Substring(8) + " where day='Saturday'");

                if (dt.Rows[0]["p1"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Saturday p1");

                    dattendence = db.GetTable("select p1 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Saturday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                       // MessageBox.Show(dt.Rows[0]["p1"].ToString() + " Saturday p1" + " " + j);
                        subcount++;
                        if (dattendence.Rows[j]["p1"].ToString().Equals("1"))
                        {

                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p2"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Saturday p2");

                    dattendence = db.GetTable("select p2 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Saturday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p2"].ToString() + " Saturday p2 " + j);
                        if (dattendence.Rows[j]["p2"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p3"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Saturday p3");

                    dattendence = db.GetTable("select p3 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Saturday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                        //MessageBox.Show(dt.Rows[0]["p3"].ToString() + " Saturday p3 " + j);
                        if (dattendence.Rows[j]["p3"].ToString().Equals("1"))
                        {
                            stucount++;
                            //MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p4"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Saturday p4");

                    dattendence = db.GetTable("select p4 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Saturday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p4"].ToString() + " Saturday p4 " + j);
                        if (dattendence.Rows[j]["p4"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }
                if (dt.Rows[0]["p5"].ToString().Equals("" + subject + ""))
                {
                    //MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Saturday p5");

                    dattendence = db.GetTable("select p5 from attendance where reg='" + d.Rows[i]["reg"].ToString() + "' and branch='" + branch + "' and semester='" + semester + "' and day='Saturday' ");
                    for (int j = 0; j < dattendence.Rows.Count; j++)
                    {
                        subcount++;
                       // MessageBox.Show(dt.Rows[0]["p5"].ToString() + " Saturday p5 " + j);
                        if (dattendence.Rows[j]["p5"].ToString().Equals("1"))
                        {
                            stucount++;
                           // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
                        }
                    }
                }


               // MessageBox.Show(d.Rows[i]["reg"].ToString() + ":" + stucount.ToString());
               // MessageBox.Show("subcount" + ":" + subcount.ToString());
               // MessageBox.Show("%" + ":" + (((float)stucount / subcount) * 100).ToString());
                dataGridView1.Rows.Add(d.Rows[i]["reg"].ToString(), ds.Rows[i]["name"].ToString(), subcount.ToString(), stucount.ToString(), (((float)stucount / subcount) * 100).ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
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
