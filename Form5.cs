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
using iTextSharp.text.pdf.parser;

namespace FilingAssignment
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
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
                try
                {
                    int pdfIndex = comboBox3.Text.IndexOf(".pdf");
                    int textIndex = comboBox3.Text.IndexOf(".txt");
                    int wordIndex = comboBox3.Text.IndexOf(".docx");
                    int excelIndex = comboBox3.Text.IndexOf(".csv'");
                    if(pdfIndex != -1)
                    {
                        iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(path);
                        StringBuilder sb = new StringBuilder();
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            //Read page
                            sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }
                        richTextBox1.Text = sb.ToString();
                        reader.Close();
                    }
                    else if (textIndex != -1)
                    {
                        StreamReader strm = new StreamReader(path);
                        richTextBox1.Text = strm.ReadToEnd();
                        strm.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("File not found");
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
