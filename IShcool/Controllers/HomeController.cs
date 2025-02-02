
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IShcool.Controllers
{
    public class HomeController : Controller
    {


        #region Dependancey injuction

        private readonly ILogger<HomeController> _logger;
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly IChapterRepository _chapterRepository;

        public HomeController(ILogger<HomeController> logger,
                              ITeacherRepository teacherRepository,
                              ILessonRepository lessonRepository,
                              IChapterRepository chapterRepository)
        {
            _logger = logger;
            _teacherRepository = teacherRepository;
            _lessonRepository = lessonRepository;
            _chapterRepository = chapterRepository;
        }

        #endregion



        #region Home Page

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.Teachers = await _teacherRepository.GetAllTeachers();

            return View();
        }

        #endregion


        #region Exploration The Academy

        #region Teacher Page

        [HttpGet]
        public async Task<IActionResult> TeacherPage(Id_VM model)
        {
            var teacher = await _teacherRepository.GetTeacherById(model.Id);
            ViewBag.Teacher = teacher;

            string sorce = "";
            if (teacher.Subject == "لغـة عـربيـة")
            {
                sorce = "/Subjects/Arabic.png";
            }
            else if (teacher.Subject == "لغـة انجليـزيـة")
            {
                sorce = "/Subjects/English.png";
            }
            else if (teacher.Subject == "ريـاضيـات")
            {
                sorce = "/Subjects/Math.png";
            }
            else if (teacher.Subject == "كيـميـاء")
            {
                sorce = "/Subjects/chimi.png";
            }
            else if (teacher.Subject == "فيـزيـاء")
            {
                sorce = "/Subjects/physics.png";
            }
            else if (teacher.Subject == "أحـيـاء")
            {
                sorce = "/Subjects/Bio.png";
            }
            else if (teacher.Subject == "تـاريـخ")
            {
                sorce = "/Subjects/History.png";
            }
            else if (teacher.Subject == "جغـرافيـا")
            {
                sorce = "/Subjects/maps.png";
            }
            else if (teacher.Subject == "فـلسفـة" || teacher.Subject == "فـلسفـة و منطـق")
            {
                sorce = "/Subjects/philo1.png";
            }
            else if (teacher.Subject == "ريـاضيـات تطبيقيـة")
            {
                sorce = "/Subjects/AppliedM.png";
            }
            else if (teacher.Subject == "ريـاضيـات بحتـة")
            {
                sorce = "/Subjects/Bahata.png";
            }
            else if (teacher.Subject == "علـم نفـس" || teacher.Subject == "علـم الـنفـس و الاجـتمـاع")
            {
                sorce = "/Subjects/Adabi2.png";
            }
            else if (teacher.Subject == "جيـولـوجيـا")
            {
                sorce = "/Subjects/Giolo.png";
            }
            else if (teacher.Subject == "اللغـة الفرنسيـة")
            {
                sorce = "/Subjects/Frensh.png";
            }
            else if (teacher.Subject == "اللغـة الألمـانيـة")
            {
                sorce = "/Subjects/German.png";
            }
            else if (teacher.Subject == "اللغـة الإيطـاليـة")
            {
                sorce = "/Subjects/Italy.png";
            }

            ViewBag.Src = sorce;

            return View();
        }

        #endregion

        #region Course Tetails

        public async Task<IActionResult> Course_Tetails(Academy_Year_VM model)
        {
            ViewBag.Year = model.Academy_Year;
            ViewBag.Teacher = await _teacherRepository.GetTeacherById(model.TeacherId);

            var lessons = await _lessonRepository.GetAllTeacherLessonsInAcademyYear(model.TeacherId, model.Academy_Year);
            ViewBag.Lessons = lessons;
            ViewBag.LessonsCount = lessons.Count();

            var chapters = await _chapterRepository.GetAllTeacherChapters(model.TeacherId);
            ViewBag.Chapters = chapters;
            ViewBag.ChaptersCount = chapters.Count();

            return View();
        }

        #endregion

        #region Lesson

        public async Task<IActionResult> Lesson(Lesson_Url_VM model)
        {
            var lesson = await _lessonRepository.GetTeacherLessonByUrl(model);

            ViewBag.Lesson = lesson;
            ViewBag.TeacherId = model.TeacherId;

            return View();
        }

        #endregion

        #endregion

    }
}