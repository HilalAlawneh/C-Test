using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Primary(int x)
        {
            for (int j = 1; j <= x; j++)
                comboBox1.Items.Add(j);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Primary(15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }
    }
}
