namespace SignalR_demo_dal.Domain
{
    public class Device : BaseEntity
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}