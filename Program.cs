using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKris
{
    public class Game
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public int YearProduced { get; set; }

        public Game(string name, double price, string genre, int yearProduced)
        {
            Name = name;
            Price = price;
            Genre = genre;
            YearProduced = yearProduced;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Genre: {Genre}, Year Produced: {YearProduced}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>()
            {
                new Game("Game1", 50, "FPS", 2020),
                new Game("Game2", 60, "ACTION", 2021),
                new Game("Game3", 45, "3D ACTION", 2022),
                new Game("Game4", 55, "RPG", 2023),
                new Game("Game5", 65, "FPS", 2024)
            };

            // Изведете всички игри в нисходящ ред според цената
            var sortedGames = games.OrderByDescending(g => g.Price);
            Console.WriteLine("Games sorted by price (descending):");
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game);
            }

            // Изведете всички игри, които с жанр „FPS“, “ACTION”, “3D ACTION”
            var gamesInSelectedGenres = games.Where(g => g.Genre == "FPS" || g.Genre == "ACTION" || g.Genre == "3D ACTION");
            Console.WriteLine("\nGames in FPS, ACTION, or 3D ACTION genres:");
            foreach (var game in gamesInSelectedGenres)
            {
                Console.WriteLine(game);
            }

            // Изведете тези игри, които струват между 45-60 долара
            var gamesInPriceRange = games.Where(g => g.Price >= 45 && g.Price <= 60);
            Console.WriteLine("\nGames priced between 45 and 60 dollars:");
            foreach (var game in gamesInPriceRange)
            {
                Console.WriteLine(game);
            }
        }
    }
}



