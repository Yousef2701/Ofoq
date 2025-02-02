namespace ISchool.Core.Repository
{
    public class SubjectRepository : ISubjectRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion



        #region Git Subject List

        public async Task<IEnumerable<Subject>> GetSubjectList(string grade, string department)
        {
            if (grade != null && department != null)
            {
                var subjects = _context.Subjects.Where(x => x.Grade == grade
                && x.Department == department).ToList();
                if (subjects.Count > 0)
                {
                    return subjects;
                }
                return null;
            }
            return null;
        }

        #endregion


        #region Split Subject List

        public async Task<string[]> SplitSubjectList(string list)
        {
            if (list != null)
            {
                var sub = list.Remove(0, 1);
                var subList = sub.Split(",");
                return subList;
            }
            else
                return null;
        }

        #endregion


        #region Git Subjects Teachers

        public async Task<IEnumerable<Teacher>> GitSubjectsTeachers(string[] subjects, Student student)
        {
            if (subjects != null && student != null)
            {
                List<Teacher> teachers = new List<Teacher>();

                for (int i = 0; i < subjects.Length; i++)
                {
                    if (subjects[i] == "لغـة ثـانيـة")
                        subjects[i] = student.SecondLang;

                    List<Teacher> teachersForSubject = new List<Teacher>();

                    if (student.Grade == "أولى ثانوي")
                    {
                        teachersForSubject = _context.Teachers.Where(m => m.Subject == subjects[i] & m.First == true).ToList();
                    }
                    else if (student.Grade == "ثانية ثانوي")
                    {
                        teachersForSubject = _context.Teachers.Where(m => m.Subject == subjects[i] & m.Second == true).ToList();
                    }
                    else
                    {
                        teachersForSubject = _context.Teachers.Where(m => m.Subject == subjects[i] & m.Third == true).ToList();
                    }

                    if (teachersForSubject.Count > 0)
                        teachers.AddRange(teachersForSubject);
                }

                return teachers;
            }
            return null;
        }

        #endregion


        #region Get All Grade Subjects By Department

        public async Task<IEnumerable<Subject>> GetAllGradeSubjectsByDepartment(string grade, string department)
        {
            if (grade != null & department != null)
            {
                var subjects = _context.Subjects.Where(m => m.Grade == grade & m.Department == department).ToList();

                if (subjects != null)
                    return subjects;
            }
            return null;
        }

        #endregion

    }
}
