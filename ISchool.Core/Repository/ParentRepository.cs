namespace ISchool.Core.Repository
{
    public class ParentRepository : IParentRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;

        public ParentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion



        #region Check

        public async Task<bool> Check(Parent_Login_VM model)
        {
            if (model != null)
            {
                var student = _context.Students.Where(m => m.Phone == model.StudentPhone).FirstOrDefault();
                if (student != null)
                {
                    if (student.Par_Phone == model.ParentPhone)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

    }
}
