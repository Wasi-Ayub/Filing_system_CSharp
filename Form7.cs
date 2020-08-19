using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilingAssignment
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DriveInfo[] list = DriveInfo.GetDrives();
            foreach (DriveInfo c in list)
                comboBox1.Items.Add(c.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo f = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] g = f.GetDirectories();
            foreach (DirectoryInfo h in g)
                comboBox2.Items.Add(h.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text + "\\";
            DirectoryInfo j = new DirectoryInfo(path);
            FileInfo[] find = j.GetFiles();
            foreach (FileInfo k in find)
            {
                comboBox3.Items.Add(k.ToString());
            }
            button1.Visible = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("File Have Been Deleted");

            }
            else
            {
                MessageBox.Show("Couldn't Delete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
