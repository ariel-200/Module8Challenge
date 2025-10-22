namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of at least 5 Video Games
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "The Sims 4", Genre = "RPG", Rating = 4.35 });
            games.Add(new VideoGame { Name = "Mario Kart 8", Genre = "Racing", Rating = 4.4 });
            games.Add(new VideoGame { Name = "Animal Crossing New Horizons", Genre = "Simulator", Rating = 4.5 });
            games.Add(new VideoGame { Name = "Nintendo Switch Sports", Genre = "Simulator", Rating = 3.5 });
            games.Add(new VideoGame { Name = "Just Dance 4", Genre = "Dance", Rating = 3.6 });

            // Query to find games with rating higher than 4
            var topRated = (from game in games where game.Rating >= 4 select game).ToList();

            // Sort the top rated games list by name
            var sortedGames = (from game in topRated orderby game.Name select game).ToList();

            // Use a loop to print out the names of the games
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }

        }
    }
}