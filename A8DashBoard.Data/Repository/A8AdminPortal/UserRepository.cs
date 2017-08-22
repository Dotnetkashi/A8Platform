using A8Dashboard.Models.CustomUserIdentity;
using A8DashBoard.Data.CustomUserIdentity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Web;
using A8DashBoard.Data.CustomIdentity;
using Microsoft.AspNet.Identity;
using System.Linq;

/// <summary>
/// 
/// </summary>
namespace A8DashBoard.Data.Repository.A8AdminPortal
{
  /// <summary>
  /// 
  /// </summary>
  public class UserRepository
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;
        private A8Product.A8ProdcutEntities db;

        public UserRepository()
        {
            db = new A8Product.A8ProdcutEntities();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public UserRepository(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
            //: base(databaseFactory)
        {
            UserManager = userManager;
            SignInManager = signInManager;
          
        }
        
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public async Task CreateApplicationUser(User objUser)
        {
            await UserManager.CreateAsync(objUser);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public async Task CreateWifiUser(User objUser)
        {
            string Password = CustomPasswordHasher.HashPassword(objUser.PasswordHash);
            await UserManager.CreateAsync(objUser, Password);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public async Task UpdateUser(User objUser)
        {
            await UserManager.UpdateAsync(objUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public async Task DeleteUser(User objUser)
        {
           await UserManager.DeleteAsync(objUser);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<string> GetUserEmail(int Id)
        {
          return await UserManager.GetEmailAsync(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public async Task GetUserByUserName(string UserName)
        {
            await UserManager.FindByNameAsync(UserName);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleName"></param>
        /// <returns></returns>
        public async Task<bool> IsInRoleExist(int UserId, string RoleName)
        {
            return await UserManager.IsInRoleAsync(UserId, RoleName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Role"></param>
        public void AddToRoleAsync(int Id,string RoleName)
        {
            UserManager.AddToRole(Id, RoleName);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public int GetUserIdFromUserName(string UserName)
        {
           return db.Users.Find(UserName).Id;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public User GetMemberAsPerUserUniqueId(string UserId,int SiteId)
        {
            return db.Users.FirstOrDefault(m => m.UniqueUserId == UserId && m.SiteId == SiteId);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="MemberUniqueId"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public bool IsMemberExist(string MemberUniqueId,int SiteId)
        {
            return db.Users.Any(m => m.UniqueUserId == MemberUniqueId && m.SiteId == SiteId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public User GetUserAsPerUserNameDb(string UserName,int SiteId)
        {
            return db.Users.FirstOrDefault(m => m.UserName == UserName && m.SiteId == SiteId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MacAddress"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public User GetUserAsPerMacAddress(string MacAddress,int SiteId)
        {
            return db.MacAddresses.FirstOrDefault(m => m.MacAddressValue == MacAddress && m.User.SiteId == SiteId).User;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool IsUserAMember(string UserName)
        {
            var ObjUser = db.Users.FirstOrDefault(m => m.UserName == UserName);
            if (!string.IsNullOrEmpty(ObjUser.UniqueUserId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="SiteId"></param>
        public bool IsAuthenticatedMemberWithCredential(string UserName,string Password,int SiteId)
        {
            string hashPassword = CustomPasswordHasher.HashPassword(Password);
            return db.Users.Any(m => m.UserName == UserName && m.PasswordHash == hashPassword);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public bool IsNewUserAsPerUserName(string UserName, int SiteId)
        {
            return db.Users.Any(m => m.UserName == UserName && m.SiteId == SiteId);
        }
    }
}
