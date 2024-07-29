namespace FactoryMethod.MusicPlayer
{
    public class CDCreator : MusicPlayerFactory
    {
        public override IMusicPlayer CreatePlayer() => new CDPlayer();
    }
}
