using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yunus = textBox1.Text;
            listBox1.Items.Add(yunus);
            textBox1.Text = "";
            textBox1.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yunus = listBox1.Items();
            int sayac = 0;
            while (sayac < yunus );
            { 
                if (yunus ½ 2 == 0)
                {
                    listBox2.Items.Add(yunus);
                }
                else
                {
                    listBox3.Items.Add(yunus);
                }
            }
            




            }
        }
    }
}
