using IShcool.Data;
using IShcool.Interfaces;
using IShcool.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom.Compiler;

namespace IShcool.Repository
{
    public class ParentRepository : IParentRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _Environment;

        public ParentRepository(ApplicationDbContext context,
                                Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            _Environment = environment;
        }

        #endregion



        #region Check

        public async Task<bool> Check(Parent_Login_VM model)
        {
            if(model != null)
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
