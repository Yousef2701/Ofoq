namespace ISchool.Core.Repository
{
    public class LessonRepository : ILessonRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
        private readonly IUserRepository _userRepository;

        public LessonRepository(ApplicationDbContext context,
                                Microsoft.AspNetCore.Hosting.IHostingEnvironment environment,
                                IUserRepository userRepository)
        {
            _context = context;
            _environment = environment;
            _userRepository = userRepository;
        }

        #endregion



        #region Add New Lesson

        public async Task<Lesson> AddNewLesson(Lesson_VM model)
        {
            if (model != null)
            {
                var environment = Environment.GetEnvironmentVariables();

                var vedio = new Tools(_environment);
                string vedioUrl = vedio.AddVedios(model.VedioFile, await _userRepository.GetUserPhoneById(model.TeacherId) ,model.Title);

                var lesson = new Lesson
                {
                    Title = model.Title,
                    TeacherId = model.TeacherId,
                    ChapterTitle = model.ChapterTitle,
                    Academy_Year = model.Academy_Year,
                    Vedio_Url = vedioUrl,
                    Date = DateTime.Now.ToString("dd-MM-yyyy"),
                    Time = DateTime.Now.ToString("hh:mm"),
                    Am_Pm = DateTime.Now.ToString("tt")
                };

                _context.Lessons.Add(lesson);
                _context.SaveChanges();

                return lesson;
            }
            return null;
        }

        #endregion


        #region Add Lesson Test Question

        public async Task<LessonQuestion> AddLessonTestQuestion(Lesson_Test_VM model)
        {
            if (model != null)
            {
                if (model.Quest_Type == "Image")
                {
                    var count = _context.LessonQuestions.Where(m => m.Vedio_Url == model.Vedio_Url).Count() + 1;

                    var answer_1 = new Tools(_environment);
                    string answer_1_Url = answer_1.AddAnswersImages(model.Frist_Answer_File, model.Vedio_Url + "1" + count);

                    var answer_2 = new Tools(_environment);
                    string answer_2_Url = answer_2.AddAnswersImages(model.Second_Answer_File, model.Vedio_Url + "2" + count);

                    var answer_3 = new Tools(_environment);
                    string answer_3_Url = answer_3.AddAnswersImages(model.Third_Answer_File, model.Vedio_Url + "3" + count);

                    var answer_4 = new Tools(_environment);
                    string answer_4_Url = answer_4.AddAnswersImages(model.Third_Answer_File, model.Vedio_Url + "4" + count);

                    var question = new LessonQuestion
                    {
                        Vedio_Url = model.Vedio_Url,
                        Quest = model.Quest,
                        Quest_Type = model.Quest_Type,
                        Frist_Answer = answer_1_Url,
                        Second_Answer = answer_2_Url,
                        Third_Answer = answer_3_Url,
                        Forth_Answer = answer_4_Url,
                        Correct_Answer = model.Correct_Answer
                    };

                    _context.LessonQuestions.Add(question);
                    _context.SaveChanges();

                    return question;
                }
                else if (model.Quest_Type == "Text")
                {
                    var question = new LessonQuestion
                    {
                        Vedio_Url = model.Vedio_Url,
                        Quest = model.Quest,
                        Quest_Type = model.Quest_Type,
                        Frist_Answer = model.Frist_Answer,
                        Second_Answer = model.Second_Answer,
                        Third_Answer = model.Third_Answer,
                        Forth_Answer = model.Forth_Answer,
                        Correct_Answer = model.Correct_Answer
                    };

                    _context.LessonQuestions.Add(question);
                    _context.SaveChanges();

                    return question;
                }
            }
            return null;
        }

        #endregion


        #region Git All Lessons

        public async Task<IEnumerable<Lesson>> GetAllLessons()
        {
            var lessons = _context.Lessons.ToList();
            if (lessons != null)
                return lessons;
            else
                return null;
        }

        #endregion


        #region Get All Teacher Lessons In AcademyYear

        public async Task<IEnumerable<Lesson>> GetAllTeacherLessonsInAcademyYear(string id, string year)
        {
            if (id != null & year != null)
            {
                var lessons = _context.Lessons.Where(m => m.TeacherId == id & m.Academy_Year == year).OrderBy(m => m.Date).ThenBy(m => m.Am_Pm).ThenBy(m => m.Time).ToList();

                if (lessons != null)
                    return lessons;
            }
            return null;
        }

        #endregion


        #region Get Teacher Lesson By Url

        public async Task<Lesson> GetTeacherLessonByUrl(Lesson_Url_VM model)
        {
            if (model != null)
            {
                var lesson = _context.Lessons.Where(m => m.TeacherId == model.TeacherId & m.Vedio_Url == model.Url).FirstOrDefault();

                if (lesson != null)
                    return lesson;
            }
            return null;
        }

        #endregion


        #region Get Lesson Title

        public async Task<string> GetLessonTitle(string url)
        {
            if (url != null)
            {
                var title = _context.Lessons.Where(m => m.Vedio_Url == url).Select(m => m.Title).FirstOrDefault();

                if (title != null)
                    return title;
            }
            return null;
        }

        #endregion


        #region Get Lesson Details By Url

        public async Task<Lesson> GetLessonDetailsByUrl(string url)
        {
            if (url != null)
            {
                var lesson = _context.Lessons.Where(m => m.Vedio_Url == url).FirstOrDefault();
                if (lesson != null)
                    return lesson;
            }
            return null;
        }

        #endregion


        #region Get All Teacher Lessons

        public async Task<IEnumerable<Lesson>> GetAllTeacherLessons(string id)
        {
            if (id != null)
            {
                var lessons = _context.Lessons.Where(m => m.TeacherId == id).OrderBy(m => m.ChapterTitle).ThenBy(m => m.Date).ThenBy(m => m.Time).ToList();
                if (lessons != null)
                    return lessons;
            }
            return null;
        }

        #endregion
    }
}
