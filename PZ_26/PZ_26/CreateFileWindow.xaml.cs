using System.Windows;

namespace PZ_26
{
    public partial class CreateFileWindow : Window
    {
        public CreateFileWindow()
        {
            InitializeComponent();
        }

        private void AcceptClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        public string FileName
        {
            get { return FileNameBox.Text; }
        }
    }
}
