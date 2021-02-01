using Microsoft.EntityFrameworkCore;
using SignalR_demo_dal.Context;
using SignalR_demo_dal.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR_demo_dal.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly SignalRDbContext _signalRDbContext;

        public SqlUserRepository(SignalRDbContext signalRDbContext)
        {
            _signalRDbContext = signalRDbContext;
        }

        public async Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            var collection = await _signalRDbContext.Users.Take(maxTop).ToListAsync(cancellationToken);
            return new UserViewModel(collection);
        }

        public async Task<UserViewModel> GetUserById(int id, CancellationToken cancellationToken = default)
        {
            var user = await _signalRDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
            return new UserViewModel(user);
        }
    }
}