namespace Bridge.Device
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        void Mute()
        {
            base._device.SetVolume(0);
        }
    }
}
