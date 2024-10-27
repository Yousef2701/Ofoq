using IShcool.Interfaces;
using IShcool.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IShcool.Controllers
{
    public class Teacher : Controller
    {

        #region Dependancey injuction

        private readonly IUserRepository _userRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILessonTestRepository _lessonTestRepository;
        private readonly IQuestionBanqRepository _questionBanqRepository;

        public Teacher(IUserRepository userRepository,
                       IStudentRepository studentRepository,
                       IEnrollmentRepository enrollmentRepository,
                       ILessonRepository lessonRepository,
                       ITeacherRepository teacherRepository,
                       ILessonTestRepository lessonTestRepository,
                       IQuestionBanqRepository questionBanqRepository)
        {
            _userRepository = userRepository;
            _studentRepository = studentRepository;  
            _enrollmentRepository = enrollmentRepository;
            _lessonRepository = lessonRepository;
            _teacherRepository = teacherRepository;
            _lessonTestRepository = lessonTestRepository;
            _questionBanqRepository = questionBanqRepository;
        }

        #endregion



        #region Dashboard

        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

        #endregion


        #region Students List

        [HttpGet]
        public async Task<IActionResult> StudentsList()
        {
            var teacherId = await _userRepository.GitLoggingUserId();
            var students = await _studentRepository.GetAllStudents();
            var sup_students = await _enrollmentRepository.GitEnrollmentStudents(teacherId);

            ViewBag.Students = students;
            ViewBag.SubStudents = sup_students;
            return View();
        }

        #endregion


        #region Lessons List

        [HttpGet]
        public async Task<IActionResult> LessonsList()
        {
            var userId = await _userRepository.GitLoggingUserId();
            ViewBag.Lessons = await _lessonRepository.GetAllTeacherLessons(userId);
            ViewBag.Teacher = await _teacherRepository.GetTeacherById(userId);

            return View();
        }

        #endregion


        #region Students Attendance

        [HttpGet]
        public async Task<IActionResult> StudentsAttendance(Lesson_Url_VM model)
        {
            var lesson = await _lessonRepository.GetTeacherLessonByUrl(model);
            int questNum = await _lessonTestRepository.GetTestQuestionCount(model.Url);

            ViewBag.Lesson = lesson;
            ViewBag.QuestNum = questNum;

            var Students = await _studentRepository.GetAllStudentsInAcademyYear(lesson.Academy_Year);
            List<The_Top_App.Models.Student> subStudents = new List<The_Top_App.Models.Student>();
            foreach (The_Top_App.Models.Student std in Students)
            {
                bool check = await _enrollmentRepository.CheckEnrollment(std.Id, model.TeacherId);
                if (check)
                {
                    subStudents.Add(std);
                }
            }

            ViewBag.Students = subStudents;

            return View();
        }

        #endregion


        #region General Exams List

        [HttpGet]
        public async Task<IActionResult> GeneralExamsList()
        {
            ViewBag.Teacher = await _teacherRepository.GetTeacherById(await _userRepository.GitLoggingUserId());
            ViewBag.Exams = await _questionBanqRepository.GetAllTeacherGeneralExams(await _userRepository.GitLoggingUserId());            

            return View();
        }

        #endregion


        #region Students General Exam Results

        [HttpGet]
        public async Task<IActionResult> StudentsGeneralExamResults(General_Exam_VM model)
        {
            var exam = await _questionBanqRepository.GetGeneralExam(model.TeacherId, model.Title, model.Academy_Year);
            int questNum = await _questionBanqRepository.GetGeneralExamQuestionsCount(model.TeacherId, model.Title, model.Academy_Year);

            ViewBag.Exam = exam;
            ViewBag.QuestNum = questNum;

            var Students = await _studentRepository.GetAllStudentsInAcademyYear(model.Academy_Year);
            List<The_Top_App.Models.Student> subStudents = new List<The_Top_App.Models.Student>();
            foreach (The_Top_App.Models.Student std in Students)
            {
                var check = await _enrollmentRepository.CheckEnrollment(std.Id, model.TeacherId);
                if (check)
                {
                    subStudents.Add(std);
                }
            }

            ViewBag.Students = subStudents;

            return View();
        }

        #endregion

    }
}
