using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleAdSense;
using InvisibleAdSense.Spawner;

namespace AppRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var spawner = new AdSenseSpawner();

            RegisterDespawnOnProcessExit(spawner);

            var browser = spawner.Spawn();

            browser.GoTo("http://google.co.uk"); 
        }

        /// <summary>
        /// Registers the despawn on process exit.
        /// </summary>
        /// <param name="adSenseSpawner">The AdSenseSpawner.</param>
        private static void RegisterDespawnOnProcessExit(AdSenseSpawner adSenseSpawner)
        {
            AppDomain.CurrentDomain.ProcessExit += adSenseSpawner.CloseHandler;
        }
    }
}
