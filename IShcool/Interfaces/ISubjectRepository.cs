using IShcool.Models;
using IShcool.ViewModels;
using Test.Models;
using The_Top_App.Models;

namespace IShcool.Interfaces
{
    public interface ISubjectRepository
    {

        public Task<IEnumerable<Subject>> GetSubjectList(string grade, string department);

        public Task<string[]> SplitSubjectList(string list);

        public Task<IEnumerable<Teacher>> GitSubjectsTeachers(string[] subjects, Student student);

        public Task<IEnumerable<Subject>> GetAllGradeSubjectsByDepartment(string grade, string department);


    }
}
