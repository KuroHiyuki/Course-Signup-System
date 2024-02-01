using CourseSignupSystem.Services.AnotherService.DTO;

namespace CourseSignupSystem.Services.AnotherService
{
    public interface IAnotherService
    {
        public Task<List<ListRoomDTO>> RoomListAsync();
        public Task AddRoomAsync(RUDRoomDTO model);
        public Task RemoveRoomAsync(string? RoomId);
        public Task UpdateRoomAsync(string? RoomId, RUDRoomDTO model);
    }
}
