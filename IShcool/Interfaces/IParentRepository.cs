using IShcool.ViewModels;

namespace IShcool.Interfaces
{
    public interface IParentRepository
    {

        public Task<bool> Check(Parent_Login_VM model);

    }
}
