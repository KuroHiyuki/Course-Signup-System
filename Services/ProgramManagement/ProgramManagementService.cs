using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.ProgramManagement.DTO;
using CourseSignupSystem.Services.TeacherManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.ProgramManagement
{
    public class ProgramManagementService : IProgramManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public ProgramManagementService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddProgramAsync(RUDProgramDTO model)
        {
            try
            {
                var program = _mapper.Map<Programs>(model);
                if (model.ProgramId == null)
                {
                    program.ProgramId = Guid.NewGuid().ToString();
                }
                program.CreatedDate = DateTime.Now;
                _context.Add(program);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteProgramAsync(string ProgramId)
        {
            try
            {
                var delete = await _context.Programs!.FirstOrDefaultAsync(u => u.ProgramId == ProgramId) ?? throw new Exception($"Not found {ProgramId}");
                ;
                _context.Programs!.Remove(delete!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProgramListDTO>> ListProgramAsync()
        {
            try
            {
                var program = await _context.Programs!
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<ProgramListDTO>>(program);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateProgramAsync(string ProgramId, RUDProgramDTO model)
        {
            try
            {
                var update = await _context.Programs!.FindAsync(ProgramId) ?? throw new Exception($"Invalid Program {ProgramId}");
                update.StartDate = model.StartDate != DateTime.Now ? model.StartDate: update.StartDate;
                update.EndDate = model.EndDate != DateTime.Now ? model.EndDate : update.EndDate;
                update.ProgramName = model.ProgramName != "string" ? model.ProgramName :update.ProgramName;
                _context.Programs!.Update(update);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
