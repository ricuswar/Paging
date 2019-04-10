using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paging_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public int setsize = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            AccessSequanceListBox.Items.Clear();
        }

        private void btnGetPages_Click(object sender, EventArgs e)
        {
            lsbPages.Items.Clear();
            int amount = int.Parse(numHDD.Text);

            for (int i = 1; i <= amount; i++)
            {
                lsbPages.Items.Add(Convert.ToChar(i + 64));
                ASCB.Items.Add(Convert.ToChar(i + 64));
                
            }
        }

        private void SetSizeButton_Click(object sender, EventArgs e)
        {
            setsize = int.Parse(ASUD.Text);
        }

        private void SetValButton_Click(object sender, EventArgs e)
        {
            if (setsize > 0)
            {
                setsize = setsize - 1;
                AccessSequanceListBox.Items.Add(ASCB.Text);
            }
            else
            {
                MessageBox.Show("sorry no space left");
            }
            

        }

        private void AccessSequanceButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < setsize; i++)
            {
                int temp = rnd.Next(setsize);
                AccessSequanceListBox.Items.Add(Convert.ToChar(temp + 64));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessSequanceListBox.Items.Clear();
        }
    }
}
