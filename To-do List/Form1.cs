using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                checkedListBox1.Items.Add(text);
                textBox1.Text = string.Empty; 
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBox1.SelectedIndex;
            if (selectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(selectedIndex);
            }
        }

    }
}
