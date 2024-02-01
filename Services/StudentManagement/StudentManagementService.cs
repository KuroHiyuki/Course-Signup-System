using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.StudentManagement.DTOs;
using CourseSignupSystem.Services.TeacherManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.StudentManagement
{
    public class StudentManagementService : IStudentManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public StudentManagementService(CourseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddStudentAsync(RUDStudentDTO model)
        {
            try
            {
                var student = _mapper.Map<User>(model);
                student.UserId = Guid.NewGuid().ToString();
                student.UserName = model.Email;
                student.RoleId = "HV01";
                _context.Add(student);
                await _context.SaveChangesAsync();
                var parent = new Student
                {
                    UserId = student.UserId,
                    ParentName = model.ParentName
                };
                _context.Add(parent);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteStudentAsync(string UserId)
        {
            try
            {
                var delete = await _context.Users!.FirstOrDefaultAsync(u => u.UserId == UserId) ?? throw new Exception($"Not found {UserId}");
                ;
                _context.Users!.Remove(delete!);
               
                var parent = await _context.Students!.FirstOrDefaultAsync(u => u.UserId == UserId);
                if (parent != null)
                {
                    _context.Students!.Remove(parent!);
                }
                await _context.SaveChangesAsync();
            }
            catch( Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StudentListDTO>> ListStudentAsync()
        {
            try
            {
                var Student = await _context.Users!
                    .Include(st => st.Co_Student)
                    .Where(st => st.RoleId == "HV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<StudentListDTO>>(Student);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateStudentAsync(string UserId, RUDStudentDTO model)
        {
            try
            {
                
                var student = await _context.Users!.Include(e => e.Co_Student_Class).FirstOrDefaultAsync(u => u.UserId == UserId) ?? throw new Exception($"Not Found {model.UserId}");
                student.UpdateDate = DateTime.Now;
                student.FirstName = model.FirstName != "string" ? model.FirstName : student.FirstName;
                student.LastName = model.LastName != "string" ? model.LastName : student.LastName;
                student.Image = model.Image != "string" ? model.Image : student.Image;
                student.Address = model.Address != "string" ? model.Address : student.Address;
                student.NumberPhone = model.NumberPhone != "string" ? model.NumberPhone : student.NumberPhone;
                student.BirthDate = model.BirthDate != DateTime.Now ? model.BirthDate : student.BirthDate;
                student.UserPassword = model.UserPassword != "string" ? model.UserPassword : student.UserPassword;
                student.Sex = model.Sex != 0 ? model.Sex : student.Sex;
                _context.Users!.Update(student);
                await _context.SaveChangesAsync();
                var parent = await _context.Students!.FirstOrDefaultAsync(u => u.UserId == UserId);
                if(model.ParentName != null)
                {
                    parent!.ParentName = model.ParentName!="string" ? model.ParentName:parent.ParentName;
                    _context.Students?.Update(parent);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<StudentListDTO>> ListStudentOfClassAsync(string ClassId)
        {
            try
            {
                if(await  _context.Classes!.FindAsync(ClassId) == null)
                {
                    throw new Exception($"Not Found {ClassId}");
                }
                var Student = await _context.Users!
                    .Include(st => st.Co_Student)
                    .Where(st => st.RoleId == "HV01" && st.Co_Student_Class.Any(e => e.ClassId == ClassId))
                    .ToArrayAsync() ?? throw new Exception("Missing class");
                return _mapper.Map<List<StudentListDTO>>(Student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task EnrollmentAsync(EnrollmentDTO model)
        {
            try
            {
                var Enroll = _mapper.Map<Student_Class>(model) ?? throw new Exception("Failed");
                Enroll.EnrollmentDate = DateTime.Now;
                Enroll.IsPayment = false;
                _context.Add(Enroll);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StudentScheduleDTO>> TimeTableStudentAsync(string? UserId)
        {
            try
            {
                var student = await _context.Class_Schedules!
                    .Include(a => a.GetSchedule)
                    .Include(o => o.GetClass)
                    .ThenInclude(b => b!.Co_Student_Class)
                    .Where(d => d.GetClass!.Co_Student_Class.FirstOrDefault(df => df.ClassId == d.ClassId)!.UserId == UserId)
                    .ToListAsync();
                return _mapper.Map<List<StudentScheduleDTO>>(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task FeePaid(string UserId, string ClassId)
        {
            try
            {
                var paid = await _context.Student_Classes!.FirstOrDefaultAsync(dt => dt.ClassId == ClassId && dt.UserId == UserId) ?? throw new Exception($"The Student Id {UserId}does't enroll this class {ClassId}");
                paid.PaymentDate = DateTime.Now;
                paid.IsPayment = true;
                _context.Student_Classes!.Update(paid);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
