/* Calculator Widget by Kevin Pan
 * Date: February 14 2018
 * 
 * Function:
 * A calulator to help you evaluate basic mathematic expressions
 * 
 * Key Features:
 * Standard and Scientific Calculator modes that can be switched the options menu
 * history label which displays number and operation
 * Clear entry, clear all and backspace
 * See more in Scientific.cs
 * 
 * Challenges:
 * Learning to switch between forms
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
    public partial class Standard : Form
    {

        Thread thread;
        Double result = 0;
        String operation = "";
        bool isOpertationClicked = false;
        bool toClear = false;

        public Standard()
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
            switch (operation) // four cases: add, subctract, mutiply and divide 
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
                default:
                    break;
            }
            operation = ""; // reset operation to null
            if (((Button)sender).Text == "=") // if equal button was pressed, the next number clears the display
                toClear = true;
        }

        private void clearEntry(object sender, EventArgs e) // clears the current display number 
        {
            display_textBox.Text = "";
        }

        private void clearAll(object sender, EventArgs e) // clears previous number,display number and current operation 
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
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            this.Close();
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA); //change apartment threading from MTA to STA
            thread.Start();
        }

        private void openForm(object sender) // open the new form
        {
            Application.Run(new Scientific()); // scientific calculator 
        }
    }
}
