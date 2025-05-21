using System;

namespace StudentLife
{
    public delegate void StudentEventHandler(object sender, StudentEventArgs e);

    public class StudentLife
    {
        public event StudentEventHandler StudentEvent;
        private Random rnd = new Random();

        private string[] events = { "DailyRoutine", "ExamPrep", "Party" };

        public void StartLife(int days)
        {
            for (int day = 1; day <= days; day++)
            {
                Console.WriteLine($"\n--- Δενό {day} ---");
                string currentEvent = events[rnd.Next(events.Length)];
                StudentEventArgs args = new StudentEventArgs(currentEvent, day);
                OnStudentEvent(args);
            }
        }

        protected virtual void OnStudentEvent(StudentEventArgs e)
        {
            if (StudentEvent != null)
            {
                foreach (StudentEventHandler handler in StudentEvent.GetInvocationList())
                {
                    handler(this, e);
                }
            }
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
