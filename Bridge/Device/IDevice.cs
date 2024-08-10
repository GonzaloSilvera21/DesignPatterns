namespace Bridge.Device
{
    public interface IDevice
    {
        bool isEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }
}
