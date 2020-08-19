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
using SautinSoft.Document;

namespace FilingAssignment
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            button1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            string result = comboBox1.Text + comboBox2.Text + "\\result" + textBox1.Text;
            if (File.Exists(path))
            {
                int pdfIndex = textBox1.Text.IndexOf(".pdf");
                int textIndex = textBox1.Text.IndexOf(".txt");
                int wordIndex = textBox1.Text.IndexOf(".docx");
                int excelIndex = textBox1.Text.IndexOf(".csv'");
                if (pdfIndex != -1)
                {
                    DocumentCore dc = DocumentCore.Load(path);
                    ContentRange cr = dc.Content.Find("Hello").FirstOrDefault();
                    if(cr != null)
                    {
                        cr.Start.Insert(richTextBox1.Text);
                    }
                    dc.Save(path);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path));
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(result) { UseShellExecute = true });
                    MessageBox.Show("File Have Been Saved");
                }
                else if (textIndex != -1)
                {
                    StreamWriter strm = new StreamWriter(path, true);
                    strm.Write(richTextBox1.Text);
                    strm.Close();
                    MessageBox.Show("File Have Been Saved");
                }

            }
            else
            {
                MessageBox.Show("File not found");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
            this.Hide();
        }
    }
}
