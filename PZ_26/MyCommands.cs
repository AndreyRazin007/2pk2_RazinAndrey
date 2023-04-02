using System.Windows.Input;

namespace PZ_26
{
    public static class MyCommands
    {
        public static readonly RoutedUICommand Exit = new
        (
            "Exit",
            "Exit",
            typeof(MainWindow),
            new InputGestureCollection()
            {
                new KeyGesture(Key.F4, ModifierKeys.Alt)
            }
        );
    }
}
