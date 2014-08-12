using System;
using System.Collections.Generic;
using InvisibleAdSense.Driver;

namespace InvisibleAdSense.Spawner
{
    public interface ISpawner
    {
        List<IAdSenseDriver> Cache { get; set; }

        AdSenseDriver Spawn();
        void Despawn(IAdSenseDriver toDespawn);

        void CloseHandler(object sender, EventArgs args);
    }
}