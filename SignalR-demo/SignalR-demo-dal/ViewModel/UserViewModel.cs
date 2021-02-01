using SignalR_demo_dal.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SignalR_demo_dal.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            User = new UserDto(user);
        }

        public UserViewModel(IReadOnlyCollection<User> users)
        {
            Collection = users.Select(user => new UserDto(user)).ToList();
        }
        public UserDto User { get; }
        public IReadOnlyCollection<UserDto> Collection { get; }
    }
}