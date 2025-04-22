
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
            if (teacher.Subject == "اللغة العربية")
            {
                sorce = "Arabic.png";
            }
            else if (teacher.Subject == "اللغة الانجليزية")
            {
                sorce = "English.png";
            }
            else if (teacher.Subject == "الرياضيات")
            {
                sorce = "Math.png";
            }
            else if (teacher.Subject == "الكيمياء")
            {
                sorce = "chimi.png";
            }
            else if (teacher.Subject == "الفيزياء")
            {
                sorce = "physics.png";
            }
            else if (teacher.Subject == "الأحياء")
            {
                sorce = "Bio.png";
            }
            else if (teacher.Subject == "التاريخ")
            {
                sorce = "History.png";
            }
            else if (teacher.Subject == "الجغرافيا")
            {
                sorce = "maps.png";
            }
            else if (teacher.Subject == "الفلسفة و المنطق")
            {
                sorce = "philo1.png";
            }
            else if (teacher.Subject == "علم النفس و الاجتماع")
            {
                sorce = "Adabi2.png";
            }
            else if (teacher.Subject == "الجيولوجيا")
            {
                sorce = "Giolo.png";
            }
            else if (teacher.Subject == "اللغة الفرنسية")
            {
                sorce = "Frensh.png";
            }
            else if (teacher.Subject == "اللغة الألمانية")
            {
                sorce = "German.png";
            }
            else if (teacher.Subject == "اللغة الايطالية")
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