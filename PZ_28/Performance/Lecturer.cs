namespace Performance
{
    class Lecturer
    {
        public delegate void PrintMessage(string message);
        public event PrintMessage? MyEvent;

        public void Message(double number)
        {
            if (number <= 2.4)
            {
                MyEvent?.Invoke($"Ваша успеваемость: {number} критична!");
            }
            else
            {
                MyEvent?.Invoke($"Ваша успеваемость: {number} удовлетворительна!");
            }
        }
    }
}
