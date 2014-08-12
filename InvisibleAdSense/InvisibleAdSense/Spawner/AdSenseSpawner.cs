#region

using System;
using System.Collections.Generic;
using InvisibleAdSense.Driver;
using OpenQA.Selenium.PhantomJS;

#endregion

namespace InvisibleAdSense.Spawner
{
    public class AdSenseSpawner : ISpawner
    {
        /// <summary>
        ///     The _driver service
        /// </summary>
        private readonly PhantomJSDriverService _driverService;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdSenseSpawner" /> class.
        /// </summary>
        public AdSenseSpawner()
        {
            Cache = new List<IAdSenseDriver>();

            _driverService = PhantomJSDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;
        }

        /// <summary>
        ///     Gets or sets the cache.
        /// </summary>
        /// <value>
        ///     The cache.
        /// </value>
        public List<IAdSenseDriver> Cache { get; set; }

        /// <summary>
        ///     Spawns the specified URL.
        /// </summary>
        /// <returns></returns>
        public AdSenseDriver Spawn()
        {
            var aDriver = new PhantomJSDriver(_driverService);

            var newAdSenseDriver = new AdSenseDriver(aDriver);

            Cache.Add(newAdSenseDriver);

            return newAdSenseDriver;
        }

        /// <summary>
        ///     Despawns the specified to despawn.
        /// </summary>
        /// <param name="toDespawn">To despawn.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Despawn(IAdSenseDriver toDespawn)
        {
            toDespawn.Close();
            Cache.Remove(toDespawn);
        }

        /// <summary>
        ///     Closes the handler.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void CloseHandler(object sender, EventArgs args)
        {
            DespawnAll();
        }

        /// <summary>
        ///     Depsawns all.
        /// </summary>
        public void DespawnAll()
        {
            foreach (var adSenseDriver in Cache)
            {
                adSenseDriver.Close();
            }
        }
    }
}