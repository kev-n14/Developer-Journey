using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circuit silverstone = new Circuit 
            {
                //assign
                CircuitId = 1,
                CircuitName = "Silverstone",
                City = "Towcester",
                Country = "England",
                LengthOfTrack = 5.891

            };
            Race RoundOne = new Race
            {
                RoundNumber = 1,
                LengthOfTrack = silverstone.LengthOfTrack,
                RaceFormat = new string[] { "Sprint", "Main" },
                NumberOfLaps = 52

            };

            Console.WriteLine($"Round Number: {RoundOne.RoundNumber}");

            Console.WriteLine($"Circuit Name: {silverstone.CircuitName}");
            Console.WriteLine($"City: {silverstone.City}");
            Console.WriteLine($"Country: {silverstone.Country}");
            Console.WriteLine($"Track Length: {silverstone.LengthOfTrack}");

            Console.WriteLine($"Race Format: {RoundOne.RaceFormat[0]}");
            Console.WriteLine($"Number of Laps: {RoundOne.NumberOfLaps}");
            Console.ReadLine();
        }
    }
}