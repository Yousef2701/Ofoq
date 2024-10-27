using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Interfaces
{
    public interface ILessonRepository
    {

        public Task<Lesson> AddNewLesson(Lesson_VM model);

        public Task<LessonTest> AddLessonTestQuestion(Lesson_Test_VM model);

        public Task<IEnumerable<Lesson>> GetAllLessons();

        public Task<IEnumerable<Lesson>> GetAllTeacherLessonsInAcademyYear(string id, string year);

        public Task<Lesson> GetTeacherLessonByUrl(Lesson_Url_VM model);

        public Task<string> GetLessonTitle(string url);

        public Task<Lesson> GetLessonDetailsByUrl(string url);

        public Task<IEnumerable<Lesson>> GetAllTeacherLessons(string id);

    }
}
