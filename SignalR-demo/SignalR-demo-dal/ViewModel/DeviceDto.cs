using SignalR_demo_dal.Domain;

namespace SignalR_demo_dal.ViewModel
{
    public class DeviceDto
    {
        public DeviceDto()
        {
        }

        public DeviceDto(Device device)
        {
            Id = device.Id;
            Name = device.Name;
            Manufacturer = device.Manufacturer;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }
}