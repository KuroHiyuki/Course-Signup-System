using CourseSignupSystem.Services.RevenueManagement.DTO;

namespace CourseSignupSystem.Services.RevenueManagement
{
    public interface IRevenueManagementSerive
    {
        public Task<DownLoadDTO> ExportExelReportRevenue(string Day);
        public Task<List<StudentSelttledListDTO>> StudentSelttledList();
        public Task<List<TeacherSalaryListDTO>> TeacherSalaryList();
        public Task<List<PaySlipDTO>> PaySlipList();
        public Task AddPaySlip( RUDPaySlipDTO model);
        public Task UpdatePaySlip(string UserId, string ClassId, RUDPaySlipDTO model);

    }
}
