using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilingAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form4 j = new Form4();
            j.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form5 l = new Form5();
            l.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form6 m = new Form6();
            m.Show();
            this.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Form7 o = new Form7();
            o.Show();
            this.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Form8 p = new Form8();
            p.Show();
            this.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Form9 q = new Form9();
            q.Show();
            this.Hide();
        }
    }
}
