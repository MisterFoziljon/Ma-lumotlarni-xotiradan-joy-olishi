using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace _3_project
{
    public partial class textbox : Form
    {
        public string name;
        public string format;
        public string text;
        public textbox(string name,string format,string text)
        {
            this.name = name;   
            this.format = format;
            this.text = text;
            InitializeComponent();
            richTextBox1.Text = text;
            this.Text = name;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToString(e.KeyData));
        }

        private void saqlashToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            Form2 f = new Form2(richTextBox1.Text,name,format);
            f.ShowDialog();
        }
    }
}
