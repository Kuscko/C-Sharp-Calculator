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
        string valueHolder;
        String operator_selected;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnClick_Numbers(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(tboEntry.Text == "0")
                tboEntry.Clear();
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

        }
    }
}
