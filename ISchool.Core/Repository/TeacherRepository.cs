namespace ISchool.Core.Repository
{
    public class TeacherRepository : ITeacherRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;

        public TeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion



        #region Git Teachers Id List

        public async Task<string[]> GitTeachersIdList(string phonesList)
        {
            if (phonesList != null)
            {
                var phone = phonesList.Remove(0, 1);
                var teachersphone = phone.Split(',');
                string[] teachersId = new string[teachersphone.Length];
                for (int i = 0; i < teachersphone.Length; i++)
                {
                    teachersId[i] = _context.Teachers.Where(m => m.Phone == teachersphone[i]).Select(m => m.Id).FirstOrDefault();
                }
                return teachersId;
            }
            return null;
        }

        #endregion


        #region Create New Teacher

        public async Task<Teacher> CreateNewTeacher(Teacher_Register_VM model, string id)
        {
            if (model != null && id != null)
            {
                var image = new Tools();
                string imageUrl = image.AddImages(model.ImageFile, model.Phone);

                var teacher = new Teacher
                {
                    Id = id,
                    Phone = model.Phone,
                    Name = model.Name,
                    Subject = model.Subject,
                    First = model.First,
                    Second = model.Second,
                    Third = model.Third,
                    Image_Url = imageUrl
                };

                _context.Teachers.Add(teacher);
                _context.SaveChanges();

                return teacher;
            }
            return null;
        }

        #endregion


        #region Git All Teachers

        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            var teachers = _context.Teachers.OrderBy(m => m.Name).ToList();
            if (teachers != null)
                return teachers;
            else
                return null;
        }

        #endregion


        #region Git Teacher By Id

        public async Task<Teacher> GetTeacherById(string id)
        {
            if (id != null)
            {
                var teacher = _context.Teachers.Find(id);
                if (teacher != null)
                    return teacher;
                else
                    return null;
            }
            else
                return null;
        }

        #endregion

    }
}
