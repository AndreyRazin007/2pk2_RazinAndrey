using System.IO.Enumeration;
using System.Windows;
using System.Windows.Controls;

namespace PZ_26
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewFileMenuItemClick(object sender, RoutedEventArgs e)
        {
            string name;
            CreateFileWindow createFileWindow = new();
            if (createFileWindow.ShowDialog() == true)
                name = createFileWindow.FileName;
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateCursorPosition()
        {

        }

        private void textField_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
        }

        private void textField_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
    }
}
