using System;
using static Race;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circuit australia = new Circuit 
            {
                //assign
                CircuitId = 1,
                CircuitName = "Albert Park",
                City = "Melbourne",
                Country = "Australia",
                LengthOfTrack = 5.303

            };
            Circuit china = new Circuit
            {
                CircuitId = 2,
                CircuitName = "Shanghai International Circuit",
                City = "Shanghai",
                Country = "China",
                LengthOfTrack = 5.451

            };
            Circuit greatBritain = new Circuit
            {
                CircuitId = 3,
                CircuitName = "Silverstone",
                City = "Towcester",
                Country = "Great Britain",
                LengthOfTrack = 5.891

            };

            List<Circuit> circuits = new List<Circuit>();
            List<Race> season = new List<Race>();

            Race roundOne = new Race
            {
                RoundNumber = 1,
                Circuit = australia,
                NumberOfLaps = 58,
                RaceDate = new DateTime(2026, 3, 8),
                raceType = RaceType.Main


            };
            Race roundTwo = new Race
            {
                RoundNumber = 2,
                Circuit = china,
                NumberOfLaps = 56,
                RaceDate = new DateTime(2026, 3, 15),
                raceType = RaceType.Sprint

            };
            Race roundThree = new Race
            {
                RoundNumber = 3,
                Circuit = greatBritain,
                NumberOfLaps = 52,
                RaceDate = new DateTime(2026, 7, 5),
                raceType = RaceType.Sprint

            };

            circuits.Add(australia);
            circuits.Add(china);
            circuits.Add(greatBritain);

            season.Add(roundOne);
            season.Add(roundTwo);
            season.Add(roundThree);
            
            Title();

            foreach (Race race in season) 
            {
                    DisplayCircuitInfo(race);
            }
        }

        static void DisplayCircuitInfo(Race race)
        {

            Console.WriteLine($"{race.Circuit.Country} Grand Prix");
            Console.WriteLine($"Circuit: {race.Circuit.CircuitName}");
            Console.WriteLine($"Country: {race.Circuit.Country}");
            Console.WriteLine($"Length: {race.Circuit.LengthOfTrack} km");
            Console.WriteLine($"Laps: {race.NumberOfLaps}");
            Console.WriteLine($"Race Format: {race.raceType}");
            Console.WriteLine("----------------------------------------\n");
        }
        
        static void Title() {
            Console.WriteLine("========= 2026 Formula One Calendar =========");
        
        }
    }
}