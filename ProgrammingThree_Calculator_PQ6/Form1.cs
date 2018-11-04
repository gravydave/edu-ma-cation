using System;
using BasicMath;
using System.Windows.Forms;

/*
 *  Author: David Chilcott
 *  Creation Date: 3/09/2018
 *  Version Control: Git
 */

namespace ProgrammingThree_Calculator_PQ6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
         * Initialise the required variables to be used throughout the program.
         * Doubles used to store values being operated on.
         * Booleans used to validate which arithmetic operation is being executed.
         */

        double total1 = 0;
        double total2 = 0; 
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        
        
        /*
         * Methods 0 - 9 are the numerical input methods that
         * assign values to the listbox
         */
        //1
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        //2
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        //3
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        //4
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        //5
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        //6
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        //7
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        //8
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        //9
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        //0
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }



        //This method clears the Display Text Box using the TextBox.Clear() method
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }


        //This method is the event handler for a user clicking the decimal point button
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }



        /*
         * The arithmetic methods are listed below. 
         * The behaviour of the method is that it sets the variable total1 to 
         * whatever value is held currently + the value as double of the text display.
         * 
         * The method will then set the associated boolean to true before setting the others to false
         */


        //Plus button
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }


        //Minus button
        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //Divide button
        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }


        //Multiply button
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }



        /*
         *The btnEquals method uses conditional If's in order to determine which
         * arithmetic operation to execute. The respective code is executed, then
         * displayed to the user, followed by a reset of the total1 value.
         */

        private void btnEquals_Click(object sender, EventArgs e)
        {

                if (plusButtonClicked == true)
                {
                    total2 = total1 + double.Parse(txtDisplay.Text);
                }
                else if (minusButtonClicked == true)
                {
                    total2 = total1 - double.Parse(txtDisplay.Text);
                }
                else if (divideButtonClicked == true)
                {
                    total2 = total1 / double.Parse(txtDisplay.Text);
                }
                else if (multiplyButtonClicked == true)
                {
                    total2 = total1 * double.Parse(txtDisplay.Text);
                }

                displayTotal(total2);

                total1 = 0;
        }

        /*
         * The displayTotal method is generic text box display method,
         * with conditional if's implemented in order to append a negative
         * symbol to the total displayed.
         */

        private void displayTotal(double total)
        {
            if(total2 < 0)
            {
                txtDisplay.Text = "-" + total.ToString();
            }
            else
            {
                txtDisplay.Text = total.ToString();
            }
        }



        /*
         * The btnSqr method parses the number in the text box before either executing the operation
         * or presenting an error message if the user has entered a none positive integer.
         */
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if (num >= 0)
            {
                txtDisplay.Text = Math.Sqrt(num).ToString();
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }


        /*
         * The cubeRT method parses the number in the text box before either executing the operation
         * or presenting an error message if the user has entered a none positive integer.
         */
        private void btnCubeRT_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if (num >= 0)
            {
                txtDisplay.Text = Math.Pow(num, 1/3.0).ToString();
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }



        /*
         *The inverse method parses the textbox as a double before excecuting
         * the inverse operation
         */
        private void btnInverse_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);

            txtDisplay.Text = Math.Pow(num, -1.0).ToString();
        }


        /*
         *The tane method parses the textbox as a double before validating the input with
         * a conditional if that checks for Tan(90) which causes a divide by zero error.
         */
        private void btnTan_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if(num != 90)
            {
                txtDisplay.Text = Math.Tan(num).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input", "Error Message");
                txtDisplay.Text = "0";
            }
        }


        /*
         * The Cos method parses the textbox as a double before executing Cos(num) 
         */
        private void btnCos_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(num).ToString();
        }

        /*
       * The Sin method parses the textbox as a double before executing Sin(num) 
       */
        private void btnSin_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(num).ToString();
        }

        
    }
}
