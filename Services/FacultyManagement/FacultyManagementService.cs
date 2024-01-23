using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.FacultyManagement.DTO;
using CourseSignupSystem.Services.ProgramManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.FacultyManagement
{
    public class FacultyManagementService : IFacultyManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public FacultyManagementService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddFacultyAsync(RUDFacultyDTO model)
        {
            try
            {
                var faculty = _mapper.Map<Faculty>(model);
                if (model.FacultyId == null)
                {
                    faculty.FacultyId = Guid.NewGuid().ToString();
                }
                _context.Add(faculty);
                await _context.SaveChangesAsync(); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteFacultyAsync(string FacultyId)
        {
            try
            {
                var delete = await _context.Faculties!.FirstOrDefaultAsync(u => u.FacultyId == FacultyId) ?? throw new Exception($"Not found {FacultyId}");
                ;
                _context.Faculties!.Remove(delete!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<FacultyListDTO>> ListFacultyAsync()
        {
            try
            {
                var faculty = await _context.Faculties!
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<FacultyListDTO>>(faculty);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateFacultyAsync(string FacultyId, RUDFacultyDTO model)
        {
            try
            {
                var update = await _context.Faculties!.FindAsync(FacultyId) ?? throw new Exception($"Invalid Program {FacultyId}");
                update.UpdateDate = DateTime.Now;
                update.FacultyName = model.FacultyName != "string" ? model.FacultyName : update.FacultyName;
                update.Note = model.Note != "string" ? model.Note : update.Note;
                update.DepartmentId = model.DepartmentId != "string" ? model.DepartmentId : update.DepartmentId;
                _context.Faculties!.Update(update);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
