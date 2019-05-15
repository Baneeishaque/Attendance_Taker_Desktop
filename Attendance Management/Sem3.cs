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
    public partial class Sem3 : Form
    {
        DBhandler d = new DBhandler();

        public Sem3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 1 WHERE        (semester = 'semester1')");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 0 WHERE        (semester = 'semester1')");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 1 WHERE        (semester = 'semester2')");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 0 WHERE        (semester = 'semester2')");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 1 WHERE        (semester = 'semester3')");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 0 WHERE        (semester = 'semester3')");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 1 WHERE        (semester = 'semester4')");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 1 WHERE        (semester = 'semester5')");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 0 WHERE        (semester = 'semester5')");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 1 WHERE        (semester = 'semester6')");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 0 WHERE        (semester = 'semester6')");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d.Ins_Up_Del("UPDATE       sem SET                state = 0 WHERE        (semester = 'semester4')");
        }
    }
}
 