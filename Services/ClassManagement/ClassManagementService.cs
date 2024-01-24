using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.ClassManagement.DTO;
using CourseSignupSystem.Services.DepartmentManagement.DTO;
using CourseSignupSystem.Services.StudentManagement.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.ClassManagement
{
    public class ClassManagementService : IClassManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public ClassManagementService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddClassAsync(RUDClassDTO model)
        {
            try
            {
                var Classes = _mapper.Map<Class>(model);
                if (model.ProgramId == null)
                {
                    Classes.ClassId = Guid.NewGuid().ToString();
                }
                Classes.CreatedDate = DateTime.Now;
                var Cost = new Fee
                {
                    FeeId = Guid.NewGuid().ToString(),
                    FeeCost = model.FeeCost,
                    UpdateDate = DateTime.Now,
                    Description = $"Học phí Lớp {Classes.ClassId}",
                    TypeId = "ALLCOURSE100%"
                };
                _context.Add(Cost);
                await _context.SaveChangesAsync();
                Classes.FeeId = Cost.FeeId;
                Classes.ScheduleId = "NOTSET_SCHEDULE";
                _context.Add(Classes);
                var program = new Class_Program
                {
                    ClassId =model.ClassId,
                    ProgramId = model.ProgramId,
                };
                _context.Add(program);
                await _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteClassAsync(string ClassId)
        {
            try
            {
                var delete = await _context.Classes!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId) ?? throw new Exception($"Not found {ClassId}");
                ;
                _context.Classes!.Remove(delete!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassListDTO>> ListClassAsync()
        {
            try
            {
                var classes = await _context.Classes!
                    .Include(p => p.Co_Class_Program)
                    .ThenInclude(g => g.GetProgram)
                    .Include(f => f.GetFee)
                    .Include(e => e.GetSchedule)
                    .Include(a => a.Co_Class_Subject)
                    .ThenInclude(af => af.GetSubject)
                    .ThenInclude(b => b!.GetFaculty)
                    .ThenInclude(c => c!.GetDepartment)
                    .Include(ks => ks.Co_Student_Class)
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<ClassListDTO>>(classes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StudentOfClassListDTO>> ListStudentOfClass(string? ClassId)
        {
            try
            {
                var Student = await _context.Users!
                    .Include(st => st.Co_Student)
                    .Include(uc => uc.Co_Student_Class)
                    .Where(st => st.RoleId == "HV01" && st.Co_Student_Class.FirstOrDefault(p=> p.UserId ==st.UserId)!.ClassId == ClassId)
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<StudentOfClassListDTO>>(Student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<SubjectOfClassListDTO>> ListSubjectOfClass(string? ClassId)
        {
            try
            {
                var Subject = await _context.Subjects!
                    .Include(st => st.Co_Class_Subject)
                    .ThenInclude(sc => sc.GetClass)
                    .Include(uc => uc.GetFaculty)
                    .Where(st =>  st.Co_Class_Subject.FirstOrDefault(fs => fs.SubjectId == st.SubjectId)!.GetClass!.ClassId == ClassId)
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<SubjectOfClassListDTO>>(Subject);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task UpdateClassAsync(string ClassId, RUDClassDTO model)
        {
            throw new NotImplementedException();
        }
        public Task AddScore()
        {
            throw new NotImplementedException();
        }
        public Task ListScoreOfClass()
        {
            throw new NotImplementedException();
        }
    }
}
