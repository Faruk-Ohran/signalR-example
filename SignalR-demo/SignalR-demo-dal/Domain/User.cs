using System.Collections.Generic;

namespace SignalR_demo_dal.Domain
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Device> Devices { get; set; }
    }
}