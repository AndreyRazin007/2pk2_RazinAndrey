using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace PZ_25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Press0Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "0";
        }

        private void Press1Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "1";
        }

        private void Press2Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "2";
        }

        private void Press3Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "3";
        }

        private void Press4Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "4";
        }

        private void Press5Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "5";
        }

        private void Press6Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "6";
        }

        private void Press7Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "7";
        }

        private void Press8Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "8";
        }

        private void Press9Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBlock.Text == "0")
                InputTextBlock.Text = InputTextBlock.Text.Remove(0);
            InputTextBlock.Text += "9";
        }

        private void PressPlusButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "+";
        }

        private void PressMinusButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text = "";
            InputTextBlock.Text += "-";
        }

        private void PressMultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "*";
        }

        private void PressSharingButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "/";
        }

        private void PressCEButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text = "0";
        }

        private void PressCButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text = InputTextBlock.Text
                .Remove(InputTextBlock.Text.Length - 1, 1);
        }

        private void PressRPow_2_Button_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;
            InputTextBlock.Text = Math.Pow(Calculation(expression), 2).ToString();
        }

        private void PressSqrtButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;
            InputTextBlock.Text = Math.Sqrt(Calculation(expression)).ToString();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;
            InputTextBlock.Text = Calculation(expression).ToString();
        }

        private double Calculation(string expression)
        {
            expression = InputTextBlock.Text;

            Regex regex = new(@"[^0-9]");
            MatchCollection matches = regex.Matches(expression);

            if (matches.Count == 0 || (matches.Count == 1 && expression[0] == '-'))
                return Convert.ToDouble(expression);

            else if (matches.Count == 1 || matches.Count == 2)
            {
                if (matches.Count == 1)
                {
                    double firstOperand = Convert.ToDouble(expression[..matches[0].Index]);
                    double secondOperand = Convert.ToDouble(expression[(matches[0].Index + 1)..]);

                    return matches[0].ToString() switch
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
                    double firstOperand = Convert.ToDouble(expression[matches[0].Index..matches[1].Index]);
                    double secondOperand = Convert.ToDouble(expression[(matches[1].Index + 1)..]);

                    return matches[1].ToString() switch
                    {
                        "+" => firstOperand + secondOperand,
                        "-" => firstOperand - secondOperand,
                        "*" => firstOperand * secondOperand,
                        "/" => firstOperand / secondOperand,
                        _ => 0,
                    };
                }
            }

            else if (matches.Count == 2 || matches.Count == 3)
            {
                if (matches.Count == 2)
                {
                    double firstOperand = Convert.ToDouble(expression[..matches[0].Index]);
                    double secondOperand = Convert.ToDouble(expression[(matches[0].Index + 1)..matches[1].Index]);
                    double thirdOperand = Convert.ToDouble(expression[(matches[1].Index + 1)..]);
                    double firstOperation = 0;

                    switch (matches[0].ToString())
                    {
                        case "+": firstOperation = firstOperand + secondOperand; break;
                        case "-": firstOperation = firstOperand - secondOperand; break;
                        case "*": firstOperation = firstOperand * secondOperand; break;
                        case "/": firstOperation = firstOperand / secondOperand; break;
                    }

                    if (matches[1].ToString() == "*")
                    {
                        switch (matches[0].ToString())
                        {
                            case "+": return thirdOperand * secondOperand + firstOperand;
                            case "-": return thirdOperand * secondOperand - firstOperand;
                        }
                    }
                    else if (matches[1].ToString() == "/")
                    {
                        switch (matches[0].ToString())
                        {
                            case "+": return thirdOperand / secondOperand + firstOperand;
                            case "-": return thirdOperand / secondOperand - firstOperand;
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
                else
                {
                    double firstOperand = Convert.ToDouble(expression[matches[0].Index..matches[1].Index]);
                    double secondOperand = Convert.ToDouble(expression[(matches[1].Index + 1)..matches[2].Index]);
                    double thirdOperand = Convert.ToDouble(expression[(matches[2].Index + 1)..]);
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
                            case "+": return thirdOperand * secondOperand + firstOperand;
                            case "-": return thirdOperand * secondOperand - firstOperand;
                        }
                    }
                    else if (matches[2].ToString() == "/")
                    {
                        switch (matches[1].ToString())
                        {
                            case "+": return thirdOperand / secondOperand + firstOperand;
                            case "-": return thirdOperand / secondOperand - firstOperand;
                        }
                    }

                    return matches[2].ToString() switch
                    {
                        "+" => firstOperation + thirdOperand,
                        "-" => firstOperation - thirdOperand,
                        "*" => firstOperation * thirdOperand,
                        "/" => firstOperation / thirdOperand,
                        _ => 0,
                    };
                }
            }

            else return 0;
        }
    }
}
