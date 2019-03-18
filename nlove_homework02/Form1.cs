using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace nlove_homework02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs2 = new FileStream("something.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs2);
            string line2;

            while ((line2 = sr.ReadLine()) != null)
            {
                richTextBox1.Text += line2 + "\n";
            }
               // line2 = sr.ReadLine();
           // richTextBox1.Text = line2;
            sr.Close();
            fs2.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("something.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //create streamwr to print into  the file:
            StreamWriter sw = new StreamWriter(fs);
            string line = "";
           // method to concatinate lines in 1 text in the textbox
            richTextBox1.Text += line + "\n";


            //method to write into streamWriter object (s):
            sw.WriteLine(richTextBox1.Text.ToString());

            // close FileStream and StreamReader after using
            sw.Close();
            fs.Close();

           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2 ();
            form2.ShowDialog();
        }

        
    }
}
