using System;

namespace StudentLife
{
    internal class ExamPreparationTask
    {
        private int daysLeft = 5;

        public void HandleEvent(object sender, StudentEventArgs e)
        {
            if (e.EventName == "ExamPrep")
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
                    daysLeft = 5; // Скидаємо цикл, щоб було більше динаміки
                }
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
