using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleAdSense;

namespace AppRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var spawner = new Spawner();

            spawner.Spawn();

            Console.ReadLine();
        }
    }
}
