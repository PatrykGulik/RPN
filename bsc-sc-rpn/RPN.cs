using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsc_sc_rpn
{
    public partial class RPN : Form
    {
        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public RPN()
        {
            InitializeComponent();
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            // Read and Parse Expression here... 
            stack = new ArrayStack<double>(10);

            calculator = new PolishNotationCalculator(stack);


            string input = Txt_Input.Text;

            Lbl_Output.Text = calculator.Evaluate(input).ToString();
        }
    }
}
