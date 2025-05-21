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
                    Console.WriteLine($"ϳ�������� �� ���: ���������� {daysLeft} ���");
                    Console.WriteLine("����������� �������� �� ������ ���������� ��������");
                    daysLeft--;
                }
                else
                {
                    Console.WriteLine("������ ���� ��������: ������ ������");
                    daysLeft = DefaultDays; // �������� ����� ���� ���������
                }

                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
