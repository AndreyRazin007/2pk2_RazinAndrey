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
            if (InputTextBlock.Text != "")
            {
                InputTextBlock.Text = InputTextBlock.Text
                    .Remove(InputTextBlock.Text.Length - 1, 1);
            }
        }

        private void PressRPow_2_Button_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;

            Regex regex = MyRegex();
            MatchCollection matches = regex.Matches(expression);

            if ((expression.Length == 2 && matches.Count == 0) 
                || (expression.Length > 2 && matches.Count > 0)
                || (expression.Length == 1 && matches.Count == 0)
                || (expression.Length > 2 && matches.Count == 0))
            {
                InputTextBlock.Text = Math.Pow(Calculation(ref expression), 2).ToString();
            }
        }

        private void PressSqrtButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;

            Regex regex = MyRegex();
            MatchCollection matches = regex.Matches(expression);

            if ((expression.Length == 2 && matches.Count == 0)
                || (expression.Length > 2 && matches.Count > 0)
                || (expression.Length == 1 && matches.Count == 0)
                || (expression.Length > 2 && matches.Count == 0))
            {
                InputTextBlock.Text = Math.Sqrt(Calculation(ref expression)).ToString();
            }
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = InputTextBlock.Text;
            InputTextBlock.Text = Calculation(ref expression).ToString();
        }

        private double Calculation(ref string expression)
        {
            expression = InputTextBlock.Text;

            Regex regex = MyRegex();
            MatchCollection matches = regex.Matches(expression);

            if (matches.Count == 0 || (matches.Count == 1 && expression[0] == '-'))
            {
                return Convert.ToDouble(expression);
            }

            else if (matches.Count == 1)
            {
                return Calculations.SingleSignOperation(ref matches, ref expression);
            }

            else if (matches.Count == 2)
            {
                return Calculations.OperationTwoSigns(ref matches, ref expression);
            }

            else if (matches.Count == 3)
            {
                return Calculations.OperationThreeSigns(ref matches, ref expression);
            }

            else return 0;
        }

        [GeneratedRegex("[^0-9]")]
        private static partial Regex MyRegex();
    }
}
