using System;

namespace Performance
{
    class Student
    {
        private readonly int _countScore;

        public double AveragePerformance
        {
            get;
            private set;
        }

        public Student(int number)
        {
            _countScore = number;
        }

        public void EnteringGrades()
        {
            Random random = new();

            for (int i = 0; i < _countScore; ++i)
            {
                int score = random.Next(0, 6);
                AveragePerformance += score;
            }

            AveragePerformance /= _countScore;
        }
    }
}
