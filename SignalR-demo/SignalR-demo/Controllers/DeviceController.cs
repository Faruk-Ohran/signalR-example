using Microsoft.AspNetCore.Mvc;
using SignalR_demo_dal.Repositories;
using System.Threading.Tasks;

namespace SignalR_demo.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceController(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _deviceRepository.GetTopTen();
            return Ok(books);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _deviceRepository.GetDeviceById(id);
            return Ok(book);
        }
    }
}