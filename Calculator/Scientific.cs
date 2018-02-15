/* Calculator Widget by Kevin Pan
 * Date: February 14 2018
 * 
 * Key Features:
 * Arithmetic,trigonometric,exponential operations
 * Mathematical constants PI and E
 * 1 memory slot with memory operations
 * Pressing A or B button changes operations to their inverse form
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
    public partial class Scientific : Form
    {
        Thread thread;
        Double memory = 0;
        Double result = 0;
        String operation = "";
        bool isOpertationClicked = false;
        bool toClear = false;

        public Scientific()
        {
            InitializeComponent();
        }

        private void click_number(object sender, EventArgs e) // called when a number button or decimal button is clicked 
        {
            if (toClear) // clear the display after an operation is successful
            {
                toClear = false;
                display_textBox.Clear();
            }
            Button button = (Button)sender; // get the button object
            if (display_textBox.Text == "0" || isOpertationClicked) // clear display when the number is just 0
                display_textBox.Clear();
            if (display_textBox.Text == "-0" && button.Text == "0") // do not add more 0's after text "-0"
                return;
            if (button.Text == ".") // handle decimal cases 
            {
                if (display_textBox.Text.Contains(".")) // do not add another decimal if one already exists
                {
                    return;
                }
                else if (display_textBox.Text == "0" || display_textBox.Text == "") // pad decimal with 0 in front
                {
                    display_textBox.Text = "0";
                }
                else if (display_textBox.Text == "-") // pad decimal with 0 (negative case)
                {
                    display_textBox.Text = "-0";
                }

            }
            display_textBox.Text += button.Text; // concatinate button text to display text
            isOpertationClicked = false;
        }

        private void click_operation(object sender, EventArgs e) // called when a math operation button is clicked
        {
            Button button = (Button)sender; // get the button object 
            if (display_textBox.Text == "") // if the display is empty, stop 
                return;
            if (!isOpertationClicked && operation != "") // instead of pressing the equals button, user can use multiple operations in a row
                calculate(sender, e);
            operation = button.Text;
            result = Double.Parse(display_textBox.Text);
            history_label.Text = display_textBox.Text + " " + operation; // set the history on top of display
            isOpertationClicked = true;
        }

        private void calculate(object sender, EventArgs e) // method called whe equal sign is pressed or another operation is applied
        {
            history_label.Text = ""; // clear text on top of display
            if (display_textBox.Text == "") // if display number is empty, stop
                return;
            switch (operation) // five cases: add, subtract, mutiply, divide and exponent
            {
                case "+":
                    display_textBox.Text = (result + Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "-":
                    display_textBox.Text = (result - Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "*":
                    display_textBox.Text = (result * Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "/":
                    display_textBox.Text = (result / Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "^":
                    display_textBox.Text = (Math.Pow(result, Double.Parse(display_textBox.Text))).ToString();
                    break;
                default:
                    break;
            }
            operation = ""; // clear current operation
            if (((Button)sender).Text == "=") // if equal button was pressed, the next number clears the display
                toClear = true;
        }

        private void clearEntry(object sender, EventArgs e) // clears the current display number 
        {
            display_textBox.Text = "";
        }

        private void clearAll(object sender, EventArgs e) // clears previous number,display number,history and current operation 
        {
            result = 0; 
            display_textBox.Text = "";
            history_label.Text = "";
            operation = "";
        }

        private void changeSign(object sender, EventArgs e) // changes the display number from positive to negative and vice versa
        {
            if (display_textBox.Text.Contains("-")) // negative -> positive
            {
                display_textBox.Text = display_textBox.Text.TrimStart('-');
            }
            else // positive to negative 
            {
                display_textBox.Text = "-" + display_textBox.Text;
            }
        }

        private void deleteText(object sender, EventArgs e) // deletes the last character in the display is display is non-empty
        {
            if (display_textBox.Text != "")
                display_textBox.Text = display_textBox.Text.Substring(0, display_textBox.Text.Length - 1);
        }

        private void cycleColor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red;
        }

        private void resetColor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = default(Color);
            button.UseVisualStyleBackColor = true;
        }

        private void changeMode(object sender, EventArgs e) // closes current form and starts a new thread for the new calculator
        {
            this.Close();
            thread = new Thread(openForm); 
            thread.SetApartmentState(ApartmentState.STA);  //change apartment threading from MTA to STA
            thread.Start(); 
        }

        private void openForm(object sender) // open the new form
        {
            Application.Run(new Standard()); // standard calculator
        }

        private void click_constant(object sender, EventArgs e) // displays a constant, replacing display
        {
            Random random = new Random(); // random object
            String constant = ((Button)sender).Text;
            switch (constant) // 3 cases: pi,euler's number and a random number between 0.0 and 1.0
            {
                case "π":
                    display_textBox.Text = Math.PI.ToString();
                    break;
                case "e":
                    display_textBox.Text = Math.E.ToString();
                    break;
                case "Rnd":
                    display_textBox.Text = random.NextDouble().ToString(); // retrieve random number
                    break;
                default:
                    break;
            }
            isOpertationClicked = false; // reset operation
            toClear = true; // next number clears display
        }

        private void click_scientific(object sender, EventArgs e) // scientific operation is performed on display number if non-empty
        {
            if (display_textBox.Text == "") // return if empty
                return;
            String scientific = ((Button)sender).Text; // get button text
            toClear = true; 
            switch (scientific) // 7 operations: sqaure root, sine, cosine, tangent, logarithm, natural log and factorial
            {                   // 6 inverse operations: sqare, arcsine, arccosine, arctangent, 10^x and e^x
                case "√":
                    display_textBox.Text = Math.Sqrt(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "x²":
                    display_textBox.Text = Math.Pow(Double.Parse(display_textBox.Text), 2).ToString();
                    break;
                case "sin":
                    display_textBox.Text = Math.Sin(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "sin⁻¹":
                    display_textBox.Text = Math.Sinh(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "cos":
                    display_textBox.Text = Math.Cos(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "cos⁻¹":
                    display_textBox.Text = Math.Cosh(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "tan":
                    display_textBox.Text = Math.Tan(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "tan⁻¹":
                    display_textBox.Text = Math.Tanh(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "log":
                    display_textBox.Text = Math.Log10(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "10ˣ":
                    display_textBox.Text = Math.Pow(10,Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "ln":
                    display_textBox.Text = Math.Log(Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "eˣ":
                    display_textBox.Text = Math.Pow(Math.E,Double.Parse(display_textBox.Text)).ToString();
                    break;
                case "n!":
                    double input = Double.Parse(display_textBox.Text); 
                    if (input < 0 || input > 170) // input must be a non-negative integer and less than 170 or overflow
                    {
                        toClear = false; // will not clear display due to failing to perform operation
                        break;
                    }
                    double answer = 1; 
                    for (int i = 1; i <= (int)input; ++i) // get factorial in linear time
                    {
                        answer *= i;
                    }
                    display_textBox.Text = answer.ToString(); // set factorial
                    break;
                default:
                    break;
            }
        }

        private void memory_add(object sender, EventArgs e) // add the display number to the current memory
        {
            if (display_textBox.Text == "") // stop if empty
                return;
            memory += Double.Parse(display_textBox.Text);
            memory_label.Text = "M = " + memory; // display memory in memory_label
        }

        private void memory_recall(object sender, EventArgs e) // replace display with the current memory
        {
            display_textBox.Text = memory.ToString();
        }

        private void memory_clear(object sender, EventArgs e) // clear the current memory and memory_label
        {
            memory = 0;
            memory_label.Text = "";
        }

        private void toggle_operation(object sender, EventArgs s) //switch to inverse operations
        {
            Button button = (Button)sender;
            if (button.Text =="A") // change all button texts to their inverse form
            {
                sine_button.Text = "sin⁻¹";
                cosine_button.Text = "cos⁻¹";
                tangent_button.Text = "tan⁻¹";
                log_button.Text = "10ˣ";
                naturalLog_button.Text = "eˣ";
                squareRoot_button.Text = "x²";
                button.Text = "B"; // change button Text
            }
            else // change all button texts to their inverse form
            {
                sine_button.Text = "sin";
                cosine_button.Text = "cos";
                tangent_button.Text = "tan";
                log_button.Text = "log";
                naturalLog_button.Text = "ln";
                squareRoot_button.Text = "√";
                button.Text = "A"; // change button Text
            }
        }
    }
}
