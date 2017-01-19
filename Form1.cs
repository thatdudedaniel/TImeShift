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

                if (dateTimePicker1.Checked == false)
                {
                    bool okay = int.TryParse(this.maskedTextBox1.Text, out input);
                    var calc = dateTimePicker1.Value.AddMonths(-Math.Abs(input));
                    label1.Text = "" + calc.ToString("MM/yyyy");
                }

                else
                {
                    if (dateTimePicker1.Checked)
                    {
                     
                        bool okay = int.TryParse(this.maskedTextBox1.Text, out input);
                        var customcalc = dateTimePicker1.Value.Date.AddMonths(-Math.Abs(input));
                        label1.Text = "" + customcalc.ToString("MM/yyyy");
                    }

                
                }
            }
        }

        #endregion

        public void _Clear()

        {

            label1.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Checked = false;
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


