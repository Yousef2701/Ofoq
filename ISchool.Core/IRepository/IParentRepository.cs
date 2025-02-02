namespace ISchool.Core.IRepository
{
    public interface IParentRepository
    {

        public Task<bool> Check(Parent_Login_VM model);

    }
}
