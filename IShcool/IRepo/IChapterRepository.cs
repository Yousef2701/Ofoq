using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Interfaces
{
    public interface IChapterRepository
    {

        public Task<Chapter> CreateNewChapter(Chapter_VM model);

        public Task<IEnumerable<Chapter>> GetAllChapters();

        public Task<IEnumerable<Chapter>> GetAllTeacherChapters(string id);

    }
}
