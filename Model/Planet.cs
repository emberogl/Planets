namespace Planets
{
    public class Planet
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Diameter { get; set; }
        public int Density { get; set; }
        public double Gravity { get; set; }
        public double RotationPeriod { get; set; }
        public double LengthOfDay { get; set; }
        public double DistanceFromSun { get; set; }
        public double OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
        public int MeanTemperature { get; set; }
        public int NumberOfMoons { get; set; }
        public bool RingSystem { get; set; }

        public Planet(string name = "", double mass = 0, double diameter = 0, int density = 0, double gravity = 0, double rotationPeriod = 0,
                      double lengthOfDay = 0, double distanceFromSun = 0, double orbitalPeriod = 0, double orbitalVelocity = 0,
                      int meanTemperature = 0, int numberOfMoons = 0, bool ringSystem = false)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoons;
            RingSystem = ringSystem;
        }
    }
}