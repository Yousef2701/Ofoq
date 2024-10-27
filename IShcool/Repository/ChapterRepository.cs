using IShcool.Data;
using IShcool.Interfaces;
using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Repository
{
    public class ChapterRepository : IChapterRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;

        public ChapterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion



        #region Create New Chapter

        public async Task<Chapter> CreateNewChapter(Chapter_VM model)
        {
            if(model != null)
            {
                var chapter = new Chapter
                {
                    TeacherId = model.TeacherId,
                    Title = model.Title
                };

                _context.Chapters.Add(chapter);
                _context.SaveChanges();

                return chapter;
            }
            return null;
        }

        #endregion


        #region Git All Chapters

        public async Task<IEnumerable<Chapter>> GetAllChapters()
        {
            var chapters = _context.Chapters.ToList();
            if (chapters != null)
                return chapters;
            else
                return null;
        }

        #endregion


        #region Get All Teacher Chapters

        public async Task<IEnumerable<Chapter>> GetAllTeacherChapters(string id)
        {
            if(id != null)
            {
                var chapters = _context.Chapters.Where(m => m.TeacherId == id).ToList();

                if(chapters != null)
                    return chapters;
            }
            return null;
        }

        #endregion
    }
}
