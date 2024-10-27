using IShcool.Data;
using IShcool.Interfaces;
using IShcool.ViewModels;
using The_Top_App.Models;

namespace IShcool.Repository
{
    public class StudentRepository : IStudentRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion



        #region Create New Student

        public async Task<Student> CreateNewStudent(Student_Register_VM model, string id)
        {
            if (model != null)
            {
                var student = new Student
                {
                    Id = id,
                    Name = model.Name,
                    Phone = model.Phone,
                    Department = model.Department,
                    Grade = model.Grade,
                    SecondLang = model.SecondLang,
                    Par_Phone = model.Par_Phone
                };

                _context.Students.Add(student);
                _context.SaveChanges();

                return student;
            }
            else
            {
                return null;
            }
        }

        #endregion


        #region Git Student By Id

        public async Task<Student> GetStudentById(string id)
        {
            if (id != null)
            {
                var student = _context.Students.Find(id);
                if (student != null)
                    return student;
                else
                    return null;
            }
            else
                return null;
        }

        #endregion


        #region Get All Students

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students = _context.Students.OrderBy(m => m.Grade).ThenBy(m => m.Department).ToList();
            if (students != null)
                return students;
            else
                return null;
        }

        #endregion


        #region Get Student By Phone

        public async Task<Student> GetStudentByPhone(string phone)
        {
            if(phone != null)
            {
                var student = _context.Students.Where(m => m.Phone == phone).FirstOrDefault();
                if(student != null)
                    return student;
            }
            return null;
        }

        #endregion


        #region Get All Students In AcademyYear

        public async Task<IEnumerable<Student>> GetAllStudentsInAcademyYear(string year)
        {
            if(year != null)
            {
                var students = _context.Students.Where(m => m.Grade == year).ToList();
                if(students != null) 
                    return students;
            }
            return null;
        }

        #endregion

    }
}
