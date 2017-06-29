namespace Trains
{
    class CreateTrain
    {
        private World world;

        public CreateTrain(World world)
        {
            this.world = world;
        }

        public void Execute()
        {
            Train train = world.createTrain();
        }
    }
}
