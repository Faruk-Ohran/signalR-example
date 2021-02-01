using SignalR_demo_dal.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SignalR_demo_dal.ViewModel
{
    public class DeviceViewModel
    {
        public DeviceViewModel(Device device)
        {
            Device = new DeviceDto(device);
        }

        public DeviceViewModel(IReadOnlyCollection<Device> devices)
        {
            Collection = devices.Select(device => new DeviceDto(device)).ToList();
        }

        public IReadOnlyCollection<DeviceDto> Collection { get; }
        public DeviceDto Device { get; }
    }
}