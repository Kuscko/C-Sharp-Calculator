using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Calculator
{
    public partial class frmCalculator : Form
    {

        Double solution;
        Double valueHolder;
        String operator_selected;
        bool op = false;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnClick_Numbers(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(tboEntry.Text == "0" || op)
                tboEntry.Clear();
            op = false;
            switch (button.Text)
            {
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

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.Text == ".")
            {
                if (!tboEntry.Text.Contains("."))
                    tboEntry.Text += button.Text;
            }
        }

        private void btnClick_Opperators(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(tboEntry.Text != "0")
            {
                operator_selected = button.Text;
                btnReturn.PerformClick();
                tboEntry.Clear();
                op = true;
            }
            else
            {
                solution = Double.Parse(tboEntry.Text);
                operator_selected = button.Text;
                op = true;
            }
        }

        private void btnClick_Return(object sender, EventArgs e)
        {
            switch (operator_selected)
            {
                case "+":
                    tboEntry.Text = (solution + Double.Parse(tboEntry.Text)).ToString();
                    break;
                case "-":
                    tboEntry.Text = (solution - Double.Parse(tboEntry.Text)).ToString();
                    break;
                case "*":
                    tboEntry.Text = (solution * Double.Parse(tboEntry.Text)).ToString();
                    break;
                case "/":
                    tboEntry.Text = (solution / Double.Parse(tboEntry.Text)).ToString();
                    break;
                default:
                    break;
            }
            solution = Double.Parse(tboEntry.Text);
        }
    }
}
