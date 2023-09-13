using Planets.Controller;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cycle controller = new Cycle();
            controller.Start();
        }
    }
}