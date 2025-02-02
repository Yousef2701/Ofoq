namespace ISchool.Core.IRepository
{
    public interface IBookRepository
    {

        public Task<Book> AddNewBook(Book_VM model);

        public Task<IEnumerable<Book>> GetStudentBooks(Student model);

    }
}
