using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.FacultyManagement.DTO;
using CourseSignupSystem.Services.VacationManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.VacationManagement
{
    public class VacationManagementService : IVacationManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public VacationManagementService(CourseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddVacationAsync(RUDVacationDTO model)
        {
            try
            {
                if (model.StartDate > model.EndDate)
                {
                    throw new Exception("Start Time must less than End Time");
                }
                var vacation = _mapper.Map<Vaction>(model);
                vacation.VacationId = Guid.NewGuid().ToString();
                vacation.CreatedAt = DateTime.Now;
                _context.Add(vacation);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteVacationAsync(string VacationId)
        {
            try
            {
                var delete = await _context.Vactions!.FindAsync(VacationId) ?? throw new Exception($"Not found {VacationId}");
             
                _context.Vactions.Remove(delete);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<VacationListDTO>> VacationListAsync()
        {
            try
            {
                var vacation = await _context.Vactions!
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<VacationListDTO>>(vacation);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateVacationAsync(string VacationId, RUDVacationDTO model)
        {
            try
            {
                if(model.StartDate > model.EndDate)
                {
                    throw new Exception("Start Time must less than End Time");
                }
                var update = await _context.Vactions!.FindAsync(VacationId) ?? throw new Exception($"Invalid Program {VacationId}");
                update.VacationName = model.VacationName != "string" ? model.VacationName : update.VacationName;
                update.Reason = model.Reason != "string" ? model.Reason : update.Reason;
                update.StartDate = model.StartDate != DateTime.Now ? model.StartDate : update.StartDate;
                update.EndDate = model.EndDate != DateTime.Now ? model.EndDate : update.EndDate;
                _context.Vactions!.Update(update);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
