using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Patryk Gulik
 * 11002010
 * Class: RPN
 * Manages UI and user interactions
 * Instantiates objects and calls methods
 */

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
            try
            {
                //stack = new ArrayStack<double>(10);
                stack = new LinkedListStack<double>();
                calculator = new PolishNotationCalculator(stack);

                string input = Txt_Input.Text;
                Lbl_Output.Text = calculator.Evaluate(input).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid: " + ex.Message);
            }
            
        }
    }
}
