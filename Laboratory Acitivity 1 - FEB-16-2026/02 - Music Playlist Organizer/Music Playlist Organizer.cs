using System;

namespace Playlist
{
    class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }

        public Song(string title, string artist, double duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }

        public Song(string title, string artist) : this(title, artist, 0.0)
        {
        }

        public Song() : this("Unknown", "Unknown", 0.0)
        {
        }

        public void DisplaySong()
        {
            Console.WriteLine($"{Title,-20} {Artist,-20} {Duration:F2}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Songs to add: ");
            if (!int.TryParse(Console.ReadLine(), out int size))
            {
                size = 0;
            }

            Song[] playlist = new Song[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nSong #{i + 1}");
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Artist: ");
                string artist = Console.ReadLine();

                Console.Write("Duration (minutes): ");
                if (!double.TryParse(Console.ReadLine(), out double duration))
                {
                    duration = 0.0;
                }

                playlist[i] = new Song(title, artist, duration);
            }

            Console.WriteLine("\n=== PLAYLIST ==="); 
            Console.WriteLine($"{"Title",-20} {"Artist",-20} {"Time"}");
            Console.WriteLine(new string('-', 50));

            double totalDuration = 0;

            foreach (Song s in playlist)
            {
                s.DisplaySong();
                totalDuration += s.Duration;
            }

            double averageDuration = size > 0 ? totalDuration / size : 0;

            Console.WriteLine();
            Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
            Console.WriteLine($"Average Duration: {averageDuration:F2} mins");
        }
    }
}