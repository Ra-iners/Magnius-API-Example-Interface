using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagniusApi;

namespace MagniusAPIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Magnius.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magnius.Execute(richTextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Magnius.Inject();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magnius.GetKey();
        }
    }
}
