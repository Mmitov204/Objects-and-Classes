namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] songComponents = Console.ReadLine().Split("_");
                string typeSet = songComponents[0];
                string songName = songComponents[1];
                string songTime = songComponents[2];

                Song currentSong = new Song
                {
                    name = songName,
                    TypeSet = typeSet,
                    time = songTime,
                };

                songs.Add(currentSong);
            }
            string commandType = Console.ReadLine();
            if (commandType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.name);
                }
            }
            else
            {
                List<Song> FilterSong = songs.Where(x => x.TypeSet == commandType).ToList();
                foreach (Song song in FilterSong)
                {
                    Console.WriteLine(song.name);
                }
            }

        }
    }

    public class Song
    {
        public string name { get; set; }
        public string time { get; set; }
        public string TypeSet { get; set; }
    }
}

