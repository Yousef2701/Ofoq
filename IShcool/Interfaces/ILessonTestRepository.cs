using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Interfaces
{
    public interface ILessonTestRepository
    {

        public Task<IEnumerable<LessonQuestion>> GetTestQuestions(string url);

        public Task<int> GetTestQuestionCount(string url);

        public Task<int> SaveTestResult(Test_Answers_VM model);

        public Task<IEnumerable<LTestResult>> GetStudentTestResults(string studentId);

    }
}
