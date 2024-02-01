using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Enumerables;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.ClassManagement.DTO;
using CourseSignupSystem.Services.ScheduleManagement.DTO;
using CourseSignupSystem.Services.TeacherManagement.DTO;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseSignupSystem.Services.ScheduleManagement
{
    public class ScheduleManagementService : IScheduleManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public ScheduleManagementService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddScheduleToTeacher(RUDScheduleDTO model)
        {
            try
            {
                if(model.WeekDay == "string")
                {
                    throw new Exception("Please fill out this field.");
                }

                var Class_Subject = new Class_Subject
                {
                    ClassId = model.ClassId,
                    SubjectId = model.SubjectId,
                    CreatedDate = DateTime.Now,
                };
                _context.Add(Class_Subject);
                
                var Class_room = new Class_Room
                {
                    ClassId = model.ClassId,
                    RoomId = model.RoomId,
                    AlterRoomId = null
                };
                _context.Add(Class_room);
                var Class_Teacher = new Teacher_Class
                {
                    ClassId = model.ClassId,
                    UserId = model.UserId,
                    CreateDate = DateTime.Now,
                    IsPayment = false
                };
                _context.Add(Class_Teacher);
                var classes = await _context.Classes!.FindAsync(model.ClassId);
                classes!.StartedDate = model.StartedDate;
                classes.EndDate = model.EndDate;
                classes.DayOfWeek = model.WeekDay;
                _context.Classes.Update(classes);
                string[] date = model.WeekDay!.Split(",");
                int[] dayOfWeeks = Array.ConvertAll(date, int.Parse);

                for (DateTime currentDate = model.StartedDate; currentDate <= model.EndDate; currentDate = currentDate.AddDays(1))
                {
                    for(int i = 0; i < date.Length; i++)
                    {

                        if ((DayOfWeek)dayOfWeeks[i] == currentDate.DayOfWeek)
                        {
                            var schedule = new Schedule
                            {
                                ScheduleId = Guid.NewGuid().ToString(),
                                Duration = model.Duration,
                                TimeStart = model.TimeStart,
                                ScheduleName = (Day)dayOfWeeks[i],
                            };
                            _context.Add(schedule);
                            var class_schedule = new Class_Schedule
                            {
                                ScheduleId = schedule.ScheduleId,
                                ClassId = model.ClassId,
                                CreateDate = DateTime.Now
                            };
                            _context.Add(class_schedule);
                        }
                    }
                    
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ScheduleToTeacherDTO>> ListScheduleTeacher()
        {
            try
            {
                var Teacher = await _context.Users!
                    .Include(st => st.Co_Teacher)
                    .Include(a => a.Co_Teacher)
                    .Include(b => b.Co_Teacher_Class)
                    .ThenInclude(c => c.GetClass)
                    .ThenInclude(d => d!.Co_Class_Subject)
                    .ThenInclude(g => g.GetSubject)
                    .Where(st => st.RoleId == "GV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<ScheduleToTeacherDTO>>(Teacher);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task RemoveScheduleFromTeacher(string? ClassId)
        {
            try
            {
                var classes = await _context.Classes!.FindAsync(ClassId) ?? throw new Exception($"Not found {ClassId}");
                
                var delete_R_Program = await _context.Class_Programs!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                if (delete_R_Program != null)
                {
                    _context.Class_Programs!.RemoveRange(delete_R_Program!);
                };

                var delete_R_Room = await _context.Class_Rooms!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                if (delete_R_Room != null)
                {
                    _context.Class_Rooms!.RemoveRange(delete_R_Room!);
                };

                var delete_R_Student = await _context.Student_Classes!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                if (delete_R_Student != null)
                {
                    _context.Student_Classes!.RemoveRange(delete_R_Student!);
                };

                var delete_R_Teacher = await _context.Teacher_Classes!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                if (delete_R_Teacher != null)
                {
                    _context.Teacher_Classes!.RemoveRange(delete_R_Teacher!);
                };
                var delete_R_Subject = await _context.Class_Subjects!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                if (delete_R_Subject != null)
                {
                    _context.Class_Subjects!.RemoveRange(delete_R_Subject!);
                };
                var delete_R_Salary = await _context.Salaries!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                if (delete_R_Salary != null)
                {
                    _context.Salaries!.RemoveRange(delete_R_Salary!);
                };
                var class_schedule = await  _context.Class_Schedules!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                _context.Class_Schedules!.RemoveRange(class_schedule!);
                foreach (var schedule in class_schedule)
                {
                    var itenary = await _context.Schedules!.FindAsync(schedule.ScheduleId) ?? throw new Exception($"Missing {schedule.ScheduleId}");
                    _context.Schedules!.Remove(itenary);
                }
                
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateScheduleFromTeacher(string? ClassId, RUDScheduleDTO model)
        {
            try
            {
                var classes = await _context.Classes!.FindAsync(ClassId) ?? throw new Exception($"Not found {ClassId}");

                classes.StartedDate = model.StartedDate != DateTime.Now ? model.StartedDate : classes.StartedDate;
                classes.EndDate = model.EndDate != DateTime.Now ? model.EndDate : classes.EndDate;
                if(classes.DayOfWeek != model.WeekDay && model.WeekDay != "string")
                {
                    classes.DayOfWeek = model.WeekDay;
                    var class_schedule = await _context.Class_Schedules!
                    .Where(u => u.ClassId == ClassId).ToListAsync();
                    foreach (var schedule in class_schedule)
                    {
                        var itenary = await _context.Schedules!.FindAsync(schedule.ScheduleId) ?? throw new Exception($"Missing {schedule.ScheduleId}");
                        _context.Schedules!.Remove(itenary);
                    }
                    _context.Class_Schedules!.RemoveRange(class_schedule!);
                    string[] date = model.WeekDay!.Split(",");
                    int[] dayOfWeeks = Array.ConvertAll(date, int.Parse);

                    for (DateTime currentDate = model.StartedDate; currentDate <= model.EndDate; currentDate = currentDate.AddDays(1))
                    {
                        for (int i = 0; i > date.Length; i++)
                        {

                            if ((DayOfWeek)dayOfWeeks[i] == currentDate.DayOfWeek)
                            {
                                var schedule = new Schedule
                                {
                                    ScheduleId = Guid.NewGuid().ToString(),
                                    Duration = model.Duration,
                                    TimeStart = model.TimeStart,
                                    ScheduleName = (Day)dayOfWeeks[i],
                                };
                                _context.Add(schedule);
                                var newclass_schedule = new Class_Schedule
                                {
                                    ScheduleId = schedule.ScheduleId,
                                    ClassId = model.ClassId,
                                    CreateDate = DateTime.Now
                                };
                                _context.Add(class_schedule);
                            }
                        }

                    }
                }
                _context.Classes.Update(classes);

                var class_subject = await _context.Class_Subjects!.FirstOrDefaultAsync(e => e.ClassId == ClassId) ?? throw new Exception($"Not found {ClassId}");
                if( class_subject.SubjectId != "string" && class_subject.SubjectId != model.SubjectId)
                {
                    _context.Class_Subjects!.Remove(class_subject);
                    var NewClass_Subject = new Class_Subject
                    {
                        ClassId = model.ClassId,
                        SubjectId = model.SubjectId,
                        CreatedDate = DateTime.Now,
                    };
                    _context.Add(NewClass_Subject);
                }

                var class_room = await _context.Class_Rooms!.FirstOrDefaultAsync(e => e.ClassId == ClassId) ?? throw new Exception($"Not found {ClassId}");
                if (class_room.RoomId != "string" && class_room.RoomId != model.RoomId)
                {
                    _context.Class_Rooms!.Remove(class_room);
                    var NewClass_room = new Class_Room
                    {
                        ClassId = model.ClassId,
                        RoomId = model.RoomId,
                    };
                    _context.Add(NewClass_room);
                }

                var teacher_class = await _context.Teacher_Classes!.FirstOrDefaultAsync(e => e.ClassId == ClassId) ?? throw new Exception($"Not found {ClassId}");
                if (teacher_class.UserId != "string" && teacher_class.UserId != model.UserId)
                {
                    _context.Teacher_Classes!.Remove(teacher_class);
                    var NewTeacher_class = new Teacher_Class
                    {
                        ClassId = model.ClassId,
                        UserId = model.UserId,
                    };
                    _context.Add(NewTeacher_class);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
