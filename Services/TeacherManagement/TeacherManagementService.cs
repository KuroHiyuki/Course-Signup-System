using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.StudentManagement.DTOs;
using CourseSignupSystem.Services.TeacherManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.TeacherManagement
{
    public class TeacherManagementService : ITeacherManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public TeacherManagementService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddTeacherAsync(RUDTeacherDTO model)
        {
            try
            {
                var teacher = _mapper.Map<User>(model);
                if(model.UserId == null) 
                {
                    teacher.UserId = Guid.NewGuid().ToString();
                }
                teacher.UserName = model.Email;
                teacher.RoleId = "GV01";
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                var sub = new Teacher
                {
                    UserId = teacher.UserId,
                    TaxCode = model.TaxCode,
                    MainSubject = model.MainSubject,
                    SubSubject = model.SubSubject,
                };
                _context.Add(sub);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteTeacherAsync(string UserId)
        {
            try
            {
                var delete = await _context.Users!.FirstOrDefaultAsync(u => u.UserId == UserId) ?? throw new Exception($"Not found {UserId}");
                ;
                _context.Users!.Remove(delete!);

                var sub = await _context.Teachers!.FirstOrDefaultAsync(u => u.UserId == UserId);
                if (sub != null)
                {
                    _context.Teachers!.Remove(sub!);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TeacherListDTO>> ListTeacherAsync()
        {
            try
            {
                var Teacher = await _context.Users!
                    .Include(st => st.Co_Teacher)
                    .Where(st => st.RoleId == "GV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<TeacherListDTO>>(Teacher);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateTeacherAsync(string UserId, RUDTeacherDTO model)
        {
            try
            {
                var teacher = await _context.Users!.Include(e => e.Co_Teacher_Class).FirstOrDefaultAsync(u => u.UserId == UserId) ?? throw new Exception($"Not Found {model.UserId}");
                teacher.UpdateDate = DateTime.Now;
                teacher.FirstName = model.FirstName != "string" ? model.FirstName : teacher.FirstName;
                teacher.LastName = model.LastName != "string" ? model.LastName : teacher.LastName;
                teacher.Image = model.Image != "string" ? model.Image : teacher.Image;
                teacher.Address = model.Address != "string" ? model.Address : teacher.Address;
                teacher.NumberPhone = model.NumberPhone != "string" ? model.NumberPhone : teacher.NumberPhone;
                teacher.BirthDate = model.BirthDate != DateTime.Now ? model.BirthDate : teacher.BirthDate;
                teacher.UserPassword = model.UserPassword != "string" ? model.UserPassword : teacher.UserPassword;
                teacher.Sex = model.Sex != 0 ? model.Sex : teacher.Sex;
                _context.Users!.Update(teacher);
                await _context.SaveChangesAsync();
                var sub = await _context.Teachers!.FirstOrDefaultAsync(u => u.UserId == UserId);
                if (model.TaxCode != null)
                {
                    sub!.TaxCode = model.TaxCode != "string" ? model.TaxCode : sub.TaxCode;
                }
                if (model.MainSubject != null)
                {
                    sub!.MainSubject = model.MainSubject != "string" ? model.MainSubject : sub.MainSubject;
                }
                if (model.SubSubject != null)
                {
                    sub!.SubSubject = model.SubSubject != "string" ? model.SubSubject : sub.SubSubject;
                    
                }
                _context.Teachers?.Update(sub!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ScheduleTeacherDTO>> TimeTableTeacherAsync(string? UserId)
        {
            try
            {
                var teacher = await _context.Class_Schedules!
                    .Include(a => a.GetSchedule)
                    .Include(o => o.GetClass)
                    .ThenInclude(b => b!.Co_Teacher_Class)
                    .Where(d => d.GetClass!.Co_Teacher_Class.FirstOrDefault(df => df.ClassId == d.ClassId)!.UserId == UserId)
                    .ToListAsync();
                return _mapper.Map<List<ScheduleTeacherDTO>>(teacher);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
