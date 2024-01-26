using AutoMapper;
using ClosedXML.Excel;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.RevenueManagement.DTO;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace CourseSignupSystem.Services.RevenueManagement
{
    public class RevenueManagementService : IRevenueManagementSerive
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public RevenueManagementService(CourseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<DownLoadDTO> ExportExelReportRevenue(string Day)
        {
            try
            {
                string dateFormat = "dd/MM/yyyy";

                // Thử chuyển đổi ngày từ chuỗi đầu vào
                if (DateTime.TryParseExact(Day, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
                {
                    DataTable dataTable = new();
                    dataTable.Columns.Add("Mã học viên", typeof(string));
                    dataTable.Columns.Add("Họ Tên", typeof(string));
                    dataTable.Columns.Add("Mã Lớp", typeof(string));
                    dataTable.Columns.Add("Doanh Thu", typeof(int));
                    var Data = await _context.Student_Classes!
                        .Include(s => s.GetClass)
                        .ThenInclude(a => a!.GetFee)
                        .Where(w => w.PaymentDate.Day == dateTime.Day)
                        .ToArrayAsync();
                    var Data_sort = _mapper.Map<List<RevenueListDTO>>(Data);
                    foreach (var item in Data_sort)
                    {
                        DataRow row = dataTable.NewRow();
                        row["Mã học viên"] = item.UserId;
                        row["Họ Tên"] = item.StudentName;
                        row["Mã Lớp"] = item.ClassId;
                        row["Doanh Thu"] = item.FeeCost;
                        dataTable.Rows.Add(row);
                    }
                    using XLWorkbook wb = new();
                    wb.AddWorksheet(dataTable, "Doanh thu");
                    using MemoryStream ms = new();
                    var result = new DownLoadDTO
                    {
                        Content = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        Filepath = $"DoanhThuNgay{dateTime.Day}.xlsx"
                    };
                    wb.SaveAs(ms);
                    result.Data = ms.ToArray();
                    return result;
                }
                else
                {
                    throw new Exception("Invalid date format. Please use dd/MM/yyyy.");
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        public async Task<List<StudentSelttledListDTO>> StudentSelttledList()
        {
            try
            {
                var student = await _context.Users!
                    .Include(e => e.Co_Student)
                    .Include(d => d.Co_Student_Class)
                    .Where(ds => ds.Co_Student_Class.FirstOrDefault(fs => fs.UserId == ds.UserId)!.IsPayment == true)
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<StudentSelttledListDTO>>(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TeacherSalaryListDTO>> TeacherSalaryList()
        {
            try
            {
                var teacher = await _context.Users!
                    .Include(e => e.Co_Salary)
                    .Include(d => d.Co_Teacher_Class)
                    .Where(st => st.RoleId == "GV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<TeacherSalaryListDTO>>(teacher);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdatePaySlip(string UserId, string ClassId, RUDPaySlipDTO model)
        {
            try
            {
                var slip = await _context.Salaries!.FirstOrDefaultAsync(ds => ds.ClassId == ClassId && ds.UserId == UserId) ?? throw new Exception("Invalid Id");
                slip.Allowance = model.Allowance != 0? model.Allowance : slip.Allowance;
                slip.RateOfCharge = model.RateOfCharge != 0 ? model.RateOfCharge: slip.RateOfCharge;
                _context.Salaries!.Update(slip);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task AddPaySlip(RUDPaySlipDTO model)
        {
            try
            {
                var salary = _mapper.Map<Salary>(model);
                salary.ClassId = salary.GetUser!.Co_Teacher_Class.FirstOrDefault(ds => ds.UserId == salary.UserId)!.ClassId;

                _context.Salaries!.Add(salary!);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<PaySlipDTO>> PaySlipList()
        {
            try
            {
                var Payslip = await _context.Users!
                    .Include(e => e.Co_Salary)
                    .Include(d => d.Co_Teacher_Class)
                    .Include(r => r.GetRole)
                    .Where(st => st.RoleId == "GV01")
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<PaySlipDTO>>(Payslip);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
