using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Interfaces
{
    public interface IQuestionBanqRepository
    {

        public Task<GeneralExam> AddNewGeneralExam(General_Exam_VM model);

        public Task<GeneralExamQuestion> AddGeneralExamQuestion(General_Exam_Question_VM model);

        public Task<IEnumerable<GeneralExam>> GetAllTeacherGeneralExamsInAcademyYear(string teacherId, string year);

        public Task<IEnumerable<GeneralExamQuestion>> GetGenaralExamQuestions(General_Exam_VM model);

        public Task<int> SaveGenaralExamResult(General_Exam_Answers_VM model);

        public Task<IEnumerable<GeneralExamResult>> GetStudentGeneeralExamResults(string studentId, string teacherId);

        public Task<IEnumerable<GeneralExam>> GetAllTeacherGeneralExams(string teacherId);

        public Task<GeneralExam> GetGeneralExam(string teacherId, string title, string year);

        public Task<int> GetGeneralExamQuestionsCount(string teacherId, string title, string year);

        public Task<string> GetGenaralExamDuration(General_Exam_VM model);

    }
}
