using SignalR_demo_dal.Domain;

namespace SignalR_demo_dal.ViewModel
{
    public class UserDto
    {
        public UserDto()
        {
        }

        public UserDto(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}