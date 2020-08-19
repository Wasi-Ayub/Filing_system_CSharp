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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DriveInfo[] list = DriveInfo.GetDrives();
            foreach (DriveInfo c in list)
                comboBox1.Items.Add(c.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder Created");
            }
            else
            {
                MessageBox.Show("Folder not Created ");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 i = new Form1();
            i.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
