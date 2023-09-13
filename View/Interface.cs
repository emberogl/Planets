using Planets.Model;

namespace Planets.View
{
    internal class Interface
    {
        public static void OutputPlanetList()
        {
            foreach (Planet planet in PlanetList.planetList)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Name: {planet.Name}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Mass: {planet.Mass}");
                Console.WriteLine($"Diameter: {planet.Diameter}");
                Console.WriteLine($"Density: {planet.Density}");
                Console.WriteLine($"Gravity: {planet.Gravity}");
                Console.WriteLine($"Rotation Period: {planet.RotationPeriod}");
                Console.WriteLine($"Length of Day: {planet.LengthOfDay}");
                Console.WriteLine($"Distance from Sun: {planet.DistanceFromSun}");
                Console.WriteLine($"Orbital Period: {planet.OrbitalPeriod}");
                Console.WriteLine($"Orbital Velocity: {planet.OrbitalVelocity}");
                Console.WriteLine($"Mean Temperature: {planet.MeanTemperature}");
                Console.WriteLine($"Number of Moons: {planet.NumberOfMoons}");
                Console.WriteLine($"Ring System: {planet.RingSystem}");
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void OutputPlanetListCount()
        {
            Console.WriteLine("Planets: " + PlanetList.planetList.Count());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
