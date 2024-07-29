namespace FactoryMethod.MusicPlayer
{
    public class CDPlayer : IMusicPlayer
    {
        public string Play() => "Playing music from CD player.";
    }
}
