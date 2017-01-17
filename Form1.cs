using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TImeShift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(this.maskedTextBox1.Text);
                int years = input / 12;
                label1.Text = "" + years;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Input a number", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text ="";
            maskedTextBox1.Text = "";
           
        }
    }
}
