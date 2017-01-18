using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeShift
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MagicSauce 
        public void _magicsauce()

        {
            if (this.maskedTextBox1.Text == (""))
            {
                MessageBox.Show("Please Input a Number", "Enter Number",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                int input;
                bool okay = int.TryParse(this.maskedTextBox1.Text, out input);
                var calc = DateTime.Today.AddMonths(-Math.Abs(input));
                label1.Text = "" + calc.ToString("MM/yyyy");

            }
        }

        #endregion

            public void _Clear()
            {
             label1.Text = "";
              maskedTextBox1.Text = "";
            }
            
            
        private void button1_Click(object sender, EventArgs e)
        {

            _magicsauce();


        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            _Clear();

        }

        
    }
   }


