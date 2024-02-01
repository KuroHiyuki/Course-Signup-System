using CourseSignupSystem.Services.AnotherService;
using CourseSignupSystem.Services.AnotherService.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotherServiceController : ControllerBase
    {
        private readonly IAnotherService _repo;

        public AnotherServiceController(IAnotherService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetRoomListAsync()
        {
            var result = await _repo.RoomListAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddRoomAsync(RUDRoomDTO model)
        {
            await _repo.AddRoomAsync(model);
            return NoContent(); 
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRoomAsync(string? RoomId, RUDRoomDTO model)
        {
            await _repo.UpdateRoomAsync(RoomId, model);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRoomAsync(string? RoomId)
        {
            await _repo.RemoveRoomAsync(RoomId);
            return NoContent();
        }
    }
}
