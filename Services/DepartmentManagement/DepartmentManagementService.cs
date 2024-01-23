using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.DepartmentManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.DepartmentManagement
{
    public class DepartmentManagementService : IDepartmentManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public DepartmentManagementService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddDepartmentAsync(RUDDepartmentDTO model)
        {
            try
            {
                var department = _mapper.Map<Department>(model);
                department.DepartmentId = Guid.NewGuid().ToString();
                department.CreatedDate = DateTime.Now;
                _context.Add(department);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteDepartmentAsync(string DepartmentId)
        {
            try
            {
                var delete = await _context.Departments!.FirstOrDefaultAsync(u => u.DepartmentId == DepartmentId) ?? throw new Exception($"Not found {DepartmentId}");
                ;
                _context.Departments!.Remove(delete!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<DepartmentListDTO>> ListDepartmentAsync()
        {
            try
            {
                var departments = await _context.Departments!
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<DepartmentListDTO>>(departments);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateDepartmentAsync(string DepartmentId, RUDDepartmentDTO model)
        {
            try
            {
                var update = await _context.Departments!.FindAsync(DepartmentId) ?? throw new Exception($"Invalid Program {DepartmentId}");
                update.DepartmentName = model.DepartmentName;
                update.DepartmentStatus = model.DepartmentStatus;
                _context.Departments!.Update(update);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
