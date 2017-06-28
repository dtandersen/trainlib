using System;
using Savoa;

namespace Train
{
    public class RandomMoverSystem : IteratingEntitySystem
    {
      override public void AddedToEngine(Engine engine)
      {
        entities = engine.EntitiesFor(new Family(typeof(RandomComponent)));
      }

      override public void processEntity(Entity entity) {

      }
    }

    class RandomComponent
    {

    }
}
