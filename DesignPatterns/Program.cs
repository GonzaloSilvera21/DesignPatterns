using FactoryMethod;
using FactoryMethod.MusicPlayer;

MusicPlayerFactory playerFactory;
IMusicPlayer musicPlayer;

playerFactory = new CDCreator();
musicPlayer = playerFactory.CreatePlayer();

string playerMessage = musicPlayer.Play();
Console.WriteLine(playerMessage);