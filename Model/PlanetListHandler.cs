namespace Planets.Model
{
    internal class PlanetList
    {
        // Saving planets to a dictionary for convenient retrieval.
        public static Dictionary<string, Planet> planetObjects = new()
        {
            {"Mercury", new Planet(name: "Mercury", mass: 0.333, diameter: 4879, density: 5427, gravity: 3.7, rotationPeriod: 1407.6, lengthOfDay: 4222.6, distanceFromSun: 57.9, orbitalPeriod: 88.0, orbitalVelocity: 47.4, meanTemperature: 167, numberOfMoons: 0, ringSystem: false) },
            {"Venus", new Planet(name: "Venus", mass: 4.87, diameter: 12104, density: 5243, gravity: 8.9, rotationPeriod: -5832.5, lengthOfDay: 2802.0, distanceFromSun: 108.2, orbitalPeriod: 224.7, orbitalVelocity: 35.0, meanTemperature: 464, numberOfMoons: 0, ringSystem: false) },
            {"Earth", new Planet(name: "Earth", mass: 5.97, diameter: 12756, density: 5514, gravity: 9.8, rotationPeriod: 23.9, lengthOfDay: 24, distanceFromSun: 149.6, orbitalPeriod: 365.2, orbitalVelocity: 365.2, meanTemperature: 15, numberOfMoons: 1, ringSystem: false) },
            {"Mars", new Planet(name: "Mars", mass: 0.642, diameter: 6792, density: 3933, gravity: 3.7, rotationPeriod: 24.6, lengthOfDay: 24.7, distanceFromSun: 227.9, orbitalPeriod: 678.0, orbitalVelocity: 24.1, meanTemperature: -65, numberOfMoons: 2, ringSystem: false) },
            {"Jupiter", new Planet(name: "Jupiter", mass: 1898, diameter: 142984, density: 1326, gravity: 23.1, rotationPeriod: 9.9, lengthOfDay: 9.9, distanceFromSun: 778.6, orbitalPeriod: 4331, orbitalVelocity: 13.1, meanTemperature: -110, numberOfMoons: 67, ringSystem: true) },
            {"Saturn", new Planet(name: "Saturn", mass: 568, diameter: 120536, density: 687, gravity: 9.0, rotationPeriod: 10.7, lengthOfDay: 10.7, distanceFromSun: 1433.5, orbitalPeriod: 10747, orbitalVelocity: 9.7, meanTemperature: -140, numberOfMoons: 62, ringSystem: true) },
            {"Uranus", new Planet(name: "Uranus", mass: 86.8, diameter: 51118, density: 1271, gravity: 8.7, rotationPeriod: -17.2, lengthOfDay: 17.2, distanceFromSun: 2872.5, orbitalPeriod: 30589, orbitalVelocity: 6.7, meanTemperature: -195, numberOfMoons: 27, ringSystem: true) },
            {"Neptune", new Planet(name: "Neptune", mass: 102, diameter: 49528, density: 1638, gravity: 11.0, rotationPeriod: 16.1, lengthOfDay: 16.1, distanceFromSun: 4495.1, orbitalPeriod: 59.8, orbitalVelocity: 5.4, meanTemperature: -200, numberOfMoons: 14, ringSystem: true) },
            {"Pluto", new Planet(name: "Pluto", mass: 0.0146, diameter: 2370, density: 2095, gravity: 0.7, rotationPeriod: -153.3, lengthOfDay: 153.3, distanceFromSun: 5906.4, orbitalPeriod: 90.56, orbitalVelocity: 4.7, meanTemperature: -225, numberOfMoons: 5, ringSystem: false) }
        };
        // The active list where all interaction will happen.
        public static List<Planet> planetList = new List<Planet>();
        // Loads all planets into list except for Venus (necessary for the assignment). 
        public static void InitializePlanets()
        {
            foreach (KeyValuePair<string, Planet> planet in planetObjects)
            {
                if (planet.Key != "Venus")
                {
                    planetList.Add(planet.Value);
                }
            }
        }
        // LINQ query to get all planets with a mean temperature under 0.
        public static void InitializePlanetsWithMeanUnderzero()
        {
            var planetsWithMeanUnderzero = planetObjects.Values.Where(planet => planet.MeanTemperature < 0);
            planetList.AddRange(planetsWithMeanUnderzero);
        }
        // LINQ query to get all planets within a diameter specified in arguments.
        public static void InitializePlanetsWithDiameterBetween(double min, double max)
        {
            var planetsWithDiameterBetween = planetObjects.Values.Where(planet => planet.Diameter >= min && planet.Diameter <= max);
            planetList.AddRange(planetsWithDiameterBetween);
        }
        // Insert a planet by getting index by if-condition.
        public static void InsertPlanet(Planet planet, string planetName)
        {
            int index = -1;

            for (int i = 0; i < planetList.Count; i++)
            {
                if (planetList[i].Name == planetName)
                {
                    index = i;
                    break;
                }
            }
            if (planetName == "Neptune") // When inserting Pluto, it goes behind Neptune, so incrementing index to put Pluto after.

            {
                planetList.Insert(index + 1, planet);
            } else { planetList.Insert(index, planet); }
        }
        public static void RemovePlanet(Planet planet)
        {

            planetList.Remove(planet);
        }

        public static void RemovePlanets()
        {
            planetList.Clear();
        }
    }
}