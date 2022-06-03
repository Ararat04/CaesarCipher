using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length>Convert.ToInt32(textBox2.Tag))
            { 
            char c = textBox2.Text[textBox2.Text.Length-1];
            int s=Convert.ToInt32(c+ (int)numericUpDown1.Value);
            textBox3.AppendText(Convert.ToString(Convert.ToChar(s)));
            }
            else
            {
                if (textBox2.Text.Length>0)
                {
                    textBox4.Text = textBox4.Text.Substring(0, textBox4.TextLength - 1);
                    textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 1);
                }
                else
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
    
            }
            textBox2.Tag = textBox2.Text.Length;
            label1.Text = Convert.ToString(textBox2.Text.Length);
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > Convert.ToInt32(textBox3.Tag))
            {
            char c = textBox3.Text[textBox3.Text.Length-1];
            int a;
            a = Convert.ToInt32(c)- (int)numericUpDown1.Value;
            textBox4.AppendText(Convert.ToString(Convert.ToChar(a)));
            }
            textBox3.Tag = textBox3.Text.Length;
            label2.Text = Convert.ToString(textBox3.Text.Length);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Tag = 0;
            label1.Text = Convert.ToString(0);
            textBox3.Clear();
            textBox3.Tag = 0;
            label2.Text = Convert.ToString(0);
            textBox4.Clear();
            label3.Text = Convert.ToString(0);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(textBox4.Text.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
