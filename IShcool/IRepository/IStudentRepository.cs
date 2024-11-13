using IShcool.ViewModels;
using The_Top_App.Models;

namespace IShcool.Interfaces
{
    public interface IStudentRepository
    {
        public Task<Student> CreateNewStudent(Student_Register_VM model, string id);


        public Task<Student> GetStudentById(string id);


        public Task<IEnumerable<Student>> GetAllStudents();


        public Task<Student> GetStudentByPhone(string phone);

        public Task<IEnumerable<Student>> GetAllStudentsInAcademyYear(string year);

    }
}
