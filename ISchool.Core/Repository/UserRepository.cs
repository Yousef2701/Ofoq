using System.Security.Claims;

namespace ISchool.Core.Repository
{
    public class UserRepository : IUserRepository
    {

        #region Dependancey injuction

        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        #endregion



        #region Check User

        public bool CheckUser(string email)
        {
            var user = _context.Users.Where(m => m.Email == email).FirstOrDefault();

            if (user is null)
                return false;
            else
                return true;
        }

        #endregion


        #region Confirm Email

        public bool ConfirmEmail(string id)
        {
            if (id != null)
            {
                var u = _context.Users.Find(id);
                u.EmailConfirmed = true;
                _context.Users.Update(u);
                _context.SaveChanges();

                return true;
            }
            else
                return false;
        }

        #endregion


        #region Get Logging User Id

        public async Task<string> GitLoggingUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
                return userId;
            else
                return string.Empty;
        }

        #endregion


        #region Pending User

        public async Task<string> PendingUser(string id)
        {
            if (id != null)
            {
                var user = _context.Users.Find(id);
                if (user != null)
                {
                    user.EmailConfirmed = false;

                    _context.SaveChanges();
                }
            }
            return null;
        }

        #endregion


        #region Activing User

        public async Task<string> ActivingUser(string id)
        {
            if (id != null)
            {
                var user = _context.Users.Find(id);
                if (user != null)
                {
                    user.EmailConfirmed = true;

                    _context.SaveChanges();
                }
            }
            return null;
        }

        #endregion

    }
}
