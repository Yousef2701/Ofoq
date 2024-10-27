using Test.Models;
using The_Top_App.Models;

namespace IShcool.Interfaces
{
    public interface IEnrollmentRepository
    {

        public void NewEnrollment(string studentId, string[] teachersId);

        public Task<string[]> GitEnrollmentSubjects(string studentId);

        public Task<IEnumerable<Teacher>> GitEnrollmentTeachers(string studentId);

        public Task<IEnumerable<Enrollment>> GetMySubjects(string id);

        public Task<string> GetTeacherIdByStudentIdAndSubject(string studentId, string subject);

        public Task<IEnumerable<Enrollment>> GitEnrollmentStudents(string teacherId);

        public Task<bool> CheckEnrollment(string studentId, string teacherId);

    }
}
