using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.ClassManagement.DTO;
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
                if (model.ClassId == null)
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
                Classes.FeeId = Cost.FeeId;
                Classes.DepartmentId = model.DepartmentId;
                Classes.ScheduleId = "NOTSET_SCHEDULE";
                _context.Add(Classes);
                var program = new Class_Program
                {
                    ClassId = model.ClassId,
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
                var delete_R_Program = await _context.Class_Programs!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                if(delete_R_Program != null)
                {
                    _context.Class_Programs!.Remove(delete_R_Program!);
                };

                var delete_R_Room = await _context.Class_Rooms!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                if (delete_R_Room != null)
                {
                    _context.Class_Rooms!.Remove(delete_R_Room!);
                };
                
                var delete_R_Student = await _context.Student_Classes!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                if (delete_R_Student != null)
                {
                    _context.Student_Classes!.Remove(delete_R_Student!);
                };
                
                var delete_R_Teacher = await _context.Teacher_Classes!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                if (delete_R_Teacher != null)
                {
                    _context.Teacher_Classes!.Remove(delete_R_Teacher!);
                };
                var delete_R_Subject = await _context.Class_Subjects!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                if (delete_R_Subject != null)
                {
                    _context.Class_Subjects!.Remove(delete_R_Subject!);
                };
                var delete_R_Salary = await _context.Salaries!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                if (delete_R_Salary != null)
                {
                    _context.Salaries!.Remove(delete_R_Salary!);
                };
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
                    .Include(a => a.GetDepartment)
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
                    .Include(st => st.Co_Class_Subject)!
                    .ThenInclude(sc => sc.GetClass)
                    .Include(uc => uc.GetFaculty)
                    .Where(st =>  st.Co_Class_Subject!.FirstOrDefault(fs => fs.SubjectId == st.SubjectId)!.GetClass!.ClassId == ClassId)
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<SubjectOfClassListDTO>>(Subject);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateClassAsync(string ClassId, RUDClassDTO model)
        {
            try
            {
                var update = await _context.Classes!.FindAsync(ClassId) ?? throw new Exception($"Invalid Class {ClassId}");
                update.IsOpen = model.IsOpen;
                update.ClassId = model.ClassId != "string" ? model.ClassId : update.ClassId;
                update.ClassName = model.ClassName != "string" ? model.ClassName : update.ClassName;
                update.MaxStudent = model.MaxStudent != 0 ? model.MaxStudent : update.MaxStudent;
                update.Image = model.Image != "string" ? model.Image : update.Image;
                update.DepartmentId = model.DepartmentId != "string" ? model.DepartmentId : update.DepartmentId;
                update.Description = model.Description != "string" ? model.Description : update.Description;
                _context.Classes!.Update(update);

                var Cost = await _context.Fees!.FindAsync(update.FeeId);
                Cost!.FeeCost = model.FeeCost != 0? model.FeeCost: Cost.FeeCost;
                _context.Fees!.Update(Cost);
                
                if(model.ProgramId !=  "string")
                {
                    var delete_R_Program = await _context.Class_Programs!
                    .FirstOrDefaultAsync(u => u.ClassId == ClassId);
                    if (delete_R_Program != null)
                    {
                        _context.Class_Programs!.Remove(delete_R_Program!);
                    };
                    var program = new Class_Program
                    {
                        ClassId = ClassId,
                        ProgramId = model.ProgramId,
                    };
                    _context.Add(program);
                }

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
