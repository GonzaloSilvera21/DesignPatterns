namespace FactoryMethod.MusicPlayer
{
    public class CasseteCreator : MusicPlayerFactory
    {
        public override IMusicPlayer CreatePlayer() => new CassetePlayer();
    }
}
