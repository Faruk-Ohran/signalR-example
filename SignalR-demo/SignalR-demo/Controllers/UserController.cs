using Microsoft.AspNetCore.Mvc;
using SignalR_demo_dal.Repositories;
using System.Threading.Tasks;

namespace SignalR_demo.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _userRepository.GetTopTen();
            return Ok(books);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _userRepository.GetUserById(id);
            return Ok(book);
        }
    }
}