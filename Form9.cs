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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            DriveInfo[] list = DriveInfo.GetDrives();
            foreach (DriveInfo c in list)
                comboBox1.Items.Add(c.Name);
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo f = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] g = f.GetDirectories();
            foreach (DirectoryInfo h in g)
                comboBox2.Items.Add(h.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo[] list = DriveInfo.GetDrives();
            foreach (DriveInfo c in list)
                comboBox4.Items.Add(c.Name);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo f = new DirectoryInfo(comboBox4.Text);
            DirectoryInfo[] g = f.GetDirectories();
            foreach (DirectoryInfo h in g)
                comboBox5.Items.Add(h.ToString());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string targetPath = comboBox4.Text + comboBox5.Text + "\\" + comboBox3.Text;
            string sourcePath = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            File.Move(sourcePath, targetPath);
            MessageBox.Show("File Moved");
        }
    }
}
