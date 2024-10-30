using IShcool.ViewModels;
using The_Top_App.Models;

namespace IShcool.Interfaces
{
    public interface ITeacherRepository
    {

        public Task<string[]> GitTeachersIdList(string phonesList);

        public Task<Teacher> CreateNewTeacher(Teacher_Register_VM model,string id);

        public Task<IEnumerable<Teacher>> GetAllTeachers();

        public Task<Teacher> GetTeacherById(string id);

    }
}
