using SignalR_demo_dal.ViewModel;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR_demo_dal.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetUserById(int id, CancellationToken cancellation = default);
        Task<UserViewModel> GetTopTen(CancellationToken cancellation = default);
    }
}