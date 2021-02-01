using Microsoft.EntityFrameworkCore;
using SignalR_demo_dal.Context;
using SignalR_demo_dal.ViewModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR_demo_dal.Repositories
{
    public class SqlDeviceRepository : IDeviceRepository
    {
        private readonly SignalRDbContext _signalRDbContext;

        public SqlDeviceRepository(SignalRDbContext signalRDbContext)
        {
            _signalRDbContext = signalRDbContext;
        }

        public async Task<DeviceViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            var collection = await _signalRDbContext.Devices.Take(maxTop).ToListAsync(cancellationToken);
            return new DeviceViewModel(collection);
        }

        public async Task<DeviceViewModel> GetDeviceById(int id, CancellationToken cancellationToken = default)
        {
            var device = await _signalRDbContext.Devices.FirstOrDefaultAsync(u => u.Id == id);
            return new DeviceViewModel(device);
        }
    }
}