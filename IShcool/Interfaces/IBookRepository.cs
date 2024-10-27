using IShcool.Models;
using IShcool.ViewModels;
using The_Top_App.Models;

namespace IShcool.Interfaces
{
    public interface IBookRepository
    {

        public Task<Book> AddNewBook(Book_VM model);

        public Task<IEnumerable<Book>> GetStudentBooks(Student model);

    }
}
