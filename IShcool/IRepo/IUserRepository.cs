namespace IShcool.Interfaces
{
    public interface IUserRepository
    {
        public bool CheckUser(string email);

        public bool ConfirmEmail(string id);

        public Task<string> GitLoggingUserId();

        public Task<string> PendingUser(string id);

        public Task<string> ActivingUser(string id);
    }
}
