using System;

namespace StudentLife
{
    internal class PartyTask
    {
        private readonly string[] playlist = { "Bur man laimi", "Peacefield", "Satanized", "Ashamed" };
        private int partyCount = 0;

        public void HandleEvent(object sender, StudentEventArgs e)
        {
            if (e != null && string.Equals(e.EventName, "Party", StringComparison.OrdinalIgnoreCase))
            {
                partyCount++;
                Console.WriteLine($"ϒ������ #{partyCount}: ����������� ������� ����������!");

                var random = new Random();
                var shuffledPlaylist = playlist.OrderBy(x => random.Next()).ToArray();
                foreach (var track in shuffledPlaylist)
                {
                    Console.WriteLine($"��� ����: {track}");
                }

                Console.WriteLine("����� �� �����, � ���� � �� ������, ����� ���������� ����");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
