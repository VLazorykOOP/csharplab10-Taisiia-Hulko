using System;

namespace StudentLife
{
    internal class DailyRoutineTask
    {
        public void HandleEvent(object sender, StudentEventArgs e)
        {
            if (e.EventName == "DailyRoutine")
            {
                Console.WriteLine("����������� � 7:30");
                Console.WriteLine("������� ���� �� ���� � 8:00");
                Console.WriteLine("������, ���������, �������");
                Console.WriteLine("��� � ������");
                Console.WriteLine("�����: ������ ���������� � VS Code");
                Console.WriteLine("�������� �� �������");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
