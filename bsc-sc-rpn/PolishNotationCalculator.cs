namespace bsc_sc_rpn
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        public double Evaluate(string expression)
        {

            string[] parts = expression.Split(' ');


            foreach (string part in parts)
            {
                bool operand = !double.TryParse(part, out double number);

                if (operand)
                {
                    double[] doubles = new double[2];   

                    for (int i = 0; i < 2; i++)
                    {
                        doubles[i] = stack.Pop();
                    }

                    if (part == "+")
                    {
                        stack.Push(doubles[1] + doubles[0]);
                    }

                    if (part == "-")
                    {
                        stack.Push(doubles[1] - doubles[0]);
                    }

                    if (part == "*")
                    {
                        stack.Push(doubles[1] * doubles[0]);
                    }

                    if (part == "/")
                    {
                        stack.Push(doubles[1] / doubles[0]);
                    }
                }
                else if (!operand)
                {
                    stack.Push(number);
                }
            }

            return stack.Pop();
        }
    }
}

/*
 * 1. Split the expression into individual tokens using a space as the delimiter.
 * 2. Iterate over each token:
 *      - If the token is a number, push it onto the stack.
 *      - If the token is an operator (+, -, *, /):
 *          a. Pop two numbers from the stack (b first, then a).
 *          b. Perform the operation (a + b, a - b, etc.).
 *          c. Push the result back onto the stack.
 * 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
 *    Pop and return it as the final result.
 */