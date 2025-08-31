using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.BeginUpdate();
            for (int i = 0; i < 1000; i++) 
            { 
             comboBox1.Items.Add("Item" + i.ToString());
            }
            comboBox1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(textBox1.Text);
            MessageBox.Show(index.ToString());
        }
    }
}
