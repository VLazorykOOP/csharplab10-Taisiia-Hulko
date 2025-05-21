using System;

namespace StudentLife
{
    internal class DailyRoutineTask
    {
        public void HandleEvent(object sender, StudentEventArgs e)
        {
            if (e.EventName == "DailyRoutine")
            {
                Console.WriteLine("Прокидаємось о 7:30");
                Console.WriteLine("Ранкова кава та пара о 8:00");
                Console.WriteLine("Лекції, конспекти, нотатки");
                Console.WriteLine("Обід у їдальні");
                Console.WriteLine("Вечір: кодимо лабораторні у VS Code");
                Console.WriteLine("Засинаємо під подкаст");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
