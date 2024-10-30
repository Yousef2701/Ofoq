using ArabityAuth;
using IShcool.Data;
using IShcool.Interfaces;
using IShcool.Models;
using IShcool.ViewModels;
using System.Security.Claims;

namespace IShcool.Repository
{
    public class QuestionBanqRepository : IQuestionBanqRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _Environment;
        private readonly IUserRepository _userRepository;

        public QuestionBanqRepository(ApplicationDbContext context,
                                      Microsoft.AspNetCore.Hosting.IHostingEnvironment environment,
                                      IUserRepository userRepository)
        {
            _context = context;
            _Environment = environment;
            _userRepository = userRepository;
        }

        #endregion



        #region Add New General Exam

        public async Task<Exam> AddNewGeneralExam(General_Exam_VM model)
        {
            if(model != null)
            {
                string start = model.StartExamDate + " " + model.StartExamTime;
                string finish = model.FinishExamDate + " " + model.FinishExamTime;

                var exam = new Exam
                {
                    TeacherId = model.TeacherId,
                    Title = model.Title,
                    Exam_Duration = model.Exam_Duration,
                    Academy_Year = model.Academy_Year,
                    StartExamDate = DateTime.Parse(start),
                    FinishExamDate = DateTime.Parse(finish)
                };

                _context.Exams.Add(exam);
                _context.SaveChanges();

                return exam;
            }
            return null;
        }

        #endregion


        #region Add General Exam Question

        public async Task<ExamQuestion> AddGeneralExamQuestion(General_Exam_Question_VM model)
        {
            if(model != null)
            {
                if (model.Quest_Type == "Image")
                {
                    int count = _context.ExamQuestions.Where(m => m.ExamTitle == model.ExamTitle).Count() + 1;

                    var answer_1 = new Tools(_Environment);
                    string answer_1_Url = answer_1.AddAnswersImages(model.Frist_Answer_File,model.TeacherId + model.ExamTitle + "1" + count);

                    var answer_2 = new Tools(_Environment);
                    string answer_2_Url = answer_2.AddAnswersImages(model.Second_Answer_File, model.TeacherId + model.ExamTitle + "2" + count);

                    var answer_3 = new Tools(_Environment);
                    string answer_3_Url = answer_3.AddAnswersImages(model.Third_Answer_File, model.TeacherId + model.ExamTitle + "3" + count);

                    var answer_4 = new Tools(_Environment);
                    string answer_4_Url = answer_4.AddAnswersImages(model.Forth_Answer_File, model.TeacherId + model.ExamTitle + "4" + count);

                    var question = new ExamQuestion
                    {
                        ExamTitle = model.ExamTitle,
                        TeacherId = model.TeacherId,
                        Academy_Year = model.Academy_Year,
                        Quest = model.Quest,
                        Quest_Type = model.Quest_Type,
                        Frist_Answer = "",
                        Frist_Answer_Url = answer_1_Url,
                        Second_Answer = "",
                        Second_Answer_Url = answer_2_Url,
                        Third_Answer = "",
                        Forth_Answer_Url = answer_4_Url,
                        Forth_Answer = "",
                        Third_Answer_Url = answer_3_Url,
                        Correct_Answer = model.Correct_Answer
                    };

                    _context.ExamQuestions.Add(question);
                    _context.SaveChanges();

                    return question;
                }
                else if (model.Quest_Type == "Text")
                {
                    var question = new ExamQuestion
                    {
                        ExamTitle = model.ExamTitle,
                        TeacherId = model.TeacherId,
                        Academy_Year = model.Academy_Year,
                        Quest = model.Quest,
                        Quest_Type = model.Quest_Type,
                        Frist_Answer = model.Frist_Answer,
                        Frist_Answer_Url = "",
                        Second_Answer = model.Second_Answer,
                        Second_Answer_Url = "",
                        Third_Answer = model.Third_Answer,
                        Third_Answer_Url = "",
                        Forth_Answer = model.Forth_Answer,
                        Forth_Answer_Url = "",
                        Correct_Answer = model.Correct_Answer
                    };

                    _context.ExamQuestions.Add(question);
                    _context.SaveChanges();

                    return question;
                }
            }
            return null;
        }

        #endregion


        #region Get All Teacher General Exams In Academy Year

