using System;

namespace StudentLife
{
    public delegate void StudentEventHandler(object sender, StudentEventArgs e);

    public class StudentLife
    {
        public event StudentEventHandler StudentEvent;

        private readonly Random rnd = new Random();
        private readonly string[] events = { "DailyRoutine", "ExamPrep", "Party" };

        public void StartLife(int days)
        {
            for (int day = 1; day <= days; day++)
            {
                Console.WriteLine($"\n--- День {day} ---");

                // Випадкова подія дня
                string currentEvent = events[rnd.Next(events.Length)];

                // Створюємо аргументи події
                var args = new StudentEventArgs(currentEvent, day);

                // Відправляємо всім підписаним обробникам
                OnStudentEvent(args);
            }
        }

        protected virtual void OnStudentEvent(StudentEventArgs e)
        {
            StudentEvent?.Invoke(this, e);
        }
    }

    public class StudentEventArgs : EventArgs
    {
        public string EventName { get; }
        public int Day { get; }

        public StudentEventArgs(string eventName, int day)
        {
            EventName = eventName;
            Day = day;
        }
    }
}
