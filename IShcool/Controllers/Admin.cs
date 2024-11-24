using IShcool.Data;
using IShcool.Interfaces;
using IShcool.Models;
using IShcool.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using The_Top_App.Models;

namespace IShcool.Controllers
{
    public class Admin : Controller
    {

        #region Dependancey injuction

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _Environment;
        private readonly IStudentRepository _studentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IChapterRepository _chapterRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly IQuestionBanqRepository _questionBanqRepository;
        private readonly IBookRepository _bookRepository;

        public Admin(IHttpContextAccessor httpContextAccessor,
                     UserManager<IdentityUser> userManager,
                     ILogger<HomeController> Logger,
                     SignInManager<IdentityUser> signInManager,
                     Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment,
                     IStudentRepository studentRepository,
                     ITeacherRepository teacherRepository,
                     IEnrollmentRepository enrollmentRepository,
                     IChapterRepository chapterRepository,
                     ILessonRepository lessonRepository,
                     IQuestionBanqRepository questionBanqRepository,
                     IBookRepository bookRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _logger = Logger;
            _signInManager = signInManager;
            _Environment = Environment;
            _studentRepository = studentRepository;
            _teacherRepository = teacherRepository;
            _enrollmentRepository = enrollmentRepository;
            _chapterRepository = chapterRepository;
            _lessonRepository = lessonRepository;
            _questionBanqRepository = questionBanqRepository;
            _bookRepository = bookRepository;
        }

        #endregion


        #region Admin Home Page

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region Student List

        [HttpGet]
        public async Task<IActionResult> StudentList()
        {
            ViewBag.Students = await _studentRepository.GetAllStudents();

            return View();
        }

        #endregion

        #region Student Enrollment List

        [HttpGet]
        public async Task<IActionResult> StudentEnrollmentList(Id_VM model)
        {
            ViewBag.Teachers = await _enrollmentRepository.GitEnrollmentTeachers(model.Id);

            return View();
        }

        #endregion

        #region Teachers List

        [HttpGet]
        public async Task<IActionResult> TeachersList()
        {
            ViewBag.Teachers = await _teacherRepository.GetAllTeachers();

            return View();
        }

        #endregion

        #region Teacher Exams List

        [HttpGet]
        public async Task<IActionResult> TeacherExamsList(Id_VM model)
        {
            ViewBag.Exams = await _questionBanqRepository.GetAllTeacherGeneralExams(model.Id);
            var teacher = await _teacherRepository.GetTeacherById(model.Id);
            ViewBag.Name = teacher.Name;

            return View();
        }

        #endregion

        #region Exam Questions List

        [HttpGet]
        public async Task<IActionResult> ExamQuestionsList(General_Exam_VM model)
        {
            ViewBag.Questions = await _questionBanqRepository.GetGenaralExamQuestions(model);

            return View();
        }

        #endregion

        #region Remove Question

        [HttpPost]
        public async Task<IActionResult> RemoveQuestion(General_Exam_Question_VM model)
        {
            var result = await _questionBanqRepository.RemoveGeneralExamQuestion(model);

            return RedirectToAction("Index");
        }

        #endregion

        #region Delete Exam

        [HttpPost]
        public async Task<IActionResult> DeleteExam(General_Exam_VM model)
        {
            var result = await _questionBanqRepository.DeleteGeneralExam(model);

            return RedirectToAction("Index");
        }

        #endregion

        #region Lessons

        #region Add New Chapter

        [HttpGet]
        public async Task<IActionResult> AddNewChapter()
        {
            ViewBag.Teachers = await _teacherRepository.GetAllTeachers();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewChapter(Chapter_VM model)
        {
            await _chapterRepository.CreateNewChapter(model);

            return RedirectToAction("Index");
        }

        #endregion

        #region Add New Lesson

        [HttpGet]
        public async Task<IActionResult> AddNewLesson()
        {
            ViewBag.Teachers = await _teacherRepository.GetAllTeachers();

            ViewBag.Chapters = await _chapterRepository.GetAllChapters();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewLesson(Lesson_VM model)
        {
            var result = await _lessonRepository.AddNewLesson(model);

            return RedirectToAction("AddLessonTestQuestion","Admin", new { vedio_url = result.Vedio_Url});
        }

        #endregion

        #region Add Lesson Test Question

        [HttpGet]
        public IActionResult AddLessonTestQuestion(string vedio_url)
        {
            ViewBag.Url = vedio_url;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddLessonTestQuestion(Lesson_Test_VM model)
        {
            await _lessonRepository.AddLessonTestQuestion(model);

            return RedirectToAction("AddLessonTestQuestion", "Admin", new { vedio_url = model.Vedio_Url });
        }

        #endregion

        #endregion

        #region Exams

        #region Add New General Exam

        [HttpGet]
        public async Task<IActionResult> AddNewGeneralExam()
        {
            ViewBag.Teachers = await _teacherRepository.GetAllTeachers();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewGeneralExam(General_Exam_VM model)
        {
            await _questionBanqRepository.AddNewGeneralExam(model);

            return RedirectToAction("AddGeneralExamQuestion","Admin", new {TeacherId = model.TeacherId,Academy_Year = model.Academy_Year,Title = model.Title});
        }

        #endregion

        #region Add General Exam Question

        [HttpGet]
        public async Task<IActionResult> AddGeneralExamQuestion(string TeacherId,string Academy_Year,string Title)
        {
            ViewBag.TeacherId = TeacherId;
            ViewBag.Academy_Year = Academy_Year;
            ViewBag.Title = Title;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGeneralExamQuestion(General_Exam_Question_VM model)
        {
            await _questionBanqRepository.AddGeneralExamQuestion(model);

            return RedirectToAction("AddGeneralExamQuestion", "Admin", new { TeacherId = model.TeacherId, Academy_Year = model.Academy_Year, Title = model.ExamTitle });
        }

        #endregion

        #endregion

        #region Add New Book

        [HttpGet]
        public async Task<IActionResult> AddNewBook()
        {
            ViewBag.Teachers = await _teacherRepository.GetAllTeachers();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(Book_VM model)
        {
            var result = await _bookRepository.AddNewBook(model);

            return RedirectToAction("Index");
        }

        #endregion

    }
}
