using DSA.Problems;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin buddies😎");
            counterGameProblem.hallo(args);

            Console.WriteLine(sumXorr.sumXor(1000000000000000));

            int n = 3; // seconds
            var grid = new List<string>
        {
            ".......",
            "...O...",
            "....O..",
            ".......",
            "OO.....",
            "OO....."
        };

            var result = BomberMan.bomberMan(n, grid);
            foreach (var row in result)
            {
                Console.WriteLine(row);
            }

            //string name = week1.counterGame(132);
            //Console.WriteLine("Congrates "+ name);

            //Console.WriteLine("Press any key to exit..."+ BomberMan.calling());
        }
    }
}
