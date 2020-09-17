using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] data = Console.ReadLine().Split('_').ToArray();

               string type = data[0];
               string name = data[1];
               string time = data[2];

                Song currentSong = new Song();
                currentSong.Typelist = type;
                currentSong.Name = name;
                currentSong.Time = time;

                songs.Add(currentSong);

            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
            else
            {
                foreach (Song currentSong in songs)
                {
                    if (typeList == currentSong.Typelist)
                    {
                        Console.WriteLine(currentSong.Name);
                    }
                }
                
            }
            
        }
    }
    class Song
    {
        public string Typelist { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
