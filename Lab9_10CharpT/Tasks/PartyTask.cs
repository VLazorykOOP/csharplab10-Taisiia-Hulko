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
                Console.WriteLine($"ѕТ€тниц€ #{partyCount}: студентська веч≥рка починаЇтьс€!");

                var random = new Random();
                var shuffledPlaylist = playlist.OrderBy(x => random.Next()).ToArray();
                foreach (var track in shuffledPlaylist)
                {
                    Console.WriteLine($"√раЇ трек: {track}");
                }

                Console.WriteLine("“анц≥ до ранку, а пот≥м Ч €к завжди, новий навчальний день");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
