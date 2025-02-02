namespace ISchool.Core.IRepository
{
    public interface IQuestionBanqRepository
    {

        public Task<Exam> AddNewGeneralExam(General_Exam_VM model);

        public Task<ExamQuestion> AddGeneralExamQuestion(General_Exam_Question_VM model);

        public Task<IEnumerable<Exam>> GetAllTeacherGeneralExamsInAcademyYear(string teacherId, string year);

        public Task<IEnumerable<ExamQuestion>> GetGenaralExamQuestions(General_Exam_VM model);

        public Task<int> SaveGenaralExamResult(General_Exam_Answers_VM model);

        public Task<IEnumerable<ExamResult>> GetStudentGeneeralExamResults(string studentId, string teacherId);

        public Task<IEnumerable<Exam>> GetAllTeacherGeneralExams(string teacherId);

        public Task<Exam> GetGeneralExam(string teacherId, string title, string year);

        public Task<int> GetGeneralExamQuestionsCount(string teacherId, string title, string year);

        public Task<string> GetGenaralExamDuration(General_Exam_VM model);

        public Task<string> RemoveGeneralExamQuestion(General_Exam_Question_VM model);

        public Task<string> DeleteGeneralExam(General_Exam_VM model);

    }
}
