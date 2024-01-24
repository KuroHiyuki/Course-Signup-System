using CourseSignupSystem.Services.ScoreManagement.DTO;

namespace CourseSignupSystem.Services.ScoreManagement
{
    public interface IScoreManagementService
    {
        public Task<List<SubjectofScoreListDTO>> ListSubjectOfScore();
        public Task AddSubjectOfScoreAsync(RUDSubjectOfScoreDTO model);
        public Task UpdateSubjectOfScoreAsync(string ScoreId, string SubjectId, RUDSubjectOfScoreDTO model);
        public Task DeleteSubjectOfScoreAsync(string ScoreId, string SubjectId);
        public Task<List<ScoreTypeListDTO>> ListScoreTypeAsync();
        public Task AddScoreTypeAsync(RUDScoreTypeDTO model);
        public Task UpdateScoreTypeAsync(string ScoreId, RUDScoreTypeDTO model);
        public Task DeleteScoreTypeAsync(string ScoreId);
    }
}
