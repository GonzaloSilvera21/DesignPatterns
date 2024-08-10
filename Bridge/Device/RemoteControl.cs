namespace Bridge.Device
{
    public class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }
        
        void TogglePower()
        {
            if(_device.isEnabled()) _device.Disable();
            else _device.Enable();
        }

        void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        void VolumeUp() 
        { 
            _device.SetVolume(_device.GetVolume() + 10);
        }

        void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        void ChannelUp()
        { 
            _device.SetChannel(_device.GetChannel() + 1);
        }
    }
}
