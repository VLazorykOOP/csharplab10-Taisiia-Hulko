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
                Console.WriteLine("ѕТ€тниц€: студентська веч≥рка");
                foreach (var track in playlist)
                {
                    Console.WriteLine($"√раЇ трек: {track}");
                }
                Console.WriteLine("“анц≥ до ранку, а пот≥м новий навчальний день");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
