using System;
using System.Windows.Forms;

namespace C_Sharp_Calculator
{
    public partial class frmCalculator : Form
    {

        private Double solution = 0;
        private String operator_selection;
        private bool operator_selected = false;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            /*
             * If the value in the textbox is 0, or the operator is selected then we clear the box.
             * This is to reset the text box after an operator was selected.
             */

            if (tboEntry.Text == "0" || operator_selected)
                tboEntry.Clear();
            operator_selected = false; // sets to false as not to reset the text box while tying the next value.
        }
        

        private void btnClick_Numbers(object sender, EventArgs e)
        {
            Button button = sender as Button;

            clearTextBox();

            // appends int values to the tboEntry textbox.
            switch (button.Text)
            {
                case ".": // checks to see if the program has only one decimal and enters it.
                    if (!tboEntry.Text.Contains("."))
                        tboEntry.Text += ".";
                    break;
                case "0":
                    tboEntry.Text += button.Text;
                    break;
                case "1":
                    tboEntry.Text += button.Text;
                    break;
                case "2":
                    tboEntry.Text += button.Text;
                    break;
                case "3":
                    tboEntry.Text += button.Text;
                    break;
                case "4":
                    tboEntry.Text += button.Text;
                    break;
                case "5":
                    tboEntry.Text += button.Text;
                    break;
                case "6":
                    tboEntry.Text += button.Text;
                    break;
                case "7":
                    tboEntry.Text += button.Text;
                    break;
                case "8":
                    tboEntry.Text += button.Text;
                    break;
                case "9":
                    tboEntry.Text += button.Text;
                    break;
            }
        }

        private void btnClick_SelectOperators(object sender, EventArgs e)
        {
            /*
             * Selects operators and does the calculations when an operator button is clicked.
             */

            Button button = sender as Button;
            if(tboEntry.Text != "0")
            {
                btnReturn.PerformClick(); 
                operator_selection = button.Text;
                operator_selected = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
            /*
             * Determine the result of the solution using a switch-case condition against the operator selection of /, *, -, +.
             */
        {
            switch (operator_selection)
            {
                case "+":
                    // takes the solution = 0, and adds a double data type value from the tboEntry text box, then assign that result to the textbox.
                    tboEntry.Text = (solution + Double.Parse(tboEntry.Text)).ToString();
                    break;
                case "-":
                    tboEntry.Text = (solution - Double.Parse(tboEntry.Text)).ToString();
                    break;
                case "/":
                    tboEntry.Text = (solution / Double.Parse(tboEntry.Text)).ToString();
                    break;
                case "*":
                    tboEntry.Text = (solution * Double.Parse(tboEntry.Text)).ToString();
                    break;
            }
            solution = Double.Parse(tboEntry.Text);
            operator_selection = ""; // prevents using another operator when selecting another. IE, not multiplying 10+2 after multiplying 5*2
        }

        // Clear variables and the text box.
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboEntry.Text = "0";
            operator_selection = "";
            solution = 0;
            operator_selected = false;
        }
    }
}

