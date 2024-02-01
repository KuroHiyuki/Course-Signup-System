using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.SubjectManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.SubjectManagement
{
    public class SubjectManagementService : ISubjectManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public SubjectManagementService(CourseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddSubjectAsync(RUDSubjectDTO model)
        {
            try
            {
                var subject = _mapper.Map<Subject>(model);
                if (model.SubjectId == null)
                {
                    subject.SubjectId = Guid.NewGuid().ToString();
                }
                subject.CreatedDate = DateTime.Now;
                _context.Add(subject);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteSubjectAsync(string SubjectId)
        {
            try
            {
                var delete = await _context.Subjects!.FirstOrDefaultAsync(u => u.SubjectId == SubjectId) ?? throw new Exception($"Not found {SubjectId}");
                ;
                _context.Subjects!.Remove(delete!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<SubjectListDTO>> ListSubjectAsync()
        {
            try
            {
                var subject = await _context.Subjects!
                    .Include(f => f.GetFaculty)
                    .ThenInclude(d => d!.GetDepartment)
                    .Where(d => d.SubjectId != "NOTSET_SUBJECT")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<SubjectListDTO>>(subject);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateSubjectAsync(string SubjectId, RUDSubjectDTO model)
        {
            try
            {
                var update = await _context.Subjects!.FindAsync(SubjectId) ?? throw new Exception($"Invalid Program {SubjectId}");
                update.SubjectName = model.SubjectName != "string" ? model.SubjectName : update.SubjectName;
                update.FacultyId = model.FacultyId != "string" ? model.FacultyId : update.FacultyId;
                _context.Subjects!.Update(update);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
