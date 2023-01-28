using System;

namespace PZ_21
{
    class Subject
    {
        private string title = "Undefined";
        private double duration;
        private string control;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Control
        {
            get { return control; }
            set { control = value; }
        }

        public void PrintInfo()
        {
            Console.Write($"Название предмета: {Title}\n" +
                $"Продолжительность предмета в часах: {Duration}\n" +
                $"Итоговое оценивание предмета - экзамен или зачет: {control}");
        }

        public Subject()
        {

        }

        public Subject(string title)
        {
            Title = title;
        }

        public Subject(string title, double duration)
        {
            Title = title;
            Duration = duration;
        }

        public Subject(string title, double duration, string control)
        {
            Title = title;
            Duration = duration;
            Control = control;
        }

        public Subject(string title, string control)
        {
            title = "Math";
            Title = title;

            control = "Examination";
            Control = control;
        }
    }
}
