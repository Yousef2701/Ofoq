using IShcool.Data;
using IShcool.Interfaces;
using IShcool.Models;
using IShcool.ViewModels;

namespace IShcool.Repository
{
    public class LessonTestRepository : ILessonTestRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _Environment;
        private readonly IUserRepository _userRepository;

        public LessonTestRepository(ApplicationDbContext context,
                                    Microsoft.AspNetCore.Hosting.IHostingEnvironment environment,
                                    IUserRepository userRepository)
        {
            _context = context;
            _Environment = environment;
            _userRepository = userRepository;
        }

        #endregion



        #region Get Test Questions

        public async Task<string[]> GetTestQuestions(string url)
        {
            if (url != null)
            {
                var questions = _context.LessonsTest.Where(m => m.Vedio_Url == url).OrderBy(m => m.Date).ThenBy(m => m.Time).ToList();
                string q = "";
                string ans = "";
                int c = 0;
                string type = "";

                foreach (IShcool.Models.LessonTest item in questions)
                {
                    c++;
                    q += item.Quest;

                    if (c < questions.Count)
                    {
                        q += ", ";
                    }

                    string answer1 = null;
                    string answer2 = null;
                    string answer3 = null;

                    if (item.Quest_Type == "Text")
                    {
                        if (c < questions.Count)
                        {
                            type += "false,";
                        }
                        else
                        {
                            type += "false";
                        }
                        answer1 = item.Frist_Answer;
                        answer2 = item.Second_Answer;
                        answer3 = item.Third_Answer;
                    }
                    else if (item.Quest_Type == "Image")
                    {
                        if (c < questions.Count)
                        {
                            type += "true,";
                        }
                        else
                        {
                            type += "true";
                        }
                        answer1 = item.Frist_Answer_Url;
                        answer2 = item.Second_Answer_Url;
                        answer3 = item.Third_Answer_Url;
                    }

                    string t = answer1 + "," + answer2 + "," + answer3;

                    ans += t;

                    if (c < questions.Count)
                    {
                        ans += " && ";
                    }

                }

                string[] results = new string[4];
                results[0] = q;
                results[1] = ans;
                results[2] = questions.Count().ToString();
                results[3] = type;

                return results;
            }
            return null;
        }

        #endregion


        #region Get Test Question Count

        public async Task<int> GetTestQuestionCount(string url)
        {
            if(url != null)
            {
                int count = _context.LessonsTest.Where(m => m.Vedio_Url == url).Count();
                return count;
            }
            return 0;
        }

        #endregion


        #region Save Test Result

        public async Task<string> SaveTestResult(Test_Answers_VM model)
        {
            if(model != null)
            {
                var userId = await _userRepository.GitLoggingUserId();

                string[] ans = model.answers.Split(",");
                var questions = _context.LessonsTest.Where(m => m.Vedio_Url == model.url).OrderBy(m => m.Date).ThenBy(m => m.Time).ToList();

                int c1 = 0;
                int index = -1;

                int correct = 0;
                int wrong = 0;
                string answer = "";

                string logic = "[";
                foreach (IShcool.Models.LessonTest q in questions)
                {
                    c1++;
                    index++;

                    logic += "{ \"question\": \"";
                    logic += q.Quest;
                    logic += "\",\"choices\": [";

                    logic += "\"";
                    if (q.Quest_Type == "Text")
                    {
                        logic += q.Frist_Answer;
                        logic += "\",\"";
                        logic += q.Second_Answer;
                        logic += "\",\"";
                        logic += q.Third_Answer;
                    }
                    else
                    {
                        logic += q.Frist_Answer_Url;
                        logic += "\",\"";
                        logic += q.Second_Answer_Url;
                        logic += "\",\"";
                        logic += q.Third_Answer_Url;
                    }

                    logic += "\"], \"correctAnswer\" :";
                    if (q.Correct_Answer == "1")
                    {
                        logic += "0 , \"studentAnswer\" :";
                        if (q.Quest_Type == "Text")
                            answer = q.Frist_Answer;
                        else
                            answer = q.Frist_Answer_Url;

                    }
                    else if (q.Correct_Answer == "2")
                    {
                        logic += "1 , \"studentAnswer\" :";
                        if (q.Quest_Type == "Text")
                            answer = q.Second_Answer;
                        else
                            answer = q.Second_Answer_Url;
                    }
                    else if (q.Correct_Answer == "3")
                    {
                        logic += "2 , \"studentAnswer\" :";
                        if (q.Quest_Type == "Text")
                            answer = q.Third_Answer;
                        else
                            answer = q.Third_Answer_Url;
                    }

                    string studentAns = ans[index].ToString();

                    if (q.Quest_Type == "Text")
                    {
                        if (studentAns.ToLower().Replace(" ", "") == q.Frist_Answer.ToLower().Replace(" ", ""))
                        {
                            logic += "0";
                        }
                        else if (studentAns.ToLower().Replace(" ", "") == q.Second_Answer.ToLower().Replace(" ", ""))
                        {
                            logic += "1";
                        }
                        else if (studentAns.ToLower().Replace(" ", "") == q.Third_Answer.ToLower().Replace(" ", ""))
                        {
                            logic += "2";
                        }
                    }
                    else
                    {
                        if (studentAns.ToLower().Replace(" ", "") == q.Frist_Answer_Url.ToLower().Replace(" ", ""))
                        {
                            logic += "0";
                        }
                        else if (studentAns.ToLower().Replace(" ", "") == q.Second_Answer_Url.ToLower().Replace(" ", ""))
                        {
                            logic += "1";
                        }
                        else if (studentAns.ToLower().Replace(" ", "") == q.Third_Answer_Url.ToLower().Replace(" ", ""))
                        {
                            logic += "2";
                        }
                    }


                    if (studentAns.ToLower().Replace(" ", "") == answer.ToLower().Replace(" ", ""))
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                    logic += ", \"QuestType\" : ";
                    if (q.Quest_Type == "Image")
                    {
                        logic += "\"true\"}";
                    }
                    else
                    {
                        logic += "\"false\"}";
                    }

                    if (c1 < questions.Count)
                    {
                        logic += ",";
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
                        Correct_Answers_No = correct,
                    };
                    _context.LTestResults.Add(result);
                    _context.SaveChanges();
                }

                logic += "]";

                return logic;
            }
            return null;
        }

        #endregion


        #region Get Student Test Results

        public async Task<IEnumerable<LTestResult>> GetStudentTestResults(string studentId)
        {
            if(studentId != null)
            {
                var results = _context.LTestResults.Where(m => m.StudentId == studentId).ToList();
                if(results != null)
                    return results;
            }
            return null;
        }

        #endregion

    }
}
