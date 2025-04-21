namespace ISchool.Core.Repository
{
    public class BookRepository : IBookRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;

        public BookRepository(ApplicationDbContext context,Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        #endregion



        #region Add New Book

        public async Task<Book> AddNewBook(Book_VM model)
        {
            if (model != null)
            {
                int count = _context.Books.Where(m => m.TeacherId == model.TeacherId).Count() + 1;

                var file = new Tools(_environment);
                string fileUrl = file.AddTasks(model.Task_File, model.TeacherId + count);

                var book = new Book
                {
                    TeacherId = model.TeacherId,
                    Title = model.Title,
                    Academy_Year = model.Academy_Year,
                    FileUrl = fileUrl
                };

                _context.Books.Add(book);
                _context.SaveChanges();

                return book;
            }
            return null;
        }

        #endregion


        #region Get Student Books

        public async Task<IEnumerable<Book>> GetStudentBooks(Student model)
        {
            if (model != null)
            {
                List<Book> books = new List<Book>();
                var enrolls = _context.Enrollments.Where(m => m.StudentId == model.Id).ToList();
                if (enrolls != null)
                {
                    foreach (Enrollment item in enrolls)
                    {
                        var book = _context.Books.Where(m => m.TeacherId == item.TeacherId & m.Academy_Year == model.Grade).ToList();
                        if (book.Count > 0)
                        {
                            books.AddRange(book);
                        }
                    }
                    return books;
                }
                return null;
            }
            return null;
        }

        #endregion

    }
}
