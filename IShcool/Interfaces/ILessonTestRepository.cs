using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Interfaces
{
    public interface ILessonTestRepository
    {

        public Task<string[]> GetTestQuestions(string url);

        public Task<int> GetTestQuestionCount(string url);

        public Task<string> SaveTestResult(Test_Answers_VM model);

        public Task<IEnumerable<LTestResult>> GetStudentTestResults(string studentId);

    }
}
