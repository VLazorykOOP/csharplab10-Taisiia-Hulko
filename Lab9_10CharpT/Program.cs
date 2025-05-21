using System;

namespace StudentLife
{
    internal class Program
    {
        static void Main()
        {
            var studentLife = new StudentLife();

            // Підписуємося на події (реакції)
            var dailyRoutine = new DailyRoutineTask();
            var examPrep = new ExamPreparationTask();
            var party = new PartyTask();

            studentLife.StudentEvent += dailyRoutine.HandleEvent;
            studentLife.StudentEvent += examPrep.HandleEvent;
            studentLife.StudentEvent += party.HandleEvent;

            studentLife.StartLife(7);  // Симулюємо 7 днів життя студента
        }
    }
}
