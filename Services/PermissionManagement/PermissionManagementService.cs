using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.PermissionManagement.DTO;
using CourseSignupSystem.Services.RevenueManagement.DTO;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.PermissionManagement
{
    public class PermissionManagementService : IPermissionManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public PermissionManagementService(CourseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddAdmin(RUDAdminDTO model)
        {
            try
            {
                var admin = _mapper.Map<User>(model);
                admin.UserId = Guid.NewGuid().ToString();

                _context.Add(admin);
                await _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<AdminListDTO>> AdminList()
        {
            try
            {
                var Admin = await _context.Users!
                    .Include(e => e.GetRole)
                    .Where(st => st.RoleId != "HV01" && st.RoleId != "GV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<AdminListDTO>>(Admin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateAdmin(string UserId, RUDAdminDTO model)
        {
            try
            {
                var admin = await _context.Users!.FindAsync(UserId) ?? throw new Exception($"Not Found {UserId}");
                admin.UpdateDate = DateTime.Now;
                admin.Image = model.Image != "string" ? model.Image : admin.Image;
                admin.UserPassword = model.UserPassword != "string" ? model.UserPassword : admin.UserPassword;
                admin.RoleId = model.RoleId != "string" ? model.RoleId : admin.RoleId;
                _context.Users!.Update(admin);
                await _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteAdmin(string UserId)
        {
            try
            {
                var admin = await _context.Users!.FindAsync(UserId) ?? throw new Exception($"Not Found {UserId}");
                admin.UpdateDate = DateTime.Now;
                
                _context.Users!.Remove(admin);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<RoleListDTO>> RoleList()
        {
            try
            {
                var Role = await _context.Roles!
                    .Where(st => st.RoleId != "HV01" && st.RoleId != "GV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<RoleListDTO>>(Role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateRolePermission(string RoleId, string? PermissionId, RUDRolePermissionDTO model)
        {
            try
            {
                var role = await _context.Roles!.FindAsync(RoleId) ?? throw new Exception($"Not invalid {RoleId}");
                var permission = await _context.Permissions!.FindAsync(PermissionId) ?? throw new Exception($"Not invalid {PermissionId}");
                var RolePermission = await _context.Role_Permissions!
                    .Include(da => da.GetPermission)
                    .Include(ds => ds.GetRole)
                    .FirstOrDefaultAsync(st => st.RoleId == RoleId && st.PermissionId == PermissionId);
                if(RolePermission !=null)
                {
                    if(model.IsTrue == false)
                    {
                        _context.Role_Permissions!.Remove(RolePermission);
                    }
                    else
                    {
                        throw new Exception("Invalid Value");
                    }
                }
                else
                {
                    if (model.IsTrue == false)
                    {
                        throw new Exception("Invalid Value");
                        
                    }
                    else
                    {
                        var roleper = new Role_Permission
                        {
                            RoleId = RoleId,
                            PermissionId = PermissionId,
                            UpdateDate = DateTime.Now,
                        };
                        _context.Role_Permissions!.Add(roleper!);
                    }
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<RolePermissionDTO>> RolePermissionList(string RoleId)
        {
            try
            {
                var RolePermission = await _context.Permissions!
                    .Include(da => da.Co_Role_Permission)
                    .Where(st => st.Co_Role_Permission.FirstOrDefault(ds => ds.PermissionId == st.PermissionId)!.RoleId == RoleId || st.Co_Role_Permission.FirstOrDefault(ds => ds.PermissionId == st.PermissionId)!.RoleId == null)
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<RolePermissionDTO>>(RolePermission);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
