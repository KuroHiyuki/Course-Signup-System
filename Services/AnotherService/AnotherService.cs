using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.AnotherService.DTO;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.AnotherService
{
    public class AnotherService : IAnotherService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public AnotherService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddRoomAsync(RUDRoomDTO model)
        {
            try
            {
                var room = _mapper.Map<Room>(model);
                room.RoomId = Guid.NewGuid().ToString();
                _context.Add(room);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task RemoveRoomAsync(string? RoomId)
        {
            try
            {
                var room = await _context.Rooms!.FindAsync(RoomId) ?? throw new Exception("Not found");
                _context.Remove(room);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ListRoomDTO>> RoomListAsync()
        {
            try
            {
                var room = await _context.Rooms!.ToListAsync();
                return _mapper.Map<List<ListRoomDTO>>(room);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateRoomAsync(string? RoomId, RUDRoomDTO model)
        {
            try
            {
                var room = await _context.Rooms!.FindAsync(RoomId) ?? throw new Exception("Not found");
                room.RoomName = model.RoomName != "string" ? model.RoomName : room.RoomName;
                _context.Rooms.Update(room);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
