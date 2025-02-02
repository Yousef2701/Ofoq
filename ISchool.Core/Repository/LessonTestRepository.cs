namespace ISchool.Core.Repository
{
    public class LessonTestRepository : ILessonTestRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private readonly IUserRepository _userRepository;

        public LessonTestRepository(ApplicationDbContext context,
                                    IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        #endregion



        #region Get Test Questions

        public async Task<IEnumerable<LessonQuestion>> GetTestQuestions(string url)
        {
            if (url != null)
            {
                List<LessonQuestion> quests = _context.LessonQuestions.Where(m => m.Vedio_Url == url).OrderBy(m => m.Quest).ToList();
                return quests;
            }
            return null;
        }

        #endregion


        #region Get Test Question Count

        public async Task<int> GetTestQuestionCount(string url)
        {
            if (url != null)
            {
                int count = _context.LessonQuestions.Where(m => m.Vedio_Url == url).Count();
                return count;
            }
            return 0;
        }

        #endregion


        #region Save Test Result

        public async Task<int> SaveTestResult(Test_Answers_VM model)
        {
            if (model != null)
            {
                var userId = await _userRepository.GitLoggingUserId();

                string[] ans = model.answers.Split(",");
                List<LessonQuestion> quests = _context.LessonQuestions.Where(m => m.Vedio_Url == model.url).OrderBy(m => m.Quest).ToList();
                int count = 0;

                for (int i = 0; i < quests.Count; i++)
                {
                    if (quests[i].Correct_Answer == ans[i])
                    {
                        count++;
                    }
                }

                var check = _context.LTestResults.Where(m => m.Vedio_Url == model.url & m.StudentId == userId).FirstOrDefault();
                if (check == null)
                {
                    var result = new LTestResult
                    {
                        Vedio_Url = model.url,
                        StudentId = userId,
                        Date = DateTime.Now.ToString("dd-MM-yyyy"),
                        Time = DateTime.Now.ToString("hh:mm tt"),
                        Correct_Answers_No = count
                    };
                    _context.LTestResults.Add(result);
                    _context.SaveChanges();
                }

                return count;
            }
            return 0;
        }

        #endregion


        #region Get Student Test Results

        public async Task<IEnumerable<LTestResult>> GetStudentTestResults(string studentId)
        {
            if (studentId != null)
            {
                var results = _context.LTestResults.Where(m => m.StudentId == studentId).ToList();
                if (results != null)
                    return results;
            }
            return null;
        }

        #endregion

    }
}
