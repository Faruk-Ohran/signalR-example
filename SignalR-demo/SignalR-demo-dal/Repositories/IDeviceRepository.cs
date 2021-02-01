using SignalR_demo_dal.ViewModel;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR_demo_dal.Repositories
{
    public interface IDeviceRepository
    {
        Task<DeviceViewModel> GetDeviceById(int id, CancellationToken cancellation = default);
        Task<DeviceViewModel> GetTopTen(CancellationToken cancellation = default);
    }
}