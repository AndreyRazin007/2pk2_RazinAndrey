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

        private void Press9Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "9";
        }

        private void Press8Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "8";
        }

        private void Press5Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "5";
        }

        private void PressPlusButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "+";
        }

        private void Press7Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "7";
        }

        private void Press6Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "6";
        }

        private void Press4Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "4";
        }

        private void PressMinusButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "-";
        }

        private void Press1Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "1";
        }

        private void Press2Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "2";
        }

        private void Press3Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "3";
        }

        private void PressMultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "*";
        }

        private void Press0Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "0";
        }

        private void PressSharingButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBlock.Text += "/";
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;
            InputTextBlock.Text = Calculation(expression).ToString();
        }

        private double Calculation(string expression)
        {
            expression = InputTextBlock.Text;

            Regex regex = new Regex(@"[^0-9]");
            MatchCollection matches = regex.Matches(expression);

            double firstOperand = Convert.ToDouble(expression.Substring(0, expression.IndexOf(matches[0].ToString())));
            double secondOperand = Convert.ToDouble(expression
                .Substring(matches[0].Index + 1,
                expression.Length - matches[0].Index - 1));

            double result = 0;

            switch (matches[0].ToString())
            {
                case "+": result = firstOperand + secondOperand; break;
                case "-": result = firstOperand - secondOperand; break;
                case "*": result = firstOperand * secondOperand; break;
                case "/": result = firstOperand / secondOperand; break;
            }

            return result;
        }
    }
}
