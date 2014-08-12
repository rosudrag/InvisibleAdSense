using System.Collections.Generic;

namespace InvisibleAdSense
{
    public interface ISpawner
    {
        List<IAdSenseDriver> Cache { get; set; }

        AdSenseDriver Spawn();
        void Despawn(IAdSenseDriver toDespawn);
    }
}