using ISchool.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IShcool.Controllers
{
    public class ParentController : Controller
    {

        #region Dependancey injuction

        private readonly IStudentRepository _studentRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ILessonTestRepository _lessonTestRepository;
        private readonly IQuestionBanqRepository _questionBanqRepository;
        private readonly IParentRepository _parentRepository;

        public ParentController(IStudentRepository studentRepository,
                      IEnrollmentRepository enrollmentRepository,
                      ILessonRepository lessonRepository,
                      ILessonTestRepository lessonTestRepository,
                      IQuestionBanqRepository questionBanqRepository,
                      IParentRepository parentRepository)
        {
            _studentRepository = studentRepository;
            _enrollmentRepository = enrollmentRepository;
            _lessonRepository = lessonRepository;
            _lessonTestRepository = lessonTestRepository;
            _questionBanqRepository = questionBanqRepository;
            _parentRepository = parentRepository;
        }

        #endregion



        #region Parent Login

        [HttpGet]
        public async Task<IActionResult> ParentLogin()
        {
            return View();
        }

        #endregion


        #region Report

        [HttpGet]
        public async Task<IActionResult> Report(Parent_Login_VM model)
        {
            bool check = await _parentRepository.Check(model);
            if(check == false)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var student = await _studentRepository.GetStudentByPhone(model.StudentPhone);
                ViewBag.Student = student;

                ViewBag.Subjects = await _enrollmentRepository.GetMySubjects(student.Id);

                return View();
            }      
        }

        #endregion


        #region Attendance

        [HttpGet]
        public async Task<IActionResult> Attendance(Report_VM model)
        {
            var student = await _studentRepository.GetStudentById(model.Student_Id);
            ViewBag.Student = student;
            ViewBag.Subject = model.Subject;
            var lessons = await _lessonRepository.GetAllTeacherLessonsInAcademyYear(model.Teacher_Id, student.Grade);
            ViewBag.Lessons = lessons;
            var results = await _lessonTestRepository.GetStudentTestResults(student.Id);
            List<LTestResult> resultsList = new List<LTestResult>();
            foreach (LTestResult item in results)
            {
                var lesson = await _lessonRepository.GetLessonDetailsByUrl(item.Vedio_Url);
                if (lesson != null)
                {
                    if (model.Teacher_Id == lesson.TeacherId)
                    {
                        resultsList.Add(item);
                    }
                }
            }
            ViewBag.Tests = resultsList;

            return View();
        }

        #endregion


        #region General Exam Report

        [HttpGet]
        public async Task<IActionResult> GeneralExamReport(Report_VM model)
        {
            var student = await _studentRepository.GetStudentById(model.Student_Id);
            ViewBag.Student = student;
            ViewBag.Subject = model.Subject;
            var Exams = await _questionBanqRepository.GetAllTeacherGeneralExamsInAcademyYear(model.Teacher_Id, student.Grade);
            ViewBag.Exams = Exams;
            var results = await _questionBanqRepository.GetStudentGeneeralExamResults(model.Student_Id, model.Teacher_Id);
            ViewBag.Results = results;

            return View();
        }

        #endregion

    }
}
