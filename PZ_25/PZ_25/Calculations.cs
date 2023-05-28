using System.Text.RegularExpressions;
using System;

namespace PZ_25
{
    class Calculations
    {
        public static double SingleSignOperation(ref MatchCollection matches,
            ref string expression)
        {
            double firstOperand = Convert
                .ToDouble(expression[..matches[0].Index]);
            double secondOperand = Convert
                .ToDouble(expression[(matches[0].Index + 1)..]);

            return matches[0].ToString() switch
            {
                "+" => firstOperand + secondOperand,
                "-" => firstOperand - secondOperand,
                "*" => firstOperand * secondOperand,
                "/" => firstOperand / secondOperand,
                _ => 0,
            };
        }

        public static double OperationTwoSigns(ref MatchCollection matches,
            ref string expression)
        {
            if (matches[0].ToString() == "-" && matches[1].ToString() != "-"
                && expression[0] != '0')
            {
                double firstOperand = Convert
                    .ToDouble(expression[..matches[1].Index]);
                double secondOperand = Convert
                    .ToDouble(expression[(matches[1].Index + 1)..]);

                return matches[1].ToString() switch
                {
                    "+" => firstOperand + secondOperand,
                    "-" => firstOperand - secondOperand,
                    "*" => firstOperand * secondOperand,
                    "/" => firstOperand / secondOperand,
                    _ => 0,
                };
            }

            else
            {
                double firstOperand = Convert
                    .ToDouble(expression[..matches[0].Index]);
                double secondOperand = Convert
                    .ToDouble(expression[(matches[0].Index + 1)..matches[1].Index]);
                double thirdOperand = Convert
                    .ToDouble(expression[(matches[1].Index + 1)..]);

                double firstOperation = 0;

                switch (matches[0].ToString())
                {
                    case "+":
                        firstOperation = firstOperand
                            + secondOperand; break;
                    case "-":
                        firstOperation = firstOperand
                            - secondOperand; break;
                    case "*":
                        firstOperation = firstOperand
                            * secondOperand; break;
                    case "/":
                        firstOperation = firstOperand
                            / secondOperand; break;
                }

                if (matches[1].ToString() == "*")
                {
                    switch (matches[0].ToString())
                    {
                        case "+":
                            return firstOperand + secondOperand
                                * thirdOperand;
                        case "-":
                            return firstOperand - secondOperand
                                * thirdOperand;
                    }
                }

                else if (matches[1].ToString() == "/")
                {
                    switch (matches[0].ToString())
                    {
                        case "+":
                            return firstOperand + secondOperand
                                / thirdOperand;
                        case "-":
                            return firstOperand - secondOperand
                                / thirdOperand;
                    }
                }

                return matches[1].ToString() switch
                {
                    "+" => firstOperation + thirdOperand,
                    "-" => firstOperation - thirdOperand,
                    "*" => firstOperation * thirdOperand,
                    "/" => firstOperation / thirdOperand,
                    _ => 0,
                };
            }
        }

        public static double OperationThreeSigns(ref MatchCollection matches,
            ref string expression)
        {
            double firstOperand = Convert
                .ToDouble(expression[..matches[1].Index]);
            double secondOperand = Convert
                .ToDouble(expression[(matches[1].Index + 1)..matches[2].Index]);
            double thirdOperand = Convert
                .ToDouble(expression[(matches[2].Index + 1)..]);

            double firstOperation = 0;

            switch (matches[1].ToString())
            {
                case "+": firstOperation = firstOperand + secondOperand; break;
                case "-": firstOperation = firstOperand - secondOperand; break;
                case "*": firstOperation = firstOperand * secondOperand; break;
                case "/": firstOperation = firstOperand / secondOperand; break;
            }

            if (matches[2].ToString() == "*")
            {
                switch (matches[1].ToString())
                {
                    case "+":
                        return firstOperand + secondOperand
                            * thirdOperand;
                    case "-":
                        return firstOperand - secondOperand
                            * thirdOperand;
                }
            }

            else if (matches[2].ToString() == "/")
            {
                switch (matches[1].ToString())
                {
                    case "+":
                        return firstOperand + secondOperand
                            / thirdOperand;
                    case "-":
                        return firstOperand - secondOperand
                            / thirdOperand;
                }
            }

            return matches[1].ToString() switch
            {
                "+" => firstOperation + thirdOperand,
                "-" => firstOperation - thirdOperand,
                "*" => firstOperation * thirdOperand,
                "/" => firstOperation / thirdOperand,
                _ => 0,
            };
        }
    }
}
