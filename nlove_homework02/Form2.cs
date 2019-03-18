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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            if (MessageBox.Show("Are you sure you want to clear?", "Confirm Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                richTextBox2.Text = "";
               
            }
        }
        
      
        private void Form2_Load(object sender, EventArgs e)
        {
            FileStream fs2 = new FileStream("something.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs2);
            string line2;
            line2 = sr.ReadLine();
            richTextBox2.Text = line2;
        }
    }
}
