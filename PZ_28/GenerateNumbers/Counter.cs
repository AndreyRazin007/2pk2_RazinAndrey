namespace PZ_28
{
    class Counter
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public void GenerateNumber(int number)
        {
            for (int i = 1; i <= 1000; ++i)
            {
                _number += 1;

                if (i == number)
                {
                    break;
                }
            }
        }
    }
}
