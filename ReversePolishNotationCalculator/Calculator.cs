using System.Collections.Generic;

namespace ReversePolishNotationCalculator {
    public static class Calculator {
        public static double Calculate(params string[] inputs) {
            var stack = new Stack<double>();
            foreach (var input in inputs) {
                if (double.TryParse(input, out double value)) {
                    stack.Push(value);
                } else if (input == "+") {
                    stack.Push(stack.Pop() + stack.Pop());
                } else if (input == "-") {
                    var number2 = stack.Pop();
                    var number1 = stack.Pop();
                    stack.Push(number1 - number2);
                } else if (input == "*") {
                    stack.Push(stack.Pop() * stack.Pop());
                } else if (input == "/") {
                    var divider = stack.Pop();
                    var number = stack.Pop();
                    stack.Push(number / divider);
                }
            }
            return stack.Peek();
        }
    }
}
