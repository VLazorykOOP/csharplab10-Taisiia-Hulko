using System;

namespace StudentLife
{
    internal class PartyTask
    {
        private string[] playlist = { "Bur man laimi", "Peacefield", "Satanized", "Ashamed" };

        public void HandleEvent(object sender, StudentEventArgs e)
        {
            if (e.EventName == "Party")
            {
                Console.WriteLine("ϒ������: ����������� �������");
                foreach (var track in playlist)
                {
                    Console.WriteLine($"��� ����: {track}");
                }
                Console.WriteLine("����� �� �����, � ���� ����� ���������� ����");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
