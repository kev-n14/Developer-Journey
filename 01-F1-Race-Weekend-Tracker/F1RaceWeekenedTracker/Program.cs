using System;
using static Race;

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
                Circuit = silverstone,
                //RaceType.Sprint,
                NumberOfLaps = 52

            };
            DisplayCircuitInfo(silverstone);



        }

        static void DisplayCircuitInfo(Circuit circuit)
        {
            Console.WriteLine($"Circuit ID: {circuit.CircuitId}");
            Console.WriteLine($"Circuit Name: {circuit.CircuitName}");
            Console.WriteLine($"City: {circuit.City}");
            Console.WriteLine($"Country: {circuit.Country}");
            Console.WriteLine($"Length of Track: {circuit.LengthOfTrack} km");
        }
    }
}