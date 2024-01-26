using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.ScoreManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem.Services.ScoreManagement
{
    public class ScoreManagementSerive : IScoreManagementService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;

        public ScoreManagementSerive(CourseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddSubjectOfScoreAsync(RUDSubjectOfScoreDTO model)
        {
            try
            {
                if (model.RequiredColumn > model.ScoreColumn)
                {
                    throw new Exception($"Required Column must less than or equal Score Column");
                }
                var subject = await _context.Subjects!.FindAsync(model.SubjectId);
                if (await _context.Scores!.FindAsync(model.ScoreId) == null || subject == null)
                {
                    throw new Exception($"NO EXIST Score {model.ScoreId} or Subject {model.SubjectId}");
                }
                var subject_score = _mapper.Map<Subject_Score>(model);
                subject_score.UpdateDate = DateTime.Now;
                _context.Subject_Scores!.Add(subject_score);
                
                subject!.ProgramId = model.ProgramId;
                _context.Subjects!.Update(subject);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteSubjectOfScoreAsync(string ScoreId,string SubjectId)
        {
            try
            {
                var delete = await _context.Subject_Scores!
                    .Where(st => st.ScoreId == ScoreId && st.SubjectId == SubjectId)
                    .FirstOrDefaultAsync();
                _context.Subject_Scores!.Remove(delete!);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<SubjectofScoreListDTO>> ListSubjectOfScore()
        {
            try
            {
                var subject_scores = await _context.Subject_Scores!
                    .Include(p => p.GetSubject)!
                    .ThenInclude(sk => sk!.GetPrograms)
                    .Include(f => f.GetScore)!
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<SubjectofScoreListDTO>>(subject_scores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateSubjectOfScoreAsync(string ScoreId, string SubjectId, RUDSubjectOfScoreDTO model)
        {
            try
            {
                if (model.RequiredColumn > model.ScoreColumn)
                {
                    throw new Exception($"Required Column must less than or equal Score Column");
                }
                var update = await _context.Subject_Scores!
                    .Where(st => st.ScoreId == ScoreId && st.SubjectId == SubjectId)
                    .FirstOrDefaultAsync() ?? throw new Exception($"Invalid or not found {ScoreId} and {SubjectId}");
                update!.RequiredColumn = model.RequiredColumn != 0? model.RequiredColumn : update.RequiredColumn;
                update!.ScoreColumn = model.ScoreColumn != 0? model.ScoreColumn : update.ScoreColumn;
                _context.Subject_Scores!.Update(update!);
                if(model.ProgramId != "string")
                {
                    var subject = await _context.Subjects!.FindAsync(SubjectId);
                    subject!.ProgramId = model.ProgramId;
                    _context.Subjects!.Update(subject);
                }
                
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task AddScoreTypeAsync(RUDScoreTypeDTO model)
        {
            try
            {
                var score = _mapper.Map<Score>(model);
                score.ScoreId = Guid.NewGuid().ToString();
                _context!.Add(score);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteScoreTypeAsync(string ScoreId)
        {
            try
            {
                var delete = await _context.Scores!.FindAsync(ScoreId);
                _context!.Scores!.Remove(delete!);

                var subject_score = await _context.Subject_Scores!
                    .Where(sk => sk.ScoreId == ScoreId)
                    .ToListAsync();
                if (subject_score != null && subject_score.Any())
                {
                    _context!.Subject_Scores!.RemoveRange(subject_score);
                }

                var student_score = await _context.Student_Scores!
                    .Where(sk => sk.ScoreId == ScoreId)
                    .ToListAsync();
                if (student_score != null && student_score.Any())
                {
                    _context!.Student_Scores!.RemoveRange(student_score);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<ScoreTypeListDTO>> ListScoreTypeAsync()
        {
            try
            {
                var score = await _context.Scores!
                    .ToArrayAsync() ?? throw new Exception("Bad request");
                return _mapper.Map<List<ScoreTypeListDTO>>(score);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateScoreTypeAsync(string ScoreId, RUDScoreTypeDTO model)
        {
            try
            {
                var update = await _context.Scores!.FindAsync(ScoreId) ?? throw new Exception($"Not found {ScoreId}");
                update!.MultiplierScore = model.MultiplierScore != 0 ? model.MultiplierScore : update.MultiplierScore;
                _context.Scores!.Update(update);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
