using IShcool.Data;
using IShcool.IRepo;

namespace IShcool.Repository
{
    public class LogInManagement : ILoginManagement
    {
        #region Denpencies
        private readonly ApplicationDbContext _context;

        public LogInManagement(ApplicationDbContext context)
        {
             _context = context;
        }


        #endregion



        #region Student
        public async Task<bool> IsTeacherSelectedAsync(string id)
        {
            var teachers = _context.Enrollments.Where(s => s.StudentId == id).FirstOrDefault();
            if (teachers == null)
                return false;

            return true;
        }
        
        #endregion 
    }
}
