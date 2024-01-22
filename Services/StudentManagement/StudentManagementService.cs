using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.StudentManagement.DTOs;
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
        public async Task AddStudentAsync(RUDStudent model)
        {
            try
            {
                var student = _mapper.Map<User>(model);
                var Class = await _context.Classes!.FindAsync(model.ClassId);
                if (Class != null)
                {
                    _context.Classes.Add(Class);
                    await _context.SaveChangesAsync();
                }
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
                var delete = await _context.Users!.FirstOrDefaultAsync(u => u.UserId == UserId);
                if (delete == null)
                {
                    throw new Exception($"Not found {UserId}");
                };
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
                    .ToArrayAsync();
                if (Student == null)
                {
                    throw new Exception("Bad request");
                }
                return _mapper.Map<List<StudentListDTO>>(Student);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateStudentAsync(string UserId, RUDStudent model)
        {
            try
            {
                var student = await _context.Users!.FirstOrDefaultAsync(u => u.UserId == UserId);
                if (student == null)
                {
                    throw new Exception($"Not Found {UserId}");
                }
                student.Sex = model.Sex;
                //var mapper = _mapper.Map<User>(model);
                _context.Users!.Update(student);
                await _context.SaveChangesAsync();
                //await _context.SaveChangesAsync();
                //_context.RemoveRange();
                //if ( model.ParentName != "" && model.ParentName != "string")
                //{
                //    var parent = await _context.Students!.FirstOrDefaultAsync(u => u.UserId == UserId);
                //    var UpdateParent = new Student
                //    {
                //        ParentName = model.ParentName
                //    };
                //    _context.Students!.Update(UpdateParent);
                //}

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Task EnrollmentAsync()
        {
            throw new NotImplementedException();
        }
        public Task<List<StudentListDTO>> ListStudentOfClassAsync(string ClassId)
        {
            throw new NotImplementedException();
        }

        public Task TimeTableStudentAsync()
        {
            throw new NotImplementedException();
        }
    }
}
