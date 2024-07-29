namespace FactoryMethod.MusicPlayer
{
    public class MP3Creator : MusicPlayerFactory
    {
        public override IMusicPlayer CreatePlayer() => new MP3Player();
    }
}
