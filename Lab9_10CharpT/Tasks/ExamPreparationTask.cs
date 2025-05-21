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
                    Console.WriteLine($"ϳ�������� �� ���: ���������� {daysLeft} ���");
                    Console.WriteLine("����������� �������� �� ������ ���������� ��������");
                    daysLeft--;
                }
                else
                {
                    Console.WriteLine("������ ���� ��������: ������ ������");
                    daysLeft = 5; // ������� ����, ��� ���� ����� �������
                }
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
