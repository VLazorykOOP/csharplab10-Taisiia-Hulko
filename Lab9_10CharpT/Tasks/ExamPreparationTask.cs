using System;

namespace StudentLife
{
    internal class ExamPreparationTask
    {
        private int daysLeft;
        private const int DefaultDays = 5;

        public ExamPreparationTask()
        {
            daysLeft = DefaultDays;
        }

        public void HandleEvent(object sender, StudentEventArgs e)
        {
            if (e != null && string.Equals(e.EventName, "ExamPrep", StringComparison.OrdinalIgnoreCase))
            {
                if (daysLeft > 0)
                {
                    Console.WriteLine($"Підготовка до сесії: залишилося {daysLeft} днів");
                    Console.WriteLine("Опрацьовуємо конспект та робимо повторення матеріалу");
                    daysLeft--;
                }
                else
                {
                    Console.WriteLine("Настав день екзамену: пишемо роботу");
                    daysLeft = DefaultDays; // Починаємо новий цикл підготовки
                }

                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
