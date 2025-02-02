namespace ISchool.Core.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {


        #region Dependancey injuction

        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion



        #region New Enrollment

        public void NewEnrollment(string studentId, string[] teachersId)
        {
            if (studentId != null && teachersId != null)
            {
                for (int i = 0; i < teachersId.Length; i++)
                {
                    string subject = _context.Teachers.Where(m => m.Id == teachersId[i]).Select(m => m.Subject).FirstOrDefault();
                    var enroll = new Enrollment
                    {
                        StudentId = studentId,
                        TeacherId = teachersId[i],
                        Subject = subject
                    };

                    _context.Enrollments.Add(enroll);
                }
                _context.SaveChanges();
            }
        }

        #endregion


        #region Git Enrollment Subjects

        public async Task<string[]> GitEnrollmentSubjects(string studentId)
        {
            if (studentId != null)
            {
                var student = _context.Students.Find(studentId);
                if (student != null)
                {
                    string[] subjects = _context.Enrollments.Where(x => x.StudentId == studentId).Select(x => x.Subject).ToArray();
                    if (subjects != null)
                        return subjects;
                }
                return null;
            }
            return null;
        }

        #endregion


        #region Git Enrollment Teachers

        public async Task<IEnumerable<Teacher>> GitEnrollmentTeachers(string studentId)
        {
            if (studentId != null)
            {
                var enrollTeachersId = _context.Enrollments.Where(m => m.StudentId == studentId).ToList();
                List<Teacher> teachers = new List<Teacher>();

                foreach (Enrollment item in enrollTeachersId)
                {
                    var t = _context.Teachers.Find(item.TeacherId);
                    teachers.Add(t);
                }

                return teachers;
            }
            return null;
        }

        #endregion


        #region Get My Subjects

        public async Task<IEnumerable<Enrollment>> GetMySubjects(string id)
        {
            if (id != null)
            {
                var subjects = _context.Enrollments.Where(m => m.StudentId == id).ToList();

                if (subjects != null)
                    return subjects;
            }
            return null;
        }

        #endregion


        #region Get Teacher Id By Student Id And Subject

        public async Task<string> GetTeacherIdByStudentIdAndSubject(string studentId, string subject)
        {
            if (studentId != null & subject != null)
            {
                string teacherid = _context.Enrollments.Where(m => m.StudentId == studentId & m.Subject == subject).Select(m => m.TeacherId).FirstOrDefault();
                if (teacherid != null)
                    return teacherid;
            }
            return null;
        }

        #endregion


        #region Git Enrollment Students

        public async Task<IEnumerable<Enrollment>> GitEnrollmentStudents(string teacherId)
        {
            if (teacherId != null)
            {
                var enrollStudentsId = _context.Enrollments.Where(m => m.TeacherId == teacherId).ToList();
                if (enrollStudentsId != null)
                    return enrollStudentsId;
            }
            return null;
        }

        #endregion


        #region Check Enrollment

        public async Task<bool> CheckEnrollment(string studentId, string teacherId)
        {
            if (studentId != null & teacherId != null)
            {
                var enroll = _context.Enrollments.Where(m => m.StudentId == studentId & m.TeacherId == teacherId).FirstOrDefault();
                if (enroll != null)
                    return true;
            }
            return false;
        }

        #endregion
    }
}
