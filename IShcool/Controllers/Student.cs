using Humanizer;
using IShcool.Interfaces;
using IShcool.Models;
using IShcool.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace IShcool.Controllers
{
    public class Student : Controller
    {

        #region Dependancey injuction

        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _studentRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly IChapterRepository _chapterRepository;
        private readonly ILessonTestRepository _lessonTestRepository;
        private readonly IQuestionBanqRepository _questionBanqRepository;
        private readonly IBookRepository _bookRepository;

        public Student(ILogger<HomeController> logger,
                              IStudentRepository studentRepository,
                              IUserRepository userRepository,
                              ISubjectRepository subjectRepository,
                              IEnrollmentRepository enrollmentRepository,
                              ITeacherRepository teacherRepository,
                              ILessonRepository lessonRepository,
                              IChapterRepository chapterRepository,
                              ILessonTestRepository lessonTestRepository,
                              IQuestionBanqRepository questionBanqRepository,
                              IBookRepository bookRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
            _userRepository = userRepository;
            _subjectRepository = subjectRepository;
            _enrollmentRepository = enrollmentRepository;
            _teacherRepository = teacherRepository;
            _lessonRepository = lessonRepository;
            _chapterRepository = chapterRepository;
            _lessonTestRepository = lessonTestRepository;
            _questionBanqRepository = questionBanqRepository;
            _bookRepository = bookRepository;
        }

        #endregion



        #region Student Home Page

        public async Task<IActionResult> StudentHomePage()
        {
            return View();
        }

        #endregion


        #region Lessons

        #region Choose Lesson Subjects

        public async Task<IActionResult> ChooseLessonSubject()
        {
            var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());

            ViewBag.Subjects = await _subjectRepository.GetAllGradeSubjectsByDepartment(student.Grade, student.Department);

            ViewBag.MySubjects = await _enrollmentRepository.GetMySubjects(await _userRepository.GitLoggingUserId());

            ViewBag.SecondLanguage = student.SecondLang;

            return View();
        }

        #endregion

        #region Teacher Page

        public async Task<IActionResult> TeacherPage(Subject_Name_VM model)
        {
            var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());
            ViewBag.Year = student.Grade;
            ViewBag.StudentId = student.Id;

            var teacherid = await _enrollmentRepository.GetTeacherIdByStudentIdAndSubject(student.Id, model.name);
            var teacher = await _teacherRepository.GetTeacherById(teacherid);
            ViewBag.Teacher = teacher;

            var lessons = await _lessonRepository.GetAllTeacherLessonsInAcademyYear(teacherid, student.Grade);
            ViewBag.Lessons = lessons;
            ViewBag.LessonsCount = lessons.Count();

            var chapters = await _chapterRepository.GetAllTeacherChapters(teacherid);
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

            ViewBag.Count = await _lessonTestRepository.GetTestQuestionCount(model.Url);

            return View();
        }

        #endregion

        #region Lesson Test

        [HttpGet]
        public async Task<IActionResult> LessonTest(Lesson_Url_VM model)
        {
            ViewBag.Title = await _lessonRepository.GetLessonTitle(model.Url);
            ViewBag.TeacherId = model.TeacherId;
            ViewBag.Url = model.Url;

            ViewBag.Questions = await _lessonTestRepository.GetTestQuestions(model.Url);

            ViewBag.Min = await _lessonTestRepository.GetTestQuestionCount(model.Url);

            return View();
        }

        #endregion

        #region Result

        [HttpPost]
        public async Task<IActionResult> Result(Test_Answers_VM model)
        {
            ViewBag.Correct = await _lessonTestRepository.SaveTestResult(model);
            ViewBag.Count = await _lessonTestRepository.GetTestQuestionCount(model.url);
            string[] answers = model.answers.Split(',');
            ViewBag.Answers = answers;

            ViewBag.Questions = await _lessonTestRepository.GetTestQuestions(model.url);

            return View();
        }

        #endregion

        #endregion


        #region Question Banq


        #region Choose Banq Subject

        [HttpGet]
        public async Task<IActionResult> ChooseBanqSubject()
        {
            var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());

            ViewBag.Subjects = await _subjectRepository.GetAllGradeSubjectsByDepartment(student.Grade, student.Department);

            ViewBag.MySubjects = await _enrollmentRepository.GetMySubjects(await _userRepository.GitLoggingUserId());

            ViewBag.SecondLanguage = student.SecondLang;

            return View();
        }

        #endregion

        #region All Genaral Exam

        [HttpGet]
        public async Task<IActionResult> AllGenaralExam(Subject_Name_VM model)
        {
            var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());
            var teacherId = await _enrollmentRepository.GetTeacherIdByStudentIdAndSubject(student.Id, model.name);
            ViewBag.Grade = student.Grade;

            ViewBag.Exams = await _questionBanqRepository.GetAllTeacherGeneralExamsInAcademyYear(teacherId, student.Grade);

            return View();
        }

        #endregion

        #region Start Genaral Exam

        [HttpGet]
        public async Task<IActionResult> StartGenaralExam(General_Exam_VM model)
        {
            ViewBag.Title = model.Title;
            ViewBag.TeacherId = model.TeacherId;
            ViewBag.AcademyYear = model.Academy_Year;

            ViewBag.Questions = await _questionBanqRepository.GetGenaralExamQuestions(model);

            ViewBag.Min = await _questionBanqRepository.GetGenaralExamDuration(model);

            return View();
        }

        #endregion

        #region Genaral Exam Result

        [HttpPost]
        public async Task<IActionResult> GenaralExamResult(General_Exam_Answers_VM model)
        {
            ViewBag.Correct = await _questionBanqRepository.SaveGenaralExamResult(model);
            ViewBag.Count = await _questionBanqRepository.GetGeneralExamQuestionsCount(model.TeacherId, model.Title, model.Academy_Year);
            string[] answers = model.Answers.Split(',');
            ViewBag.Answers = answers;

            var exam = new General_Exam_VM
            {
                Title = model.Title,
                Academy_Year = model.Academy_Year,
                TeacherId =model.TeacherId
            };
            ViewBag.Questions = await _questionBanqRepository.GetGenaralExamQuestions(exam);

            return View();
        }

        #endregion


        #endregion


        #region Books

        [HttpGet]
        public async Task<IActionResult> Books()
        {
            var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());
            ViewBag.Books = await _bookRepository.GetStudentBooks(student);

            return View();
        }

        #endregion

    }
}
