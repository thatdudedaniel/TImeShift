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
            if (this.maskedTextBox1.Text == (""))  //Checking to see if the box is empty 
            {
                MessageBox.Show("Please Input a Number", "Enter Number", //If blank a message box will display asking to enter a number
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }


            else
            {

                int input;

                if (dateTimePicker1.Checked == false) // checking to see if the picker is checked or not
                {
                    int.TryParse(this.maskedTextBox1.Text, out input); //Text is entered and parsed into 32 bit integers then passes result
                    var calc = dateTimePicker1.Value.AddMonths(-Math.Abs(input));//Calculation is preformed, math.abs retruns the absolute value of the decimal
                    //this uses rhe default datetimepicker value which will always be the current date unless specified with custom date then adds the months value from input
                    //this is represented as a negative value so the output is positive number
                    label1.Text = "" + calc.ToString("MM/yyyy");//coverts to month/year format then updates the label with the result
                }

                else
                {
                    if (dateTimePicker1.Checked)//If checked then a custom date can be selected 
                    {
                     
                       int.TryParse(this.maskedTextBox1.Text, out input);
                        var customcalc = dateTimePicker1.Value.Date.AddMonths(-Math.Abs(input));
                        label1.Text = "" + customcalc.ToString("MM/yyyy");
                    }

                
                }
            }
        }

        #endregion

        public void _Clear() //Resets all controls to default 

        {

            label1.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Checked = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            _magicsauce();//Calls method


        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            _Clear();

        }

        
     }
   }


