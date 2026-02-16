/*
 * Patryk Gulik
 * 11002010
 * Class: PolishNotationCalculator
 * Handles Stack and calculates the result
 */

namespace bsc_sc_rpn
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;
       
        // Constructor
        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        // Processes the stack and calculates the result
        public double Evaluate(string expression)
        {

            // Splits the expression using space as delimiter 
            string[] parts = expression.Split(' ');

            // Checks each element in the array
            foreach (string part in parts)
            {
                // If element is a number, its pushed into the stack
                if (double.TryParse(part, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    // If not a number, last two numbers are popped
                    double[] doubles = new double[2];   
                    
                    for (int i = 0; i < 2; i++)
                    {
                        doubles[i] = stack.Pop();
                    }

                    // Operation is performed and result pushed back into the stack
                    switch (part)
                    {
                        case "+":
                            stack.Push(doubles[1] + doubles[0]);
                            break;

                        case "-":
                            stack.Push(doubles[1] - doubles[0]);
                            break;

                        case "*":
                            stack.Push(doubles[1] * doubles[0]);
                            break;

                        case "/":
                            stack.Push(doubles[1] / doubles[0]);
                            break;

                        default:
                            throw new System.InvalidOperationException("Unknown operator "+part);
                    }
                }
            }
            // Final result is returned
            return stack.Peek();
        }
    }
}