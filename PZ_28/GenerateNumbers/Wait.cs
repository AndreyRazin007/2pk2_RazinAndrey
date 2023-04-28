namespace PZ_28
{
    class Wait
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Wait(int number)
        {
            _number = number;
        }

        public delegate void PrintMessage(string message);
        public event PrintMessage? MyEvent;

        public void Message(int number) => MyEvent?.Invoke($"Число {number}");
    }
}
