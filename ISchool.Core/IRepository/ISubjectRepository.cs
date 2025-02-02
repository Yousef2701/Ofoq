namespace ISchool.Core.IRepository
{
    public interface ISubjectRepository
    {

        public Task<IEnumerable<Subject>> GetSubjectList(string grade, string department);

        public Task<string[]> SplitSubjectList(string list);

        public Task<IEnumerable<Teacher>> GitSubjectsTeachers(string[] subjects, Student student);

        public Task<IEnumerable<Subject>> GetAllGradeSubjectsByDepartment(string grade, string department);


    }
}
