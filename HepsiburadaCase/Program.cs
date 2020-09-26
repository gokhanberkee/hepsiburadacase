using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var b = Console.ReadLine().Trim().Split(' ');

            RoverPosition roverPosition = new RoverPosition();
            RoverPosition roverPosition1 = new RoverPosition();

            roverPosition.setPosition(Convert.ToInt32(b[0]), Convert.ToInt32(b[1]), (Directions)Enum.Parse(typeof(Directions), b[2]));

            var moves = Console.ReadLine().ToUpper();

            var c = Console.ReadLine().Trim().Split(' ');
            roverPosition1.setPosition(Convert.ToInt32(c[0]), Convert.ToInt32(c[1]), (Directions)Enum.Parse(typeof(Directions), c[2]));

            var moves1 = Console.ReadLine().ToUpper();

            roverPosition.printPosition(a, moves);
            roverPosition1.printPosition(a, moves1);
            Console.WriteLine($"{roverPosition.x} {roverPosition.y} {roverPosition.fcn.ToString()}");
            Console.WriteLine($"{roverPosition1.x} {roverPosition1.y} {roverPosition1.fcn.ToString()}");
            Console.ReadLine();
        }
    }
}