        public async Task<IEnumerable<Exam>> GetAllTeacherGeneralExamsInAcademyYear(string teacherId, string year)
        {
            if(teacherId != null && year != null)
            {
                var exams = _context.Exams.Where(m => m.Academy_Year == year & m.TeacherId == teacherId).OrderBy(m => m.StartExamDate).ToList();
                if(exams != null)
                    return exams;
            }
            return null;
        }

        #endregion


        #region Get Genaral Exam Questions

        public async Task<IEnumerable<ExamQuestion>> GetGenaralExamQuestions(General_Exam_VM model)
        {
            if (model != null)
            {
                var exam = _context.Exams.Where(m => m.Title == model.Title & m.TeacherId == model.TeacherId & m.Academy_Year == model.Academy_Year).FirstOrDefault();
                if (exam != null)
                {
                    List<ExamQuestion> quests = _context.ExamQuestions.Where(m => m.ExamTitle == exam.Title & m.TeacherId == exam.TeacherId & m.Academy_Year == exam.Academy_Year).OrderBy(m => m.Quest).ToList();
                    return quests;
                }
            }
            return null;
        }

        #endregion


        #region Save Genaral Exam Result

        public async Task<int> SaveGenaralExamResult(General_Exam_Answers_VM model)
        {
            if (model != null)
            {
                var userId = await _userRepository.GitLoggingUserId();

                string[] ans = model.Answers.Split(",");
                List<ExamQuestion> quests = _context.ExamQuestions.Where(m => m.ExamTitle == model.Title & m.TeacherId == model.TeacherId & m.Academy_Year == model.Academy_Year).OrderBy(m => m.Quest).ToList();
                int count = 0;

                for(int i = 0; i< quests.Count; i++)
                {
                    if (quests[i].Correct_Answer == ans[i]) {
                        count++; 
                    }
                }

                var check = _context.ExamResults.Where(m => m.TeacherId == model.TeacherId & m.StudentId == userId & m.ExamTitle == model.Title).FirstOrDefault();
                if (check == null)
                {
                    var result = new ExamResult
                    {
                        ExamTitle = model.Title,
                        TeacherId = model.TeacherId,
                        StudentId = userId,
                        Date = DateTime.Now.ToString("dd-MM-yyyy"),
                        Time = DateTime.Now.ToString("hh:mm tt"),
                        Correct_Answers_No = count
                    };
                    _context.ExamResults.Add(result);
                    _context.SaveChanges();
                }

                return count;
            }
            return 0;
        }

        #endregion


        #region Get Student Geneeral Exam Results

        public async Task<IEnumerable<ExamResult>> GetStudentGeneeralExamResults(string studentId, string teacherId)
        {
            if(studentId != null & teacherId != null)
            {
                var results = _context.ExamResults.Where(m => m.StudentId == studentId & m.TeacherId == teacherId).ToList();
                if (results != null) 
                    return results;
            }
            return null;
        }

        #endregion


        #region Get All Teacher General Exams

        public async Task<IEnumerable<Exam>> GetAllTeacherGeneralExams(string teacherId)
        {
            if(teacherId != null)
            {
                var exams = _context.Exams.Where(m => m.TeacherId == teacherId).OrderBy(m => m.Academy_Year).ToList();
                if(exams != null)
                    return exams;
            }
            return null;
        }

        #endregion

        
        #region Get General Exam

        public async Task<Exam> GetGeneralExam(string teacherId, string title, string year)
        {
            if(teacherId != null & title != null & year != null)
            {
                var exam = _context.Exams.Where(m => m.TeacherId == teacherId & m.Title == title & m.Academy_Year == year).FirstOrDefault();
                if(exam != null)
                    return exam;
            }
            return null;
        }

        #endregion


        #region Get General Exam Questions Count

        public async Task<int> GetGeneralExamQuestionsCount(string teacherId, string title, string year)
        {
            if (teacherId != null & title != null & year != null)
            {
                int count = _context.ExamQuestions.Where(m => m.TeacherId == teacherId & m.ExamTitle == title & m.Academy_Year == year).Count();
                if(count > 0) 
                    return count;
            }
            return 0;
        }

        #endregion


        #region Get Genaral Exam Duration

        public async Task<string> GetGenaralExamDuration(General_Exam_VM model)
        {
            if(model != null)
            {
                var exam = _context.Exams.Where(m => m.Title == model.Title & m.TeacherId == model.TeacherId & m.Academy_Year == model.Academy_Year).FirstOrDefault();
                if(exam != null)
                {
                    return exam.Exam_Duration.ToString();
                }
            }
            return null;
        }

        #endregion
    }
}
